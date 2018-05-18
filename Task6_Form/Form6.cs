using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task6_BL;
using System.IO;

namespace Task6_Form
{
    public partial class Form6 : Form
    {
        InOut6 io = new InOut6();
        MaxValues mv = new MaxValues();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void FileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    mv.numbers = io.ReadFromFile(inputOpenFileDialog.FileName, mv.numbers);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
            FileBox.Text = io.Text;
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            uint count = mv.FindAllMaxValues(mv.numbers);
            string text = Convert.ToString(count);
            MaxBox.Text = text;
        }
    }
}
