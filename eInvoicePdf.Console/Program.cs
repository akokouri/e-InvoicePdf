using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoicePdf.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfReader reader = new PdfReader(@"C:\eInvoicePdf\Invoice.pdf");
            byte[] metadata = reader.Metadata;
            //XmpCore.XmpMetaFactory.
            XmpCore.IXmpMeta meta = XmpCore.XmpMetaFactory.ParseFromBuffer(reader.Metadata);
            

            string ns = "http://www.CraneSoftwrights.com/ns/XMP/";
            string ublKey = "c:file";
            string content = meta.GetPropertyString(ns,ublKey );
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(InvoiceType));
            System.IO.StringReader rdr = new System.IO.StringReader(content);
            InvoiceType invoice = (InvoiceType)ser.Deserialize(rdr);

            meta.SetProperty(ns, ublKey, content);
            PdfStamper stamper = new PdfStamper(reader, new FileStream(@"C:\eInvoicePdf\out.pdf", FileMode.Create));

            XmpCore.Options.SerializeOptions opts = new XmpCore.Options.SerializeOptions();
            metadata = XmpCore.XmpMetaFactory.SerializeToBuffer(meta, opts);
            stamper.XmpMetadata = metadata;
            stamper.Close();



        }
    }

    class InvoiceDto
    {
        public string ID { get; set; }
        public DateTime IssueDate { get; set; }
        public Supplier AccountingSupplierParty { get; set; }
        public Supplier AccountingCustomerParty { get; set; }
        public string Reason { get; set; }
        public string InvoiceType  { get; set; }

        public InvoiceLine[] Lines { get; set; }

    }

    class Supplier
    {
        public string AccountID { get; set; }
        public string RegistrationName { get; set; }
        public string VAT { get; set; }
        public string TaxationAuthority { get; set; }
        public string Address { get; set; }
        public int CityName { get; set; }

        public string PostalZone { get; set; }
        public string IndustryClassificationCode { get; set; }
        public string IndustryClassificationDesc { get; set; }

    }

    class InvoiceLine
    {
        public string ID { get; set; }
        public string UUID { get; set; }
        public string ItemName { get; set; }
        public string UnitCode { get; set; }
        public decimal InvoicedQuantity { get; set; }

        public decimal PriceAmount { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal TaxAmount { get; set; }

    }

    //<cbc:InvoiceTypeCode listID = "UN/ECE 1001 Subset" listAgencyID="6">380</cbc:InvoiceTypeCode>
    //<cbc:InvoiceTypeCode listID = "UN/ECE 1001 Subset" listAgencyID="6">393</cbc:InvoiceTypeCode>
    //<cbc:InvoiceTypeCode listID = "UN/ECE 1001 Subset" listAgencyID="6">384</cbc:InvoiceTypeCode>
}
