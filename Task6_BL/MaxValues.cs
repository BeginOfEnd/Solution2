using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_BL
{
    public class MaxValues
    {
        public Queue<double> numbers { get; set; }

        public MaxValues()
        {
            Queue<double> QUEUE = new Queue<double>();
            numbers = QUEUE;
        }

        public double MaxValue(Queue<double> numbers)
        {            
            List<double> list = numbers.ToList();
            double max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }
            return max;
        }
        public uint FindAllMaxValues(Queue<double> numbers1)
        {
            double max = MaxValue(numbers1);
            uint count = 0;
            List<double> list = numbers1.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == max)
                    ++count;
            }
            return count;
        }
    }
}
