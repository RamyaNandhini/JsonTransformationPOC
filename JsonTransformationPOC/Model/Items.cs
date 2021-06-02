using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.Model
{
    public class Items
    {
        public int? number { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
        public int itemCategoryId { get; set; }
        public string itemCategoryCode { get; set; }
        public Boolean blocked { get; set; }
        public string gtin { get; set; }
        public string inventory { get; set; }
        public int unitPrice { get; set; }
        public string priceIncludesTax { get; set; }
        public int unitCost { get; set; }
        public int taxGroupId { get; set; }
        public string taxGroupCode { get; set; }
        public string baseUnitOfMeasureId { get; set; }
        public string baseUnitOfMeasureCode { get; set; }
        public int qboReferenceId { get; set; }
    }
}
