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

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            StreamReader inputFile;
            string fileData;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file
                inputFile = File.OpenText(openFile.FileName);

                // Loop to read entire file
                while(!inputFile.EndOfStream)
                {
                    // Hold lower case data from file
                    string lowerCase;
                    fileData = inputFile.ReadToEnd();
                    // Convert fileData to lower case
                    lowerCase = fileData.ToLower();

                    tbx_display_file.Text = fileData;
                }

            }
            else
            {
                MessageBox.Show("Operation cancelled");
            }
        }
    }
}
