namespace RequestManager.Views
{
    partial class RequestManagerView
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cmbStatut = new System.Windows.Forms.ComboBox();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.cmbPriorite = new System.Windows.Forms.ComboBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSauver = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblFiltres = new System.Windows.Forms.Label();
            this.lbl2Statut = new System.Windows.Forms.Label();
            this.cmb2Statut = new System.Windows.Forms.ComboBox();
            this.lblNDemande = new System.Windows.Forms.Label();
            this.txtNDemande = new System.Windows.Forms.TextBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(13, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 17);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(16, 51);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(100, 22);
            this.txtTitre.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(151, 30);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(79, 17);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(154, 51);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(339, 134);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(500, 30);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(45, 17);
            this.lblStatut.TabIndex = 4;
            this.lblStatut.Text = "Statut";
            // 
            // cmbStatut
            // 
            this.cmbStatut.FormattingEnabled = true;
            this.cmbStatut.Location = new System.Drawing.Point(503, 47);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(121, 24);
            this.cmbStatut.TabIndex = 5;
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Location = new System.Drawing.Point(631, 30);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(53, 17);
            this.lblPriorite.TabIndex = 6;
            this.lblPriorite.Text = "Priorité";
            // 
            // cmbPriorite
            // 
            this.cmbPriorite.FormattingEnabled = true;
            this.cmbPriorite.Location = new System.Drawing.Point(634, 47);
            this.cmbPriorite.Name = "cmbPriorite";
            this.cmbPriorite.Size = new System.Drawing.Size(121, 24);
            this.cmbPriorite.TabIndex = 7;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(650, 104);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(104, 23);
            this.btnNouveau.TabIndex = 8;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnSauver
            // 
            this.btnSauver.Location = new System.Drawing.Point(650, 133);
            this.btnSauver.Name = "btnSauver";
            this.btnSauver.Size = new System.Drawing.Size(104, 23);
            this.btnSauver.TabIndex = 9;
            this.btnSauver.Text = "Sauver";
            this.btnSauver.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(650, 162);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(104, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblFiltres
            // 
            this.lblFiltres.AutoSize = true;
            this.lblFiltres.Location = new System.Drawing.Point(16, 219);
            this.lblFiltres.Name = "lblFiltres";
            this.lblFiltres.Size = new System.Drawing.Size(46, 17);
            this.lblFiltres.TabIndex = 11;
            this.lblFiltres.Text = "Filtres";
            // 
            // lbl2Statut
            // 
            this.lbl2Statut.AutoSize = true;
            this.lbl2Statut.Location = new System.Drawing.Point(34, 236);
            this.lbl2Statut.Name = "lbl2Statut";
            this.lbl2Statut.Size = new System.Drawing.Size(45, 17);
            this.lbl2Statut.TabIndex = 12;
            this.lbl2Statut.Text = "Statut";
            // 
            // cmb2Statut
            // 
            this.cmb2Statut.FormattingEnabled = true;
            this.cmb2Statut.Location = new System.Drawing.Point(37, 256);
            this.cmb2Statut.Name = "cmb2Statut";
            this.cmb2Statut.Size = new System.Drawing.Size(121, 24);
            this.cmb2Statut.TabIndex = 13;
            // 
            // lblNDemande
            // 
            this.lblNDemande.AutoSize = true;
            this.lblNDemande.Location = new System.Drawing.Point(185, 236);
            this.lblNDemande.Name = "lblNDemande";
            this.lblNDemande.Size = new System.Drawing.Size(156, 17);
            this.lblNDemande.TabIndex = 14;
            this.lblNDemande.Text = "Numéro de la demande";
            // 
            // txtNDemande
            // 
            this.txtNDemande.Location = new System.Drawing.Point(188, 258);
            this.txtNDemande.Name = "txtNDemande";
            this.txtNDemande.Size = new System.Drawing.Size(132, 22);
            this.txtNDemande.TabIndex = 15;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(19, 287);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.RowTemplate.Height = 24;
            this.dgvRequests.Size = new System.Drawing.Size(735, 150);
            this.dgvRequests.TabIndex = 16;
            // 
            // RequestManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.txtNDemande);
            this.Controls.Add(this.lblNDemande);
            this.Controls.Add(this.cmb2Statut);
            this.Controls.Add(this.lbl2Statut);
            this.Controls.Add(this.lblFiltres);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnSauver);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.cmbPriorite);
            this.Controls.Add(this.lblPriorite);
            this.Controls.Add(this.cmbStatut);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblTitre);
            this.Name = "RequestManagerView";
            this.Text = "RequestManagerView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cmbStatut;
        private System.Windows.Forms.Label lblPriorite;
        private System.Windows.Forms.ComboBox cmbPriorite;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSauver;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblFiltres;
        private System.Windows.Forms.Label lbl2Statut;
        private System.Windows.Forms.ComboBox cmb2Statut;
        private System.Windows.Forms.Label lblNDemande;
        private System.Windows.Forms.TextBox txtNDemande;
        private System.Windows.Forms.DataGridView dgvRequests;
    }
}