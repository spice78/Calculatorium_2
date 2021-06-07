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
            Int64 iNum = 0;
            string numDec = "0";
            string bufDec = decime.Text;
            if (bufDec == "")
            { bufDec = "0"; }
            else { numDec = bufDec; }

            if (Convert.ToInt64(numDec) <= 9223372036854775807)
            { iNum = Convert.ToInt64(numDec, 10); }

            string shex = Convert.ToString(iNum, 16);
            hexito.Text = shex.ToUpper();
            string sbin = Convert.ToString(iNum, 2);
            la_binare.Text = sbin;
        }

        private void hexito_TextChanged(object sender, EventArgs e)
        {
            Int64 iNum = 0;
            string numHex = "0";
            string bufHex = hexito.Text;
            if (bufHex == "")
            { bufHex = "0"; }
            else { numHex = bufHex; }

            if (Convert.ToInt64(numHex, 16) <= 0x7FFFFFFFFFFFFFFF)
            { iNum = Convert.ToInt64(numHex, 16); }

            string sdec = Convert.ToString(iNum, 10);
            decime.Text = sdec.ToUpper();
            string sbin = Convert.ToString(iNum, 2);
            la_binare.Text = sbin;
        }

        private void la_binare_TextChanged(object sender, EventArgs e)
        {
            Int64 iNum = 0;
            string numBin = "0";
            string bufBin = la_binare.Text;
            if (bufBin == "")
            { bufBin = "0"; }
            else { numBin = bufBin; }

            if (Convert.ToInt64(numBin, 2) <= 0b0111111111111111111111111111111111111111111111111111111111111111)
            { iNum = Convert.ToInt64(numBin, 2); }

            string sdec = Convert.ToString(iNum, 10);
            decime.Text = sdec.ToUpper();
            string shex = Convert.ToString(iNum, 16);
            hexito.Text = shex;
        }
        //end of shit
        
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

        private void la_pulsante_uno_plus_MouseClick(object sender, MouseEventArgs e)
        {
            Int64 plusField = Convert.ToInt64(decime.Text);
            plusField++;
            decime.Text = Convert.ToString(plusField);
        }        
    }
}
