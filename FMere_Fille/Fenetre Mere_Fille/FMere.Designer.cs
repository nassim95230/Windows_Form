﻿namespace Fenetre_Mere_Fille
{
    partial class FMere
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLesFilles = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(23, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New()";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(178, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbLesFilles
            // 
            this.lbLesFilles.FormattingEnabled = true;
            this.lbLesFilles.Location = new System.Drawing.Point(23, 64);
            this.lbLesFilles.Name = "lbLesFilles";
            this.lbLesFilles.Size = new System.Drawing.Size(230, 134);
            this.lbLesFilles.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(23, 204);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(178, 204);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(23, 233);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 5;
            this.btnShowDialog.Text = "Show Dialog";
            this.btnShowDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowDialog.UseVisualStyleBackColor = true;
            // 
            // FMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbLesFilles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Name = "FMere";
            this.Text = "Mere";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbLesFilles;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShowDialog;
    }
}

