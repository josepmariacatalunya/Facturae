﻿/* FacturaE - The MIT License (MIT)
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

namespace FacturaE
{
    using FacturaE.DataType;
    using FacturaE.Enums;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    [XmlRootAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae", IsNullable = false)]
    public partial class Facturae
    {

        private FileHeaderType fileHeaderField;

        private PartiesType partiesField;

        private List<InvoiceType> invoicesField;

        private ExtensionsType extensionsField;

        private SignatureType signatureField;



        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public FileHeaderType FileHeader
        {
            get
            {
                return this.fileHeaderField;
            }
            set
            {
                this.fileHeaderField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PartiesType Parties
        {
            get
            {
                return this.partiesField;
            }
            set
            {
                this.partiesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Invoice", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<InvoiceType> Invoices
        {
            get
            {
                return this.invoicesField;
            }
            set
            {
                this.invoicesField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ExtensionsType Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class FileHeaderType
    {

        private SchemaVersionType schemaVersionField;

        private ModalityType modalityField;

        private InvoiceIssuerTypeType invoiceIssuerTypeField;

        private ThirdPartyType thirdPartyField;

        private BatchType batchField;

        private FactoringAssignmentDataType factoringAssignmentDataField;

        public FileHeaderType()
        {
            this.schemaVersionField = SchemaVersionType.Item32;
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public SchemaVersionType SchemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ModalityType Modality
        {
            get
            {
                return this.modalityField;
            }
            set
            {
                this.modalityField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceIssuerTypeType InvoiceIssuerType
        {
            get
            {
                return this.invoiceIssuerTypeField;
            }
            set
            {
                this.invoiceIssuerTypeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ThirdPartyType ThirdParty
        {
            get
            {
                return this.thirdPartyField;
            }
            set
            {
                this.thirdPartyField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public BatchType Batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public FactoringAssignmentDataType FactoringAssignmentData
        {
            get
            {
                return this.factoringAssignmentDataField;
            }
            set
            {
                this.factoringAssignmentDataField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ThirdPartyType
    {

        private TaxIdentificationType taxIdentificationField;

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxIdentificationType TaxIdentification
        {
            get
            {
                return this.taxIdentificationField;
            }
            set
            {
                this.taxIdentificationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Individual", typeof(IndividualType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LegalEntity", typeof(LegalEntityType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class TaxIdentificationType
    {

        private PersonTypeCodeType personTypeCodeField;

        private ResidenceTypeCodeType residenceTypeCodeField;

        private string taxIdentificationNumberField;
        
        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PersonTypeCodeType PersonTypeCode
        {
            get
            {
                return this.personTypeCodeField;
            }
            set
            {
                this.personTypeCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ResidenceTypeCodeType ResidenceTypeCode
        {
            get
            {
                return this.residenceTypeCodeField;
            }
            set
            {
                this.residenceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string TaxIdentificationNumber
        {
            get
            {
                return this.taxIdentificationNumberField;
            }
            set
            {
                this.taxIdentificationNumberField = value;
            }
        }
    }

 
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ObjectType
    {

        private XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [XmlTextAttribute()]
        [XmlAnyElementAttribute()]
        public XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SPKIDataType
    {

        private byte[] sPKISexpField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
        public byte[] SPKISexp
        {
            get
            {
                return this.sPKISexpField;
            }
            set
            {
                this.sPKISexpField = value;
            }
        }

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class PGPDataType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        [XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialType
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class X509DataType
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        [XmlElementAttribute("X509CRL", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509Certificate", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [XmlElementAttribute("X509SKI", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509SubjectName", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

  

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RetrievalMethodType
    {

        private List<TransformType> transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [XmlArrayItemAttribute("Transform", IsNullable = false)]
        public List<TransformType> Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformType
    {

        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        [XmlElementAttribute("XPath", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class RSAKeyValueType
    {

        private byte[] modulusField;

        private byte[] exponentField;

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Modulus
        {
            get
            {
                return this.modulusField;
            }
            set
            {
                this.modulusField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DSAKeyValueType
    {

        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] P
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Q
        {
            get
            {
                return this.qField;
            }
            set
            {
                this.qField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Seed
        {
            get
            {
                return this.seedField;
            }
            set
            {
                this.seedField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] PgenCounter
        {
            get
            {
                return this.pgenCounterField;
            }
            set
            {
                this.pgenCounterField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyValueType
    {

        private object itemField;

        private List<string> textField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        [XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public List<string> Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class KeyInfoType
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string[] textField;

        private string idField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        [XmlElementAttribute("KeyName", typeof(string))]
        [XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [XmlElementAttribute("MgmtData", typeof(string))]
        [XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [XmlElementAttribute("X509Data", typeof(X509DataType))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DigestMethodType
    {

        private XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [XmlTextAttribute()]
        [XmlAnyElementAttribute()]
        public XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ReferenceType
    {

        private List<TransformType> transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [XmlArrayItemAttribute("Transform")]
        public List<TransformType> Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public DigestMethodType DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureMethodType
    {

        private string hMACOutputLengthField;

        private XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [XmlElementAttribute(DataType = "integer")]
        public string HMACOutputLength
        {
            get
            {
                return this.hMACOutputLengthField;
            }
            set
            {
                this.hMACOutputLengthField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        [XmlAnyElementAttribute()]
        public XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class CanonicalizationMethodType
    {

        private XmlNode[] anyField;

        private string algorithmField;

        /// <remarks/>
        [XmlTextAttribute()]
        [XmlAnyElementAttribute()]
        public XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignedInfoType
    {

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private List<ReferenceType> referenceField;

        private string idField;

        /// <remarks/>
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Reference")]
        public List<ReferenceType> Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private List<ObjectType> objectField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Object")]
        public List<ObjectType> Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AttachmentType
    {

        private AttachmentCompressionAlgorithmType attachmentCompressionAlgorithmField;

        private bool attachmentCompressionAlgorithmFieldSpecified;

        private AttachmentFormatType attachmentFormatField;

        private AttachmentEncodingType attachmentEncodingField;

        private bool attachmentEncodingFieldSpecified;

        private string attachmentDescriptionField;

        private string attachmentDataField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AttachmentCompressionAlgorithmType AttachmentCompressionAlgorithm
        {
            get
            {
                return this.attachmentCompressionAlgorithmField;
            }
            set
            {
                this.attachmentCompressionAlgorithmField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AttachmentCompressionAlgorithmSpecified
        {
            get
            {
                return this.attachmentCompressionAlgorithmFieldSpecified;
            }
            set
            {
                this.attachmentCompressionAlgorithmFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AttachmentFormatType AttachmentFormat
        {
            get
            {
                return this.attachmentFormatField;
            }
            set
            {
                this.attachmentFormatField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AttachmentEncodingType AttachmentEncoding
        {
            get
            {
                return this.attachmentEncodingField;
            }
            set
            {
                this.attachmentEncodingField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AttachmentEncodingSpecified
        {
            get
            {
                return this.attachmentEncodingFieldSpecified;
            }
            set
            {
                this.attachmentEncodingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AttachmentDescription
        {
            get
            {
                return this.attachmentDescriptionField;
            }
            set
            {
                this.attachmentDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AttachmentData
        {
            get
            {
                return this.attachmentDataField;
            }
            set
            {
                this.attachmentDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AdditionalDataType
    {

        private string relatedInvoiceField;

        private List<AttachmentType> relatedDocumentsField;

        private string invoiceAdditionalInformationField;

        private ExtensionsType extensionsField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string RelatedInvoice
        {
            get
            {
                return this.relatedInvoiceField;
            }
            set
            {
                this.relatedInvoiceField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Attachment", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<AttachmentType> RelatedDocuments
        {
            get
            {
                return this.relatedDocumentsField;
            }
            set
            {
                this.relatedDocumentsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceAdditionalInformation
        {
            get
            {
                return this.invoiceAdditionalInformationField;
            }
            set
            {
                this.invoiceAdditionalInformationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ExtensionsType Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ExtensionsType
    {

        private List<XmlElement> anyField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public List<XmlElement> Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class SpecialTaxableEventType
    {

        private SpecialTaxableEventCodeType specialTaxableEventCodeField;

        private string specialTaxableEventReasonField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public SpecialTaxableEventCodeType SpecialTaxableEventCode
        {
            get
            {
                return this.specialTaxableEventCodeField;
            }
            set
            {
                this.specialTaxableEventCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string SpecialTaxableEventReason
        {
            get
            {
                return this.specialTaxableEventReasonField;
            }
            set
            {
                this.specialTaxableEventReasonField = value;
            }
        }
    }

   

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class DeliveryNoteType
    {

        private string deliveryNoteNumberField;

        private System.DateTime deliveryNoteDateField;

        private bool deliveryNoteDateFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string DeliveryNoteNumber
        {
            get
            {
                return this.deliveryNoteNumberField;
            }
            set
            {
                this.deliveryNoteNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DeliveryNoteDate
        {
            get
            {
                return this.deliveryNoteDateField;
            }
            set
            {
                this.deliveryNoteDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DeliveryNoteDateSpecified
        {
            get
            {
                return this.deliveryNoteDateFieldSpecified;
            }
            set
            {
                this.deliveryNoteDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceLineType
    {

        private string issuerContractReferenceField;

        private System.DateTime issuerContractDateField;

        private bool issuerContractDateFieldSpecified;

        private string issuerTransactionReferenceField;

        private System.DateTime issuerTransactionDateField;

        private bool issuerTransactionDateFieldSpecified;

        private string receiverContractReferenceField;

        private System.DateTime receiverContractDateField;

        private bool receiverContractDateFieldSpecified;

        private string receiverTransactionReferenceField;

        private System.DateTime receiverTransactionDateField;

        private bool receiverTransactionDateFieldSpecified;

        private string fileReferenceField;

        private System.DateTime fileDateField;

        private bool fileDateFieldSpecified;

        private double sequenceNumberField;

        private bool sequenceNumberFieldSpecified;

        private List<DeliveryNoteType> deliveryNotesReferencesField;

        private string itemDescriptionField;

        private double quantityField;

        private UnitOfMeasureType unitOfMeasureField;

        private bool unitOfMeasureFieldSpecified;

        private DoubleSixDecimalType unitPriceWithoutTaxField;

        private DoubleSixDecimalType totalCostField;

        private List<DiscountType> discountsAndRebatesField;

        private List<ChargeType> chargesField;

        private DoubleSixDecimalType grossAmountField;

        private List<TaxType> taxesWithheldField;

        private List<InvoiceLineTypeTax> taxesOutputsField;

        private PeriodDates lineItemPeriodField;

        private System.DateTime transactionDateField;

        private bool transactionDateFieldSpecified;

        private string additionalLineItemInformationField;

        private SpecialTaxableEventType specialTaxableEventField;

        private string articleCodeField;

        private ExtensionsType extensionsField;

        internal InvoiceType Parent
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string IssuerContractReference
        {
            get
            {
                return this.issuerContractReferenceField;
            }
            set
            {
                this.issuerContractReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime IssuerContractDate
        {
            get
            {
                return this.issuerContractDateField;
            }
            set
            {
                this.issuerContractDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IssuerContractDateSpecified
        {
            get
            {
                return this.issuerContractDateFieldSpecified;
            }
            set
            {
                this.issuerContractDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string IssuerTransactionReference
        {
            get
            {
                return this.issuerTransactionReferenceField;
            }
            set
            {
                this.issuerTransactionReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime IssuerTransactionDate
        {
            get
            {
                return this.issuerTransactionDateField;
            }
            set
            {
                this.issuerTransactionDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IssuerTransactionDateSpecified
        {
            get
            {
                return this.issuerTransactionDateFieldSpecified;
            }
            set
            {
                this.issuerTransactionDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ReceiverContractReference
        {
            get
            {
                return this.receiverContractReferenceField;
            }
            set
            {
                this.receiverContractReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime ReceiverContractDate
        {
            get
            {
                return this.receiverContractDateField;
            }
            set
            {
                this.receiverContractDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReceiverContractDateSpecified
        {
            get
            {
                return this.receiverContractDateFieldSpecified;
            }
            set
            {
                this.receiverContractDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ReceiverTransactionReference
        {
            get
            {
                return this.receiverTransactionReferenceField;
            }
            set
            {
                this.receiverTransactionReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime ReceiverTransactionDate
        {
            get
            {
                return this.receiverTransactionDateField;
            }
            set
            {
                this.receiverTransactionDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReceiverTransactionDateSpecified
        {
            get
            {
                return this.receiverTransactionDateFieldSpecified;
            }
            set
            {
                this.receiverTransactionDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string FileReference
        {
            get
            {
                return this.fileReferenceField;
            }
            set
            {
                this.fileReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime FileDate
        {
            get
            {
                return this.fileDateField;
            }
            set
            {
                this.fileDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FileDateSpecified
        {
            get
            {
                return this.fileDateFieldSpecified;
            }
            set
            {
                this.fileDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public double SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SequenceNumberSpecified
        {
            get
            {
                return this.sequenceNumberFieldSpecified;
            }
            set
            {
                this.sequenceNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("DeliveryNote", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<DeliveryNoteType> DeliveryNotesReferences
        {
            get
            {
                return this.deliveryNotesReferencesField;
            }
            set
            {
                this.deliveryNotesReferencesField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ItemDescription
        {
            get
            {
                return this.itemDescriptionField;
            }
            set
            {
                this.itemDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public double Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public UnitOfMeasureType UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool UnitOfMeasureSpecified
        {
            get
            {
                return this.unitOfMeasureFieldSpecified;
            }
            set
            {
                this.unitOfMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleSixDecimalType UnitPriceWithoutTax
        {
            get
            {
                return this.unitPriceWithoutTaxField;
            }
            set
            {
                this.unitPriceWithoutTaxField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
#warning TODO: usa el tipo de 6 pero dice que tiene que ir formateado con 2
        public DoubleSixDecimalType TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Discount", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<DiscountType> DiscountsAndRebates
        {
            get
            {
                return this.discountsAndRebatesField;
            }
            set
            {
                this.discountsAndRebatesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Charge", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<ChargeType> Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
#warning TODO: usa el tipo de 6 pero dice que tiene que ir formateado con 2
        public DoubleSixDecimalType GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<TaxType> TaxesWithheld
        {
            get
            {
                return this.taxesWithheldField;
            }
            set
            {
                this.taxesWithheldField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<InvoiceLineTypeTax> TaxesOutputs
        {
            get
            {
                return this.taxesOutputsField;
            }
            set
            {
                this.taxesOutputsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PeriodDates LineItemPeriod
        {
            get
            {
                return this.lineItemPeriodField;
            }
            set
            {
                this.lineItemPeriodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime TransactionDate
        {
            get
            {
                return this.transactionDateField;
            }
            set
            {
                this.transactionDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TransactionDateSpecified
        {
            get
            {
                return this.transactionDateFieldSpecified;
            }
            set
            {
                this.transactionDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AdditionalLineItemInformation
        {
            get
            {
                return this.additionalLineItemInformationField;
            }
            set
            {
                this.additionalLineItemInformationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public SpecialTaxableEventType SpecialTaxableEvent
        {
            get
            {
                return this.specialTaxableEventField;
            }
            set
            {
                this.specialTaxableEventField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ArticleCode
        {
            get
            {
                return this.articleCodeField;
            }
            set
            {
                this.articleCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ExtensionsType Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }

  

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class DiscountType
    {

        private string discountReasonField;

        private DoubleFourDecimalType discountRateField;

        private bool discountRateFieldSpecified;

        private DoubleSixDecimalType discountAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string DiscountReason
        {
            get
            {
                return this.discountReasonField;
            }
            set
            {
                this.discountReasonField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleFourDecimalType DiscountRate
        {
            get
            {
                return this.discountRateField;
            }
            set
            {
                this.discountRateField = value;
                this.DiscountRateSpecified = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DiscountRateSpecified
        {
            get
            {
                return this.discountRateFieldSpecified;
            }
            set
            {
                this.discountRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
#warning TODO: Usa el tipo de 6 pero tiene que ir formateado con 2
        public DoubleSixDecimalType DiscountAmount
        {
            get
            {
                return this.discountAmountField;
            }
            set
            {
                this.discountAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ChargeType
    {

        private string chargeReasonField;

        private DoubleFourDecimalType chargeRateField;

        private bool chargeRateFieldSpecified;

        private DoubleSixDecimalType chargeAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ChargeReason
        {
            get
            {
                return this.chargeReasonField;
            }
            set
            {
                this.chargeReasonField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleFourDecimalType ChargeRate
        {
            get
            {
                return this.chargeRateField;
            }
            set
            {
                this.chargeRateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ChargeRateSpecified
        {
            get
            {
                return this.chargeRateFieldSpecified;
            }
            set
            {
                this.chargeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
#warning TODO: Usa el tipo de 6 pero tiene que ir formateado con 2
        public DoubleSixDecimalType ChargeAmount
        {
            get
            {
                return this.chargeAmountField;
            }
            set
            {
                this.chargeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class TaxType
    {

        private TaxTypeCodeType taxTypeCodeField;

        private DoubleTwoDecimalType taxRateField;

        private AmountType taxableBaseField;

        private AmountType taxAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxTypeCodeType TaxTypeCode
        {
            get
            {
                return this.taxTypeCodeField;
            }
            set
            {
                this.taxTypeCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TaxRate
        {
            get
            {
                return this.taxRateField;
            }
            set
            {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxableBase
        {
            get
            {
                return this.taxableBaseField;
            }
            set
            {
                this.taxableBaseField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }
    }

 

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AmountType
    {

        private DoubleTwoDecimalType totalAmountField;

        private DoubleTwoDecimalType equivalentInEurosField;

        private bool equivalentInEurosFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType EquivalentInEuros
        {
            get
            {
                return this.equivalentInEurosField;
            }
            set
            {
                this.equivalentInEurosField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EquivalentInEurosSpecified
        {
            get
            {
                return this.equivalentInEurosFieldSpecified;
            }
            set
            {
                this.equivalentInEurosFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceLineTypeTax : TaxOutputType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class TaxOutputType
    {

        private TaxTypeCodeType taxTypeCodeField;

        private DoubleTwoDecimalType taxRateField;

        private AmountType taxableBaseField;

        private AmountType taxAmountField;

        private AmountType specialTaxableBaseField;

        private AmountType specialTaxAmountField;

        private DoubleTwoDecimalType equivalenceSurchargeField;

        private bool equivalenceSurchargeFieldSpecified;

        private AmountType equivalenceSurchargeAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxTypeCodeType TaxTypeCode
        {
            get
            {
                return this.taxTypeCodeField;
            }
            set
            {
                this.taxTypeCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TaxRate
        {
            get
            {
                return this.taxRateField;
            }
            set
            {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxableBase
        {
            get
            {
                return this.taxableBaseField;
            }
            set
            {
                this.taxableBaseField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType SpecialTaxableBase
        {
            get
            {
                return this.specialTaxableBaseField;
            }
            set
            {
                this.specialTaxableBaseField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType SpecialTaxAmount
        {
            get
            {
                return this.specialTaxAmountField;
            }
            set
            {
                this.specialTaxAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType EquivalenceSurcharge
        {
            get
            {
                return this.equivalenceSurchargeField;
            }
            set
            {
                this.equivalenceSurchargeField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EquivalenceSurchargeSpecified
        {
            get
            {
                return this.equivalenceSurchargeFieldSpecified;
            }
            set
            {
                this.equivalenceSurchargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType EquivalenceSurchargeAmount
        {
            get
            {
                return this.equivalenceSurchargeAmountField;
            }
            set
            {
                this.equivalenceSurchargeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class PeriodDates
    {

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AmountsWithheldType
    {

        private string withholdingReasonField;

        private DoubleFourDecimalType withholdingRateField;

        private bool withholdingRateFieldSpecified;

        private DoubleTwoDecimalType withholdingAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string WithholdingReason
        {
            get
            {
                return this.withholdingReasonField;
            }
            set
            {
                this.withholdingReasonField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleFourDecimalType WithholdingRate
        {
            get
            {
                return this.withholdingRateField;
            }
            set
            {
                this.withholdingRateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool WithholdingRateSpecified
        {
            get
            {
                return this.withholdingRateFieldSpecified;
            }
            set
            {
                this.withholdingRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType WithholdingAmount
        {
            get
            {
                return this.withholdingAmountField;
            }
            set
            {
                this.withholdingAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ReimbursableExpensesType
    {

        private TaxIdentificationType reimbursableExpensesSellerPartyField;

        private TaxIdentificationType reimbursableExpensesBuyerPartyField;

        private System.DateTime issueDateField;

        private bool issueDateFieldSpecified;

        private string invoiceNumberField;

        private string invoiceSeriesCodeField;

        private DoubleTwoDecimalType reimbursableExpensesAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxIdentificationType ReimbursableExpensesSellerParty
        {
            get
            {
                return this.reimbursableExpensesSellerPartyField;
            }
            set
            {
                this.reimbursableExpensesSellerPartyField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxIdentificationType ReimbursableExpensesBuyerParty
        {
            get
            {
                return this.reimbursableExpensesBuyerPartyField;
            }
            set
            {
                this.reimbursableExpensesBuyerPartyField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IssueDateSpecified
        {
            get
            {
                return this.issueDateFieldSpecified;
            }
            set
            {
                this.issueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceSeriesCode
        {
            get
            {
                return this.invoiceSeriesCodeField;
            }
            set
            {
                this.invoiceSeriesCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType ReimbursableExpensesAmount
        {
            get
            {
                return this.reimbursableExpensesAmountField;
            }
            set
            {
                this.reimbursableExpensesAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class PaymentOnAccountType
    {

        private System.DateTime paymentOnAccountDateField;

        private DoubleTwoDecimalType paymentOnAccountAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime PaymentOnAccountDate
        {
            get
            {
                return this.paymentOnAccountDateField;
            }
            set
            {
                this.paymentOnAccountDateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType PaymentOnAccountAmount
        {
            get
            {
                return this.paymentOnAccountAmountField;
            }
            set
            {
                this.paymentOnAccountAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class SubsidyType
    {

        private string subsidyDescriptionField;

        private DoubleFourDecimalType subsidyRateField;

        private bool subsidyRateFieldSpecified;

        private DoubleTwoDecimalType subsidyAmountField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string SubsidyDescription
        {
            get
            {
                return this.subsidyDescriptionField;
            }
            set
            {
                this.subsidyDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleFourDecimalType SubsidyRate
        {
            get
            {
                return this.subsidyRateField;
            }
            set
            {
                this.subsidyRateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SubsidyRateSpecified
        {
            get
            {
                return this.subsidyRateFieldSpecified;
            }
            set
            {
                this.subsidyRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType SubsidyAmount
        {
            get
            {
                return this.subsidyAmountField;
            }
            set
            {
                this.subsidyAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceTotalsType
    {

        private DoubleTwoDecimalType totalGrossAmountField;

        private List<DiscountType> generalDiscountsField;

        private List<ChargeType> generalSurchargesField;

        private DoubleTwoDecimalType totalGeneralDiscountsField;

        private bool totalGeneralDiscountsFieldSpecified;

        private DoubleTwoDecimalType totalGeneralSurchargesField;

        private bool totalGeneralSurchargesFieldSpecified;

        private DoubleTwoDecimalType totalGrossAmountBeforeTaxesField;

        private DoubleTwoDecimalType totalTaxOutputsField;

        private double totalTaxesWithheldField;

        private double invoiceTotalField;

        private List<SubsidyType> subsidiesField;

        private List<PaymentOnAccountType> paymentsOnAccountField;

        private List<ReimbursableExpensesType> reimbursableExpensesField;

        private DoubleTwoDecimalType totalFinancialExpensesField;

        private bool totalFinancialExpensesFieldSpecified;

        private DoubleTwoDecimalType totalOutstandingAmountField;

        private DoubleTwoDecimalType totalPaymentsOnAccountField;

        private bool totalPaymentsOnAccountFieldSpecified;

        private AmountsWithheldType amountsWithheldField;

        private DoubleTwoDecimalType totalExecutableAmountField;

        private DoubleTwoDecimalType totalReimbursableExpensesField;

        private bool totalReimbursableExpensesFieldSpecified;

        /// <summary>
        /// (TGA) Total sum of the gross amounts of the invoice 
        /// items. Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalGrossAmount
        {
            get
            {
                return this.totalGrossAmountField;
            }
            set
            {
                this.totalGrossAmountField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Discount", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<DiscountType> GeneralDiscounts
        {
            get
            {
                return this.generalDiscountsField;
            }
            set
            {
                this.generalDiscountsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Charge", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<ChargeType> GeneralSurcharges
        {
            get
            {
                return this.generalSurchargesField;
            }
            set
            {
                this.generalSurchargesField = value;
            }
        }

        /// <summary>
        /// Discounts on the Total Gross Amount. There will be as many blocks of fields GeneralDiscounts as there 
        /// are different discount types applied to the same invoice. 
        /// When there are different taxable bases, they will be applied proportionally, 
        /// the final round-up to the nearest cent being carried out on the tax type of greatest value.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalGeneralDiscounts
        {
            get
            {
                return this.totalGeneralDiscountsField;
            }
            set
            {
                this.totalGeneralDiscountsField     = value;
                this.TotalGeneralDiscountsSpecified = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalGeneralDiscountsSpecified
        {
            get
            {
                return this.totalGeneralDiscountsFieldSpecified;
            }
            set
            {
                this.totalGeneralDiscountsFieldSpecified = value;
            }
        }

        /// <summary>
        /// Sum of different fields  GeneralSurcharges Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalGeneralSurcharges
        {
            get
            {
                return this.totalGeneralSurchargesField;
            }
            set
            {
                this.totalGeneralSurchargesField        = value;
                this.TotalGeneralSurchargesSpecified    = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalGeneralSurchargesSpecified
        {
            get
            {
                return this.totalGeneralSurchargesFieldSpecified;
            }
            set
            {
                this.totalGeneralSurchargesFieldSpecified = value;
            }
        }

        /// <summary>
        /// Result: TotalGrossAmount - TotalGeneralDiscounts + TotalGeneralSurcharges Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalGrossAmountBeforeTaxes
        {
            get
            {
                return this.totalGrossAmountBeforeTaxesField;
            }
            set
            {
                this.totalGrossAmountBeforeTaxesField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalTaxOutputs
        {
            get
            {
                return this.totalTaxOutputsField;
            }
            set
            {
                this.totalTaxOutputsField = value;
            }
        }

        /// <summary>
        /// Sum of different fields TaxAmount. Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalTaxesWithheld
        {
            get
            {
                return this.totalTaxesWithheldField;
            }
            set
            {
                this.totalTaxesWithheldField = value;
            }
        }

        /// <summary>
        /// Result: TotalGrossAmountBeforeTaxes + TotalTaxOutputs - TotalTaxesWithheld. Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType InvoiceTotal
        {
            get
            {
                return this.invoiceTotalField;
            }
            set
            {
                this.invoiceTotalField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Subsidy", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<SubsidyType> Subsidies
        {
            get
            {
                return this.subsidiesField;
            }
            set
            {
                this.subsidiesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("PaymentOnAccount", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<PaymentOnAccountType> PaymentsOnAccount
        {
            get
            {
                return this.paymentsOnAccountField;
            }
            set
            {
                this.paymentsOnAccountField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("ReimbursableExpenses", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<ReimbursableExpensesType> ReimbursableExpenses
        {
            get
            {
                return this.reimbursableExpensesField;
            }
            set
            {
                this.reimbursableExpensesField = value;
            }
        }

        /// <summary>
        /// Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalFinancialExpenses
        {
            get
            {
                return this.totalFinancialExpensesField;
            }
            set
            {
                this.totalFinancialExpensesField = value;
                this.TotalFinancialExpensesSpecified = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalFinancialExpensesSpecified
        {
            get
            {
                return this.totalFinancialExpensesFieldSpecified;
            }
            set
            {
                this.totalFinancialExpensesFieldSpecified = value;
            }
        }

        /// <summary>
        /// Result: InvoiceTotal - (SubsidyAmount + TotalPaymentsOnAccount). Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalOutstandingAmount
        {
            get
            {
                return this.totalOutstandingAmountField;
            }
            set
            {
                this.totalOutstandingAmountField = value;
            }
        }

        /// <summary>
        /// Sum of the fields PaymentOnAccountAmount. Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalPaymentsOnAccount
        {
            get
            {
                return this.totalPaymentsOnAccountField;
            }
            set
            {
                this.totalPaymentsOnAccountField        = value;
                this.TotalPaymentsOnAccountSpecified    = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalPaymentsOnAccountSpecified
        {
            get
            {
                return this.totalPaymentsOnAccountFieldSpecified;
            }
            set
            {
                this.totalPaymentsOnAccountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountsWithheldType AmountsWithheld
        {
            get
            {
                return this.amountsWithheldField;
            }
            set
            {
                this.amountsWithheldField = value;
            }
        }

        /// <summary>
        /// Result: TotalOutstandingAmount - WithholdingAmount + Reimbursable expenses + Financial expenses. Always to two decimal points
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalExecutableAmount
        {
            get
            {
                return this.totalExecutableAmountField;
            }
            set
            {
                this.totalExecutableAmountField = value;
            }
        }

        /// <summary>
        /// Always to two decimal points.
        /// </summary>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType TotalReimbursableExpenses
        {
            get
            {
                return this.totalReimbursableExpensesField;
            }
            set
            {
                this.totalReimbursableExpensesField     = value;
                this.TotalReimbursableExpensesSpecified = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalReimbursableExpensesSpecified
        {
            get
            {
                return this.totalReimbursableExpensesFieldSpecified;
            }
            set
            {
                this.totalReimbursableExpensesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ExchangeRateDetailsType
    {

        private DoubleTwoDecimalType exchangeRateField;

        private System.DateTime exchangeRateDateField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime ExchangeRateDate
        {
            get
            {
                return this.exchangeRateDateField;
            }
            set
            {
                this.exchangeRateDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class PlaceOfIssueType
    {

        private string postCodeField;

        private string placeOfIssueDescriptionField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PlaceOfIssueDescription
        {
            get
            {
                return this.placeOfIssueDescriptionField;
            }
            set
            {
                this.placeOfIssueDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceIssueDataType
    {

        private System.DateTime issueDateField;

        private System.DateTime operationDateField;

        private bool operationDateFieldSpecified;

        private PlaceOfIssueType placeOfIssueField;

        private PeriodDates invoicingPeriodField;

        private CurrencyCodeType invoiceCurrencyCodeField;

        private ExchangeRateDetailsType exchangeRateDetailsField;

        private CurrencyCodeType taxCurrencyCodeField;

        private LanguageCodeType languageNameField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime OperationDate
        {
            get
            {
                return this.operationDateField;
            }
            set
            {
                this.operationDateField = value;
                this.OperationDateSpecified = true;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OperationDateSpecified
        {
            get
            {
                return this.operationDateFieldSpecified;
            }
            set
            {
                this.operationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PlaceOfIssueType PlaceOfIssue
        {
            get
            {
                return this.placeOfIssueField;
            }
            set
            {
                this.placeOfIssueField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PeriodDates InvoicingPeriod
        {
            get
            {
                return this.invoicingPeriodField;
            }
            set
            {
                this.invoicingPeriodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CurrencyCodeType InvoiceCurrencyCode
        {
            get
            {
                return this.invoiceCurrencyCodeField;
            }
            set
            {
                this.invoiceCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ExchangeRateDetailsType ExchangeRateDetails
        {
            get
            {
                return this.exchangeRateDetailsField;
            }
            set
            {
                this.exchangeRateDetailsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return this.taxCurrencyCodeField;
            }
            set
            {
                this.taxCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public LanguageCodeType LanguageName
        {
            get
            {
                return this.languageNameField;
            }
            set
            {
                this.languageNameField = value;
            }
        }
    }

  

 

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class CorrectiveType
    {

        private string invoiceNumberField;

        private string invoiceSeriesCodeField;

        private ReasonCodeType reasonCodeField;

        private ReasonDescriptionType reasonDescriptionField;

        private PeriodDates taxPeriodField;

        private CorrectionMethodType correctionMethodField;

        private CorrectionMethodDescriptionType correctionMethodDescriptionField;

        private string additionalReasonDescriptionField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceSeriesCode
        {
            get
            {
                return this.invoiceSeriesCodeField;
            }
            set
            {
                this.invoiceSeriesCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ReasonCodeType ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ReasonDescriptionType ReasonDescription
        {
            get
            {
                return this.reasonDescriptionField;
            }
            set
            {
                this.reasonDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PeriodDates TaxPeriod
        {
            get
            {
                return this.taxPeriodField;
            }
            set
            {
                this.taxPeriodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CorrectionMethodType CorrectionMethod
        {
            get
            {
                return this.correctionMethodField;
            }
            set
            {
                this.correctionMethodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CorrectionMethodDescriptionType CorrectionMethodDescription
        {
            get
            {
                return this.correctionMethodDescriptionField;
            }
            set
            {
                this.correctionMethodDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AdditionalReasonDescription
        {
            get
            {
                return this.additionalReasonDescriptionField;
            }
            set
            {
                this.additionalReasonDescriptionField = value;
            }
        }
    }
         
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceHeaderType
    {

        private string invoiceNumberField;

        private string invoiceSeriesCodeField;

        private InvoiceDocumentTypeType invoiceDocumentTypeField;

        private InvoiceClassType invoiceClassField;

        private CorrectiveType correctiveField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string InvoiceSeriesCode
        {
            get
            {
                return this.invoiceSeriesCodeField;
            }
            set
            {
                this.invoiceSeriesCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceDocumentTypeType InvoiceDocumentType
        {
            get
            {
                return this.invoiceDocumentTypeField;
            }
            set
            {
                this.invoiceDocumentTypeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceClassType InvoiceClass
        {
            get
            {
                return this.invoiceClassField;
            }
            set
            {
                this.invoiceClassField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CorrectiveType Corrective
        {
            get
            {
                return this.correctiveField;
            }
            set
            {
                this.correctiveField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InvoiceType
    {

        private InvoiceHeaderType invoiceHeaderField;

        private InvoiceIssueDataType invoiceIssueDataField;

        private List<TaxOutputType> taxesOutputsField;

        private List<TaxType> taxesWithheldField;

        private InvoiceTotalsType invoiceTotalsField;

        private List<InvoiceLineType> itemsField;

        private List<InstallmentType> paymentDetailsField;

        private List<string> legalLiteralsField;

        private AdditionalDataType additionalDataField;

        internal Facturae Parent
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceHeaderType InvoiceHeader
        {
            get
            {
                return this.invoiceHeaderField;
            }
            set
            {
                this.invoiceHeaderField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceIssueDataType InvoiceIssueData
        {
            get
            {
                return this.invoiceIssueDataField;
            }
            set
            {
                this.invoiceIssueDataField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<TaxOutputType> TaxesOutputs
        {
            get
            {
                return this.taxesOutputsField;
            }
            set
            {
                this.taxesOutputsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<TaxType> TaxesWithheld
        {
            get
            {
                return this.taxesWithheldField;
            }
            set
            {
                this.taxesWithheldField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public InvoiceTotalsType InvoiceTotals
        {
            get
            {
                return this.invoiceTotalsField;
            }
            set
            {
                this.invoiceTotalsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("InvoiceLine", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<InvoiceLineType> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Installment", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<InstallmentType> PaymentDetails
        {
            get
            {
                return this.paymentDetailsField;
            }
            set
            {
                this.paymentDetailsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("LegalReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<string> LegalLiterals
        {
            get
            {
                return this.legalLiteralsField;
            }
            set
            {
                this.legalLiteralsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AdditionalDataType AdditionalData
        {
            get
            {
                return this.additionalDataField;
            }
            set
            {
                this.additionalDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class InstallmentType
    {

        private System.DateTime installmentDueDateField;

        private DoubleTwoDecimalType installmentAmountField;

        private PaymentMeansType paymentMeansField;

        private AccountType accountToBeCreditedField;

        private string paymentReconciliationReferenceField;

        private AccountType accountToBeDebitedField;

        private string collectionAdditionalInformationField;

        private string regulatoryReportingDataField;

        private string debitReconciliationReferenceField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime InstallmentDueDate
        {
            get
            {
                return this.installmentDueDateField;
            }
            set
            {
                this.installmentDueDateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public DoubleTwoDecimalType InstallmentAmount
        {
            get
            {
                return this.installmentAmountField;
            }
            set
            {
                this.installmentAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public PaymentMeansType PaymentMeans
        {
            get
            {
                return this.paymentMeansField;
            }
            set
            {
                this.paymentMeansField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AccountType AccountToBeCredited
        {
            get
            {
                return this.accountToBeCreditedField;
            }
            set
            {
                this.accountToBeCreditedField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PaymentReconciliationReference
        {
            get
            {
                return this.paymentReconciliationReferenceField;
            }
            set
            {
                this.paymentReconciliationReferenceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AccountType AccountToBeDebited
        {
            get
            {
                return this.accountToBeDebitedField;
            }
            set
            {
                this.accountToBeDebitedField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string CollectionAdditionalInformation
        {
            get
            {
                return this.collectionAdditionalInformationField;
            }
            set
            {
                this.collectionAdditionalInformationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string RegulatoryReportingData
        {
            get
            {
                return this.regulatoryReportingDataField;
            }
            set
            {
                this.regulatoryReportingDataField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string DebitReconciliationReference
        {
            get
            {
                return this.debitReconciliationReferenceField;
            }
            set
            {
                this.debitReconciliationReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AccountType
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string bankCodeField;

        private string branchCodeField;

        private object item1Field;

        private string bICField;

        /// <remarks/>
        [XmlElementAttribute("AccountNumber", typeof(string), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("IBAN", typeof(string), Form = XmlSchemaForm.Unqualified)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string BankCode
        {
            get
            {
                return this.bankCodeField;
            }
            set
            {
                this.bankCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string BranchCode
        {
            get
            {
                return this.branchCodeField;
            }
            set
            {
                this.branchCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("BranchInSpainAddress", typeof(AddressType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("OverseasBranchAddress", typeof(OverseasAddressType), Form = XmlSchemaForm.Unqualified)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string BIC
        {
            get
            {
                return this.bICField;
            }
            set
            {
                this.bICField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AddressType
    {

        private string addressField;

        private string postCodeField;

        private string townField;

        private string provinceField;

        private CountryType countryCodeField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CountryType CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

 

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class OverseasAddressType
    {

        private string addressField;

        private string postCodeAndTownField;

        private string provinceField;

        private CountryType countryCodeField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PostCodeAndTown
        {
            get
            {
                return this.postCodeAndTownField;
            }
            set
            {
                this.postCodeAndTownField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CountryType CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AdministrativeCentreType
    {

        private string centreCodeField;

        private RoleTypeCodeType roleTypeCodeField;

        private bool roleTypeCodeFieldSpecified;

        private string nameField;

        private string firstSurnameField;

        private string secondSurnameField;

        private object itemField;

        private ContactDetailsType contactDetailsField;

        private string physicalGLNField;

        private string logicalOperationalPointField;

        private string centreDescriptionField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string CentreCode
        {
            get
            {
                return this.centreCodeField;
            }
            set
            {
                this.centreCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public RoleTypeCodeType RoleTypeCode
        {
            get
            {
                return this.roleTypeCodeField;
            }
            set
            {
                this.roleTypeCodeField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RoleTypeCodeSpecified
        {
            get
            {
                return this.roleTypeCodeFieldSpecified;
            }
            set
            {
                this.roleTypeCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string FirstSurname
        {
            get
            {
                return this.firstSurnameField;
            }
            set
            {
                this.firstSurnameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string SecondSurname
        {
            get
            {
                return this.secondSurnameField;
            }
            set
            {
                this.secondSurnameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AddressInSpain", typeof(AddressType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("OverseasAddress", typeof(OverseasAddressType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ContactDetailsType ContactDetails
        {
            get
            {
                return this.contactDetailsField;
            }
            set
            {
                this.contactDetailsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PhysicalGLN
        {
            get
            {
                return this.physicalGLNField;
            }
            set
            {
                this.physicalGLNField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string LogicalOperationalPoint
        {
            get
            {
                return this.logicalOperationalPointField;
            }
            set
            {
                this.logicalOperationalPointField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string CentreDescription
        {
            get
            {
                return this.centreDescriptionField;
            }
            set
            {
                this.centreDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class ContactDetailsType
    {

        private string telephoneField;

        private string teleFaxField;

        private string webAddressField;

        private string electronicMailField;

        private string contactPersonsField;

        private string cnoCnaeField;

        private string iNETownCodeField;

        private string additionalContactDetailsField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string TeleFax
        {
            get
            {
                return this.teleFaxField;
            }
            set
            {
                this.teleFaxField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string WebAddress
        {
            get
            {
                return this.webAddressField;
            }
            set
            {
                this.webAddressField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ElectronicMail
        {
            get
            {
                return this.electronicMailField;
            }
            set
            {
                this.electronicMailField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ContactPersons
        {
            get
            {
                return this.contactPersonsField;
            }
            set
            {
                this.contactPersonsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string CnoCnae
        {
            get
            {
                return this.cnoCnaeField;
            }
            set
            {
                this.cnoCnaeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string INETownCode
        {
            get
            {
                return this.iNETownCodeField;
            }
            set
            {
                this.iNETownCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AdditionalContactDetails
        {
            get
            {
                return this.additionalContactDetailsField;
            }
            set
            {
                this.additionalContactDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class BusinessType
    {

        private TaxIdentificationType taxIdentificationField;

        private string partyIdentificationField;

        private List<AdministrativeCentreType> administrativeCentresField;

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxIdentificationType TaxIdentification
        {
            get
            {
                return this.taxIdentificationField;
            }
            set
            {
                this.taxIdentificationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string PartyIdentification
        {
            get
            {
                return this.partyIdentificationField;
            }
            set
            {
                this.partyIdentificationField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("AdministrativeCentre", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<AdministrativeCentreType> AdministrativeCentres
        {
            get
            {
                return this.administrativeCentresField;
            }
            set
            {
                this.administrativeCentresField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Individual", typeof(IndividualType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LegalEntity", typeof(LegalEntityType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class IndividualType
    {

        private string nameField;

        private string firstSurnameField;

        private string secondSurnameField;

        private object itemField;

        private ContactDetailsType contactDetailsField;

        internal BusinessType Parent
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string FirstSurname
        {
            get
            {
                return this.firstSurnameField;
            }
            set
            {
                this.firstSurnameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string SecondSurname
        {
            get
            {
                return this.secondSurnameField;
            }
            set
            {
                this.secondSurnameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AddressInSpain", typeof(AddressType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("OverseasAddress", typeof(OverseasAddressType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ContactDetailsType ContactDetails
        {
            get
            {
                return this.contactDetailsField;
            }
            set
            {
                this.contactDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class LegalEntityType
    {

        private string corporateNameField;

        private string tradeNameField;

        private RegistrationDataType registrationDataField;

        private object itemField;

        private ContactDetailsType contactDetailsField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string CorporateName
        {
            get
            {
                return this.corporateNameField;
            }
            set
            {
                this.corporateNameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string TradeName
        {
            get
            {
                return this.tradeNameField;
            }
            set
            {
                this.tradeNameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public RegistrationDataType RegistrationData
        {
            get
            {
                return this.registrationDataField;
            }
            set
            {
                this.registrationDataField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AddressInSpain", typeof(AddressType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("OverseasAddress", typeof(OverseasAddressType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public ContactDetailsType ContactDetails
        {
            get
            {
                return this.contactDetailsField;
            }
            set
            {
                this.contactDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class RegistrationDataType
    {

        private string bookField;

        private string registerOfCompaniesLocationField;

        private string sheetField;

        private string folioField;

        private string sectionField;

        private string volumeField;

        private string additionalRegistrationDataField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Book
        {
            get
            {
                return this.bookField;
            }
            set
            {
                this.bookField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string RegisterOfCompaniesLocation
        {
            get
            {
                return this.registerOfCompaniesLocationField;
            }
            set
            {
                this.registerOfCompaniesLocationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Sheet
        {
            get
            {
                return this.sheetField;
            }
            set
            {
                this.sheetField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AdditionalRegistrationData
        {
            get
            {
                return this.additionalRegistrationDataField;
            }
            set
            {
                this.additionalRegistrationDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class PartiesType
    {

        private BusinessType sellerPartyField;

        private BusinessType buyerPartyField;

        internal Facturae Parent
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public BusinessType SellerParty
        {
            get
            {
                return this.sellerPartyField;
            }
            set
            {
                this.sellerPartyField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public BusinessType BuyerParty
        {
            get
            {
                return this.buyerPartyField;
            }
            set
            {
                this.buyerPartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class AssigneeType
    {

        private TaxIdentificationType taxIdentificationField;

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public TaxIdentificationType TaxIdentification
        {
            get
            {
                return this.taxIdentificationField;
            }
            set
            {
                this.taxIdentificationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Individual", typeof(IndividualType), Form = XmlSchemaForm.Unqualified)]
        [XmlElementAttribute("LegalEntity", typeof(LegalEntityType), Form = XmlSchemaForm.Unqualified)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class FactoringAssignmentDataType
    {

        private AssigneeType assigneeField;

        private List<InstallmentType> paymentDetailsField;

        private string factoringAssignmentClausesField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AssigneeType Assignee
        {
            get
            {
                return this.assigneeField;
            }
            set
            {
                this.assigneeField = value;
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItemAttribute("Installment", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<InstallmentType> PaymentDetails
        {
            get
            {
                return this.paymentDetailsField;
            }
            set
            {
                this.paymentDetailsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string FactoringAssignmentClauses
        {
            get
            {
                return this.factoringAssignmentClausesField;
            }
            set
            {
                this.factoringAssignmentClausesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public partial class BatchType
    {

        private string batchIdentifierField;

        private long invoicesCountField;

        private AmountType totalInvoicesAmountField;

        private AmountType totalOutstandingAmountField;

        private AmountType totalExecutableAmountField;

        private CurrencyCodeType invoiceCurrencyCodeField;

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public string BatchIdentifier
        {
            get
            {
                return this.batchIdentifierField;
            }
            set
            {
                this.batchIdentifierField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public long InvoicesCount
        {
            get
            {
                return this.invoicesCountField;
            }
            set
            {
                this.invoicesCountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TotalInvoicesAmount
        {
            get
            {
                return this.totalInvoicesAmountField;
            }
            set
            {
                this.totalInvoicesAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TotalOutstandingAmount
        {
            get
            {
                return this.totalOutstandingAmountField;
            }
            set
            {
                this.totalOutstandingAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public AmountType TotalExecutableAmount
        {
            get
            {
                return this.totalExecutableAmountField;
            }
            set
            {
                this.totalExecutableAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
        public CurrencyCodeType InvoiceCurrencyCode
        {
            get
            {
                return this.invoiceCurrencyCodeField;
            }
            set
            {
                this.invoiceCurrencyCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class TransformsType
    {

        private List<TransformType> transformField;

        /// <remarks/>
        [XmlElementAttribute("Transform")]
        public List<TransformType> Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class ManifestType
    {

        private List<ReferenceType> referenceField;

        private string idField;

        /// <remarks/>
        [XmlElementAttribute("Reference")]
        public List<ReferenceType> Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertiesType
    {

        private List<SignaturePropertyType> signaturePropertyField;

        private string idField;

        /// <remarks/>
        [XmlElementAttribute("SignatureProperty")]
        public List<SignaturePropertyType> SignatureProperty
        {
            get
            {
                return this.signaturePropertyField;
            }
            set
            {
                this.signaturePropertyField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignaturePropertyType
    {

        private List<XmlElement> itemsField;

        private List<string> textField;

        private string targetField;

        private string idField;

        /// <remarks/>
        [XmlAnyElementAttribute()]
        public List<XmlElement> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public List<string> Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}