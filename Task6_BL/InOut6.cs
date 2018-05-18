using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6_BL
{
    public class InOut6
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        

        public Queue<double> ReadFromFile(string Filename, Queue<double> numbers)
        {
            Text = "";
            numbers.Clear();
            StreamReader sr = new StreamReader(Filename);
            string reader = sr.ReadToEnd();
            Text += reader;
            sr.Close();
            string text = "";
            int count = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == ' ')
                {
                    for (int j = count; j < i; j++)
                    {
                        text += Text[j];
                    }
                    list.Add(Convert.ToDouble(text));
                    text = "";
                    ++i;
                    count = i;
                }
            }
            for (int i = 0; i < list.Count; i++)
                numbers.Enqueue(list[i]);
            return numbers;
        }
    }
}
