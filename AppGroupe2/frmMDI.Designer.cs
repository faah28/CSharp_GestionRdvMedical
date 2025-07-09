namespace AppGroupe2
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.btnPatient = new Guna.UI2.WinForms.Guna2Button();
            this.Pn_left = new Guna.UI2.WinForms.Guna2Panel();
            this.btnParametre = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlanification = new Guna.UI2.WinForms.Guna2Button();
            this.btnActions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUtilisateur = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeDeconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRv = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedecin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pn_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Pn_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Animated = true;
            this.btnPatient.AutoRoundedCorners = true;
            this.btnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatient.FillColor = System.Drawing.Color.White;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatient.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPatient.Location = new System.Drawing.Point(23, 347);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(243, 45);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // Pn_left
            // 
            this.Pn_left.Controls.Add(this.pn_top);
            this.Pn_left.Controls.Add(this.btnParametre);
            this.Pn_left.Controls.Add(this.btnPlanification);
            this.Pn_left.Controls.Add(this.btnActions);
            this.Pn_left.Controls.Add(this.btnUtilisateur);
            this.Pn_left.Controls.Add(this.btnQuitter);
            this.Pn_left.Controls.Add(this.btnSeDeconnecter);
            this.Pn_left.Controls.Add(this.pictureBox1);
            this.Pn_left.Controls.Add(this.btnRv);
            this.Pn_left.Controls.Add(this.btnMedecin);
            this.Pn_left.Controls.Add(this.btnPatient);
            this.Pn_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_left.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pn_left.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn_left.Location = new System.Drawing.Point(0, 0);
            this.Pn_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pn_left.Name = "Pn_left";
            this.Pn_left.Size = new System.Drawing.Size(784, 684);
            this.Pn_left.TabIndex = 3;
            this.Pn_left.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_left_Paint);
            // 
            // btnParametre
            // 
            this.btnParametre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParametre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParametre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParametre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParametre.FillColor = System.Drawing.Color.White;
            this.btnParametre.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnParametre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParametre.Location = new System.Drawing.Point(3, 526);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(154, 45);
            this.btnParametre.TabIndex = 13;
            this.btnParametre.Text = "Paramétres";
            // 
            // btnPlanification
            // 
            this.btnPlanification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlanification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlanification.FillColor = System.Drawing.Color.White;
            this.btnPlanification.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPlanification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlanification.Location = new System.Drawing.Point(3, 296);
            this.btnPlanification.Name = "btnPlanification";
            this.btnPlanification.Size = new System.Drawing.Size(158, 45);
            this.btnPlanification.TabIndex = 12;
            this.btnPlanification.Text = "Planification";
            // 
            // btnActions
            // 
            this.btnActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActions.FillColor = System.Drawing.Color.White;
            this.btnActions.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnActions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActions.Location = new System.Drawing.Point(3, 164);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(109, 45);
            this.btnActions.TabIndex = 11;
            this.btnActions.Text = "Actions";
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Animated = true;
            this.btnUtilisateur.AutoRoundedCorners = true;
            this.btnUtilisateur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUtilisateur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUtilisateur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUtilisateur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUtilisateur.FillColor = System.Drawing.Color.White;
            this.btnUtilisateur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilisateur.Image")));
            this.btnUtilisateur.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUtilisateur.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUtilisateur.Location = new System.Drawing.Point(23, 226);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(243, 45);
            this.btnUtilisateur.TabIndex = 10;
            this.btnUtilisateur.Text = "Utilisateur";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Animated = true;
            this.btnQuitter.AutoRoundedCorners = true;
            this.btnQuitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitter.FillColor = System.Drawing.Color.White;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnQuitter.Location = new System.Drawing.Point(23, 627);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(243, 45);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Animated = true;
            this.btnSeDeconnecter.AutoRoundedCorners = true;
            this.btnSeDeconnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeDeconnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeDeconnecter.FillColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSeDeconnecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSeDeconnecter.Location = new System.Drawing.Point(23, 577);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(243, 45);
            this.btnSeDeconnecter.TabIndex = 6;
            this.btnSeDeconnecter.Text = "&Se Deconnecter";
            this.btnSeDeconnecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRv
            // 
            this.btnRv.Animated = true;
            this.btnRv.AutoRoundedCorners = true;
            this.btnRv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRv.FillColor = System.Drawing.Color.White;
            this.btnRv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRv.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRv.Image = ((System.Drawing.Image)(resources.GetObject("btnRv.Image")));
            this.btnRv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRv.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRv.Location = new System.Drawing.Point(23, 458);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(243, 45);
            this.btnRv.TabIndex = 2;
            this.btnRv.Tag = "  ";
            this.btnRv.Text = "      Rendez-vous";
            // 
            // btnMedecin
            // 
            this.btnMedecin.Animated = true;
            this.btnMedecin.AutoRoundedCorners = true;
            this.btnMedecin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedecin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedecin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedecin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedecin.FillColor = System.Drawing.Color.White;
            this.btnMedecin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedecin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMedecin.Image = ((System.Drawing.Image)(resources.GetObject("btnMedecin.Image")));
            this.btnMedecin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedecin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMedecin.Location = new System.Drawing.Point(23, 398);
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(243, 45);
            this.btnMedecin.TabIndex = 1;
            this.btnMedecin.Text = "Medecin";
            this.btnMedecin.Click += new System.EventHandler(this.btnMedecin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 636);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.pn_top.Controls.Add(this.btnMax);
            this.pn_top.Controls.Add(this.guna2ControlBox1);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(784, 42);
            this.pn_top.TabIndex = 21;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.White;
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.White;
            this.btnMax.IconColor = System.Drawing.Color.DimGray;
            this.btnMax.Location = new System.Drawing.Point(685, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 29);
            this.btnMax.TabIndex = 21;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(736, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 684);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pn_left);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.Pn_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPatient;
        private Guna.UI2.WinForms.Guna2Panel Pn_left;
        private Guna.UI2.WinForms.Guna2Button btnMedecin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnRv;
        private Guna.UI2.WinForms.Guna2Button btnQuitter;
        private Guna.UI2.WinForms.Guna2Button btnSeDeconnecter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnUtilisateur;
        private Guna.UI2.WinForms.Guna2Button btnParametre;
        private Guna.UI2.WinForms.Guna2Button btnPlanification;
        private Guna.UI2.WinForms.Guna2Button btnActions;
        private Guna.UI2.WinForms.Guna2Panel pn_top;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}