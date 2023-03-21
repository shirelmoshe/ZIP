using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winfromZip
{
    
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                string inputPath = TextBox.Text;
                string outputPath = TextBox.Text;

                if (RadioButton.Checked)
                {
                    FileCompression.ZipDirectory(inputPath, outputPath);
                }
                else if (radioButton2.Checked)
                {
                    FileCompression.RarDirectory(inputPath, outputPath);
                }
            }
        }

    
}
