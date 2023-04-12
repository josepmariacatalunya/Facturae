/* FacturaE - The MIT License (MIT)
 * 
 * Copyright (c) 2012-2014 Carlos Guzmán Álvarez
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using FacturaE.DataType;
using FacturaE.Enums;
using FacturaE.Xml;
using FirmaXadesNet;
using FirmaXadesNet.Crypto;
using FirmaXadesNet.Signature;
using FirmaXadesNet.Signature.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FacturaE
{
    /// <summary>
    /// Facturae extensions
    /// </summary>
    public partial class Facturae
    {
        #region · Static Members ·

        static readonly XmlSerializer FacturaeSerializer = new XmlSerializer(typeof(Facturae));

        #endregion
        
        #region Public Fields 

        [XmlIgnore]
        public string BuyerReference;

        #endregion

        #region · Constructors ·

        /// <summary>
        /// Initializes a new instance of the <see cref="Facturae"/> class.
        /// </summary>
        public Facturae()
        {
            this.FileHeader = new FileHeaderType
            {
                Batch         = new BatchType()
              , SchemaVersion = SchemaVersionType.Item32
            };
            this.Parties = new PartiesType
            {
                SellerParty = new BusinessType(this)
              , BuyerParty  = new BusinessType(this)
              , Parent      = this
            };
                
            this.Invoices = new List<InvoiceType>();
            this.SetCurrency(CurrencyCodeType.EUR);
            this.SetIssuer(InvoiceIssuerTypeType.EM);
        }

        #endregion

        #region · Facturae Extensions ·

        /// <summary>
        /// Sets the currency code of the electronic invoice
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <param name="currencyCode">The currency code</param>
        /// <returns></returns>
        public Facturae SetCurrency(CurrencyCodeType currencyCode)
        {
            this.FileHeader.Batch.InvoiceCurrencyCode = currencyCode;

            return this;
        }

        /// <summary>
        /// Sets the electronic invoice schema version
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <param name="schemaVersion">The schema version</param>
        /// <returns></returns>
        public Facturae SetSchemaVersion(SchemaVersionType schemaVersion)
        {
            this.FileHeader.SchemaVersion = schemaVersion;

            return this;
        }
        
        /// <summary>
        /// Sets the electronic invoice issuer
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <param name="issuerType">The issuer type</param>
        /// <returns></returns>
        public Facturae SetIssuer(InvoiceIssuerTypeType issuerType)
        {
            this.FileHeader.InvoiceIssuerType = issuerType;

            return this;
        }

        /// <summary>
        /// Gets the electronic invoice seller
        /// </summary>
        /// <param name="parties"></param>
        /// <returns></returns>
        public BusinessType Seller()
        {
            return this.Parties.SellerParty;
        }

        /// <summary>
        /// Gets the electronic invoice buyer
        /// </summary>
        /// <param name="parties"></param>
        /// <returns></returns>
        public BusinessType Buyer()
        {
            return this.Parties.BuyerParty;
        }
           
        /// <summary>
        /// Calculates the electronic totals
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <returns></returns>
        public Facturae CalculateTotals()
        {
            var firstInvoice = this.Invoices[0];

            this.FileHeader.Modality                     = ((this.Invoices.Count == 1) ? ModalityType.Single : ModalityType.Batch);
            this.FileHeader.Batch.InvoicesCount          = this.Invoices.Count;
            this.FileHeader.Batch.TotalInvoicesAmount    = this.SumTotalAmounts();
            this.FileHeader.Batch.TotalOutstandingAmount = this.SumTotalOutstandingAmount();
            this.FileHeader.Batch.TotalExecutableAmount  = this.SumTotalExecutableAmount();
            this.FileHeader.Batch.BatchIdentifier        = firstInvoice.InvoiceHeader.InvoiceNumber 
                                                         + firstInvoice.InvoiceHeader.InvoiceSeriesCode;

            return this;
        }

        /// <summary>
        /// Sums the invoice total
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <returns>An instance of AmountType</returns>
        public AmountType SumTotalAmounts()
        {
            return new AmountType
            {
                TotalAmount       = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.InvoiceTotal), 2)
              , EquivalentInEuros = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.InvoiceTotal), 2)
            };
        }

        /// <summary>
        /// Sums the electronic invoice outstanding amount
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <returns>An instance of AmountType</returns>
        public AmountType SumTotalOutstandingAmount()
        {
            return new AmountType
            {
                TotalAmount       = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.TotalOutstandingAmount), 2)
              , EquivalentInEuros = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.TotalOutstandingAmount), 2)
            };
        }

        /// <summary>
        /// Sums the electronic invoice executable amount
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <returns>An instance of AmountType</returns>
        public AmountType SumTotalExecutableAmount()
        {
            return new AmountType
            {
                TotalAmount       = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.TotalExecutableAmount), 2)
              , EquivalentInEuros = Math.Round(this.Invoices.Sum(il => il.InvoiceTotals.TotalExecutableAmount), 2)
            };
        }
        
        /// <summary>
        /// Creates a new invoice
        /// </summary>
        /// <param name="eInvoice"></param>
        /// <returns></returns>
        public InvoiceType CreateInvoice()
        {
            var invoice = new InvoiceType
            {
                Parent           = this
              , InvoiceHeader    = new InvoiceHeaderType()
              , InvoiceTotals    = new InvoiceTotalsType()
              , InvoiceIssueData = new InvoiceIssueDataType()
              , Items            = new List<InvoiceLineType>()
            };

            this.Invoices.Add(invoice);

            return invoice;
        }

        public InstallmentType CreatePayments()
        {
            var firstInvoice = this.Invoices[0];

            if (firstInvoice.PaymentDetails == null) firstInvoice.PaymentDetails = new List<InstallmentType>();

            var installment = new InstallmentType(this);
            installment.SetPaymentAmount(firstInvoice.InvoiceTotals.InvoiceTotal);
            if (!string.IsNullOrEmpty(this.BuyerReference))
            installment.DebitReconciliationReference = this.BuyerReference;
            
            firstInvoice.PaymentDetails.Add(installment);
            
            return  installment;
        }
       
        #endregion

        #region · XML Validation Extensions ·

        /// <summary>
        /// Validates the electronic invoice XML
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <returns></returns>
        public Facturae Validate()
        {
            XmlDocument document = this.ToXmlDocument();
            
            document.Schemas.Add(XsdSchemas.BuildSchemaSet(document.NameTable));
            document.Validate(XmlValidationEventHandler);

            return this;
        }

        static void XmlValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                throw e.Exception;
            }
            else
            {
                Trace.Write(String.Format("Warning while validating XML '{0}'", e.Message));
            }
        }

        #endregion

        #region · XML Signature Extensions ·

        public SignatureDocument Sign()
        {
            XadesService xadesService = new XadesService();
            SignatureParameters parametros = new SignatureParameters();

            // Política de firma de factura-e 3.1
            parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
            parametros.SignaturePolicyInfo.PolicyIdentifier = "http://www.facturae.es/politica_de_firma_formato_facturae/politica_de_firma_formato_facturae_v3_1.pdf";
            parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
            parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
            parametros.DataFormat = new DataFormat();
            parametros.DataFormat.MimeType = "text/xml";
            parametros.SignerRole = new SignerRole();
            parametros.SignerRole.ClaimedRoles.Add("emisor");
            using (parametros.Signer = new Signer(FirmaXadesNet.Utils.CertUtil.SelectCertificate()))
            {
                var docFirmado = xadesService.Sign(this.ToXmlDocument(), parametros);
                return docFirmado;
            }
        }
          

        #endregion

        #region · IO Extensions ·

        /// <summary>
        /// Writes the electronic invoice to the given path
        /// </summary>
        /// <param name="eInvoice">The electronic invoice</param>
        /// <param name="path">The file path</param>
        /// <returns></returns>
        public Facturae WriteToFile(string path)
        {
            this.ToXmlDocument().Save(path);

            return this;
        }

        #endregion

        #region · Private Extensions ·

        private string ToXml()
        {
            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false)
            };
            
            using (MemoryStream buffer = new MemoryStream())
            { 
                using (XmlWriter writer = XmlWriter.Create(buffer, settings))
                {
                    FacturaeSerializer.Serialize(writer, this, XsdSchemas.CreateXadesSerializerNamespace());
                }

                return Encoding.UTF8.GetString(buffer.ToArray());
            }
        }

        private XmlDocument ToXmlDocument()
        {
            var document = new XmlDocument { PreserveWhitespace = true };

            document.LoadXml(this.ToXml());

            return document;
        }

        #endregion

       
    }

    public partial class InvoiceType
    {
        #region · InvoiceType Extensions ·

        /// <summary>
        /// Set the invoice series code
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="seriesCode">The invoice series code</param>
        /// <returns></returns>
        public InvoiceType SetInvoiceSeries(string seriesCode)
        {
            this.InvoiceHeader.InvoiceSeriesCode = seriesCode;

            return this;
        }

        /// <summary>
        /// Sets the invoice number
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="invoiceNumber">The invoice number</param>
        /// <returns></returns>
        public InvoiceType SetInvoiceNumber(string invoiceNumber)
        {
            this.InvoiceHeader.InvoiceNumber = invoiceNumber;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as a complete invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsComplete()
        {
            this.InvoiceHeader.InvoiceDocumentType = InvoiceDocumentTypeType.Complete;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as a abbreviated invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsAbbreviated()
        {
            this.InvoiceHeader.InvoiceDocumentType = InvoiceDocumentTypeType.Abbreviated;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as a self invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsSelfInvoice()
        {
            this.InvoiceHeader.InvoiceDocumentType = InvoiceDocumentTypeType.SelfInvoice;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as a original invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsOriginal()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.Original;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as a corrective invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsCorrective()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.Corrective;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as summary of original invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsSummaryOriginal()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.SummaryOriginal;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as copy of original invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsCopyOfOriginal()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.CopyOfOriginal;

            return this;
        }

        /// <summary>
        /// Sets the invoice class as copy of corrective invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsCopyOfCorrective()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.CopyOfCorrective;
            
            return this;
        }

        /// <summary>
        /// Sets the invoice class as copy of summary invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <returns></returns>
        public InvoiceType IsCopyOfSummary()
        {
            this.InvoiceHeader.InvoiceClass = InvoiceClassType.CopyOfSummary;

            return this;
        }

        /// <summary>
        /// Sets the invoice issue date
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="date">The invoice issue date</param>
        /// <returns></returns>
        public InvoiceType GiveIssueDate(DateTime date)
        {
            this.InvoiceIssueData.IssueDate = date;

            return this;
        }

        /// <summary>
        /// Sets the invoice operation date
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="date">The invoice operation date</param>
        /// <returns></returns>
        public InvoiceType SetOperationDate(DateTime date)
        {
            this.InvoiceIssueData.OperationDate = date;
            
            return this;
        }

        /// <summary>
        /// Set the invoice place of issue
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="description">The place of issue description</param>
        /// <param name="postCode">The place of issue post code</param>
        /// <returns></returns>
        public InvoiceType SetPlaceOfIssue(string description, string postCode)
        {
            this.InvoiceIssueData.PlaceOfIssue = new PlaceOfIssueType
            {
                PlaceOfIssueDescription = description
              , PostCode                = postCode
            };
            
            return this;
        }

        /// <summary>
        /// Sets the invoicing period of an invoice
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="startDate">The start date</param>
        /// <param name="endDate">The end date</param>
        /// <returns></returns>
        public InvoiceType SetInvoicingPeriod(DateTime startDate, DateTime endDate)
        {
            this.InvoiceIssueData.InvoicingPeriod = new PeriodDates
            {
                StartDate = startDate
              , EndDate   = endDate
            };
            
            return this;
        }

        /// <summary>
        /// Sets the invoice currency
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="currency">The invoice currency</param>
        /// <returns></returns>
        public InvoiceType SetCurrency(CurrencyCodeType currency)
        {
            this.InvoiceIssueData.InvoiceCurrencyCode = currency;
            
            return this;
        }

        /// <summary>
        /// Sets the invoice currency exchange rate
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="exchangeRate">The exchange rate</param>
        /// <param name="exchangeDate">The exchange date</param>
        /// <returns></returns>
        public InvoiceType SetExchangeRate(double exchangeRate, DateTime exchangeDate)
        {
            this.InvoiceIssueData.ExchangeRateDetails = new ExchangeRateDetailsType
            {
                ExchangeRate = exchangeRate
            };
            
            return this;
        }

        /// <summary>
        /// Sets the invoice tax currency
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="taxCurrency">The invoice currency</param>
        /// <returns></returns>
        public InvoiceType SetTaxCurrency(CurrencyCodeType taxCurrency)
        {
            this.InvoiceIssueData.TaxCurrencyCode = taxCurrency;
                        
            return this;
        }

        /// <summary>
        /// Sets the invoice language
        /// </summary>
        /// <param name="invoice">The invoice</param>
        /// <param name="language">The invoice language</param>
        /// <returns></returns>
        public InvoiceType SetLanguage(LanguageCodeType language)
        {
            this.InvoiceIssueData.LanguageName = language;

            return this;
        }
        /// <summary>
        /// Se establece en informacion adicional y en paymentdetails la referencia del comprador
        /// </summary>
        /// <param name="buyerreference"></param>
        /// <returns></returns>
        public InvoiceType SetBuyerReference(string buyerreference)
        {
            if (!string.IsNullOrEmpty(buyerreference))
                this.Parent.BuyerReference = buyerreference;  //this value is used on paymentdetails-installment-DebitReconciliationReference


            if (this.AdditionalData == null)
                this.AdditionalData = new AdditionalDataType();

            var aditionalinformation = this.AdditionalData;
            aditionalinformation.InvoiceAdditionalInformation = $"Buyer Reference: {buyerreference}";
            return this;
        }
        /// <summary>
        /// Información adicional. Lo que considere oportuno el Emisor.
        /// En este elemento se recogerá el motivo por lo que el impuesto correspondiente está "no sujeto" o "exento", cuando se produzca esta situación.
        /// </summary>
        /// <param name="invoiceaditionalinformation"></param>
        /// <returns></returns>
        public InvoiceType  SetInvoiceAdditionalInformation(string invoiceaditionalinformation)
        {
           
            if (this.AdditionalData == null)
                this.AdditionalData = new AdditionalDataType();

            var aditionalinformation = this.AdditionalData;
            aditionalinformation.InvoiceAdditionalInformation += invoiceaditionalinformation;

            return this;
        }
        public InvoiceLineType AddInvoiceItem(string articleCode, string productDescription)
        {
            var item = new InvoiceLineType
            {
                Parent          = this
              , ArticleCode     = articleCode
              , ItemDescription = productDescription
            };

            this.Items.Add(item);

            return item;
        }

        /// <summary>
        /// Calculates the invoice totals
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
        public Facturae CalculateTotals()
        {
            double subsidyAmount = 0;

            // Taxes Outputs
            var q = from tax in this.Items.SelectMany(x => x.TaxesOutputs)
                    group tax by new { tax.TaxRate, tax.TaxTypeCode } into g
                    where g.Key.TaxTypeCode == TaxTypeCodeType.Item01
                    select new TaxOutputType
                    {
                        TaxRate     = g.Key.TaxRate,
                        TaxableBase = new AmountType 
                        { 
                            TotalAmount       = Math.Round(g.Sum(gtax => gtax.TaxableBase.TotalAmount), 2),
                            EquivalentInEuros = Math.Round(g.Sum(gtax => gtax.TaxableBase.EquivalentInEuros), 2)
                        },
                        TaxAmount   = new AmountType 
                        { 
                            TotalAmount       = Math.Round(g.Sum(gtax => gtax.TaxAmount.TotalAmount), 2),
                            EquivalentInEuros = Math.Round(g.Sum(gtax => gtax.TaxAmount.EquivalentInEuros), 2)
                        },
                        TaxTypeCode = TaxTypeCodeType.Item01,
                    };

            this.TaxesOutputs = q.ToList();
            // Taxes Outputs
            var r= from tax in this.Items.SelectMany(x => x.TaxesWithheld)
                    group tax by new { tax.TaxRate, tax.TaxTypeCode } into g 
                    where g.Key.TaxTypeCode == TaxTypeCodeType.Item04
                    select new TaxType
                    {
                        TaxRate = g.Key.TaxRate,
                        TaxableBase = new AmountType
                        {
                            TotalAmount = Math.Round(g.Sum(gtax => gtax.TaxableBase.TotalAmount), 2),
                            EquivalentInEuros = Math.Round(g.Sum(gtax => gtax.TaxableBase.EquivalentInEuros), 2)
                        },
                        TaxAmount = new AmountType
                        {
                            TotalAmount = Math.Round(g.Sum(gtax => gtax.TaxAmount.TotalAmount), 2),
                            EquivalentInEuros = Math.Round(g.Sum(gtax => gtax.TaxAmount.EquivalentInEuros), 2)
                        },
                        TaxTypeCode = g.Key.TaxTypeCode, // TaxTypeCodeType.Item01,
                    };

            if (this.TaxesWithheld != null)
               this.TaxesWithheld = r.ToList();
            // Invoice totals
            this.InvoiceTotals = new InvoiceTotalsType();

            // Calculate totals
            this.InvoiceTotals.TotalGrossAmount = Math.Round(this.Items.Sum(it => it.GrossAmount), 2);

            this.CalculateGeneralDiscountTotals();

            this.CalculateGeneralSurchargesTotals();

            this.InvoiceTotals.TotalGrossAmountBeforeTaxes = Math.Round(this.InvoiceTotals.TotalGrossAmount      
                                                                      - this.InvoiceTotals.TotalGeneralDiscounts 
                                                                      + this.InvoiceTotals.TotalGeneralSurcharges, 2);

            this.CalculatePaymentsOnAccountTotals();

            this.CalculateReimbursableExpensesTotals();
            
            // Total impuestos retenidos.
            this.CalculateTotalTaxesWithheldTotals();

            // Sum of different fields Tax Amounts + Total Equivalence 
            // Surcharges. Always to two decimal points.
            this.InvoiceTotals.TotalTaxOutputs = Math.Round(this.CalculateTaxOutputTotal(), 2);

            this.InvoiceTotals.InvoiceTotal = Math.Round(this.InvoiceTotals.TotalGrossAmountBeforeTaxes   
                                                       + this.InvoiceTotals.TotalTaxOutputs               
                                                       - this.InvoiceTotals.TotalTaxesWithheld, 2);

            // Total de gastos financieros
#warning TODO: Hacer un extension method para que se pueda indicar
            this.InvoiceTotals.TotalFinancialExpenses = 0;
            
            if (this.InvoiceTotals.Subsidies != null)
            {
                this.CalculateSubsidyAmounts();

                subsidyAmount = Math.Round(this.InvoiceTotals.Subsidies.Sum(s => s.SubsidyAmount), 2);
            }

            this.InvoiceTotals.TotalOutstandingAmount = Math.Round
            (
                this.InvoiceTotals.InvoiceTotal - (subsidyAmount + this.InvoiceTotals.TotalPaymentsOnAccount), 2
            );

            if (this.InvoiceTotals.AmountsWithheld != null)
                this.InvoiceTotals.TotalExecutableAmount = Math.Round(this.InvoiceTotals.TotalOutstandingAmount
                                                                              - this.InvoiceTotals.AmountsWithheld.WithholdingAmount 
                                                                              + this.InvoiceTotals.TotalReimbursableExpenses
                                                                              + this.InvoiceTotals.TotalFinancialExpenses, 2);
            else
                this.InvoiceTotals.TotalExecutableAmount = Math.Round(this.InvoiceTotals.TotalOutstandingAmount
                                                              + this.InvoiceTotals.TotalReimbursableExpenses
                                                              + this.InvoiceTotals.TotalFinancialExpenses, 2);

            return this.Parent;
        }

        private void CalculateSubsidyAmounts()
        {
            // Rate applied to the Invoice Total.
            this.InvoiceTotals.Subsidies.ForEach
            (
                s => s.SubsidyAmount = Math.Round(this.InvoiceTotals.InvoiceTotal * s.SubsidyRate / 100, 2)
            );
        }

        private void CalculateTotalTaxesWithheldTotals()
        {
            this.InvoiceTotals.TotalTaxesWithheld = Math.Round
            (
                this.Items.Sum
                (
                    il =>
                    {
                        double total = 0;

                        if (il.TaxesWithheld != null)
                        {
                            total = Math.Round(il.TaxesWithheld.Sum(tw => tw.TaxAmount.TotalAmount), 2);
                        }

                        return total;
                    }
                ), 2);
        }

        private void CalculateReimbursableExpensesTotals()
        {
            // Total de suplidos
            if (this.InvoiceTotals.ReimbursableExpenses != null)
            {
                this.InvoiceTotals.TotalReimbursableExpenses = Math.Round
                (
                    this.InvoiceTotals.ReimbursableExpenses.Sum(re => re.ReimbursableExpensesAmount), 2
                );
            }
        }

        private void CalculatePaymentsOnAccountTotals()
        {
            if (this.InvoiceTotals.PaymentsOnAccount != null)
            {
                this.InvoiceTotals.TotalPaymentsOnAccount = Math.Round
                (
                    this.InvoiceTotals.PaymentsOnAccount.Sum(poa => poa.PaymentOnAccountAmount), 2
                );
            }
        }

        private void CalculateGeneralSurchargesTotals()
        {
            if (this.InvoiceTotals.GeneralSurcharges != null)
            {
                this.InvoiceTotals.GeneralSurcharges.ForEach
                (
                    gs => gs.ChargeAmount = Math.Round((this.InvoiceTotals.TotalGrossAmount * gs.ChargeRate) / 100, 2)
                );

                this.InvoiceTotals.TotalGeneralSurcharges = Math.Round
                (
                    this.InvoiceTotals.GeneralSurcharges.Sum(gs => gs.ChargeAmount), 2
                );
            }
        }

        private void CalculateGeneralDiscountTotals()
        {
            if (this.InvoiceTotals.GeneralDiscounts != null)
            {
                this.InvoiceTotals.GeneralDiscounts.ForEach
                (
                    gd => gd.DiscountAmount = Math.Round((this.InvoiceTotals.TotalGrossAmount * gd.DiscountRate) / 100, 2)
                );

                this.InvoiceTotals.TotalGeneralDiscounts = Math.Round
                (
                    this.InvoiceTotals.GeneralDiscounts.Sum(gd => gd.DiscountAmount), 2
                );
            }
        }

        private double CalculateTaxOutputTotal()
        {
            return this.TaxesOutputs.Sum(to => to.TaxAmount.TotalAmount);
        }

        #endregion
    }

    public partial class InvoiceLineType
    {
        #region · InvoiceLineType Extensions ·
        public InvoiceLineType SetExpedientReference(string expedient)
        {
            this.FileReference = expedient;
            return this;
        }
        public InvoiceLineType SetExpedientDate(DateTime dateexpedient)
        {
            this.FileDate = dateexpedient;
            return this;
        }
        public InvoiceLineType AddDeliberyNotes(string deliverynumber, DateTime deliverydate)
        {
            if (!string.IsNullOrEmpty(deliverynumber))
            {
                var deliverys = this.DeliveryNotesReferences ?? new List<DeliveryNoteType>();
                deliverys.Add(new DeliveryNoteType { DeliveryNoteDate = deliverydate, DeliveryNoteNumber = deliverynumber, DeliveryNoteDateSpecified = true });
                this.DeliveryNotesReferences = deliverys;
            }
            return this;
        }
        /// <summary>
        /// Se informa del objeto global facturado al que pertenece este elemento
        /// </summary>
        /// <param name="informationofiteminvoiced"></param>
        /// <returns></returns>
        public InvoiceLineType SetInformationOfItemInvoiced(string informationofiteminvoiced)
        {
            this.AdditionalLineItemInformation = $"Identificador del objeto facturado: {informationofiteminvoiced}";

            return this;
        }
        /// <summary>
        /// Se establece en "Unidades" la unidad de medida del artículo
        /// </summary>
        /// <returns></returns>
        public InvoiceLineType SetDefaultUnitOfMeasure()
        {
            this.UnitOfMeasure = (UnitOfMeasureType)Enum.Parse(typeof(UnitOfMeasureType), "0");
            this.unitOfMeasureFieldSpecified = true;
            return this;
        }
        /// <summary>
        /// Se establece unidad de medida del artículo
        /// 0=Unidades,1=Horas,2=Kg,3=Litros,4=Otros....
        /// </summary>
        /// <param name="unitofmeasurecode"></param>
        /// <returns></returns>
        public InvoiceLineType GiveUnitOfMeasure(int unitofmeasurecode)
        {
            unitofmeasurecode = (unitofmeasurecode >= 0 & unitofmeasurecode <= 35) ? unitofmeasurecode : 0; // max code in version 3.2 
            this.UnitOfMeasure = (UnitOfMeasureType)Enum.Parse(typeof(UnitOfMeasureType), unitofmeasurecode.ToString());
            this.unitOfMeasureFieldSpecified = true;
            return this;
        }
        public InvoiceLineType GiveQuantity(double quantity)
        {
            this.Quantity = quantity;

            return this;
        }

        public InvoiceLineType GiveUnitPriceWithoutTax(double price)
        {
            this.UnitPriceWithoutTax = price;

            return this;
        }

        public InvoiceLineType GiveDiscount(double discountRate)
        {
            if (discountRate != 0)
            {
                if (this.DiscountsAndRebates == null)
                {
                    this.DiscountsAndRebates = new List<DiscountType>();
                }

                var discount = new DiscountType
                {
                    DiscountRate = discountRate
                  , DiscountReason = "Descuento"
                };

                this.DiscountsAndRebates.Add(discount);
            }
            return this;
        }

        public InvoiceLineType GiveTax(double taxRate)
        {
            if (this.TaxesOutputs == null)
            {
                this.TaxesOutputs = new List<InvoiceLineTypeTax>();
            }

            var tax = new InvoiceLineTypeTax
            {
                TaxTypeCode = TaxTypeCodeType.Item01
              , TaxRate     = taxRate
            };

            this.TaxesOutputs.Add(tax);

            return this;
        }
        public InvoiceLineType GiveTaxWithHeld(double taxRate)
        {
            if (taxRate ==  0) return this;

            if (this.taxesWithheldField == null)
            {
                this.taxesWithheldField = new List<TaxType>();
            }

            var taxwithheld = new TaxType
            {
                TaxTypeCode = TaxTypeCodeType.Item04
              ,
                TaxRate = taxRate
            };

            this.taxesWithheldField.Add(taxwithheld);

            return this;
        }

        public InvoiceType CalculateTotals()
        {
            double totalDiscounts = 0;
            double totalCharges   = 0;

            this.TotalCost = Math.Round(this.Quantity * this.UnitPriceWithoutTax, 2);

            if (this.DiscountsAndRebates != null)
            {
                this.DiscountsAndRebates.ForEach
                (
                    dar => 
                    {
                        dar.DiscountAmount = Math.Round(this.TotalCost * dar.DiscountRate / 100, 2);
                        totalDiscounts     = Math.Round(totalDiscounts + dar.DiscountAmount, 2);
                    }
                );
            }

            if (this.Charges != null)
            {
                this.Charges.ForEach
                (
                    chr =>
                    {
                        chr.ChargeAmount = Math.Round(this.TotalCost * chr.ChargeRate / 100, 2);
                        totalCharges     = Math.Round(totalCharges + chr.ChargeAmount, 2);
                    }
                );
            }

            this.GrossAmount = this.TotalCost - totalDiscounts + totalCharges;

            this.TaxesOutputs.ForEach
            (
                tax =>
                {
                    if (tax.TaxableBase == null)
                    {
                        tax.TaxableBase = new AmountType();
                    }

                    tax.TaxableBase.TotalAmount       = this.GrossAmount;
                    tax.TaxableBase.EquivalentInEuros = this.GrossAmount;

                    if (tax.TaxAmount == null)
                    {
                        tax.TaxAmount = new AmountType();
                    }

                    tax.TaxAmount.TotalAmount = Math.Round(tax.TaxableBase.TotalAmount * tax.TaxRate / 100, 2);
                }
            );
            this.TaxesWithheld?.ForEach
            (
                tax =>
                {
                    if (tax.TaxableBase == null)
                    {
                        tax.TaxableBase = new AmountType();
                    }

                    tax.TaxableBase.TotalAmount = this.GrossAmount;
                    tax.TaxableBase.EquivalentInEuros = this.GrossAmount;

                    if (tax.TaxAmount == null)
                    {
                        tax.TaxAmount = new AmountType();
                    }

                    tax.TaxAmount.TotalAmount = Math.Round(tax.TaxableBase.TotalAmount * tax.TaxRate / 100, 2);
                }
            );

            return this.Parent;
        }

        #endregion
    }

    public partial class BusinessType
    {
        #region · Fields ·

        private Facturae parent;

        #endregion

        #region · Constructors ·

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessType"/> class.
        /// </summary>
        public BusinessType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessType"/> class.
        /// </summary>
        public BusinessType(Facturae parent)
        {
            this.parent            = parent;
            this.TaxIdentification = new TaxIdentificationType();
        }

        #endregion

        #region · BusinessType Extensions ·

        public Facturae Invoice()
        {
            return this.parent;
        }

        /// <summary>
        /// Sets the identification of a invoice business party
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="identification">The identification</param>
        /// <returns></returns>
        public BusinessType SetIdentification(string identification)
        {
            this.PartyIdentification = identification;
  
            return this;
        }

        /// <summary>
        /// Sets an invoice business party as an individual
        /// </summary>
        /// <param name="party">The business party</param>
        /// <returns></returns>
        public IndividualType IsIndividual()
        {
            var individual = new IndividualType { Parent = this };

            this.Item = individual;

            if (this.TaxIdentification.ResidenceTypeCode == ResidenceTypeCodeType.ResidentInSpain)
            {
                AddressType address = new AddressType();
                    
                address.CountryCode = CountryType.ESP;
                    
                individual.Item = address;
            }
            else
            {
                individual.Item = new OverseasAddressType();
            }

            this.TaxIdentification.PersonTypeCode = PersonTypeCodeType.Individual;

            return individual;
        }

        /// <summary>
        /// Sets the identification number
        /// </summary>
        /// <param name="taxIdentification">The tax identification</param>
        /// <param name="identificationNumber">The identification number</param>
        /// <returns></returns>
        public BusinessType SetIdentificationNumber(string identificationNumber)
        {
            this.TaxIdentification.TaxIdentificationNumber = identificationNumber;
  
            return this;
        }

        public LegalEntityType IsLegalEntity()
        {
            var legalEntity = new LegalEntityType(this);

            this.Item = legalEntity;

            if (this.TaxIdentification != null)
            {
                this.TaxIdentification.PersonTypeCode = PersonTypeCodeType.LegalEntity;

                if (this.TaxIdentification.ResidenceTypeCode == ResidenceTypeCodeType.ResidentInSpain)
                {
                    AddressType address = new AddressType();

                    address.CountryCode = CountryType.ESP;

                    legalEntity.Item = address;
                }
                else
                {
                    legalEntity.Item = new OverseasAddressType();
                }
            }

            return legalEntity;
        }

        /// <summary>
        /// Sets the tax identification as a foreigner entity identification
        /// </summary>
        /// <param name="taxIdentification">The tax identification</param>
        /// <returns></returns>
        public BusinessType IsForeigner()
        {
            this.TaxIdentification.ResidenceTypeCode = ResidenceTypeCodeType.Foreigner;
  
            return this;
        }

        /// <summary>
        /// Sets the tax identification as an spain tax identification
        /// </summary>
        /// <param name="taxIdentification">The tax identification</param>
        /// <returns></returns>
        public BusinessType IsResidentInSpain()
        {
            this.TaxIdentification.ResidenceTypeCode = ResidenceTypeCodeType.ResidentInSpain;
  
            return this;
        }

        /// <summary>
        /// Sets the tax identification as an EU tax identification
        /// </summary>
        /// <param name="taxIdentification">The tax identification</param>
        /// <returns></returns>
        public BusinessType IsResidentInEU()
        {
            this.TaxIdentification.ResidenceTypeCode = ResidenceTypeCodeType.ResidentInEU;
  
            return this;
        }

        /// <summary>
        /// Adds an administrative centre
        /// </summary>
        /// <returns></returns>
        public AdministrativeCentreType AddAdministrativeCentre()
        {
            var centre = new AdministrativeCentreType(this);

            if (this.AdministrativeCentres == null)
            this.AdministrativeCentres = new List<AdministrativeCentreType>();

            this.AdministrativeCentres.Add(centre);

            if (this.TaxIdentification != null)
            {
                if (this.TaxIdentification.ResidenceTypeCode == ResidenceTypeCodeType.ResidentInSpain)
                {
                    AddressType address = new AddressType();

                    address.CountryCode = CountryType.ESP;

                    centre.Item = address;
                }
                else
                {
                    centre.Item = new OverseasAddressType();
                }
            }

            return this.AdministrativeCentres.Last();
        } 

        #endregion
    }

    public partial class IndividualType
    {
        #region · Individual Type Extensions ·

        /// <summary>
        /// Gets the individual parent party
        /// </summary>
        /// <param name="individual">The individual</param>
        /// <returns></returns>
        public BusinessType Party()
        {
            return this.Parent;
        }

        /// <summary>
        /// Sets an individual name spliting fullname into name and surnames
        /// </summary>
        /// <param name="individual">The individual</param>
        /// <param name="name">The individual name</param>
        /// <returns></returns>
        public IndividualType SetFullName(string name)
        {
            if (name.Contains(","))
            {
                string[] surname1surname2name = name.Split(' ' , ',');
                if (surname1surname2name.Length == 2)
                {
                    this.Name = surname1surname2name.LastOrDefault();
                    this.FirstSurname = surname1surname2name.FirstOrDefault();
                }
                else if (surname1surname2name.Length == 3)
                {
                    this.Name = surname1surname2name.LastOrDefault();
                    this.FirstSurname = surname1surname2name.FirstOrDefault();
                    this.SecondSurname = surname1surname2name.ElementAt(1);
                }
                else if (surname1surname2name.Length == 4)
                {
                    this.Name = surname1surname2name.ElementAt(2) + " " + surname1surname2name.ElementAt(3);
                    this.FirstSurname = surname1surname2name.ElementAt(0);
                    this.SecondSurname = surname1surname2name.ElementAt(1);
                }
                else if (surname1surname2name.Length > 4)
                {
                    this.Name = surname1surname2name.ElementAt(3) + " " + surname1surname2name.ElementAt(4);
                    this.FirstSurname = surname1surname2name.ElementAt(0);
                    this.SecondSurname = surname1surname2name.ElementAt(1);
                }
            }
            else
            {
                string[] namesurname1surname2 = name.Split(' ', ',');
                if (namesurname1surname2.Length == 2)
                {
                    this.Name = namesurname1surname2.FirstOrDefault();
                    this.FirstSurname = namesurname1surname2.LastOrDefault();
                }
                else if (namesurname1surname2.Length == 3)
                {
                    this.Name = namesurname1surname2.FirstOrDefault();
                    this.FirstSurname = namesurname1surname2.ElementAt(1);
                    this.SecondSurname = namesurname1surname2.LastOrDefault();
                }
                else if (namesurname1surname2.Length > 3)
                {
                    this.Name = namesurname1surname2.ElementAt(0) + " " + namesurname1surname2.ElementAt(1);
                    this.FirstSurname = namesurname1surname2.ElementAt(2);
                    this.SecondSurname = namesurname1surname2.ElementAt(3);
                }
            }

            return this;
        }
        /// <summary>
        /// Sets an individual name
        /// </summary>
        /// <param name="individual">The individual</param>
        /// <param name="name">The individual name</param>
        /// <returns></returns>
        public IndividualType SetName(string name)
        {
            this.Name = name;
  
            return this;
        }

        /// <summary>
        /// Sets an individual first surname
        /// </summary>
        /// <param name="individual">The individual</param>
        /// <param name="name">The individual first surname</param>
        /// <returns></returns>
        public IndividualType SetFirstSurname(string firstSurname)
        {
            this.FirstSurname = firstSurname;
  
            return this;
        }

        /// <summary>
        /// Sets an individual second surname
        /// </summary>
        /// <param name="individual">The individual</param>
        /// <param name="name">The individual second surname</param>
        /// <returns></returns>
        public IndividualType SetSecondSurname(string secondSurname)
        {
            this.SecondSurname = secondSurname;
  
            return this;
        }

        /// <summary>
        /// Sets an individual party address
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The address</param>
        /// <returns></returns>
        public IndividualType SetAddress(string address)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Address = address;
            }
            else
            {
                ((OverseasAddressType)this.Item).Address = address;
            }

            return this;
        }

        /// <summary>
        /// Sets an individual party post code
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The post code</param>
        /// <returns></returns>
        public IndividualType SetPostCode(string postCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).PostCode = postCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCode;
            }

            return this;
        }

        /// <summary>
        /// Sets an individual party country code
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The country code</param>
        /// <returns></returns>
        public IndividualType SetCountryCode(CountryType countryCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).CountryCode = countryCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).CountryCode = countryCode;
            }

            return this;
        }

        /// <summary>
        /// Sets an individual party town
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The town</param>
        /// <returns></returns>
        public IndividualType SetTown(string postCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Town = postCode;
            }

            return this;
        }

        /// <summary>
        /// Sets an individual party post code & town 
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The post code & towm</param>
        /// <returns></returns>
        public IndividualType SetPostCodeAndTown(string postCodeAndTown)
        {
            if (this.Item is OverseasAddressType)
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCodeAndTown;
            }

            return this;
        }

        /// <summary>
        /// Sets an individual party province
        /// </summary>
        /// <param name="party">The business party</param>
        /// <param name="address">The province</param>
        /// <returns></returns>
        public IndividualType SetProvince(string province)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Province = province;
            }
            else
            {
                ((OverseasAddressType)this.Item).Province = province;
            }

            return this;
        }

        public ContactDetailsType CreateContactDetails()
        {
            this.ContactDetails = this.ContactDetails ?? new ContactDetailsType(this);
            return this.ContactDetails;
        }
        #endregion
    }

    public partial class AdministrativeCentreType
    {
        #region · Fields ·

        private BusinessType parent;

        #endregion

        #region · Constructors ·

        public AdministrativeCentreType()
        {
        }

        public AdministrativeCentreType(BusinessType parent)
        {
            this.parent = parent;
        }

        #endregion

        #region · Public Methods ·

        public BusinessType Party()
        {
            return this.parent;
        }

        public AdministrativeCentreType SetRoleCodeType(string roleCodeType)
        {
            RoleTypeCodeType role = RoleTypeCodeType.Item01;

            switch (roleCodeType)
            {
                case "02":
                    role = RoleTypeCodeType.Item02;
                    break;
                case "03":
                    role = RoleTypeCodeType.Item03;
                    break;
                case "04":
                    role = RoleTypeCodeType.Item04;
                    break;
                case "05":
                    role = RoleTypeCodeType.Item05;
                    break;
                case "06":
                    role = RoleTypeCodeType.Item06;
                    break;
                case "07":
                    role = RoleTypeCodeType.Item07;
                    break;
                case "08":
                    role = RoleTypeCodeType.Item08;
                    break;
                case "09":
                    role = RoleTypeCodeType.Item09;
                    break;
            }

            this.RoleTypeCode = role;
            this.RoleTypeCodeSpecified = true;

            return this;
        }
        public AdministrativeCentreType SetRoleCodeType(int roleCodeType)
        {
            RoleTypeCodeType role = RoleTypeCodeType.Item01;

            switch (roleCodeType)
            {
                case 2:
                    role = RoleTypeCodeType.Item02;
                    break;
                case 3:
                    role = RoleTypeCodeType.Item03;
                    break;
                case 4:
                    role = RoleTypeCodeType.Item04;
                    break;
                case 5:
                    role = RoleTypeCodeType.Item05;
                    break;
                case 6:
                    role = RoleTypeCodeType.Item06;
                    break;
                case 7:
                    role = RoleTypeCodeType.Item07;
                    break;
                case 8:
                    role = RoleTypeCodeType.Item08;
                    break;
                case 9:
                    role = RoleTypeCodeType.Item09;
                    break;
            }

            this.RoleTypeCode = role;
            this.RoleTypeCodeSpecified = true;

            return this;
        }

        public AdministrativeCentreType SetCentreCode(string centreCode)
        {
            this.CentreCode = centreCode;

            return this;
        }

        public AdministrativeCentreType SetCentreDescription(string centreDescription)
        {
            this.CentreDescription = centreDescription;

            return this;
        }

        public AdministrativeCentreType SetFirstSurname(string firstSurname)
        {
            this.FirstSurname = firstSurname;

            return this;
        }

        public AdministrativeCentreType SetLogicalOperationalPoint(string logicalOperationalPoint)
        {
            this.LogicalOperationalPoint = logicalOperationalPoint;

            return this;
        }

        public AdministrativeCentreType SetName(string name)
        {
            this.Name = name;

            return this;
        }

        public AdministrativeCentreType SetPhysicalGLN(string physicalGLN)
        {
            this.PhysicalGLN = physicalGLN;

            return this;
        }

        public AdministrativeCentreType SetSecondSurname(string secondSurname)
        {
            this.SecondSurname = secondSurname;

            return this;
        }

        public AdministrativeCentreType SetAddress(string address)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Address = address;
            }
            else
            {
                ((OverseasAddressType)this.Item).Address = address;
            }

            return this;
        }

        public AdministrativeCentreType SetPostCode(string postCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).PostCode = postCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCode;
            }

            return this;
        }

        public AdministrativeCentreType SetCountryCode(CountryType countryCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).CountryCode = countryCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).CountryCode = countryCode;
            }

            return this;
        }

        public AdministrativeCentreType SetTown(string town)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Town = town;
            }

            return this;
        }

        public AdministrativeCentreType SetPostCodeAndTown(string postCodeAndTown)
        {
            if (this.Item is OverseasAddressType)
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCodeAndTown;
            }

            return this;
        }

        public AdministrativeCentreType SetProvince(string province)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Province = province;
            }
            else
            {
                ((OverseasAddressType)this.Item).Province = province;
            }

            return this;
        }

        #endregion
    }

    public partial class LegalEntityType
    {
        #region · Fields ·

        private BusinessType parent;

        #endregion

        #region · Constructors ·

        public LegalEntityType()
        {

        }

        public LegalEntityType(BusinessType parent)
        {
            this.parent = parent;

        }

        #endregion

        #region · LegalEntity Type Extensions ·

        public BusinessType Party()
        {
            return this.parent;
        }

        public LegalEntityType SetCorporateName(string corporateName)
        {
            this.CorporateName = corporateName;

            return this;
        }

        public LegalEntityType SetTradeName(string tradeName)
        {
            this.TradeName = tradeName;

            return this;
        }

        public LegalEntityType SetAddress(string address)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Address = address;
            }
            else
            {
                ((OverseasAddressType)this.Item).Address = address;
            }

            return this;
        }

        public LegalEntityType SetPostCode(string postCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).PostCode = postCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCode;
            }

            return this;
        }

        public LegalEntityType SetCountryCode(CountryType countryCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).CountryCode = countryCode;
            }
            else
            {
                ((OverseasAddressType)this.Item).CountryCode = countryCode;
            }

            return this;
        }

        public LegalEntityType SetTown(string postCode)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Town = postCode;
            }

            return this;
        }

        public LegalEntityType SetPostCodeAndTown(string postCodeAndTown)
        {
            if (this.Item is OverseasAddressType)
            {
                ((OverseasAddressType)this.Item).PostCodeAndTown = postCodeAndTown;
            }

            return this;
        }

        public LegalEntityType SetProvince(string province)
        {
            if (this.Item is AddressType)
            {
                ((AddressType)this.Item).Province = province;
            }
            else
            {
                ((OverseasAddressType)this.Item).Province = province;
            }

            return this;
        }

        public ContactDetailsType CreateContactDetails()
        {
            this.ContactDetails = this.ContactDetails ??  new ContactDetailsType(this);
            return this.ContactDetails;
        }
        #endregion
    }

    public partial class InstallmentType
    {
        private Facturae facturae;
        public InstallmentType()
        {

        }
        public InstallmentType(Facturae _facturae)
        {
            facturae = _facturae;
           
        }
        public InstallmentType SetPaymentDueDate(DateTime venciment)
        {
            this.InstallmentDueDate = venciment;

            return this;
        }
        public InstallmentType SetPaymentAmount(double importToPay)
        {
            this.InstallmentAmount = Math.Round(importToPay, 2);

            return this;
        }
        public Facturae  SetPaymentTransferencia(string iban, string bic)
        {
            if (!string.IsNullOrEmpty(iban))
            {
                var firstInvoice = facturae.Invoices[0];
                var installment = firstInvoice.PaymentDetails.FirstOrDefault();
                installment.PaymentMeans = PaymentMeansType.Item04;
                var accounttype = new AccountType();
                accounttype.Item = iban;
                accounttype.BIC = bic;
                installment.AccountToBeCredited = accounttype;
            }
            return facturae;
        }
           
    }

    public partial class ContactDetailsType
    {
        IndividualType parentindividual;
        LegalEntityType parentlegal;
        public ContactDetailsType()
        {

        }
        public ContactDetailsType(IndividualType parentindividual)
        {
            this.parentindividual = parentindividual;
        }
        public ContactDetailsType(LegalEntityType parentlegal)
        {
            this.parentlegal = parentlegal;
        }
        public IndividualType Individual()
        {
            return this.parentindividual;
        }
        public LegalEntityType Legal()
        {
            return this.parentlegal;
        }
        public ContactDetailsType SetContactPerson(String contactperson)
        {
            this.ContactPersons = contactperson;

            return this;
        }
        public ContactDetailsType SetPhone(string phone)
        {
            this.Telephone = phone;
            return this;
        }
        public ContactDetailsType SetFax(string fax)
        {
            this.TeleFax = fax;
            return this;
        }
        public ContactDetailsType SetEmail(string email)
        {
            this.ElectronicMail = email;

            return this;
        }

        public ContactDetailsType SetWeb(string web)
        {
            this.WebAddress = web;

            return this;
        }
        public ContactDetailsType SetCNAE(string cnae)
        {
            this.CnoCnae = cnae;
            return this;
        }
        public ContactDetailsType SetiNeTownCodeField(string inetowncodefield)
        {
            this.INETownCode = inetowncodefield;
            return this;
        }
        public ContactDetailsType SetAdditionalContactDetail(string additionalcontactdetail)
        {
            this.AdditionalContactDetails = additionalcontactdetail;
            return this;
        }
    }
}