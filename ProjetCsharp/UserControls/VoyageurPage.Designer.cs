namespace ProjetCsharp.UserControls
{
    partial class VoyageurPage
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
            this.label7 = new System.Windows.Forms.Label();
            this.textEmailVoyageur = new System.Windows.Forms.TextBox();
            this.textPrenomVoyageur = new System.Windows.Forms.TextBox();
            this.textNomVoyageur = new System.Windows.Forms.TextBox();
            this.SupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AjoutBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.dataGridViewVoyageur = new System.Windows.Forms.DataGridView();
            this.dgvIdVoyageur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomVoyageur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoyageur)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 84;
            this.label7.Text = "//VOYAGEUR";
            // 
            // textEmailVoyageur
            // 
            this.textEmailVoyageur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textEmailVoyageur.Location = new System.Drawing.Point(0, 22);
            this.textEmailVoyageur.Margin = new System.Windows.Forms.Padding(5);
            this.textEmailVoyageur.Multiline = true;
            this.textEmailVoyageur.Name = "textEmailVoyageur";
            this.textEmailVoyageur.Size = new System.Drawing.Size(324, 40);
            this.textEmailVoyageur.TabIndex = 81;
            // 
            // textPrenomVoyageur
            // 
            this.textPrenomVoyageur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textPrenomVoyageur.Location = new System.Drawing.Point(0, 22);
            this.textPrenomVoyageur.Margin = new System.Windows.Forms.Padding(5);
            this.textPrenomVoyageur.Multiline = true;
            this.textPrenomVoyageur.Name = "textPrenomVoyageur";
            this.textPrenomVoyageur.Size = new System.Drawing.Size(324, 40);
            this.textPrenomVoyageur.TabIndex = 80;
            // 
            // textNomVoyageur
            // 
            this.textNomVoyageur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textNomVoyageur.Location = new System.Drawing.Point(0, 22);
            this.textNomVoyageur.Margin = new System.Windows.Forms.Padding(5);
            this.textNomVoyageur.Multiline = true;
            this.textNomVoyageur.Name = "textNomVoyageur";
            this.textNomVoyageur.Size = new System.Drawing.Size(324, 40);
            this.textNomVoyageur.TabIndex = 79;
            // 
            // SupBtn
            // 
            this.SupBtn.Location = new System.Drawing.Point(277, 20);
            this.SupBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SupBtn.Name = "SupBtn";
            this.SupBtn.Size = new System.Drawing.Size(84, 36);
            this.SupBtn.TabIndex = 69;
            this.SupBtn.Text = "Supprimer";
            this.SupBtn.UseVisualStyleBackColor = true;
            this.SupBtn.Click += new System.EventHandler(this.SupBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nom :";
            // 
            // AjoutBtn
            // 
            this.AjoutBtn.Location = new System.Drawing.Point(35, 20);
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
            this.ModifierBtn.Location = new System.Drawing.Point(156, 20);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(84, 36);
            this.ModifierBtn.TabIndex = 68;
            this.ModifierBtn.Text = "Modifier ";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // dataGridViewVoyageur
            // 
            this.dataGridViewVoyageur.AllowUserToDeleteRows = false;
            this.dataGridViewVoyageur.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewVoyageur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoyageur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdVoyageur,
            this.dgvNomVoyageur,
            this.dgvPrenom,
            this.dgvEmail});
            this.dataGridViewVoyageur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVoyageur.Location = new System.Drawing.Point(0, 243);
            this.dataGridViewVoyageur.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewVoyageur.Name = "dataGridViewVoyageur";
            this.dataGridViewVoyageur.ReadOnly = true;
            this.dataGridViewVoyageur.RowHeadersVisible = false;
            this.dataGridViewVoyageur.RowHeadersWidth = 70;
            this.dataGridViewVoyageur.RowTemplate.Height = 24;
            this.dataGridViewVoyageur.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVoyageur.Size = new System.Drawing.Size(1291, 540);
            this.dataGridViewVoyageur.TabIndex = 77;
            this.dataGridViewVoyageur.DoubleClick += new System.EventHandler(this.dataGridViewVoyageur_DoubleClick);
            // 
            // dgvIdVoyageur
            // 
            this.dgvIdVoyageur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvIdVoyageur.DataPropertyName = "idVoyageur";
            this.dgvIdVoyageur.HeaderText = "Identifiant";
            this.dgvIdVoyageur.MinimumWidth = 6;
            this.dgvIdVoyageur.Name = "dgvIdVoyageur";
            this.dgvIdVoyageur.ReadOnly = true;
            // 
            // dgvNomVoyageur
            // 
            this.dgvNomVoyageur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNomVoyageur.DataPropertyName = "nomVoyageur";
            this.dgvNomVoyageur.HeaderText = "Nom ";
            this.dgvNomVoyageur.MinimumWidth = 6;
            this.dgvNomVoyageur.Name = "dgvNomVoyageur";
            this.dgvNomVoyageur.ReadOnly = true;
            // 
            // dgvPrenom
            // 
            this.dgvPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrenom.DataPropertyName = "prenomVoyageur";
            this.dgvPrenom.HeaderText = "Prénom";
            this.dgvPrenom.MinimumWidth = 6;
            this.dgvPrenom.Name = "dgvPrenom";
            this.dgvPrenom.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEmail.DataPropertyName = "emailVoyageur";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textNomVoyageur);
            this.panel2.Location = new System.Drawing.Point(37, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 62);
            this.panel2.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textPrenomVoyageur);
            this.panel3.Location = new System.Drawing.Point(477, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 62);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textEmailVoyageur);
            this.panel4.Location = new System.Drawing.Point(865, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 62);
            this.panel4.TabIndex = 87;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.SupBtn);
            this.panel5.Controls.Add(this.ModifierBtn);
            this.panel5.Controls.Add(this.AjoutBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 169);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1291, 74);
            this.panel5.TabIndex = 88;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(32, 30, 0, 0);
            this.panel6.Size = new System.Drawing.Size(1291, 79);
            this.panel6.TabIndex = 86;
            // 
            // VoyageurPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewVoyageur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VoyageurPage";
            this.Size = new System.Drawing.Size(1291, 783);
            this.Load += new System.EventHandler(this.VoyageurPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoyageur)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmailVoyageur;
        private System.Windows.Forms.TextBox textPrenomVoyageur;
        private System.Windows.Forms.TextBox textNomVoyageur;
        private System.Windows.Forms.Button SupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AjoutBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.DataGridView dataGridViewVoyageur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdVoyageur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomVoyageur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}
