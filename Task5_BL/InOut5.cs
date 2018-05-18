using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5_BL
{
    public class InOut5
    {        
        public string Filename { get; set; }
        public string Text { get; set; }


        public Queue<string> ReadFromFile(string Filename, Queue<string> students)
        {
            students.Clear();
            StreamReader sr = new StreamReader(Filename);
            string reader = sr.ReadToEnd();
            Text = "";
            Text += reader;
            sr.Close();
            string text = Text;
            List<string> list = new List<string>();
            string word = "";
            int counter = 0;
            int index = text.LastIndexOf('\n');
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0)
                {
                    if (text[i - 1] == '\r' && text[i] == '\n')
                    {
                        text = text.Remove(i - 1, 2);
                        i--;
                        index -= 2;
                        for (int j = counter; j < i; j++)
                            word += text[j];
                        list.Add(word);
                        word = "";
                        counter = i;
                        i--;
                        if (i == index)
                        {
                            for (int z = index + 1; z < text.Length; z++)
                                word += text[z];
                            list.Add(word);
                            word = "";
                        }
                    }
                }
            }
            for (int k = 0; k < list.Count; k++)
                students.Enqueue(list[k]);
            return students;
        }

        //public Queue<string> AddWithSort(string surname,Queue<string> students)
        //{            
        //    if (students.count == 0)
        //        students.Enqueue(surname);
        //    else
        //    {
        //        List<string> list = new List<string>();
        //        list = students.ToList();
        //        students.Clear();
        //        int result1 = 0;
        //        int result2 = 0;
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (i > 0)
        //            {
        //                if (i < list.Count)
        //                {
        //                    result1 = String.Compare(list[i - 1], surname);
        //                    result2 = String.Compare(surname, list[i]);
        //                    if (result1 < 0 && result2 < 0)
        //                    {
        //                        list.Add(" ");
        //                        for (int k = list.Count - 1; k >= i; k--)
        //                        {
        //                            list[k] = list[k - 1];
        //                        }
        //                        list[i] = surname;
        //                        break;
        //                    }
        //                }
        //                if (i == list.Count - 1)
        //                {
        //                    result1 = String.Compare(list[i], surname);
        //                    if (result1 < 0)
        //                    {
        //                        list.Add(surname);
        //                        break;
        //                    }
        //                }
        //            }
        //            if (i == 0)
        //            {
        //                result1 = String.Compare(surname, list[i]);
        //                if (result1 < 0)
        //                {
        //                    list.Add(" ");
        //                    for (int k = list.Count - 1; k >= 1; k--)
        //                    {
        //                        list[k] = list[k - 1];
        //                    }
        //                    list[i] = surname;
        //                    break;
        //                }
        //            }
        //        }
        //        Text = "";
        //        for (int j = 0; j < list.Count; j++)
        //        {
        //            Text += list[j];
        //            Text += "\r\n";
        //        }
        //        for (int l = 0; l < list.Count; l++)
        //        {
        //            students.Enqueue(list[l]);
        //        }
        //    }
        //    return students;
        //}
    }
}
