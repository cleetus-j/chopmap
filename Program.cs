using System;
using System.IO;

namespace chopmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] input;
            try
            {
                input = File.ReadAllBytes(args[0]);

            }
            catch (Exception)
            {
                Console.WriteLine("You forgot the input parameter or something, pls check it.");
                System.Environment.Exit(-1);
                throw;
            }
            String o_f ="chop"+ args[0];
            String o_f_s = "string_chop" + args[0] + ".txt";
 //           Console.WriteLine("Orig file is "+input.Length+" in bytes.");
 //           Console.WriteLine(o_f);
            StreamWriter streamWriter = new StreamWriter(File.Open(o_f_s, FileMode.Create));
            
            using (BinaryWriter writer = new BinaryWriter(File.Open(o_f, FileMode.Create)))
            {
                for (int i = 1; i < input.Length; i+=2)
                {
                    writer.Write(input[i]);
 //                   Console.WriteLine(input[i]);
                    streamWriter.WriteLine(input[i]);
                    
                }

            }

            Console.WriteLine("Hello World!");
        }
    }
}
