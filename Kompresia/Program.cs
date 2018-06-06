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
            
           
            string pathH = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/Huffman/part.xml";
            string pathL = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/LZ/part.xml";
            string pathL2 = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/LZ/part.xml.lz";




            Huffman.AdaptiveHuffman huff = new Huffman.AdaptiveHuffman();
            LZ.LZ77 algLZ = new LZ.LZ77();

            
            huff.Compress(path: pathH);
            //huff.Decompress(path: pathH);
            //algLZ.Compress(path: pathL);
            //algLZ.Decompress(path: pathL2);



            string valueString = "Succed";
            Console.WriteLine(valueString);

        }
    }
}
