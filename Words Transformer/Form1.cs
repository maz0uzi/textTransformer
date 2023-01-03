using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words_Transformer
{
    public partial class Form1 : Form
    {

        private string Encrypt(string input)
        {
            // Create a StringBuilder to hold the encrypted text
            StringBuilder sb = new StringBuilder();

            // Loop through each character in the input string
            foreach (char c in input)
            {
                // Encrypt the character by shifting it forward by 1
                char encryptedChar = (char)(c + 1);

                // Append the encrypted character to the StringBuilder
                sb.Append(encryptedChar);
            }

            // Return the encrypted string
            return sb.ToString();
        }

        private string Decrypt(string input)
        {
            // Create a StringBuilder to hold the decrypted text
            StringBuilder sb = new StringBuilder();

            // Loop through each character in the input string
            foreach (char c in input)
            {
                // Decrypt the character by shifting it backward by 1
                char decryptedChar = (char)(c - 1);

                // Append the decrypted character to the StringBuilder
                sb.Append(decryptedChar);
            }

            // Return the decrypted string
            return sb.ToString();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the text from the input field
            string inputText = textBox1.Text;

            // Decrypt the text
            string decryptedText = Decrypt(inputText);

            // Display the decrypted text in the other input field
            textBox1.Text = decryptedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text from the input field
            string inputText = textBox1.Text;

            // Perform the desired transformation on the text
            string transformedText = Encrypt(inputText);

            // Display the transformed text in the other input field
            textBox1.Text = transformedText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
