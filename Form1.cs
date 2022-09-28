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

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Select file .txt|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                StreamReader reader = new StreamReader(filePath);
                string Content = reader.ReadToEnd();

                reader.Close();

                txtContent.Text = Content;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Save file .txt|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                string content = txtContent.Text;

                StreamWriter writer = new StreamWriter(filePath);

                writer.Write(content);

                writer.Close();
            }
        }
    }
}
