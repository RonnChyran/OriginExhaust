using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OriginExhaust;

namespace OriginExhaust.Titanfall
{
    class Program
    {
        static void Main(string[] args)
        {
            new Exhaust("Titanfall", "1011172").Start();
        }
    }
}
