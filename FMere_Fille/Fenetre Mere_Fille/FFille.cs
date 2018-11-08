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
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            btnFFMaMere.Click += new EventHandler(btnFFMaMere_Click);
            this.Load += new EventHandler(FFille_Load);
            btnFFChanger.Click += new EventHandler(btnFFChanger_Click);
        }

        void btnFFChanger_Click(object sender, EventArgs e)
        {
            
        }

        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur" + this.monNom);
        }
    
        void btnFFMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le nom de ma mère est : " + maMere.GetNomMere);
        }       
    }
}
