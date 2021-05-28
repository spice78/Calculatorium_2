using System;
using System.Windows.Forms;

namespace Calculatorium_2
{
    public partial class Calcutator : Form
    {
        //delegate block
        public const string DecLetters = "0123456789\b"; // \b is the BackSpace character
        public const string HexLetters = "0123456789abcdefABCDEF\b"; // \b is the BackSpace character
        public const string BinLetters = "01\b"; // \b is the BackSpace character
        //end delegate block

        public Calcutator()
        {
            InitializeComponent();
        }
        //this shit created automatically
        private void decime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hexito_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void la_binare_TextChanged(object sender, EventArgs e)
        {
            
        }
        //end of shit
        //start button block when u click u get result
        private void dec_il_pulsante_Click(object sender, EventArgs e) 
        {
            string numDec = decime.Text;
            decime.Text = numDec;

            Int32 iNum = Convert.ToInt32(numDec, 10);//Int32 max value 2147483647

            string shex = Convert.ToString(iNum, 16);
            hexito.Text = shex.ToUpper();
            string sbin = Convert.ToString(iNum, 2);
            la_binare.Text = sbin;
        }

        private void heximito_Click(object sender, EventArgs e)
        {
            string numHex = hexito.Text;
            hexito.Text = numHex;

            Int32 iNum = Convert.ToInt32(numHex, 16);//Int32 max value 2147483647

            string sdec = Convert.ToString(iNum, 10);
            decime.Text = sdec.ToUpper();
            string sbin = Convert.ToString(iNum, 2);
            la_binare.Text = sbin;
        }

        private void binarito_Click(object sender, EventArgs e)
        {
            string numBin = la_binare.Text;
            la_binare.Text = numBin;

            Int32 iNum = Convert.ToInt32(numBin, 2);//Int32 max value 2147483647

            string sdec = Convert.ToString(iNum, 10);
            decime.Text = sdec.ToUpper();
            string shex = Convert.ToString(iNum, 16);
            hexito.Text = shex;
        }
        //end button block
        //this und below check correct entering data in field
        private void decime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DecLetters.Contains(e.KeyChar)) { e.Handled = true; }
        }

        private void hexito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!HexLetters.Contains(e.KeyChar)) { e.Handled = true; }
        }

        private void la_binare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!BinLetters.Contains(e.KeyChar)) { e.Handled = true; }
        }
        //end check correct entering data
    }
}
