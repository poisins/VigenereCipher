using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace SecurityHW3
{
    public partial class frmMain : Form
    {

        Dictionary<string, char> tabulaRecta = new Dictionary<string, char>();
        string keyString = "";
        string usedChars = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateCipher_Click(object sender, EventArgs e)
        {
            createDictionary();
            encryptPlaintext();
        }

        private void btnCrackCipher_Click(object sender, EventArgs e)
        {
            createDictionary();
            decryptPlaintext();
        }

        void decryptPlaintext()
        {
            txtPlain.Text = "";

            int keyIndex = 0;
            foreach (char ch in txtCipher.Text)
            {

                string chUpper = ch.ToString().ToUpper();
                if (keyIndex > txtKey.Text.Length - 1)
                    keyIndex = 0;

                foreach(KeyValuePair<string,char> pair in tabulaRecta)
                {
                    if (!pair.Key.Contains(keyString[keyIndex]))
                        continue;
                    if (pair.Value != chUpper[0])
                        continue;

                    int charIndex = pair.Key.IndexOf(keyString[keyIndex]);
                    if (charIndex < 0)
                        continue;
                    string str = pair.Key.Remove(charIndex, 1);
                    txtPlain.Text += str;
                    break;
                }

                keyIndex++;
            }

            Debug.WriteLine("Text decrypted");
        }

        void encryptPlaintext()
        {
            txtCipher.Text = "";

            int keyIndex = 0;
            foreach(char ch in txtPlain.Text)
            {
                string chUpper = ch.ToString().ToUpper();
                if (keyIndex > txtKey.Text.Length-1)
                    keyIndex = 0;

                txtCipher.Text += tabulaRecta[chUpper[0] + keyString[keyIndex].ToString()];

                keyIndex++;
            }

            Debug.WriteLine("Text encrypted");
        }

        void createDictionary()
        {
            keyString = txtKey.Text.ToUpper();
            usedChars = txtChars.Text.ToUpper();

            tabulaRecta.Clear();

            for(int i=0; i < txtChars.Text.Length; i++)
            {
                for (int j = 0; j < txtChars.Text.Length; j++)
                {
                    int index = (i + j) % txtChars.Text.Length;
                    tabulaRecta.Add(usedChars[i].ToString() + usedChars[j].ToString(), usedChars[index]);
                }
            }
            Debug.WriteLine("Dictionary Created");
        }

    }
}
