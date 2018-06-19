using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Kompresia
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            
            string pathL = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/LZ/part.xml";
            string pathL2 = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/LZ/part.xml.lz";




           
            LZ.LZ77 algLZ = new LZ.LZ77();

            
            
            algLZ.Compress(path: pathL);
            algLZ.Decompress(path: pathL2);



            string valueString = "Succed";
            Console.WriteLine(valueString);

        }
    }
}
