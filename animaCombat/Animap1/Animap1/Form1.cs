using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void TxtResultat_Click(object sender, EventArgs e)
        {
            int Res = 0;
            
                Res = Attaque();
            
            this.txtResultat.Text = Res.ToString();
        }

        private int Attaque()
        {
            int Res = 0;
            Res = +Convert.ToInt32(txtAtt.Text);
            if (CbCharger.Checked)
            {
                Res = Res+10;
            }
            if(CbDegainer.Checked)
            {
                Res = Res-25;
            }
            if(CbRenverse.Checked)
            {
                Res = Res-30;
            }
            if(CbSurpris.Checked)
            {
                Res = 0;
                return Res;
            }
            if (CbCombattant.Checked)
            {
                if (CbArme.Text == "Arme grande")
                {
                    Res = Res - 40;
                }

            }
            if(CbEnJoue.Checked)
            {
                Res = Res - 20;
            }

            if(CbPosiSuperieur.Checked)
            {
                Res = Res + 20;
            }
                return Res;
            
        }
    }
}
