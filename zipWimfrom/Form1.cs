using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms.TextBox;
using Entits;

namespace zipWimfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sourceDir = txtSourceDir.Text;
            string zipFilePath = Path.Combine(Path.GetDirectoryName(sourceDir), Path.GetFileNameWithoutExtension(sourceDir) + ".zip");
            ZipDirectory(sourceDir, zipFilePath);
            MessageBox.Show("הכיווץ הצליח");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
