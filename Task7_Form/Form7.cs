using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Task7_BL;

namespace Task7_Form
{
    public partial class Form7 : Form
    {
        InOut7 io = new InOut7();
        public Form7()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    io.Text = io.ReadFromFile(inputOpenFileDialog.FileName);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
            InBox.Text = io.Text;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
