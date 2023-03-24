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
    public enum ReasonDescriptionType
    {

        /// <remarks/>
        [XmlEnumAttribute("Número de la factura")]
        Númerodelafactura,

        /// <remarks/>
        [XmlEnumAttribute("Serie de la factura")]
        Seriedelafactura,

        /// <remarks/>
        [XmlEnumAttribute("Fecha expedición")]
        Fechaexpedición,

        /// <remarks/>
        [XmlEnumAttribute("Nombre y apellidos/Razón Social-Emisor")]
        NombreyapellidosRazónSocialEmisor,

        /// <remarks/>
        [XmlEnumAttribute("Nombre y apellidos/Razón Social-Receptor")]
        NombreyapellidosRazónSocialReceptor,

        /// <remarks/>
        [XmlEnumAttribute("Identificación fiscal Emisor/obligado")]
        IdentificaciónfiscalEmisorobligado,

        /// <remarks/>
        [XmlEnumAttribute("Identificación fiscal Receptor")]
        IdentificaciónfiscalReceptor,

        /// <remarks/>
        [XmlEnumAttribute("Domicilio Emisor/Obligado")]
        DomicilioEmisorObligado,

        /// <remarks/>
        [XmlEnumAttribute("Domicilio Receptor")]
        DomicilioReceptor,

        /// <remarks/>
        [XmlEnumAttribute("Detalle Operación")]
        DetalleOperación,

        /// <remarks/>
        [XmlEnumAttribute("Porcentaje impositivo a aplicar")]
        Porcentajeimpositivoaaplicar,

        /// <remarks/>
        [XmlEnumAttribute("Cuota tributaria a aplicar")]
        Cuotatributariaaaplicar,

        /// <remarks/>
        [XmlEnumAttribute("Fecha/Periodo a aplicar")]
        FechaPeriodoaaplicar,

        /// <remarks/>
        [XmlEnumAttribute("Clase de factura")]
        Clasedefactura,

        /// <remarks/>
        [XmlEnumAttribute("Literales legales")]
        Literaleslegales,

        /// <remarks/>
        [XmlEnumAttribute("Base imponible")]
        Baseimponible,

        /// <remarks/>
        [XmlEnumAttribute("Cálculo de cuotas repercutidas")]
        Cálculodecuotasrepercutidas,

        /// <remarks/>
        [XmlEnumAttribute("Cálculo de cuotas retenidas")]
        Cálculodecuotasretenidas,

        /// <remarks/>
        [XmlEnumAttribute("Base imponible modificada por devolución de envases / embalajes")]
        Baseimponiblemodificadapordevolucióndeenvasesembalajes,

        /// <remarks/>
        [XmlEnumAttribute("Base imponible modificada por descuentos y bonificaciones")]
        Baseimponiblemodificadapordescuentosybonificaciones,

        /// <remarks/>
        [XmlEnumAttribute("Base imponible modificada por resolución firme, judicial o administrativa")]
        Baseimponiblemodificadaporresoluciónfirmejudicialoadministrativa,

        /// <remarks/>
        [XmlEnumAttribute("Base imponible modificada cuotas repercutidas no satisfechas. Auto de declaración" +
            " de concurso")]
        BaseimponiblemodificadacuotasrepercutidasnosatisfechasAutodedeclaracióndeconcurso,
    }
}
