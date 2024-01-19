using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4a_tm
{
    internal class Pierwiastek
    {
        public string name { get; set; }    
        public int xpos { get; set; }   
        public int ypos { get; set; }
        public string symbol { get; set; }
    }
    internal class TM
    {
        public List<Pierwiastek> elements { get; set; }
    }
}
