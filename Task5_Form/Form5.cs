using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5_BL;
using System.IO;

namespace Task5_Form
{
    public partial class Form5 : Form
    {
        InOut5  io = new InOut5();
        WorkWithStudents STUDENTS = new WorkWithStudents();
        public Form5()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    STUDENTS.students = io.ReadFromFile(inputOpenFileDialog.FileName, STUDENTS.students);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
            StudentsBox.Text = io.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string student = SurnameBox.Text;
            io.Text = "";
            STUDENTS.students.Enqueue(student);
            STUDENTS.students.Sort(STUDENTS.students);
            io.Text = STUDENTS.students.Print(STUDENTS.students);
            StudentsBox.Text = io.Text;
        }
    }
}
