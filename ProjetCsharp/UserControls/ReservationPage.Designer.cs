namespace ProjetCsharp.UserControls
{
    partial class ReservationPage
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.textFrais = new System.Windows.Forms.TextBox();
            this.SupBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeReservation = new System.Windows.Forms.DateTimePicker();
            this.AjoutBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.DataGridViewR = new System.Windows.Forms.DataGridView();
            this.idReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voyageur_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNbPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbVoyageur = new System.Windows.Forms.ComboBox();
            this.cmbAvion = new System.Windows.Forms.ComboBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.emailSendBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewR)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Frais (en Ariary) :";
            // 
            // textFrais
            // 
            this.textFrais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textFrais.Location = new System.Drawing.Point(0, 40);
            this.textFrais.Margin = new System.Windows.Forms.Padding(5);
            this.textFrais.Name = "textFrais";
            this.textFrais.Size = new System.Drawing.Size(324, 22);
            this.textFrais.TabIndex = 82;
            // 
            // SupBtn
            // 
            this.SupBtn.Location = new System.Drawing.Point(244, 15);
            this.SupBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SupBtn.Name = "SupBtn";
            this.SupBtn.Size = new System.Drawing.Size(84, 36);
            this.SupBtn.TabIndex = 69;
            this.SupBtn.Text = "Supprimer";
            this.SupBtn.UseVisualStyleBackColor = true;
            this.SupBtn.Click += new System.EventHandler(this.SupBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Avion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Date  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Classe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Voyageur :";
            // 
            // dateTimeReservation
            // 
            this.dateTimeReservation.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimeReservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimeReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeReservation.Location = new System.Drawing.Point(0, 40);
            this.dateTimeReservation.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimeReservation.Name = "dateTimeReservation";
            this.dateTimeReservation.Size = new System.Drawing.Size(324, 22);
            this.dateTimeReservation.TabIndex = 71;
            this.dateTimeReservation.ValueChanged += new System.EventHandler(this.dateTimeReservation_ValueChanged);
            // 
            // AjoutBtn
            // 
            this.AjoutBtn.Location = new System.Drawing.Point(1, 15);
            this.AjoutBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AjoutBtn.Name = "AjoutBtn";
            this.AjoutBtn.Size = new System.Drawing.Size(84, 36);
            this.AjoutBtn.TabIndex = 70;
            this.AjoutBtn.Text = "Ajouter";
            this.AjoutBtn.UseVisualStyleBackColor = true;
            this.AjoutBtn.Click += new System.EventHandler(this.AjoutBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(123, 15);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(84, 36);
            this.ModifierBtn.TabIndex = 68;
            this.ModifierBtn.Text = "Modifier ";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // DataGridViewR
            // 
            this.DataGridViewR.AllowUserToDeleteRows = false;
            this.DataGridViewR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservation,
            this.Voyageur_ID,
            this.Avion_ID,
            this.dgvDateDepart,
            this.dgvDestination,
            this.dgvDateArrivee,
            this.dgvNbPlace});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewR.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewR.Location = new System.Drawing.Point(0, 303);
            this.DataGridViewR.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewR.Name = "DataGridViewR";
            this.DataGridViewR.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewR.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewR.RowHeadersWidth = 70;
            this.DataGridViewR.RowTemplate.Height = 24;
            this.DataGridViewR.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewR.Size = new System.Drawing.Size(1291, 480);
            this.DataGridViewR.TabIndex = 77;
            this.DataGridViewR.DoubleClick += new System.EventHandler(this.DataGridViewR_DoubleClick);
            // 
            // idReservation
            // 
            this.idReservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReservation.DataPropertyName = "idRsvtion";
            this.idReservation.HeaderText = "Identifiant";
            this.idReservation.MinimumWidth = 6;
            this.idReservation.Name = "idReservation";
            this.idReservation.ReadOnly = true;
            // 
            // Voyageur_ID
            // 
            this.Voyageur_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Voyageur_ID.DataPropertyName = "idVoyageur";
            this.Voyageur_ID.HeaderText = "Voyageur(ID)";
            this.Voyageur_ID.MinimumWidth = 6;
            this.Voyageur_ID.Name = "Voyageur_ID";
            this.Voyageur_ID.ReadOnly = true;
            this.Voyageur_ID.Visible = false;
            // 
            // Avion_ID
            // 
            this.Avion_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Avion_ID.DataPropertyName = "idAvion";
            this.Avion_ID.HeaderText = "Avion(ID)";
            this.Avion_ID.MinimumWidth = 6;
            this.Avion_ID.Name = "Avion_ID";
            this.Avion_ID.ReadOnly = true;
            this.Avion_ID.Visible = false;
            // 
            // dgvDateDepart
            // 
            this.dgvDateDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDateDepart.DataPropertyName = "classe";
            this.dgvDateDepart.HeaderText = "Classe";
            this.dgvDateDepart.MinimumWidth = 6;
            this.dgvDateDepart.Name = "dgvDateDepart";
            this.dgvDateDepart.ReadOnly = true;
            // 
            // dgvDestination
            // 
            this.dgvDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDestination.DataPropertyName = "frais";
            this.dgvDestination.HeaderText = "Frais";
            this.dgvDestination.MinimumWidth = 6;
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            // 
            // dgvDateArrivee
            // 
            this.dgvDateArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDateArrivee.DataPropertyName = "statut";
            this.dgvDateArrivee.HeaderText = "Statut";
            this.dgvDateArrivee.MinimumWidth = 6;
            this.dgvDateArrivee.Name = "dgvDateArrivee";
            this.dgvDateArrivee.ReadOnly = true;
            this.dgvDateArrivee.Visible = false;
            // 
            // dgvNbPlace
            // 
            this.dgvNbPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNbPlace.DataPropertyName = "dateRsvtion";
            this.dgvNbPlace.HeaderText = "Date de réservation";
            this.dgvNbPlace.MinimumWidth = 6;
            this.dgvNbPlace.Name = "dgvNbPlace";
            this.dgvNbPlace.ReadOnly = true;
            // 
            // cmbClasse
            // 
            this.cmbClasse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(0, 38);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(324, 24);
            this.cmbClasse.TabIndex = 85;
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // cmbVoyageur
            // 
            this.cmbVoyageur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbVoyageur.FormattingEnabled = true;
            this.cmbVoyageur.Location = new System.Drawing.Point(0, 38);
            this.cmbVoyageur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVoyageur.Name = "cmbVoyageur";
            this.cmbVoyageur.Size = new System.Drawing.Size(324, 24);
            this.cmbVoyageur.TabIndex = 87;
            // 
            // cmbAvion
            // 
            this.cmbAvion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbAvion.FormattingEnabled = true;
            this.cmbAvion.Location = new System.Drawing.Point(0, 38);
            this.cmbAvion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAvion.Name = "cmbAvion";
            this.cmbAvion.Size = new System.Drawing.Size(324, 24);
            this.cmbAvion.TabIndex = 88;
            // 
            // textSearch
            // 
            this.textSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textSearch.Location = new System.Drawing.Point(0, 40);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(307, 22);
            this.textSearch.TabIndex = 89;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "Recherche:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbVoyageur);
            this.panel3.Location = new System.Drawing.Point(36, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 62);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cmbAvion);
            this.panel4.Location = new System.Drawing.Point(417, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 62);
            this.panel4.TabIndex = 101;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbClasse);
            this.panel5.Location = new System.Drawing.Point(36, 162);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 62);
            this.panel5.TabIndex = 102;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textFrais);
            this.panel6.Location = new System.Drawing.Point(814, 76);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(324, 62);
            this.panel6.TabIndex = 103;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.dateTimeReservation);
            this.panel7.Location = new System.Drawing.Point(417, 162);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(324, 62);
            this.panel7.TabIndex = 104;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.emailSendBtn);
            this.panel8.Controls.Add(this.SupBtn);
            this.panel8.Controls.Add(this.ModifierBtn);
            this.panel8.Controls.Add(this.AjoutBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(32, 232);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1227, 74);
            this.panel8.TabIndex = 105;
            // 
            // emailSendBtn
            // 
            this.emailSendBtn.Location = new System.Drawing.Point(356, 15);
            this.emailSendBtn.Name = "emailSendBtn";
            this.emailSendBtn.Size = new System.Drawing.Size(103, 36);
            this.emailSendBtn.TabIndex = 107;
            this.emailSendBtn.Text = "Annuler";
            this.emailSendBtn.UseVisualStyleBackColor = true;
            this.emailSendBtn.Click += new System.EventHandler(this.emailSendBtn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textSearch);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(817, 162);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(307, 62);
            this.panel9.TabIndex = 106;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(32, 30, 32, 0);
            this.panel10.Size = new System.Drawing.Size(1291, 306);
            this.panel10.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 29);
            this.label9.TabIndex = 86;
            this.label9.Text = "//RESERVATION";
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.DataGridViewR);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservationPage";
            this.Size = new System.Drawing.Size(1291, 783);
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFrais;
        private System.Windows.Forms.Button SupBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeReservation;
        private System.Windows.Forms.Button AjoutBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.DataGridView DataGridViewR;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbVoyageur;
        private System.Windows.Forms.ComboBox cmbAvion;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voyageur_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button emailSendBtn;
    }
}
