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

using FacturaE.Enums;
using FacturaE.Extensions;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FacturaE
{
    public class Program
    {
        static void Main(string[] args)
        {
            var eInvoice = new Facturae();
            // Create a new facturae invoice & sign it
            var isValid = eInvoice
                .Seller()
                    .SetIdentification("00001")
                    .IsResidentInSpain()
                    .SetIdentificationNumber("43710006R")
                    .IsIndividual()
                        .SetName("JOSEP MARIA")
                        .SetFirstSurname("CANALEJAS")
                        .SetAddress("8585 FIRST STREET")
                        .SetProvince("MADRID")
                        .SetTown("MADRID")
                        .SetPostCode("99900")
                        .SetCountryCode(CountryType.ESP)
                        .Party()
                    .Invoice()
                .Buyer()
                    .SetIdentification("00002")
                    .IsResidentInSpain()
                    .SetIdentificationNumber("P2807900B")
                    .AddAdministrativeCentre()
                        .SetCentreCode("1")
                        .SetRoleCodeType("02")
                        .SetLogicalOperationalPoint("1233")
                        .SetName("ADMINISTRATION NAME")
                        .SetAddress("1234 Street")
                        .SetProvince("MADRID")
                        .SetTown("MADRID")
                        .SetPostCode("99900")
                        .SetCountryCode(CountryType.ESP)
                    .Party()
                        .IsLegalEntity()
                            .SetCorporateName("JOHN")
                            .SetAddress("8585 FIRST STREET")
                            .SetProvince("MADRID")
                            .SetTown("MADRID")
                            .SetPostCode("99900")
                            .SetCountryCode(CountryType.ESP)
                            .CreateContactDetails()
                                .SetEmail("sssss@gmail.com")
                                .SetContactPerson("mariano")
                                .SetPhone("9999999")
                                .SetWeb("https://google.com")
                        .Legal()
                   .Party()
                .Invoice()
                .CreateInvoice()
                    .SetCurrency(CurrencyCodeType.EUR)
                    .SetExchangeRate(1, DateTime.Now)
                    .SetTaxCurrency(CurrencyCodeType.EUR)
                    .SetLanguage(LanguageCodeType.es)
                    .SetPlaceOfIssue(String.Empty, "00000")
                    .IsOriginal()
                    .IsComplete()
                    .SetInvoiceSeries("0")
                    .SetInvoiceNumber("1000")
                    .SetBuyerReference("sss/10407")
                    .SetInvoiceAdditionalInformation("Informacion adicional")
                    .AddInvoiceItem("XX", "XX")
                        .SetExpedientReference("05040-exp")
                        .SetExpedientDate(DateTime.Now)
                        .AddDeliberyNotes("00001", DateTime.Now)
                        .SetInformationOfItemInvoiced("Casa del oficis")
                        .GiveUnitOfMeasure(3)
                        .GiveQuantity(1)
                        .GiveUnitPriceWithoutTax(100.01)
                        .GiveDiscount(10.01)
                        .GiveTax(18.00)
                        .CalculateTotals()
                    .AddInvoiceItem("XXX", "XXX")
                        .AddDeliberyNotes("00002", DateTime.Now)
                        .SetInformationOfItemInvoiced("Casa dels oficis")
                        .SetDefaultUnitOfMeasure()
                        .GiveQuantity(1)
                        .GiveUnitPriceWithoutTax(100.01)
                        .GiveDiscount(0)
                        .GiveTax(18.00)
                        .CalculateTotals()
                    .CalculateTotals()
                .CalculateTotals()
                .CreatePayments()
                .SetPaymentDueDate(DateTime.Now)
                .SetPaymentTransferencia("ES1212341234551234567890", "CAIXESXXXXX")
                .Validate()
                .Sign()
                .SaveToFile(@"Sample.xsig");

            System.Console.WriteLine(isValid);
            System.Console.ReadLine();
        }
    }
}

