using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Tristan DeMaria, CSCI-1630, October 17th, 2021
 * Playfair Cipher Encoder
 * Create a GUI application that will receive a secret
 * keyword and a phrase and return a garbled message
 * that has been encoded using a playfair cipher.
 * Playfair cipher is a secret code written using a
 * 5x5 matrix of the alphabet that has been offset by 
 * appending the keyword to the start of the matrix.
 * (I and J are combined)
 * The keyword must be in all capital letters and must
 * contain no spaces, numbers, or punctuation or special
 * characters. The text to be encoded does not need to be
 * in all caps, and may contain spaces, numbers, and
 * punctuation, but these will not be encoded.
 * The resulting encoded text must be returned in all caps.
 * If done correctly, the resulting message will return the
 * original message if fed back through the encoder using the
 * same keyword.
 * The keyword and text to be encoded boxes must have their
 * text validated to be not null, and the keyword must be
 * validated as all caps and having none of the banned characters.
 * The matrix will be represented as a two-dimensional array.
 * The code must be broken into meaningful methods that only
 * perform a single function.
 * There msut be labeled fields to enter and display text,
 * as well as three buttons: a close button tha closes the program,
 * a clear button that clears the text fields,
 * and a translate button that launches the process of
 * encoding.
 * For more details, consult the prompt found on Blackboard.
 * 
 * Significant portions of this code have been provided by
 * Dr. Isaiah Abimbolah via the Tips of the Week page on Blackboard.
 */

namespace Exercise5
{
    public partial class playfairCodeTranslatorForm : Form
    {
        //initialize the strings that will be used by the program
        string cipher, cipherAlpha, inputText, outputText;

        //Create a string for the alphabet and a character array to
        //eventually place it into along with the cipher
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[,] encrypt = new char[5, 5];

        public playfairCodeTranslatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable; //turn off auto validation
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            ValidateCipher(); //validate the cipher
            ValidateInputText(); //validate the text

            var chars = alpha.ToCharArray();
            cipherAlpha = cipher + alpha; //append the cipher to the alpha string

            cipherAlpha = RemoveDuplicates(cipherAlpha); //remove duplicates from the cipherAlpha string

            chars = cipherAlpha.ToCharArray();
            
            PopulateArray(chars); //fill the array
            GetTranslatedText(); //translate the text
            outputBox.Text = outputText; //return the output to the output box
        }

        private void PopulateArray(char[] chars)
        {
            /* Set a few variables. ctr2 to use in the following for loop
             * that will be used to remove J from the cipherAlpha
             * variable. row1 and col1 will be used to craft the 2D arrays.
             */
            int ctr2 = 0;
            int row1 = 0;
            int col1 = 0;

            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                if (chars[ctr] == 'J')
                    continue;
                ctr2++;
                //Reset ctr2 to 0 if five characters have
                //been written to a row
                if (ctr2 == 5)
                {
                    ctr2 = 0;
                }
                //This actually controls populating the 2D 5x5 array
                if (col1 == 5)
                {
                    col1 = 0;
                    row1++;
                }

                encrypt[row1, col1] = chars[ctr];
                col1++;
            }
        }

        /// <summary>
        /// Validates the text to be encoded.
        /// The only validation is that the text must exist.
        /// Assign the value to the inputText string.
        /// </summary>
        private void ValidateInputText()
        {
            //detect if the input box is empty and return an error message if so
            if (string.IsNullOrEmpty(inputBox.Text))
                MessageBox.Show("You must enter the text to be encoded.");
            //assign text in input box to the input string
            else
                inputText = inputBox.Text;
        }

        /// <summary>
        /// Validates the cipher keyword.
        /// Keyword must be in all caps and must only include letters,
        /// no spaces, numbers, or punctuation / special characters.
        /// Assign the keyword to the cipherText string.
        /// </summary>
        private void ValidateCipher()
        {
            //detect if the cipher box is empty and return an error message if so
            if (string.IsNullOrEmpty(cipherBox.Text))
                MessageBox.Show("You must enter a cipher.");
            //detect if the entered cipher contains characters other than
            //letters and return an error message if so
            else if (cipherBox.Text.All(Char.IsLetter) == false)
                MessageBox.Show("Your cipher cannot include spaces, numbers, or punctuation.");
            //detect if the entered cipher is in all caps and
            //return an error message if not
            else if (cipherBox.Text.All(Char.IsUpper) == false)
                MessageBox.Show("Your cipher must be in all capital letters.");
            //assign text in the cipher box to the cipher string
            else
                cipher = cipherBox.Text;
        }

        /// <summary>
        /// Clears the text boxes on the form by reassigning
        /// the text box Text values to an empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            cipherBox.Text = "";
            inputBox.Text = "";
            outputBox.Text = "";
        }

        /// <summary>
        /// Closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Method provided by Dr. I. Abimbolah.
        /// Removes duplicate characters in a string by appending characters
        /// to a result variable, then checking if any new characters
        /// are already in the result string using a foreach loop.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        static string RemoveDuplicates(string key)
        {
            // Remove duplicate chars using string concats.
            // ... Store encountered letters in this string.

            string result = ""; //initialize result

            foreach (char value in key)
            {
                // See if character is in the result already; if not,
                //then, append that character to "result"
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }
            return result;
        }

        /// <summary>
        /// Receives the encoded letter and appends them to
        /// the outputText string
        /// </summary>
        /// <returns></returns>
        private string GetTranslatedText()
        {
            outputText = "";
            foreach (var letter in inputText.ToUpper())
            {
                char newLetter = GetTransposedLetter(letter);
                outputText += newLetter;
            }
            return outputText;
        }

        /// <summary>
        /// Detects the letter and returns its encoded equivalent.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        private char GetTransposedLetter(char letter)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (letter == 'J')
                        letter = 'I';

                    if (letter == encrypt[row, col])
                    {
                        return encrypt[col, row];
                    }
                }
            }
            return letter;
        }
    }
}
