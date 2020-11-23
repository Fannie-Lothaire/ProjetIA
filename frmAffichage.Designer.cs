namespace ProjetIAv0
{
    partial class frmAffichage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffichage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTemps = new System.Windows.Forms.Label();
            this.txtboxTemps = new System.Windows.Forms.TextBox();
            this.pboxArbre = new System.Windows.Forms.PictureBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblNoeudf = new System.Windows.Forms.Label();
            this.txtboxNoeudf = new System.Windows.Forms.TextBox();
            this.lblNoeudfo = new System.Windows.Forms.Label();
            this.txtboxNoeudfo = new System.Windows.Forms.TextBox();
            this.lblArbre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArbre)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "pictureBox1";
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(214, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(12, 68);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(104, 13);
            this.lblTemps.TabIndex = 1;
            this.lblTemps.Text = "Temps de parcours :";
            // 
            // txtboxTemps
            // 
            this.txtboxTemps.Enabled = false;
            this.txtboxTemps.Location = new System.Drawing.Point(12, 84);
            this.txtboxTemps.Name = "txtboxTemps";
            this.txtboxTemps.Size = new System.Drawing.Size(100, 20);
            this.txtboxTemps.TabIndex = 2;
            // 
            // pboxArbre
            // 
            this.pboxArbre.Location = new System.Drawing.Point(12, 239);
            this.pboxArbre.Name = "pboxArbre";
            this.pboxArbre.Size = new System.Drawing.Size(110, 91);
            this.pboxArbre.TabIndex = 3;
            this.pboxArbre.TabStop = false;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.BackColor = System.Drawing.Color.Transparent;
            this.lblInit.ForeColor = System.Drawing.Color.Red;
            this.lblInit.Location = new System.Drawing.Point(15, 20);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(64, 13);
            this.lblInit.TabIndex = 4;
            this.lblInit.Text = "Point départ";
            this.lblInit.Visible = false;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.ForeColor = System.Drawing.Color.Green;
            this.lblFin.Location = new System.Drawing.Point(15, 43);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(66, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Point arrivée";
            this.lblFin.Visible = false;
            // 
            // lblNoeudf
            // 
            this.lblNoeudf.AutoSize = true;
            this.lblNoeudf.Location = new System.Drawing.Point(9, 121);
            this.lblNoeudf.Name = "lblNoeudf";
            this.lblNoeudf.Size = new System.Drawing.Size(143, 13);
            this.lblNoeudf.TabIndex = 6;
            this.lblNoeudf.Text = "Nombre de noeuds (fermés) :";
            // 
            // txtboxNoeudf
            // 
            this.txtboxNoeudf.Enabled = false;
            this.txtboxNoeudf.Location = new System.Drawing.Point(12, 137);
            this.txtboxNoeudf.Name = "txtboxNoeudf";
            this.txtboxNoeudf.Size = new System.Drawing.Size(100, 20);
            this.txtboxNoeudf.TabIndex = 7;
            // 
            // lblNoeudfo
            // 
            this.lblNoeudfo.AutoSize = true;
            this.lblNoeudfo.Location = new System.Drawing.Point(9, 176);
            this.lblNoeudfo.Name = "lblNoeudfo";
            this.lblNoeudfo.Size = new System.Drawing.Size(193, 13);
            this.lblNoeudfo.TabIndex = 8;
            this.lblNoeudfo.Text = "Nombre de noeuds (fermés et ouverts) :";
            // 
            // txtboxNoeudfo
            // 
            this.txtboxNoeudfo.Enabled = false;
            this.txtboxNoeudfo.Location = new System.Drawing.Point(12, 192);
            this.txtboxNoeudfo.Name = "txtboxNoeudfo";
            this.txtboxNoeudfo.Size = new System.Drawing.Size(100, 20);
            this.txtboxNoeudfo.TabIndex = 9;
            // 
            // lblArbre
            // 
            this.lblArbre.AutoSize = true;
            this.lblArbre.Location = new System.Drawing.Point(15, 223);
            this.lblArbre.Name = "lblArbre";
            this.lblArbre.Size = new System.Drawing.Size(100, 13);
            this.lblArbre.TabIndex = 10;
            this.lblArbre.Text = "Arbre des chemins :";
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.lblArbre);
            this.Controls.Add(this.txtboxNoeudfo);
            this.Controls.Add(this.lblNoeudfo);
            this.Controls.Add(this.txtboxNoeudf);
            this.Controls.Add(this.lblNoeudf);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.pboxArbre);
            this.Controls.Add(this.txtboxTemps);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAffichage";
            this.Text = "Affichage des résultats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArbre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.TextBox txtboxTemps;
        private System.Windows.Forms.PictureBox pboxArbre;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblNoeudf;
        private System.Windows.Forms.TextBox txtboxNoeudf;
        private System.Windows.Forms.Label lblNoeudfo;
        private System.Windows.Forms.TextBox txtboxNoeudfo;
        private System.Windows.Forms.Label lblArbre;
    }
}

