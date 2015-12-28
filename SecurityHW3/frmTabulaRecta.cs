using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityHW3
{
    public partial class frmTabulaRecta : Form
    {
        Dictionary<string, char> tabulaRecta;
        int tabulaRowLength;
        public frmTabulaRecta(Dictionary<string, char> tabulaRecta, int tabulaRowLength)
        {
            InitializeComponent();
            this.tabulaRecta = tabulaRecta;
            this.tabulaRowLength = tabulaRowLength;
        }

        void showTable()
        {
            int i = -1;
            foreach(KeyValuePair<string,char> pair in tabulaRecta)
            {
                i++;
                if ((i % tabulaRowLength) == 0 && i !=0)
                    txtTabulaRecta.Text += "\n";
                txtTabulaRecta.Text += pair.Value + " ";
            }
        }

        private void frmTabulaRecta_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
