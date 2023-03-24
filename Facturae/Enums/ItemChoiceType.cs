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
    [XmlTypeAttribute(Namespace = "http://www.facturae.es/Facturae/2009/v3.2/Facturae", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        [XmlEnumAttribute("AccountNumber")]
        AccountNumber,

        /// <remarks/>
        [XmlEnumAttribute("IBAN")]
        IBAN,
    }
}
