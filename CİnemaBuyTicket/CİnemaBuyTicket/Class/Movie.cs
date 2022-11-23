using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CİnemaBuyTicket.Class
{
    public class Movie
    {
        public string Name { get; set; }
        public int price { get; set; }
        public string minute { get; set; }
        public List<string> category { get; set; }
    }
}
