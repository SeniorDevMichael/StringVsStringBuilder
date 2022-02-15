using System;
using System.Diagnostics;
using System.Text;

namespace StringVsStringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100000;

            #region StringBuilder         

            Stopwatch sw = Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < counter; i++)
            {
                sb.Append(i.ToString());
            }

            sw.Stop();

            long stringBuilderMS = sw.ElapsedMilliseconds;

            #endregion

            #region String

            sw.Restart();

            String test = "";

            for (int i = 1; i < counter; i++)
            {
                test += i.ToString();
            }

            long stringMS = sw.ElapsedMilliseconds;

            #endregion

            Console.WriteLine("Total MS for StringBuilder:" + stringBuilderMS);//Total MS for StringBuilder:8
            Console.WriteLine("Total MS for String:" + stringMS);//Total MS for String:15913

            Console.ReadLine();
        }
    }
}
