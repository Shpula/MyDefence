using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Data.Models
{
    public class News
    {
        public int id { set; get; }
        public string ShortDesk { set; get; }
        public string LongDesk { set; get; }
        public string img { set; get; }
        public bool isfavorite { set; get; }
        public DateTime PostTime { set; get; }
        public string categoryname { set; get; }
        public virtual Category Category { set; get; }
    }
}
