using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.Model
{
    public class Customer
    {
        public string displayName { get; set; }
        public string email { get; set; }
        public string paymentTermsId { get; set; }
        public string qboReferenceId { get; set; }
        public string currencyCode { get; set; }
        public string phoneNumber { get; set; }
        public string taxLiable { get; set; }
        public string website { get; set; }
        public string paymentMethodId { get; set; }
        public string city { get; set; }
        public string addressLine1 { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string type { get; set; }
        public string country { get; set; }
        public string taxAreaId { get; set; }
        public string taxAreaDisplayName { get; set; }
        public string taxRegistrationNumber { get; set; }
        public string currencyId { get; set; }
        public string shipmentMethodId { get; set; }
        public string blocked { get; set; }

    }
}
