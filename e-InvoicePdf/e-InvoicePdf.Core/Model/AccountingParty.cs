using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eInvoicePdf.Core.Model
{
    class AccountingCustomerParty
    {
        public Party Party { get; set; }
    }

    class Party
    {
        public PartyName Name { get; set; }
        public PartyIdentification Id { get; set; }
        public PostalAddress PostalAddress { get; set; }
    }

    class PartyName
    {
        public string Name { get; set; }

    }

    class PartyIdentification
    {
        public string ID { get; set; }

    }

    class PartyTaxScheme
    {
        public string CompanyID { get; set; }

    }

    class PostalAddress
    {
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string PostalZone { get; set; }
        public string CountrySubentity { get; set; }

    }

    class Country
    {
        public string IdentificationCode { get; set; }
    }

    class AllowanceCharge
    {
        public decimal Amount { get; set; }

    }

    class TaxCategory
    {
        public string ID { get; set; }
        public decimal Percent { get; set; }

    }

    class LegalMonetaryTotal
    {
        public decimal LineExtensionAmount { get; set; }
        public decimal AllowanceTotalAmount { get; set; }
        public decimal ChargeTotalAmount { get; set; }
        public decimal TaxExclusiveAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal PayableRoundingAmount { get; set; }
        public decimal TaxInclusiveAmount { get; set; }
        public decimal PrepaidAmount { get; set; }
        public decimal PayableAmount { get; set; }
    }

    class TaxTotal
    {

    }

    class TaxSubtotal
    {

    }
}
