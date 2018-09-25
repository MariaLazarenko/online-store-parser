using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStoreParser.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDecription { get; set; }
        public string ProductUrl { get; set; }
        public decimal ProductLastPrice { get; set; }

        public virtual ICollection<HistoryEntry> History { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}