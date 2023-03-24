using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacturaE.Enums
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae")]
    public enum InvoiceClassType
    {
        /// <remarks/>
        [XmlEnum("OO")]
        Original,

        /// <remarks/>
        [XmlEnum("OR")]
        Corrective,

        /// <remarks/>
        [XmlEnum("OC")]
        SummaryOriginal,

        /// <remarks/>
        [XmlEnum("CO")]
        CopyOfOriginal,

        /// <remarks/>
        [XmlEnum("CR")]
        CopyOfCorrective,

        /// <remarks/>
        [XmlEnum("CC")]
        CopyOfSummary,
    }
}
