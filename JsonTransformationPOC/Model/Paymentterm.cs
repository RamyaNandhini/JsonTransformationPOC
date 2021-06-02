using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.Model
{
    public class Paymentterm
    {
        public string qboReferenceId { get; set; }
        public string code { get; set; }
        public string displayName { get; set; }
        public string dueDateCalculation { get; set; }
        public string discountDateCalculation { get; set; }
        public string discountPercent { get; set; }
        public Boolean calculateDiscountOnCreditMemos { get; set; }

    }
}
