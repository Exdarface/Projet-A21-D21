namespace Mini_Projet_Recettes
{
    partial class frmCommentaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommentaires));
            this.lblChoixRecettes = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblAvis = new System.Windows.Forms.Label();
            this.cboRecettes = new System.Windows.Forms.ComboBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.btnNote1 = new System.Windows.Forms.Button();
            this.btnNote2 = new System.Windows.Forms.Button();
            this.btnNote3 = new System.Windows.Forms.Button();
            this.btnNote4 = new System.Windows.Forms.Button();
            this.txtAvis = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChoixRecettes
            // 
            this.lblChoixRecettes.AutoSize = true;
            this.lblChoixRecettes.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixRecettes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixRecettes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblChoixRecettes.Location = new System.Drawing.Point(25, 30);
            this.lblChoixRecettes.Name = "lblChoixRecettes";
            this.lblChoixRecettes.Size = new System.Drawing.Size(329, 22);
            this.lblChoixRecettes.TabIndex = 0;
            this.lblChoixRecettes.Text = "Quelle recette voulez vous Notez ?";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.BackColor = System.Drawing.Color.Transparent;
            this.lblPseudo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPseudo.Location = new System.Drawing.Point(25, 80);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(152, 22);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Votre Pseudo ?";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNote.Location = new System.Drawing.Point(25, 130);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(142, 22);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note globale ?";
            // 
            // lblAvis
            // 
            this.lblAvis.AutoSize = true;
            this.lblAvis.BackColor = System.Drawing.Color.Transparent;
            this.lblAvis.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvis.Location = new System.Drawing.Point(25, 180);
            this.lblAvis.Name = "lblAvis";
            this.lblAvis.Size = new System.Drawing.Size(119, 22);
            this.lblAvis.TabIndex = 3;
            this.lblAvis.Text = "Votre Avis ?";
            // 
            // cboRecettes
            // 
            this.cboRecettes.FormattingEnabled = true;
            this.cboRecettes.Location = new System.Drawing.Point(404, 34);
            this.cboRecettes.Name = "cboRecettes";
            this.cboRecettes.Size = new System.Drawing.Size(388, 22);
            this.cboRecettes.TabIndex = 4;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(227, 84);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(283, 20);
            this.txtPseudo.TabIndex = 5;
            // 
            // btnNote1
            // 
            this.btnNote1.Location = new System.Drawing.Point(173, 130);
            this.btnNote1.Name = "btnNote1";
            this.btnNote1.Size = new System.Drawing.Size(30, 30);
            this.btnNote1.TabIndex = 6;
            this.btnNote1.Tag = "1";
            this.btnNote1.UseVisualStyleBackColor = true;
            this.btnNote1.Click += new System.EventHandler(this.btnNote1_Click);
            // 
            // btnNote2
            // 
            this.btnNote2.Location = new System.Drawing.Point(209, 130);
            this.btnNote2.Name = "btnNote2";
            this.btnNote2.Size = new System.Drawing.Size(30, 30);
            this.btnNote2.TabIndex = 7;
            this.btnNote2.Tag = "2";
            this.btnNote2.UseVisualStyleBackColor = true;
            this.btnNote2.Click += new System.EventHandler(this.btnNote1_Click);
            // 
            // btnNote3
            // 
            this.btnNote3.Location = new System.Drawing.Point(245, 130);
            this.btnNote3.Name = "btnNote3";
            this.btnNote3.Size = new System.Drawing.Size(30, 30);
            this.btnNote3.TabIndex = 8;
            this.btnNote3.Tag = "3";
            this.btnNote3.UseVisualStyleBackColor = true;
            this.btnNote3.Click += new System.EventHandler(this.btnNote1_Click);
            // 
            // btnNote4
            // 
            this.btnNote4.Location = new System.Drawing.Point(281, 130);
            this.btnNote4.Name = "btnNote4";
            this.btnNote4.Size = new System.Drawing.Size(30, 30);
            this.btnNote4.TabIndex = 9;
            this.btnNote4.Tag = "4";
            this.btnNote4.UseVisualStyleBackColor = true;
            this.btnNote4.Click += new System.EventHandler(this.btnNote1_Click);
            // 
            // txtAvis
            // 
            this.txtAvis.Location = new System.Drawing.Point(163, 182);
            this.txtAvis.Name = "txtAvis";
            this.txtAvis.Size = new System.Drawing.Size(735, 220);
            this.txtAvis.TabIndex = 10;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(745, 438);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 35);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(836, 438);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 35);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // frmCommentaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtAvis);
            this.Controls.Add(this.btnNote4);
            this.Controls.Add(this.btnNote3);
            this.Controls.Add(this.btnNote2);
            this.Controls.Add(this.btnNote1);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.cboRecettes);
            this.Controls.Add(this.lblAvis);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblChoixRecettes);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCommentaires";
            this.Text = "Notez vos recettes";
            this.Load += new System.EventHandler(this.frmCommentaires_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixRecettes;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblAvis;
        private System.Windows.Forms.ComboBox cboRecettes;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button btnNote1;
        private System.Windows.Forms.Button btnNote2;
        private System.Windows.Forms.Button btnNote3;
        private System.Windows.Forms.Button btnNote4;
        private System.Windows.Forms.TextBox txtAvis;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}

