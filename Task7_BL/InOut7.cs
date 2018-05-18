using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task7_BL
{
    public class InOut7
    {
        public Symbols[] Arr { get; set; }
        public string Filename { get; set; }
        public string Text { get; set; }



        public string ReadFromFile(string Filename)
        {
            StreamReader sr = new StreamReader(Filename);
            string reader = sr.ReadToEnd();
            Text = "";
            Text += reader;
            sr.Close();
            int number = 0;
            string result = "";
            int x = 0;
            List<char> symbols = new List<char>();
            List<int> numbers = new List<int>();
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == '[')
                {
                    number = i + 1;
                }
                if (Text[i] == ']')
                {
                    result = "";
                    symbols.Add(Text[number]);
                    number += 2;
                    for (int j = number; j < i; j++)
                    {
                        result += Text[j];
                    }
                    x = Convert.ToInt32(result);
                    numbers.Add(x);
                }
            }
                Symbols[] arr = new Symbols[symbols.Count];
                    for (int r = 0; r < arr.Length; r++)
                    {
                        arr[r].value = ' ';
                        arr[r].key = 0;
                    }
                    for (int s = 0; s < symbols.Count; s++)
                    {
                        arr[s].value = symbols[s];
                    }
                    for (int n = 0; n < numbers.Count; n++)
                    {
                        arr[n].key = numbers[n];
                    }
                Arr = Arr;
            return Text;
        }

        public Symbols[] SortDistributingCalculation(Symbols[] Arr)//распределяющим подсчётом
        {
            int min = Arr[0].key;
            int max = Arr[0].key;
            int i;
            for (i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].key > max)
                    max = Arr[i].key;
                if (min > Arr[i].key)
                    min = Arr[i].key;
            }
            int[] C = new int[Arr.Length];
            for (i = 0; i < Math.Abs(max); i++)
            {
                C[i] = 0 + Math.Abs(min);
            }
            for (i = 0; i < C.Length; i++)
            {
                C[Arr[i].key] = C[Arr[i].key] - Math.Abs(min) + 1;
            }
            int b = 0;
            for (int j = 0; j < Math.Abs(max); j++)
            {
                for (i = 0; i < C[j] - 1; i++)
                {
                    Arr[b].key = j;
                    b++;
                }
            }
            return Arr;
        }
    }
}
