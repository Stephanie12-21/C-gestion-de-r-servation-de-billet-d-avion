using ProjetCsharp.UserControls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetCsharp
{
    public partial class Form1 : Form
    {
        private Button activeButton;

        public Form1()
        {
            InitializeComponent();
            InitializePages();
            SetButtonStyle(DashboardBtn);
            SetButtonStyle(VoyageurBtn);
            SetButtonStyle(AvionBtn);
            SetButtonStyle(ReservationBtn);
            ActivateButton(DashboardBtn);
            // Show the dashboard page when the application launches
            addUserControl(new DahsboardPage()); 

        }

        // Initialize all pages
        private void InitializePages()
        {
            addUserControl(new DahsboardPage());
            addUserControl(new VoyageurPage());
            addUserControl(new AvionPage());
            addUserControl(new ReservationPage());
        }

        // Set button style
        private void SetButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(243, 252, 249); // Background color
            button.ForeColor = Color.FromArgb(17, 19, 18); // Text color
            button.FlatAppearance.BorderSize = 0; // Remove border
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219); // Border color
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 215, 140); // Hover color
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 162, 107); // Pressed color
            button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15)); // Set rounded corners
        }

        // Create a region with rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Activate button and deactivate the previous one
        private void ActivateButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(243, 252, 249);
            }

            activeButton = button;
            activeButton.BackColor = Color.FromArgb(66, 215, 140);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            addUserControl(new DahsboardPage());
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void VoyageurBtn_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            addUserControl(new VoyageurPage());
        }

        private void AvionBtn_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            addUserControl(new AvionPage());
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            addUserControl(new ReservationPage());
        }

        
    }
}
