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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CbCharger_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbDegainer_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbRenverse_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbSurpris_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbCombattant_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbEnJoue_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbPosiSuperieur_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbReusite_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbEchec_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void rbAttaque_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void rbPare_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void rbEsquive_CheckedChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbTaille_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void CbArme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbVision_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbParalisie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void cbVol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix();
        }

        private void TxtResultat_Click(object sender, EventArgs e)
        {
            Choix();
        }

        private void btAttSpe_Click(object sender, EventArgs e)
        {
            AttaqueSpecial test = new AttaqueSpecial();
            test.Show();
        }

        private void BtDefense_Click(object sender, EventArgs e)
        {
            AttaqueSpecial test = new AttaqueSpecial();
            test.Show();
        }

        private void Choix()
        {
            int Res = 0;
            if (rbAttaque.Checked)
            {
                Res = Attaque();

                this.txtResultat.Text = Res.ToString();
            }
            if (rbPare.Checked)
            {
                Res = Pare();

                this.txtResultat.Text = Res.ToString();
            }
            if (rbEsquive.Checked)
            {
                Res = Esquive();

                this.txtResultat.Text = Res.ToString();
            }
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
            if(cbTaille.Text == "minuscule")
            {
                Res = Res - 20;
            }
            if (cbTaille.Text == "petit")
            {
                Res = Res - 10;
            }
            if (cbVision.Text == "Cécité partielle")
            {
                Res = Res - 30;
            }
            if (cbVision.Text == "Cécité totale")
            {
                Res = Res - 100;
            }
            if (cbVol.Text == "Perso en lévitation")
            {
                Res = Res - 20;
            }
            if (cbVol.Text == "Perso en vol (7-14)")
            {
                Res = Res + 10;
            }
            if (cbVol.Text == "Perso en vol (15+)")
            {
                Res = Res + 15;
            }
            if (cbPosition.Text == "dans le dos du personnage")
            {
                Res = Res - 30;
            }
            if (cbPosition.Text == "dans le flanc du personnage")
            {
                Res = Res - 10;
            }
            if (cbPosition.Text == "Paralisie totale")
            {
                Res = Res - 200;
            }
            if (cbPosition.Text == "Paralysie partielle")
            {
                Res = Res - 80;
            }
            if (cbPosition.Text == "Paralysie légère")
            {
                Res = Res - 20;
            }
            return Res;

        }

        private int Pare()
        {
            int Res = 0;
        Res = +Convert.ToInt32(txtAtt.Text);
            if (CbCharger.Checked)
            {
                Res = Res-10;
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
                Res = -90;
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
                Res = Res - 120;
            }
            if(cbTaille.Text == "minuscule")
            {
                Res = Res - 10;
            }
            if (cbVision.Text == "Cécité partielle")
            {
                Res = Res - 30;
            }
            if (cbVision.Text == "Cécité totale")
            {
                Res = Res - 80;
            }
            if (cbVol.Text == "Perso en lévitation")
            {
                Res = Res - 20;
            }
            if (cbVol.Text == "Perso en vol (7-14)")
            {
                Res = Res + 10;
            }
            if (cbVol.Text == "Perso en vol (15+)")
            {
                Res = Res + 10;
            }
            if (cbPosition.Text == "dans le dos du personnage")
            {
                Res = Res - 80;
            }
            if (cbPosition.Text == "dans le flanc du personnage")
            {
                Res = Res - 30;
            }
            if (cbPosition.Text == "Paralisie totale")
            {
                Res = Res - 200;
            }
            if (cbPosition.Text == "Paralysie partielle")
            {
                Res = Res - 80;
            }
            if (cbPosition.Text == "Paralysie légère")
            {
                Res = Res - 20;
            }
            return Res;
            
        }

        private int Esquive()
        {
            int Res = 0;
            Res = +Convert.ToInt32(txtAtt.Text);
            if (CbCharger.Checked)
            {
                Res = Res - 20;
            }
            if (CbDegainer.Checked)
            {
                Res = Res - 25;
            }
            if (CbRenverse.Checked)
            {
                Res = Res - 30;
            }
            if (CbSurpris.Checked)
            {
                Res = -90;
            }
            if (CbCombattant.Checked)
            {
                    Res = Res - 40;
            }
            if (CbEnJoue.Checked)
            {
                Res = Res - 120;
            }
            if (cbVision.Text == "Cécité partielle")
            {
                Res = Res - 15;
            }
            if (cbVision.Text == "Cécité totale")
            {
                Res = Res - 80;
            }
            if (cbVol.Text == "Perso en lévitation")
            {
                Res = Res - 40;
            }
            if (cbVol.Text == "Perso en vol (7-14)")
            {
                Res = Res + 10;
            }
            if (cbVol.Text == "Perso en vol (15+)")
            {
                Res = Res + 10;
            }
            if (cbPosition.Text == "dans le dos du personnage")
            {
                Res = Res - 80;
            }
            if (cbPosition.Text == "dans le flanc du personnage")
            {
                Res = Res - 30;
            }
            if (cbPosition.Text == "Paralisie totale")
            {
                Res = Res - 100;
            }
            if (cbPosition.Text == "Paralysie partielle")
            {
                Res = Res - 30;
            }
            if (cbPosition.Text == "Paralysie légère")
            {
                Res = Res - 40;
            }
            return Res;

        }

        
    }
}
