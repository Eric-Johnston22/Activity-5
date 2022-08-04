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

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file
                inputFile = File.OpenText(openFile.FileName);

                // Loop to read entire file
                while(!inputFile.EndOfStream)
                {
                    // String to hold all file data
                    string fileData = inputFile.ReadToEnd();
                    
                    // Part A: Convert all words to lowercase //

                    // Hold lower case data from file
                    string lowerCase;
                    // Convert fileData to lower case
                    lowerCase = fileData.ToLower();

                    // Part B: Find first and last words alphabetically //

                    // Create an array for each individual word
                    string[] wordArray = fileData.Split(' ', ',', '.', '\n');
                    // Sort all words alphabetically
                    Array.Sort(wordArray);
                    // Use Join() method to concatenate array into single string, store in new string variable
                    string alphabetized = String.Join(" ", wordArray);

                    // Part C: Find the longest worrd //

                    string longestWord = "";
                    int ctr = 0;

                    foreach (string s in wordArray)
                    {
                        if (s.Length > ctr)
                        {
                            longestWord = s;
                            ctr = s.Length;
                        }
                    }

                    tbx_display_file.Text = longestWord;

                    //tbx_display_file.Text = fileData;

                    // Display all to textbox
                    //tbx_display_file.Text = "All lower case: " + lowerCase + "\r\nAlphabetized: " + alphabetized;
                    
                }

            }
            else
            {
                MessageBox.Show("Operation cancelled");
            }
        }
    }
}
