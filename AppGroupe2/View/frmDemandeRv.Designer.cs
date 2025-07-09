namespace AppGroupe2.View
{
    partial class frmDemandeRv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemandeRv));
            this.lblCreneau = new System.Windows.Forms.Label();
            this.dgCreneau = new System.Windows.Forms.DataGridView();
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.lblListeMedecin = new System.Windows.Forms.Label();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgListeAgenda = new System.Windows.Forms.DataGridView();
            this.lblListeAgendaMedecin = new System.Windows.Forms.Label();
            this.btnVoirCreneau = new System.Windows.Forms.Button();
            this.pnBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbQuitter = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.txtNumeroRecu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRefPayement = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPayement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCout = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSoin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSpecialite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNomPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreneau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeAgenda)).BeginInit();
            this.pnBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreneau
            // 
            this.lblCreneau.AutoSize = true;
            this.lblCreneau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreneau.Location = new System.Drawing.Point(463, 88);
            this.lblCreneau.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblCreneau.Name = "lblCreneau";
            this.lblCreneau.Size = new System.Drawing.Size(95, 25);
            this.lblCreneau.TabIndex = 94;
            this.lblCreneau.Text = "Creneau";
            this.lblCreneau.Click += new System.EventHandler(this.lblCreneau_Click);
            // 
            // dgCreneau
            // 
            this.dgCreneau.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgCreneau.ColumnHeadersHeight = 34;
            this.dgCreneau.Location = new System.Drawing.Point(468, 122);
            this.dgCreneau.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dgCreneau.Name = "dgCreneau";
            this.dgCreneau.RowHeadersWidth = 62;
            this.dgCreneau.Size = new System.Drawing.Size(351, 729);
            this.dgCreneau.TabIndex = 93;
            // 
            // dgMedecin
            // 
            this.dgMedecin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgMedecin.ColumnHeadersHeight = 34;
            this.dgMedecin.Location = new System.Drawing.Point(905, 136);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.RowHeadersWidth = 62;
            this.dgMedecin.Size = new System.Drawing.Size(807, 222);
            this.dgMedecin.TabIndex = 109;
            this.dgMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // lblListeMedecin
            // 
            this.lblListeMedecin.AutoSize = true;
            this.lblListeMedecin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeMedecin.Location = new System.Drawing.Point(924, 122);
            this.lblListeMedecin.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblListeMedecin.Name = "lblListeMedecin";
            this.lblListeMedecin.Size = new System.Drawing.Size(190, 28);
            this.lblListeMedecin.TabIndex = 110;
            this.lblListeMedecin.Text = "Liste des Medecins";
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectionner.Location = new System.Drawing.Point(1570, 76);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(142, 52);
            this.btnSelectionner.TabIndex = 111;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dgListeAgenda
            // 
            this.dgListeAgenda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListeAgenda.ColumnHeadersHeight = 34;
            this.dgListeAgenda.Location = new System.Drawing.Point(905, 511);
            this.dgListeAgenda.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dgListeAgenda.Name = "dgListeAgenda";
            this.dgListeAgenda.RowHeadersWidth = 62;
            this.dgListeAgenda.Size = new System.Drawing.Size(807, 222);
            this.dgListeAgenda.TabIndex = 112;
            // 
            // lblListeAgendaMedecin
            // 
            this.lblListeAgendaMedecin.AutoSize = true;
            this.lblListeAgendaMedecin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeAgendaMedecin.Location = new System.Drawing.Point(924, 502);
            this.lblListeAgendaMedecin.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblListeAgendaMedecin.Name = "lblListeAgendaMedecin";
            this.lblListeAgendaMedecin.Size = new System.Drawing.Size(171, 28);
            this.lblListeAgendaMedecin.TabIndex = 113;
            this.lblListeAgendaMedecin.Text = "Agenda Medecin";
            this.lblListeAgendaMedecin.Click += new System.EventHandler(this.lblListeAgendaMedecin_Click);
            // 
            // btnVoirCreneau
            // 
            this.btnVoirCreneau.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoirCreneau.Location = new System.Drawing.Point(1570, 443);
            this.btnVoirCreneau.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnVoirCreneau.Name = "btnVoirCreneau";
            this.btnVoirCreneau.Size = new System.Drawing.Size(142, 52);
            this.btnVoirCreneau.TabIndex = 114;
            this.btnVoirCreneau.Text = "Voir Creneau";
            this.btnVoirCreneau.UseVisualStyleBackColor = false;
            this.btnVoirCreneau.Click += new System.EventHandler(this.btnVoirCreneau_Click);
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnBar.Controls.Add(this.guna2ControlBox2);
            this.pnBar.Controls.Add(this.cbQuitter);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1732, 52);
            this.pnBar.TabIndex = 115;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1587, 5);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(52, 43);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // cbQuitter
            // 
            this.cbQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuitter.FillColor = System.Drawing.Color.White;
            this.cbQuitter.IconColor = System.Drawing.Color.Red;
            this.cbQuitter.Location = new System.Drawing.Point(1660, 5);
            this.cbQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbQuitter.Name = "cbQuitter";
            this.cbQuitter.Size = new System.Drawing.Size(52, 43);
            this.cbQuitter.TabIndex = 8;
            this.cbQuitter.Click += new System.EventHandler(this.cbQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BorderRadius = 8;
            this.btnSupprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupprimer.FillColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(228, 779);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(149, 46);
            this.btnSupprimer.TabIndex = 140;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BorderRadius = 8;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(47, 779);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(138, 46);
            this.btnAjouter.TabIndex = 139;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_2);
            // 
            // txtNumeroRecu
            // 
            this.txtNumeroRecu.Animated = true;
            this.txtNumeroRecu.BackColor = System.Drawing.Color.White;
            this.txtNumeroRecu.BorderRadius = 8;
            this.txtNumeroRecu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroRecu.DefaultText = "";
            this.txtNumeroRecu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroRecu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroRecu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroRecu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroRecu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroRecu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroRecu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroRecu.Location = new System.Drawing.Point(17, 704);
            this.txtNumeroRecu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumeroRecu.Name = "txtNumeroRecu";
            this.txtNumeroRecu.PlaceholderText = "";
            this.txtNumeroRecu.SelectedText = "";
            this.txtNumeroRecu.Size = new System.Drawing.Size(413, 45);
            this.txtNumeroRecu.TabIndex = 138;
            // 
            // txtRefPayement
            // 
            this.txtRefPayement.Animated = true;
            this.txtRefPayement.BackColor = System.Drawing.Color.White;
            this.txtRefPayement.BorderRadius = 8;
            this.txtRefPayement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefPayement.DefaultText = "";
            this.txtRefPayement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefPayement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRefPayement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefPayement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefPayement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefPayement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtRefPayement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefPayement.Location = new System.Drawing.Point(17, 613);
            this.txtRefPayement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRefPayement.Name = "txtRefPayement";
            this.txtRefPayement.PlaceholderText = "";
            this.txtRefPayement.SelectedText = "";
            this.txtRefPayement.Size = new System.Drawing.Size(413, 45);
            this.txtRefPayement.TabIndex = 137;
            // 
            // cbPayement
            // 
            this.cbPayement.BackColor = System.Drawing.Color.Transparent;
            this.cbPayement.BorderRadius = 8;
            this.cbPayement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPayement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPayement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPayement.ItemHeight = 30;
            this.cbPayement.Location = new System.Drawing.Point(15, 502);
            this.cbPayement.Margin = new System.Windows.Forms.Padding(6);
            this.cbPayement.Name = "cbPayement";
            this.cbPayement.Size = new System.Drawing.Size(411, 36);
            this.cbPayement.TabIndex = 136;
            // 
            // txtCout
            // 
            this.txtCout.Animated = true;
            this.txtCout.BackColor = System.Drawing.Color.White;
            this.txtCout.BorderRadius = 8;
            this.txtCout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCout.DefaultText = "";
            this.txtCout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCout.Location = new System.Drawing.Point(14, 411);
            this.txtCout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCout.Name = "txtCout";
            this.txtCout.PlaceholderText = "";
            this.txtCout.SelectedText = "";
            this.txtCout.Size = new System.Drawing.Size(413, 45);
            this.txtCout.TabIndex = 135;
            // 
            // cbSoin
            // 
            this.cbSoin.BackColor = System.Drawing.Color.Transparent;
            this.cbSoin.BorderRadius = 8;
            this.cbSoin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSoin.ItemHeight = 30;
            this.cbSoin.Location = new System.Drawing.Point(14, 305);
            this.cbSoin.Margin = new System.Windows.Forms.Padding(6);
            this.cbSoin.Name = "cbSoin";
            this.cbSoin.Size = new System.Drawing.Size(411, 36);
            this.cbSoin.TabIndex = 134;
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecialite.BorderRadius = 8;
            this.cbSpecialite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpecialite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSpecialite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSpecialite.ItemHeight = 30;
            this.cbSpecialite.Location = new System.Drawing.Point(14, 213);
            this.cbSpecialite.Margin = new System.Windows.Forms.Padding(6);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(411, 36);
            this.cbSpecialite.TabIndex = 133;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Animated = true;
            this.txtNomPrenom.BackColor = System.Drawing.Color.White;
            this.txtNomPrenom.BorderRadius = 8;
            this.txtNomPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPrenom.DefaultText = "";
            this.txtNomPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNomPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNomPrenom.IconLeft")));
            this.txtNomPrenom.Location = new System.Drawing.Point(15, 122);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.PlaceholderText = "";
            this.txtNomPrenom.SelectedText = "";
            this.txtNomPrenom.Size = new System.Drawing.Size(413, 45);
            this.txtNomPrenom.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 131;
            this.label2.Text = "Mode Payement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 130;
            this.label1.Text = "Soins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 664);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 129;
            this.label3.Text = "Numero Recu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 128;
            this.label4.Text = "Specialite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 127;
            this.label5.Text = "Cout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 564);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 28);
            this.label6.TabIndex = 126;
            this.label6.Text = "Reference Payement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 125;
            this.label7.Text = "Nom prenom";
            // 
            // frmDemandeRv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 888);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroRecu);
            this.Controls.Add(this.txtRefPayement);
            this.Controls.Add(this.cbPayement);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.cbSoin);
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnBar);
            this.Controls.Add(this.btnVoirCreneau);
            this.Controls.Add(this.lblListeAgendaMedecin);
            this.Controls.Add(this.dgListeAgenda);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.lblListeMedecin);
            this.Controls.Add(this.dgMedecin);
            this.Controls.Add(this.lblCreneau);
            this.Controls.Add(this.dgCreneau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDemandeRv";
            this.Text = "Demande de Rendez-vous";
            this.Load += new System.EventHandler(this.frmDemandeRv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCreneau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeAgenda)).EndInit();
            this.pnBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreneau;
        private System.Windows.Forms.DataGridView dgCreneau;
        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Label lblListeMedecin;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgListeAgenda;
        private System.Windows.Forms.Label lblListeAgendaMedecin;
        private System.Windows.Forms.Button btnVoirCreneau;
        private Guna.UI2.WinForms.Guna2Panel pnBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox cbQuitter;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroRecu;
        private Guna.UI2.WinForms.Guna2TextBox txtRefPayement;
        private Guna.UI2.WinForms.Guna2ComboBox cbPayement;
        private Guna.UI2.WinForms.Guna2TextBox txtCout;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoin;
        private Guna.UI2.WinForms.Guna2ComboBox cbSpecialite;
        private Guna.UI2.WinForms.Guna2TextBox txtNomPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}