namespace ProjetCsharp.UserControls
{
    partial class AvionPage
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AjoutBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textNbPlace = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.textDepartAvion = new System.Windows.Forms.TextBox();
            this.textNomAvion = new System.Windows.Forms.TextBox();
            this.dateTimeDepart = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAvion = new System.Windows.Forms.DataGridView();
            this.idAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesignAvion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDépart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNbPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvion)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Départ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Date de départ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nom de l\'avion :";
            // 
            // AjoutBtn
            // 
            this.AjoutBtn.Location = new System.Drawing.Point(5, 15);
            this.AjoutBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AjoutBtn.Name = "AjoutBtn";
            this.AjoutBtn.Size = new System.Drawing.Size(84, 36);
            this.AjoutBtn.TabIndex = 53;
            this.AjoutBtn.Text = "Ajouter";
            this.AjoutBtn.UseVisualStyleBackColor = true;
            this.AjoutBtn.Click += new System.EventHandler(this.AjoutBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(125, 15);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(84, 36);
            this.ModifierBtn.TabIndex = 51;
            this.ModifierBtn.Text = "Modifier ";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Nombre de places:";
            // 
            // textNbPlace
            // 
            this.textNbPlace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textNbPlace.Location = new System.Drawing.Point(0, 22);
            this.textNbPlace.Margin = new System.Windows.Forms.Padding(5);
            this.textNbPlace.Multiline = true;
            this.textNbPlace.Name = "textNbPlace";
            this.textNbPlace.Size = new System.Drawing.Size(324, 40);
            this.textNbPlace.TabIndex = 65;
            // 
            // textDestination
            // 
            this.textDestination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textDestination.Location = new System.Drawing.Point(0, 22);
            this.textDestination.Margin = new System.Windows.Forms.Padding(5);
            this.textDestination.Multiline = true;
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(324, 40);
            this.textDestination.TabIndex = 64;
            // 
            // textDepartAvion
            // 
            this.textDepartAvion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textDepartAvion.Location = new System.Drawing.Point(0, 22);
            this.textDepartAvion.Margin = new System.Windows.Forms.Padding(5);
            this.textDepartAvion.Multiline = true;
            this.textDepartAvion.Name = "textDepartAvion";
            this.textDepartAvion.Size = new System.Drawing.Size(324, 40);
            this.textDepartAvion.TabIndex = 63;
            // 
            // textNomAvion
            // 
            this.textNomAvion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textNomAvion.Location = new System.Drawing.Point(0, 22);
            this.textNomAvion.Margin = new System.Windows.Forms.Padding(5);
            this.textNomAvion.Multiline = true;
            this.textNomAvion.Name = "textNomAvion";
            this.textNomAvion.Size = new System.Drawing.Size(324, 40);
            this.textNomAvion.TabIndex = 62;
            // 
            // dateTimeDepart
            // 
            this.dateTimeDepart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimeDepart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimeDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDepart.Location = new System.Drawing.Point(0, 40);
            this.dateTimeDepart.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimeDepart.Name = "dateTimeDepart";
            this.dateTimeDepart.Size = new System.Drawing.Size(324, 22);
            this.dateTimeDepart.TabIndex = 61;
            // 
            // dataGridViewAvion
            // 
            this.dataGridViewAvion.AllowUserToDeleteRows = false;
            this.dataGridViewAvion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAvion,
            this.dgvDesignAvion,
            this.dgvDépart,
            this.dgvDateDepart,
            this.dgvDestination,
            this.dgvDateArrivee,
            this.dgvNbPlace});
            this.dataGridViewAvion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAvion.Location = new System.Drawing.Point(0, 329);
            this.dataGridViewAvion.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewAvion.Name = "dataGridViewAvion";
            this.dataGridViewAvion.ReadOnly = true;
            this.dataGridViewAvion.RowHeadersWidth = 70;
            this.dataGridViewAvion.RowTemplate.Height = 24;
            this.dataGridViewAvion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvion.Size = new System.Drawing.Size(1148, 454);
            this.dataGridViewAvion.TabIndex = 60;
            this.dataGridViewAvion.DoubleClick += new System.EventHandler(this.dataGridViewAvion_DoubleClick_1);
            // 
            // idAvion
            // 
            this.idAvion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAvion.DataPropertyName = "idAvion";
            this.idAvion.HeaderText = "idAvion";
            this.idAvion.MinimumWidth = 6;
            this.idAvion.Name = "idAvion";
            this.idAvion.ReadOnly = true;
            // 
            // dgvDesignAvion
            // 
            this.dgvDesignAvion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDesignAvion.DataPropertyName = "designAvion";
            this.dgvDesignAvion.HeaderText = "Désignation";
            this.dgvDesignAvion.MinimumWidth = 6;
            this.dgvDesignAvion.Name = "dgvDesignAvion";
            this.dgvDesignAvion.ReadOnly = true;
            // 
            // dgvDépart
            // 
            this.dgvDépart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDépart.DataPropertyName = "depart";
            this.dgvDépart.HeaderText = "Départ";
            this.dgvDépart.MinimumWidth = 6;
            this.dgvDépart.Name = "dgvDépart";
            this.dgvDépart.ReadOnly = true;
            // 
            // dgvDateDepart
            // 
            this.dgvDateDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDateDepart.DataPropertyName = "dateDep";
            this.dgvDateDepart.HeaderText = "Date de départ";
            this.dgvDateDepart.MinimumWidth = 6;
            this.dgvDateDepart.Name = "dgvDateDepart";
            this.dgvDateDepart.ReadOnly = true;
            // 
            // dgvDestination
            // 
            this.dgvDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDestination.DataPropertyName = "destination";
            this.dgvDestination.HeaderText = "Destination";
            this.dgvDestination.MinimumWidth = 6;
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            // 
            // dgvDateArrivee
            // 
            this.dgvDateArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDateArrivee.DataPropertyName = "dateArr";
            this.dgvDateArrivee.HeaderText = "Date d\'arrivée";
            this.dgvDateArrivee.MinimumWidth = 6;
            this.dgvDateArrivee.Name = "dgvDateArrivee";
            this.dgvDateArrivee.ReadOnly = true;
            this.dgvDateArrivee.Visible = false;
            // 
            // dgvNbPlace
            // 
            this.dgvNbPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNbPlace.DataPropertyName = "nbPlace";
            this.dgvNbPlace.HeaderText = "Nombre de place";
            this.dgvNbPlace.MinimumWidth = 6;
            this.dgvNbPlace.Name = "dgvNbPlace";
            this.dgvNbPlace.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 52;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textSearch
            // 
            this.textSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textSearch.Location = new System.Drawing.Point(0, 22);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(324, 40);
            this.textSearch.TabIndex = 92;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 93;
            this.label7.Text = "Recherche :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textNomAvion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(37, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 62);
            this.panel2.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textDepartAvion);
            this.panel3.Location = new System.Drawing.Point(405, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 62);
            this.panel3.TabIndex = 97;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dateTimeDepart);
            this.panel4.Location = new System.Drawing.Point(405, 162);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 62);
            this.panel4.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textDestination);
            this.panel5.Location = new System.Drawing.Point(771, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 62);
            this.panel5.TabIndex = 99;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.textNbPlace);
            this.panel7.Location = new System.Drawing.Point(37, 162);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(324, 62);
            this.panel7.TabIndex = 101;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.textSearch);
            this.panel8.Location = new System.Drawing.Point(774, 184);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 62);
            this.panel8.TabIndex = 102;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.ModifierBtn);
            this.panel9.Controls.Add(this.AjoutBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(32, 246);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1084, 73);
            this.panel9.TabIndex = 103;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(32, 30, 32, 0);
            this.panel10.Size = new System.Drawing.Size(1148, 319);
            this.panel10.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 85;
            this.label9.Text = "//AVION";
            // 
            // AvionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.dataGridViewAvion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AvionPage";
            this.Size = new System.Drawing.Size(1148, 783);
            this.Load += new System.EventHandler(this.AvionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AjoutBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNbPlace;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.TextBox textDepartAvion;
        private System.Windows.Forms.TextBox textNomAvion;
        private System.Windows.Forms.DateTimePicker dateTimeDepart;
        private System.Windows.Forms.DataGridView dataGridViewAvion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesignAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDépart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNbPlace;
    }
}
