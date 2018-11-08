using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fenetre_Mere_Fille
{
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;

        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "la madre";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }

        public string GetNomMere
        {
            get 
            {
                return this.nomMere;
            }
        }

        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {

        }
    }
}
