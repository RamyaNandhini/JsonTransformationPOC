using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.Model
{
    public class ChartOfAccount
    {
        public int number { get; set; }
        public string displayName { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public string  blocked { get; set; }
        public string accountType { get; set; }
        //public string directPosting { get; set; }
        public int qboReferenceId { get; set; }
    }
}
