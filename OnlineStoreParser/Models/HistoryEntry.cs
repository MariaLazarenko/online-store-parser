using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStoreParser.Models
{
    public class HistoryEntry
    {
        public int HistoryEntryId { get; set; }


        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        public decimal ProductPrice { get; set; }
        public DateTime HistoryDate { get; set; }
    }
}