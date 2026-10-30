using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conta_lettere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conta_Click(object sender, EventArgs e)
        {
            string stringa = txt_frase.Text;
            int[] conta = new int[26];

            foreach (char c in stringa)
            {
                char lettera = char.ToUpper(c);
                if (lettera >= 'A' && lettera <= 'Z')
                {
                    int indice = lettera - 'A';
                    conta[indice]++;
                }
            }
            for ( int i = 0; i < 26; i++)
            {
                if (conta[i] > 0)
                {
                    char letteraT = (char)('A' + i);
                    list_lettere.Items.Add("lettera " + letteraT + ": " + conta[i]);
                }
            }
        }
    }
}
