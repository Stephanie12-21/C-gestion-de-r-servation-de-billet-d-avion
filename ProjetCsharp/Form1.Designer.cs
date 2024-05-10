namespace ProjetCsharp
{
    partial class Form1
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ReservationBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.AvionBtn = new System.Windows.Forms.Button();
            this.VoyageurBtn = new System.Windows.Forms.Button();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.ReservationBtn);
            this.menuPanel.Controls.Add(this.DashboardBtn);
            this.menuPanel.Controls.Add(this.AvionBtn);
            this.menuPanel.Controls.Add(this.VoyageurBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(203, 783);
            this.menuPanel.TabIndex = 0;
            // 
            // ReservationBtn
            // 
            this.ReservationBtn.Location = new System.Drawing.Point(15, 380);
            this.ReservationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ReservationBtn.Name = "ReservationBtn";
            this.ReservationBtn.Size = new System.Drawing.Size(164, 46);
            this.ReservationBtn.TabIndex = 2;
            this.ReservationBtn.Text = "RESERVATIONS";
            this.ReservationBtn.UseVisualStyleBackColor = true;
            this.ReservationBtn.Click += new System.EventHandler(this.ReservationBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Location = new System.Drawing.Point(15, 137);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(164, 46);
            this.DashboardBtn.TabIndex = 3;
            this.DashboardBtn.Text = "DASHBOARD";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // AvionBtn
            // 
            this.AvionBtn.Location = new System.Drawing.Point(15, 299);
            this.AvionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AvionBtn.Name = "AvionBtn";
            this.AvionBtn.Size = new System.Drawing.Size(164, 46);
            this.AvionBtn.TabIndex = 1;
            this.AvionBtn.Text = "AVIONS";
            this.AvionBtn.UseVisualStyleBackColor = true;
            this.AvionBtn.Click += new System.EventHandler(this.AvionBtn_Click);
            // 
            // VoyageurBtn
            // 
            this.VoyageurBtn.Location = new System.Drawing.Point(15, 218);
            this.VoyageurBtn.Margin = new System.Windows.Forms.Padding(0);
            this.VoyageurBtn.Name = "VoyageurBtn";
            this.VoyageurBtn.Size = new System.Drawing.Size(164, 46);
            this.VoyageurBtn.TabIndex = 0;
            this.VoyageurBtn.Text = "VOYAGEURS";
            this.VoyageurBtn.UseVisualStyleBackColor = true;
            this.VoyageurBtn.Click += new System.EventHandler(this.VoyageurBtn_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(203, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1184, 783);
            this.ContainerPanel.TabIndex = 2;
      //      this.ContainerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 783);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button ReservationBtn;
        private System.Windows.Forms.Button AvionBtn;
        private System.Windows.Forms.Button VoyageurBtn;
        private System.Windows.Forms.Panel ContainerPanel;
    }
}

