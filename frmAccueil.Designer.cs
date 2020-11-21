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
            this.lblDirection1 = new System.Windows.Forms.Label();
            this.lblVitesse1 = new System.Windows.Forms.Label();
            this.txtboxDirection1 = new System.Windows.Forms.TextBox();
            this.txtboxVitesse1 = new System.Windows.Forms.TextBox();
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
            this.rdbtnOui = new System.Windows.Forms.RadioButton();
            this.rdbtnNon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVitesse2 = new System.Windows.Forms.Label();
            this.lblDirection2 = new System.Windows.Forms.Label();
            this.txtboxVitesse2 = new System.Windows.Forms.TextBox();
            this.txtboxDirection2 = new System.Windows.Forms.TextBox();
            this.lblYinf = new System.Windows.Forms.Label();
            this.lblYsup = new System.Windows.Forms.Label();
            this.txtboxYinf = new System.Windows.Forms.TextBox();
            this.txtboxYsup = new System.Windows.Forms.TextBox();
            this.gboxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInfo
            // 
            this.gboxInfo.Controls.Add(this.txtboxYsup);
            this.gboxInfo.Controls.Add(this.txtboxYinf);
            this.gboxInfo.Controls.Add(this.lblYsup);
            this.gboxInfo.Controls.Add(this.lblYinf);
            this.gboxInfo.Controls.Add(this.txtboxDirection2);
            this.gboxInfo.Controls.Add(this.txtboxVitesse2);
            this.gboxInfo.Controls.Add(this.lblDirection2);
            this.gboxInfo.Controls.Add(this.lblVitesse2);
            this.gboxInfo.Controls.Add(this.label1);
            this.gboxInfo.Controls.Add(this.rdbtnNon);
            this.gboxInfo.Controls.Add(this.rdbtnOui);
            this.gboxInfo.Controls.Add(this.btnValider);
            this.gboxInfo.Controls.Add(this.lblDirection1);
            this.gboxInfo.Controls.Add(this.lblVitesse1);
            this.gboxInfo.Controls.Add(this.txtboxDirection1);
            this.gboxInfo.Controls.Add(this.txtboxVitesse1);
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
            this.gboxInfo.Size = new System.Drawing.Size(662, 433);
            this.gboxInfo.TabIndex = 0;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Informations de voyage";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(472, 389);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblDirection1
            // 
            this.lblDirection1.AutoSize = true;
            this.lblDirection1.Location = new System.Drawing.Point(27, 306);
            this.lblDirection1.Name = "lblDirection1";
            this.lblDirection1.Size = new System.Drawing.Size(116, 13);
            this.lblDirection1.TabIndex = 13;
            this.lblDirection1.Text = "Direction du vent en ° :";
            this.lblDirection1.Visible = false;
            // 
            // lblVitesse1
            // 
            this.lblVitesse1.AutoSize = true;
            this.lblVitesse1.Location = new System.Drawing.Point(27, 271);
            this.lblVitesse1.Name = "lblVitesse1";
            this.lblVitesse1.Size = new System.Drawing.Size(129, 13);
            this.lblVitesse1.TabIndex = 12;
            this.lblVitesse1.Text = "Vitesse du vent en km/h :";
            this.lblVitesse1.Visible = false;
            // 
            // txtboxDirection1
            // 
            this.txtboxDirection1.Location = new System.Drawing.Point(171, 303);
            this.txtboxDirection1.Name = "txtboxDirection1";
            this.txtboxDirection1.Size = new System.Drawing.Size(100, 20);
            this.txtboxDirection1.TabIndex = 11;
            this.txtboxDirection1.Visible = false;
            // 
            // txtboxVitesse1
            // 
            this.txtboxVitesse1.Location = new System.Drawing.Point(171, 268);
            this.txtboxVitesse1.Name = "txtboxVitesse1";
            this.txtboxVitesse1.Size = new System.Drawing.Size(100, 20);
            this.txtboxVitesse1.TabIndex = 10;
            this.txtboxVitesse1.Visible = false;
            // 
            // txtboxOrdFin
            // 
            this.txtboxOrdFin.Location = new System.Drawing.Point(373, 99);
            this.txtboxOrdFin.Name = "txtboxOrdFin";
            this.txtboxOrdFin.Size = new System.Drawing.Size(100, 20);
            this.txtboxOrdFin.TabIndex = 9;
            // 
            // txtboxAbsFin
            // 
            this.txtboxAbsFin.Location = new System.Drawing.Point(373, 64);
            this.txtboxAbsFin.Name = "txtboxAbsFin";
            this.txtboxAbsFin.Size = new System.Drawing.Size(100, 20);
            this.txtboxAbsFin.TabIndex = 8;
            // 
            // txtboxOrdInit
            // 
            this.txtboxOrdInit.Location = new System.Drawing.Point(91, 103);
            this.txtboxOrdInit.Name = "txtboxOrdInit";
            this.txtboxOrdInit.Size = new System.Drawing.Size(100, 20);
            this.txtboxOrdInit.TabIndex = 7;
            // 
            // txtboxAbsInit
            // 
            this.txtboxAbsInit.Location = new System.Drawing.Point(91, 64);
            this.txtboxAbsInit.Name = "txtboxAbsInit";
            this.txtboxAbsInit.Size = new System.Drawing.Size(100, 20);
            this.txtboxAbsInit.TabIndex = 6;
            // 
            // lblOrdFin
            // 
            this.lblOrdFin.AutoSize = true;
            this.lblOrdFin.Location = new System.Drawing.Point(309, 102);
            this.lblOrdFin.Name = "lblOrdFin";
            this.lblOrdFin.Size = new System.Drawing.Size(63, 13);
            this.lblOrdFin.TabIndex = 5;
            this.lblOrdFin.Text = "Ordonnee : ";
            // 
            // lblAbsFin
            // 
            this.lblAbsFin.AutoSize = true;
            this.lblAbsFin.Location = new System.Drawing.Point(309, 67);
            this.lblAbsFin.Name = "lblAbsFin";
            this.lblAbsFin.Size = new System.Drawing.Size(58, 13);
            this.lblAbsFin.TabIndex = 4;
            this.lblAbsFin.Text = "Abscisse : ";
            // 
            // lblOrdInit
            // 
            this.lblOrdInit.AutoSize = true;
            this.lblOrdInit.Location = new System.Drawing.Point(25, 106);
            this.lblOrdInit.Name = "lblOrdInit";
            this.lblOrdInit.Size = new System.Drawing.Size(60, 13);
            this.lblOrdInit.TabIndex = 3;
            this.lblOrdInit.Text = "Ordonnee :";
            // 
            // lblAbsInit
            // 
            this.lblAbsInit.AutoSize = true;
            this.lblAbsInit.Location = new System.Drawing.Point(25, 71);
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
            // rdbtnOui
            // 
            this.rdbtnOui.AutoSize = true;
            this.rdbtnOui.Location = new System.Drawing.Point(205, 156);
            this.rdbtnOui.Name = "rdbtnOui";
            this.rdbtnOui.Size = new System.Drawing.Size(41, 17);
            this.rdbtnOui.TabIndex = 15;
            this.rdbtnOui.TabStop = true;
            this.rdbtnOui.Text = "Oui";
            this.rdbtnOui.UseVisualStyleBackColor = true;
            // 
            // rdbtnNon
            // 
            this.rdbtnNon.AutoSize = true;
            this.rdbtnNon.Location = new System.Drawing.Point(312, 156);
            this.rdbtnNon.Name = "rdbtnNon";
            this.rdbtnNon.Size = new System.Drawing.Size(45, 17);
            this.rdbtnNon.TabIndex = 16;
            this.rdbtnNon.TabStop = true;
            this.rdbtnNon.Text = "Non";
            this.rdbtnNon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Influence du vent sur y :";
            // 
            // lblVitesse2
            // 
            this.lblVitesse2.AutoSize = true;
            this.lblVitesse2.Location = new System.Drawing.Point(408, 271);
            this.lblVitesse2.Name = "lblVitesse2";
            this.lblVitesse2.Size = new System.Drawing.Size(129, 13);
            this.lblVitesse2.TabIndex = 18;
            this.lblVitesse2.Text = "Vitesse du vent en km/h :";
            this.lblVitesse2.Visible = false;
            // 
            // lblDirection2
            // 
            this.lblDirection2.AutoSize = true;
            this.lblDirection2.Location = new System.Drawing.Point(408, 306);
            this.lblDirection2.Name = "lblDirection2";
            this.lblDirection2.Size = new System.Drawing.Size(116, 13);
            this.lblDirection2.TabIndex = 19;
            this.lblDirection2.Text = "Direction du vent en ° :";
            this.lblDirection2.Visible = false;
            // 
            // txtboxVitesse2
            // 
            this.txtboxVitesse2.Location = new System.Drawing.Point(556, 268);
            this.txtboxVitesse2.Name = "txtboxVitesse2";
            this.txtboxVitesse2.Size = new System.Drawing.Size(100, 20);
            this.txtboxVitesse2.TabIndex = 20;
            this.txtboxVitesse2.Visible = false;
            // 
            // txtboxDirection2
            // 
            this.txtboxDirection2.Location = new System.Drawing.Point(556, 303);
            this.txtboxDirection2.Name = "txtboxDirection2";
            this.txtboxDirection2.Size = new System.Drawing.Size(100, 20);
            this.txtboxDirection2.TabIndex = 21;
            this.txtboxDirection2.Visible = false;
            // 
            // lblYinf
            // 
            this.lblYinf.AutoSize = true;
            this.lblYinf.Location = new System.Drawing.Point(27, 230);
            this.lblYinf.Name = "lblYinf";
            this.lblYinf.Size = new System.Drawing.Size(92, 13);
            this.lblYinf.TabIndex = 22;
            this.lblYinf.Text = "Pour y inférieur à :";
            this.lblYinf.Visible = false;
            // 
            // lblYsup
            // 
            this.lblYsup.AutoSize = true;
            this.lblYsup.Location = new System.Drawing.Point(408, 230);
            this.lblYsup.Name = "lblYsup";
            this.lblYsup.Size = new System.Drawing.Size(98, 13);
            this.lblYsup.TabIndex = 23;
            this.lblYsup.Text = "Pour y supérieur à :";
            this.lblYsup.Visible = false;
            // 
            // txtboxYinf
            // 
            this.txtboxYinf.Location = new System.Drawing.Point(125, 227);
            this.txtboxYinf.Name = "txtboxYinf";
            this.txtboxYinf.Size = new System.Drawing.Size(52, 20);
            this.txtboxYinf.TabIndex = 24;
            this.txtboxYinf.Visible = false;
            // 
            // txtboxYsup
            // 
            this.txtboxYsup.Location = new System.Drawing.Point(512, 227);
            this.txtboxYsup.Name = "txtboxYsup";
            this.txtboxYsup.Size = new System.Drawing.Size(52, 20);
            this.txtboxYsup.TabIndex = 25;
            this.txtboxYsup.Visible = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(696, 468);
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
        private System.Windows.Forms.TextBox txtboxDirection1;
        private System.Windows.Forms.TextBox txtboxVitesse1;
        private System.Windows.Forms.TextBox txtboxOrdFin;
        private System.Windows.Forms.TextBox txtboxAbsFin;
        private System.Windows.Forms.TextBox txtboxOrdInit;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblDirection1;
        private System.Windows.Forms.Label lblVitesse1;
        private System.Windows.Forms.Label lblDirection2;
        private System.Windows.Forms.Label lblVitesse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnNon;
        private System.Windows.Forms.RadioButton rdbtnOui;
        private System.Windows.Forms.TextBox txtboxVitesse2;
        private System.Windows.Forms.TextBox txtboxYsup;
        private System.Windows.Forms.TextBox txtboxYinf;
        private System.Windows.Forms.Label lblYsup;
        private System.Windows.Forms.Label lblYinf;
        private System.Windows.Forms.TextBox txtboxDirection2;
    }
}