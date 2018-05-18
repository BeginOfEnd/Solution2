using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_BL
{
    public class WorkWithStudents
    {
        public Queue<string> students { get; set; }


        public WorkWithStudents()
        {
            Queue<string> Students = new Queue<string>();
            students = Students;
        }
    }
}
