using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.DataAccess.Model
{
    [Table("ItemCategory")]
    public class ItemCategory
    {
        [Key]
        public int Id { get; set; }
        public string SourceSystemId { get; set; }
        public string DestinationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
