namespace ProjetIAv0
{
    partial class frmAccueil
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
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblVitesse = new System.Windows.Forms.Label();
            this.txtboxDirection = new System.Windows.Forms.TextBox();
            this.txtboxVitesse = new System.Windows.Forms.TextBox();
            this.txtboxOrdFin = new System.Windows.Forms.TextBox();
            this.txtboxAbsFin = new System.Windows.Forms.TextBox();
            this.txtboxOrdInit = new System.Windows.Forms.TextBox();
            this.txtboxAbsInit = new System.Windows.Forms.TextBox();
            this.lblOrdFin = new System.Windows.Forms.Label();
            this.lblAbsFin = new System.Windows.Forms.Label();
            this.lblOrdInit = new System.Windows.Forms.Label();
            this.lblAbsInit = new System.Windows.Forms.Label();
            this.lblCoordsFin = new System.Windows.Forms.Label();
            this.lblCoordsInit = new System.Windows.Forms.Label();
            this.gboxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInfo
            // 
            this.gboxInfo.Controls.Add(this.btnValider);
            this.gboxInfo.Controls.Add(this.lblDirection);
            this.gboxInfo.Controls.Add(this.lblVitesse);
            this.gboxInfo.Controls.Add(this.txtboxDirection);
            this.gboxInfo.Controls.Add(this.txtboxVitesse);
            this.gboxInfo.Controls.Add(this.txtboxOrdFin);
            this.gboxInfo.Controls.Add(this.txtboxAbsFin);
            this.gboxInfo.Controls.Add(this.txtboxOrdInit);
            this.gboxInfo.Controls.Add(this.txtboxAbsInit);
            this.gboxInfo.Controls.Add(this.lblOrdFin);
            this.gboxInfo.Controls.Add(this.lblAbsFin);
            this.gboxInfo.Controls.Add(this.lblOrdInit);
            this.gboxInfo.Controls.Add(this.lblAbsInit);
            this.gboxInfo.Controls.Add(this.lblCoordsFin);
            this.gboxInfo.Controls.Add(this.lblCoordsInit);
            this.gboxInfo.Location = new System.Drawing.Point(22, 23);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Size = new System.Drawing.Size(536, 365);
            this.gboxInfo.TabIndex = 0;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Informations de voyage";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(373, 318);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(25, 237);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(116, 13);
            this.lblDirection.TabIndex = 13;
            this.lblDirection.Text = "Direction du vent en ° :";
            // 
            // lblVitesse
            // 
            this.lblVitesse.AutoSize = true;
            this.lblVitesse.Location = new System.Drawing.Point(25, 186);
            this.lblVitesse.Name = "lblVitesse";
            this.lblVitesse.Size = new System.Drawing.Size(129, 13);
            this.lblVitesse.TabIndex = 12;
            this.lblVitesse.Text = "Vitesse du vent en km/h :";
            // 
            // txtboxDirection
            // 
            this.txtboxDirection.Location = new System.Drawing.Point(205, 234);
            this.txtboxDirection.Name = "txtboxDirection";
            this.txtboxDirection.Size = new System.Drawing.Size(100, 20);
            this.txtboxDirection.TabIndex = 11;
            // 
            // txtboxVitesse
            // 
            this.txtboxVitesse.Location = new System.Drawing.Point(205, 183);
            this.txtboxVitesse.Name = "txtboxVitesse";
            this.txtboxVitesse.Size = new System.Drawing.Size(100, 20);
            this.txtboxVitesse.TabIndex = 10;
            // 
            // txtboxOrdFin
            // 
            this.txtboxOrdFin.Location = new System.Drawing.Point(373, 106);
            this.txtboxOrdFin.Name = "txtboxOrdFin";
            this.txtboxOrdFin.Size = new System.Drawing.Size(100, 20);
            this.txtboxOrdFin.TabIndex = 9;
            // 
            // txtboxAbsFin
            // 
            this.txtboxAbsFin.Location = new System.Drawing.Point(373, 71);
            this.txtboxAbsFin.Name = "txtboxAbsFin";
            this.txtboxAbsFin.Size = new System.Drawing.Size(100, 20);
            this.txtboxAbsFin.TabIndex = 8;
            // 
            // txtboxOrdInit
            // 
            this.txtboxOrdInit.Location = new System.Drawing.Point(91, 106);
            this.txtboxOrdInit.Name = "txtboxOrdInit";
            this.txtboxOrdInit.Size = new System.Drawing.Size(100, 20);
            this.txtboxOrdInit.TabIndex = 7;
            // 
            // txtboxAbsInit
            // 
            this.txtboxAbsInit.Location = new System.Drawing.Point(91, 71);
            this.txtboxAbsInit.Name = "txtboxAbsInit";
            this.txtboxAbsInit.Size = new System.Drawing.Size(100, 20);
            this.txtboxAbsInit.TabIndex = 6;
            // 
            // lblOrdFin
            // 
            this.lblOrdFin.AutoSize = true;
            this.lblOrdFin.Location = new System.Drawing.Point(309, 109);
            this.lblOrdFin.Name = "lblOrdFin";
            this.lblOrdFin.Size = new System.Drawing.Size(63, 13);
            this.lblOrdFin.TabIndex = 5;
            this.lblOrdFin.Text = "Ordonnee : ";
            // 
            // lblAbsFin
            // 
            this.lblAbsFin.AutoSize = true;
            this.lblAbsFin.Location = new System.Drawing.Point(309, 74);
            this.lblAbsFin.Name = "lblAbsFin";
            this.lblAbsFin.Size = new System.Drawing.Size(58, 13);
            this.lblAbsFin.TabIndex = 4;
            this.lblAbsFin.Text = "Abscisse : ";
            // 
            // lblOrdInit
            // 
            this.lblOrdInit.AutoSize = true;
            this.lblOrdInit.Location = new System.Drawing.Point(25, 109);
            this.lblOrdInit.Name = "lblOrdInit";
            this.lblOrdInit.Size = new System.Drawing.Size(60, 13);
            this.lblOrdInit.TabIndex = 3;
            this.lblOrdInit.Text = "Ordonnee :";
            // 
            // lblAbsInit
            // 
            this.lblAbsInit.AutoSize = true;
            this.lblAbsInit.Location = new System.Drawing.Point(25, 74);
            this.lblAbsInit.Name = "lblAbsInit";
            this.lblAbsInit.Size = new System.Drawing.Size(55, 13);
            this.lblAbsInit.TabIndex = 2;
            this.lblAbsInit.Text = "Abscisse :";
            // 
            // lblCoordsFin
            // 
            this.lblCoordsFin.AutoSize = true;
            this.lblCoordsFin.Location = new System.Drawing.Point(309, 29);
            this.lblCoordsFin.Name = "lblCoordsFin";
            this.lblCoordsFin.Size = new System.Drawing.Size(113, 13);
            this.lblCoordsFin.TabIndex = 1;
            this.lblCoordsFin.Text = "Coordonnées d\'arrivée";
            // 
            // lblCoordsInit
            // 
            this.lblCoordsInit.AutoSize = true;
            this.lblCoordsInit.Location = new System.Drawing.Point(25, 29);
            this.lblCoordsInit.Name = "lblCoordsInit";
            this.lblCoordsInit.Size = new System.Drawing.Size(118, 13);
            this.lblCoordsInit.TabIndex = 0;
            this.lblCoordsInit.Text = "Coordonnées de départ";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.gboxInfo);
            this.Name = "frmAccueil";
            this.Text = "Informations pour la navigation";
            this.gboxInfo.ResumeLayout(false);
            this.gboxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.TextBox txtboxAbsInit;
        private System.Windows.Forms.Label lblOrdFin;
        private System.Windows.Forms.Label lblAbsFin;
        private System.Windows.Forms.Label lblOrdInit;
        private System.Windows.Forms.Label lblAbsInit;
        private System.Windows.Forms.Label lblCoordsFin;
        private System.Windows.Forms.Label lblCoordsInit;
        private System.Windows.Forms.TextBox txtboxDirection;
        private System.Windows.Forms.TextBox txtboxVitesse;
        private System.Windows.Forms.TextBox txtboxOrdFin;
        private System.Windows.Forms.TextBox txtboxAbsFin;
        private System.Windows.Forms.TextBox txtboxOrdInit;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblVitesse;
    }
}