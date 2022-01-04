using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program Program1 = new Program();
            Program1.InputFile();
        }


        string dataFromFile;
        List<double> filteredData;
        double[] filteredDataArray;
        double[] xData;
        double x;
        double y;
        double[] xxData;
        double[] yyData;
        Random Rand = new Random();

        private void InputFile()
        {
            var file2 = System.IO.File.ReadAllText(@"C:\Users\jakub.drahotsky\OneDrive - Thermo Fisher Scientific\Programovani\C_sharp\EDS_calculator\blazor-google-chartsV2\test2.txt");
            Console.WriteLine(file2);
            string fileText;
            // Read file using StreamReader. Reads file line by line    
            //using (StreamReader file = new StreamReader(@"C:\Users\jakub.drahotsky\OneDrive - Thermo Fisher Scientific\Programovani\C_sharp\EDS_calculator\blazor-google-chartsV2\test2.txt"))
            //{
            //    int counter = 0;
            //    string ln;

                

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        fileText = file.ReadLine();
            //        Console.WriteLine(ln);
            //        counter++;
            //    }
            //    file.Close();
            //    Console.WriteLine($"File has {counter} lines.");
            //}


            filteredData = FilterData(file2);
            //xData = Enumerable.Range(0, filteredData.Count()).Select(x => Rand.NextDouble()).ToArray();

            filteredDataArray = filteredData.ToArray();
            foreach (var item in filteredDataArray)
            {
                Console.WriteLine(item);
            }

        }

        private List<double> FilterData(string rawData)
        {
            string[] rawDataArray = rawData.Split(";");

            string[] splitData = new string[rawDataArray.Length];
            string[] splitData2 = new string[rawDataArray.Length];
            //double[] cleanData = new double[];
            List<double> cleanData = new List<double>();
            List<string> cleanText = new List<string>();

            foreach (var item in rawDataArray)
            {
                Console.WriteLine(item);
            }

            //Console.ReadKey();
            char[] RemoveChar = new Char[] { ' ', '\n', '\r' };

            for (int i = 1; i < rawDataArray.Length; i++)
            {
                rawDataArray[i] = rawDataArray[i].Trim(RemoveChar);
                bool isDouble = double.TryParse(rawDataArray[i], out double doubleElement);
                if (isDouble)
                {
                    cleanData.Add(doubleElement);
                }
                else
                {
                    cleanText.Add(splitData[i]);
                }
            }

            Console.WriteLine(cleanData);
            Console.ReadKey();
            return cleanData;
        }

    }
}
