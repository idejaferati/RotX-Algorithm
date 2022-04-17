using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            string plaintext = textBox1.Text.ToLower();
            textBox2.Text = rotX.Encrypt(key, plaintext);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            string ciphertext = textBox2.Text.ToLower();
            textBox1.Text = rotX.Decrypt(key, ciphertext);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static char[] alfabeti = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

public class rotX
        {

            public static string Encrypt(int key, string plaintext)
            {

                StringBuilder encryption = new StringBuilder(); //encrypted plaintext
                char[] plaintextArray = plaintext.ToCharArray(); //saved the plaintext characters in this vector
                char keyedLetter = ' '; //the letter is saved after the shift is done

                for (int i = 0; i < plaintextArray.Length; i++)
                {

                    //we check if there are spaces inside the plaintext, 
                    //if yes, the same spaces are also forwarded to the ciphertext
                    if (plaintextArray[i].Equals(' '))
                    {
                        encryption.Append(plaintextArray[i]);
                        continue;
                    }

                    for (int j = 0; j < alfabeti.Length; j++)
                    {

                        //check if plaintext letters are found in the alphabet
                        if (plaintextArray[i].Equals(alfabeti[j]))   
                        {

                            // takes the letter in the alphabet string which is equal to the current letter in the plaintext string
                            // adds the value of the key to the current index value of the alphabet string
                            // %26 in it to make sure it is always in the alphabet and does not go out of bounds
                            keyedLetter = alfabeti[(j + key) % 26];
                            encryption.Append(keyedLetter);

                        }

                    }

                }

                return encryption.ToString();
            }
            
             public static string Decrypt(int key, string ciphertext)
            {
                StringBuilder decryption = new StringBuilder();
                char[] ciphertextArray = ciphertext.ToCharArray();  // in this vector we save characters of the ciphertext
                char keyedLetter = ' ';// here are saved the letters of shifting
                int letter = 0; // the new letter we get

                for (int i = 0; i < ciphertextArray.Length; i++)
                {


                    if (ciphertextArray[i].Equals(' '))
                    {
                        decryption.Append(ciphertextArray[i]);

                        continue;
                    }

                    for (int j = 0; j < alfabeti.Length; j++)
                    {

                        if (ciphertextArray[i].Equals(alfabeti[j]))
                        {
                            letter = (j - key) % 26;

                            //while the modulus of a negative number is a negative number,
                            //adding 26 to the negative number has the same result as getting a positive number
                            if (letter < 0)
                            {
                                letter += 26;
                            }

                            keyedLetter = alfabeti[letter];
                            decryption.Append(keyedLetter);

                        }

                    }

                }

                return decryption.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        
    }
}
