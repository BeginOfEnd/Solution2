using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_BL
{
    public class Symbols
    {
        public char value { get; set; }
        public int key { get; set; }

        public Symbols(char value, int key)
        {
            this.value = value;
            this.key = key;
        }
    }
}
