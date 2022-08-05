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
    public partial class form_file_read_write : Form
    {
        public form_file_read_write()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            StreamReader inputFile;
            StreamWriter outputFile;

            // Hold data for file output
            string outputData = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file
                inputFile = File.OpenText(openFile.FileName);

                // Loop to read entire file
                while(!inputFile.EndOfStream)
                {
                    // String to hold all file data
                    string fileData = inputFile.ReadToEnd();
                    
                    /* Part A: Convert all words to lowercase */

                    // Hold lower case data from file
                    string lowerCase;
                    // Convert fileData to lower case
                    lowerCase = fileData.ToLower();

                    /* Part B: Find first and last words alphabetically */

                    // Create an array for each individual word
                    string[] wordArray = fileData.Split(' ', ',', '.', '\n');
                    // Sort all words alphabetically
                    Array.Sort(wordArray);
                    // Use Join() method to concatenate array into single string, store in new string variable
                    string alphabetized = String.Join(" ", wordArray);

                    /* Part C: Find the longest word */

                    // Hold longest word
                    string longestWord = "";
                    // Length counter
                    int strLength = 0;

                    // Loop through array and find longest string
                    foreach (string s in wordArray)
                    {
                        if (s.Length > strLength)
                        {
                            longestWord = s;
                            strLength = s.Length;
                        }
                    }

                    /* Part D: Find the word with the most vowels */

                    // Hold highest vowel count
                    int highestVowelCount = 0;
                    // Hold string with the most vowels
                    string mostVowels = "";


                    // Loop through length of the array
                    for (int i = 0; i < wordArray.Length; i++)
                    {
                        // Hold temporary vowel count
                        int vowelCount = 0;
                        // Hold temporary string from array
                        string word = wordArray[i];
                        
                        // Loop through the length of each individual string
                        for (int k = 0; k < word.Length; k++)
                        {
                            // Check each string for lowecase and capital vowels
                            if ((word[k] == 'a' || word[k] == 'e' || word[k] == 'i' || word[k] == 'o' || word[k] == 'u') || 
                                (word[k] == 'A' || word[k] == 'E' || word[k] == 'I' || word[k] == 'O' || word[k] == 'U'))
                            {
                                vowelCount++;
                                // Determine which string has the most vowels
                                if (vowelCount > highestVowelCount)
                                {
                                    highestVowelCount = vowelCount;
                                    mostVowels = wordArray[i];
                                }
                            }

                        }
                    }



                    // Display all to textbox
                    tbx_display_file.Text = "All lower case: " + lowerCase + "\r\nAlphabetized: " + alphabetized + "\r\nLongest word: "
                    + longestWord + "\r\nMost Vowels: " + mostVowels;

                    // Store text from textbox into outputData
                    outputData = tbx_display_file.Text;
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled");
            }

            // Create a new file
            outputFile = File.CreateText("activity_5_output.txt");
            // Write data to new file
            outputFile.WriteLine(outputData);
            outputFile.Close();
        }
    }
}
