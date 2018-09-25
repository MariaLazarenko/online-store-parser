using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreParser.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }

        public string ProductId { get; set; }
    }
}