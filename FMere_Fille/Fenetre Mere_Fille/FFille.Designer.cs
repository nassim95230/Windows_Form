namespace Fenetre_Mere_Fille
{
    partial class FFille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFFille = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnFFChanger = new System.Windows.Forms.Button();
            this.btnFFMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFFille
            // 
            this.tbFFille.Location = new System.Drawing.Point(170, 50);
            this.tbFFille.Name = "tbFFille";
            this.tbFFille.Size = new System.Drawing.Size(100, 20);
            this.tbFFille.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(59, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "je change de nom:";
            // 
            // btnFFChanger
            // 
            this.btnFFChanger.Location = new System.Drawing.Point(327, 48);
            this.btnFFChanger.Name = "btnFFChanger";
            this.btnFFChanger.Size = new System.Drawing.Size(75, 23);
            this.btnFFChanger.TabIndex = 2;
            this.btnFFChanger.Text = "Changer";
            this.btnFFChanger.UseVisualStyleBackColor = true;
            // 
            // btnFFMaMere
            // 
            this.btnFFMaMere.Location = new System.Drawing.Point(181, 99);
            this.btnFFMaMere.Name = "btnFFMaMere";
            this.btnFFMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnFFMaMere.TabIndex = 3;
            this.btnFFMaMere.Text = "Ma mere";
            this.btnFFMaMere.UseVisualStyleBackColor = true;
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 165);
            this.Controls.Add(this.btnFFMaMere);
            this.Controls.Add(this.btnFFChanger);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbFFille);
            this.Name = "FFille";
            this.Text = "FFille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFFille;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnFFChanger;
        private System.Windows.Forms.Button btnFFMaMere;
    }
}