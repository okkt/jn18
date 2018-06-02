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
            string path = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/bin/Debug/part.xml";
             string path2x = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/File/part.xml.lz";
            string path2 = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/File/part.xml";
            string path3 = "C:/Users/rez0041/source/repos/Kompresia/Kompresia/part.xml";

            //var b = new File.CompressedFileReader(path: path);
            //var bb = new File.CompressedFileWriter();

            //var a = new Huffman.AdaptiveHuffman();
            LZ.LZ77 c = new LZ.LZ77();
            //var d = new JSON.JsonH();
            c.Compress(path: path2);
           
            c.Decompress(path: path2x);
            // a.Decompress(path: path3);
            //bb.CompressedFileWriter();

            string valueString = "Your string";
            Console.Write(valueString);

        }
    }
}
