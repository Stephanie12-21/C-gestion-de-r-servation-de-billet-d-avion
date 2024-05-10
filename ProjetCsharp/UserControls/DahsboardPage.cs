/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text.pdf;
using Spire.Pdf;


using iTextSharp.text;

using System.IO;



namespace ProjetCsharp.UserControls
{
    public partial class DahsboardPage : UserControl
    {
        public DahsboardPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");


        *//* private void panel1_Paint(object sender, PaintEventArgs e)
         {
             try
             {
                 con.Open();
                 SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Avion", con);
                 int totalCount = (int)command.ExecuteScalar();
                 string text = $"{totalCount}";

                 // Définir la police et la couleur du texte
                 Font font = new Font("Arial", 12);
                 Brush brush = Brushes.Black;

                 // Mesurer la taille du texte
                 SizeF textSize = e.Graphics.MeasureString(text, font);

                 // Calculer les coordonnées pour centrer le texte dans le panel
                 float x = (panel1.Width - textSize.Width) / 2;
                 float y = (panel1.Height - textSize.Height) / 2;

                 // Dessiner le texte centré sur le panel
                 e.Graphics.DrawString(text, font, brush, new PointF(x, y));

                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
             }

         }

         private void panel4_Paint(object sender, PaintEventArgs e)
         {
             try
             {

                 con.Open();
                 SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TableR", con);
                 int totalCount = (int)command.ExecuteScalar();
                 string text = $"{totalCount}";

                 // Définir la police et la couleur du texte
                 Font font = new Font("Arial", 12);
                 Brush brush = Brushes.Black;

                 // Dessiner le texte sur le panel
                 e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
             }
         }

         private void panel2_Paint(object sender, PaintEventArgs e)
         {

             try
             {
                 con.Open();
                 SqlCommand command = new SqlCommand("SELECT SUM(frais) as TotalFrais FROM TableR", con);
                 object totalFraisObject = command.ExecuteScalar();

                 // Vérifier si le total des frais est null
                 if (totalFraisObject != null && totalFraisObject != DBNull.Value)
                 {
                     int totalFrais = Convert.ToInt32(totalFraisObject);
                     string text = $"{totalFrais}";

                     // Définir la police et la couleur du texte
                     Font font = new Font("Arial", 12);
                     Brush brush = Brushes.Black;

                     // Dessiner le texte sur le panel
                     e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                 }
                 else
                 {
                     // Si aucun frais n'est trouvé, afficher un message approprié
                     // e.Graphics.DrawString("Aucun frais n'a été enregistré.", font, brush, new PointF(5, 5));
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Une erreur est survenue lors du calcul du total des frais : " + ex.Message);
             }
             finally
             {
                 // Assurez-vous de fermer la connexion
                 con.Close();
             }
         }*//*

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Avion", con);
                int totalCount = (int)command.ExecuteScalar();
                string text = $"{totalCount}";

                // Définir la police et la couleur du texte
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12); // Spécifiez explicitement l'espace de noms pour System.Drawing.Font
                Brush brush = Brushes.Black;

                // Mesurer la taille du texte
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Calculer les coordonnées pour centrer le texte dans le panel
                float x = (panel1.Width - textSize.Width) / 2;
                float y = (panel1.Height - textSize.Height) / 2;

                // Dessiner le texte centré sur le panel
                e.Graphics.DrawString(text, font, brush, new PointF(x, y));

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TableR", con);
                int totalCount = (int)command.ExecuteScalar();
                string text = $"{totalCount}";

                // Définir la police et la couleur du texte
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12); // Spécifiez explicitement l'espace de noms pour System.Drawing.Font
                Brush brush = Brushes.Black;

                // Dessiner le texte sur le panel
                e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT SUM(frais) as TotalFrais FROM TableR", con);
                object totalFraisObject = command.ExecuteScalar();

                // Vérifier si le total des frais est null
                if (totalFraisObject != null && totalFraisObject != DBNull.Value)
                {
                    int totalFrais = Convert.ToInt32(totalFraisObject);
                    string text = $"{totalFrais}";

                    // Définir la police et la couleur du texte
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 12); // Spécifiez explicitement l'espace de noms pour System.Drawing.Font
                    Brush brush = Brushes.Black;

                    // Dessiner le texte sur le panel
                    e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                }
                else
                {
                    // Si aucun frais n'est trouvé, afficher un message approprié
                    // e.Graphics.DrawString("Aucun frais n'a été enregistré.", font, brush, new PointF(5, 5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du total des frais : " + ex.Message);
            }
            finally
            {
                // Assurez-vous de fermer la connexion
                con.Close();
            }
        }
    }

    private void DahsboardPage_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TableR.idRsvtion, " +
                   "CONCAT(Voyageur.nomVoyageur, ' ', Voyageur.prenomVoyageur) AS Voyageur, " +
                   "Avion.designAvion as Avion, Avion.depart as Depart, Avion.destination as Destination, TableR.dateRsvtion " +
                   "FROM TableR " +
                   "INNER JOIN Voyageur ON TableR.idVoyageur = Voyageur.idVoyageur " +
                   "INNER JOIN Avion ON TableR.idAvion = Avion.idAvion", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableReservation = new DataTable();
                data.Fill(tableReservation);

                // Ajouter une colonne "NumBillet" et lui assigner des valeurs incrémentielles
                tableReservation.Columns.Add("NumBillet", typeof(int));
                for (int i = 0; i < tableReservation.Rows.Count; i++)
                {
                    tableReservation.Rows[i]["NumBillet"] = i + 1;
                }

                tableReservation.Columns["NumBillet"].SetOrdinal(0);

                dataGridView1.DataSource = tableReservation;

                dataGridView1.Columns["dateRsvtion"].HeaderText = "Date de réservation";

                // Remplacer l'en-tête de la colonne "idRsvtion" par "Numéro de réservation"
                dataGridView1.Columns["idRsvtion"].HeaderText = "Numéro de réservation";
                dataGridView1.Columns["idRsvtion"].Visible = false;

                // Définir AutoSizeMode à "Fill" pour chaque colonne
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les dates de date1 et date2
            DateTime date1Value = date1.Value.Date;
            DateTime date2Value = date2.Value.Date.AddDays(1).AddSeconds(-1); // Pour inclure toutes les heures de date2

            // Obtenir la source de données sous-jacente du DataGridView
            DataView dataView = ((DataTable)dataGridView1.DataSource).DefaultView;

            // Appliquer le filtre sur la colonne contenant les dates
            dataView.RowFilter = $"dateRsvtion >= #{date1Value.ToString("yyyy-MM-dd")}# AND dateRsvtion <= #{date2Value.ToString("yyyy-MM-dd")}#";

            // Mettre à jour le DataGridView avec les données filtrées
            dataGridView1.DataSource = dataView.ToTable();
        }

        *//*private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Vérifie d'abord si une ligne a été effectivement double-cliquée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Vous pouvez accéder aux cellules individuelles si nécessaire
                // Par exemple, pour obtenir le contenu de la première cellule :
                // var cellValue = selectedRow.Cells[0].Value;

                // Affichez un message avec les informations de la ligne sélectionnée
                MessageBox.Show("Vous avez double-cliqué sur la ligne : " + selectedRow.Index.ToString());

            }
        }*//*

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Vérifie d'abord si une ligne a été effectivement double-cliquée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtenez la valeur de la colonne "idRsvtion" de la ligne sélectionnée
                int idReservation = Convert.ToInt32(selectedRow.Cells["idRsvtion"].Value);

                // Affichez un message demandant si l'utilisateur souhaite exporter le billet en version PDF
                DialogResult result = MessageBox.Show("Souhaitez-vous exporter ce billet en version PDF?", "Exporter vers PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifiez la réponse de l'utilisateur
                if (result == DialogResult.Yes)
                {
                    // Créez un nouveau document PDF
                    Document doc = new Document();

                    try
                    {
                        // Créez un PdfWriter pour écrire dans le document
                        PdfWriter.GetInstance(doc, new FileStream("Billet.pdf", FileMode.Create));

                        // Ouvrez le document
                        doc.Open();

                        // Ajoutez les données de la requête SQL au document (exemple avec un paragraphe)
                        Paragraph paragraph = new Paragraph("ID de réservation : " + idReservation.ToString());
                        doc.Add(paragraph);

                        // Ajoutez d'autres données ou éléments au document ici

                        // Fermez le document
                        doc.Close();

                        MessageBox.Show("Le billet a été exporté avec succès en PDF.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'exportation du billet en PDF : " + ex.Message);
                    }
                }
            }
        }

    }

*/















using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing;

namespace ProjetCsharp.UserControls
{
    public partial class DahsboardPage : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");

        public DahsboardPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Avion", con);
                int totalCount = (int)command.ExecuteScalar();
                string text = $"{totalCount}";

                // Définir la police et la couleur du texte
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                Brush brush = Brushes.Black;

                // Mesurer la taille du texte
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Calculer les coordonnées pour centrer le texte dans le panel
                float x = (panel1.Width - textSize.Width) / 2;
                float y = (panel1.Height - textSize.Height) / 2;

                // Dessiner le texte centré sur le panel
                e.Graphics.DrawString(text, font, brush, new PointF(x, y));

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
            }

        }

        /*private void panel4_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TableR", con);
                int totalCount = (int)command.ExecuteScalar();
                string text = $"{totalCount}";

                // Définir la police et la couleur du texte
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                Brush brush = Brushes.Black;

                // Dessiner le texte sur le panel
                e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                con.Close();
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Calculer les coordonnées pour centrer le texte dans le panel
                float x = (panel1.Width - textSize.Width) / 2;
                float y = (panel1.Height - textSize.Height) / 2;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
            }
        }*/



        /* private void panel4_Paint(object sender, PaintEventArgs e)
         {
             try
             {
                 con.Open();
                 SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TableR", con);
                 int totalCount = (int)command.ExecuteScalar();
                 string text = $"{totalCount}";

                 // Définir la police et la couleur du texte
                 System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                 Brush brush = Brushes.Black;

                 // Dessiner le texte sur le panel
                 e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                 con.Close();

                 // Mesurer la taille du texte
                 SizeF textSize = e.Graphics.MeasureString(text, font);

                 // Calculer les coordonnées pour centrer le texte dans le panel
                 float x = (panel4.Width - textSize.Width) / 2;
                 float y = (panel4.Height - textSize.Height) / 2;

                 // Redessiner le texte centré
                 e.Graphics.DrawString(text, font, brush, new PointF(x, y));
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
             }
         }*/





        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TableR", con);
                int totalCount = (int)command.ExecuteScalar();
                string text = $"{totalCount}";

                // Définir la police et la couleur du texte
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                Brush brush = Brushes.Black;

                // Mesurer la taille du texte
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Calculer les coordonnées pour centrer le texte dans le panel
                float x = (panel4.Width - textSize.Width) / 2;
                float y = (panel4.Height - textSize.Height) / 2;

                // Dessiner le texte centré
                e.Graphics.DrawString(text, font, brush, new PointF(x, y));

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du nombre total d'avions : " + ex.Message);
            }
        }

        /*private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT SUM(frais) as TotalFrais FROM TableR", con);
                object totalFraisObject = command.ExecuteScalar();

                // Vérifier si le total des frais est null
                if (totalFraisObject != null && totalFraisObject != DBNull.Value)
                {
                    int totalFrais = Convert.ToInt32(totalFraisObject);
                    string text = $"{totalFrais}";

                    // Définir la police et la couleur du texte
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                    Brush brush = Brushes.Black;

                    // Dessiner le texte sur le panel
                    e.Graphics.DrawString(text, font, brush, new PointF(5, 5));
                }
                else
                {
                    // Si aucun frais n'est trouvé, afficher un message approprié
                    // e.Graphics.DrawString("Aucun frais n'a été enregistré.", font, brush, new PointF(5, 5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du total des frais : " + ex.Message);
            }
            finally
            {
                // Assurez-vous de fermer la connexion
                con.Close();
            }
        }*/


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT SUM(frais) as TotalFrais FROM TableR", con);
                object totalFraisObject = command.ExecuteScalar();

                // Vérifier si le total des frais est null
                if (totalFraisObject != null && totalFraisObject != DBNull.Value)
                {
                    int totalFrais = Convert.ToInt32(totalFraisObject);
                    string text = $"{totalFrais}";

                    // Définir la police et la couleur du texte
                    System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
                    Brush brush = Brushes.Black;

                    // Mesurer la taille du texte
                    SizeF textSize = e.Graphics.MeasureString(text, font);

                    // Calculer les coordonnées pour centrer le texte dans le panel
                    float x = (panel2.Width - textSize.Width) / 2;
                    float y = (panel2.Height - textSize.Height) / 2;

                    // Dessiner le texte centré sur le panel
                    e.Graphics.DrawString(text, font, brush, new PointF(x, y));
                }
                else
                {
                    // Si aucun frais n'est trouvé, afficher un message approprié
                    // e.Graphics.DrawString("Aucun frais n'a été enregistré.", font, brush, new PointF(5, 5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du calcul du total des frais : " + ex.Message);
            }
            finally
            {
                // Assurez-vous de fermer la connexion
                con.Close();
            }
        }

        private void DahsboardPage_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TableR.idRsvtion, " +
                   "CONCAT(Voyageur.nomVoyageur, ' ', Voyageur.prenomVoyageur) AS Voyageur, " +
                   "Avion.designAvion as Avion, Avion.depart as Depart, Avion.destination as Destination, TableR.dateRsvtion " +
                   "FROM TableR " +
                   "INNER JOIN Voyageur ON TableR.idVoyageur = Voyageur.idVoyageur " +
                   "INNER JOIN Avion ON TableR.idAvion = Avion.idAvion", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableReservation = new DataTable();
                data.Fill(tableReservation);

                // Ajouter une colonne "NumBillet" et lui assigner des valeurs incrémentielles
                tableReservation.Columns.Add("NumBillet", typeof(int));
                for (int i = 0; i < tableReservation.Rows.Count; i++)
                {
                    tableReservation.Rows[i]["NumBillet"] = i + 1;
                }

                tableReservation.Columns["NumBillet"].SetOrdinal(0);

                dataGridView1.DataSource = tableReservation;

                dataGridView1.Columns["dateRsvtion"].HeaderText = "Date de réservation";

                // Remplacer l'en-tête de la colonne "idRsvtion" par "Numéro de réservation"
                dataGridView1.Columns["idRsvtion"].HeaderText = "Numéro de réservation";
                dataGridView1.Columns["idRsvtion"].Visible = false;

                // Définir AutoSizeMode à "Fill" pour chaque colonne
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);
            }
        }

/*        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les dates de date1 et date2
            DateTime date1Value = date1.Value.Date;
            DateTime date2Value = date2.Value.Date.AddDays(1).AddSeconds(-1); // Pour inclure toutes les heures de date2

            // Obtenir la source de données sous-jacente du DataGridView
            DataView dataView = ((DataTable)dataGridView1.DataSource).DefaultView;

            // Appliquer le filtre sur la colonne contenant les dates
            dataView.RowFilter = $"dateRsvtion >= #{date1Value.ToString("yyyy-MM-dd")}# AND dateRsvtion <= #{date2Value.ToString("yyyy-MM-dd")}#";

            // Mettre à jour le DataGridView avec les données filtrées
            dataGridView1.DataSource = dataView.ToTable();
        }
*/
        /* private void dataGridView1_DoubleClick(object sender, EventArgs e)
         {
             // Vérifie d'abord si une ligne a été effectivement double-cliquée
             if (dataGridView1.SelectedRows.Count > 0)
             {
                 // Obtenez les données de la ligne sélectionnée
                 DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                 // Obtenez la valeur de la colonne "idRsvtion" de la ligne sélectionnée
                 int idReservation = Convert.ToInt32(selectedRow.Cells["idRsvtion"].Value);

                 // Affichez un message demandant si l'utilisateur souhaite exporter le billet en version PDF
                 DialogResult result = MessageBox.Show("Souhaitez-vous exporter ce billet en version PDF?", "Exporter vers PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 // Vérifiez la réponse de l'utilisateur
                 if (result == DialogResult.Yes)
                 {
                     // Créez un nouveau document PDF
                     Document doc = new Document();

                     try
                     {
                         // Créez un PdfWriter pour écrire dans le document
                         PdfWriter.GetInstance(doc, new FileStream("D:\\c# and react js\\Billet.pdf", FileMode.Create));

                         // Ouvrez le document
                         doc.Open();

                         // Ajoutez les données de la requête SQL au document (exemple avec un paragraphe)
                         Paragraph paragraph = new Paragraph("ID de réservation : " + idReservation.ToString());
                         doc.Add(paragraph);

                         // Ajoutez d'autres données ou éléments au document ici

                         // Fermez le document
                         doc.Close();

                         MessageBox.Show("Le billet a été exporté avec succès en PDF.");
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Une erreur est survenue lors de l'exportation du billet en PDF : " + ex.Message);
                     }
                 }
             }
         }*/



        /* private void dataGridView1_DoubleClick(object sender, EventArgs e)
         {
             // Vérifiez d'abord si une ligne a été effectivement double-cliquée
             if (dataGridView1.SelectedRows.Count > 0)
             {
                 // Obtenez les données de la ligne sélectionnée
                 DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                 // Obtenez la valeur de la colonne "idRsvtion" de la ligne sélectionnée
                 int idReservation = Convert.ToInt32(selectedRow.Cells["idRsvtion"].Value);

                 // Obtenez le nom du voyageur correspondant à cette réservation
                 string nomVoyageur = selectedRow.Cells["Voyageur"].Value.ToString();

                 // Affichez un message demandant si l'utilisateur souhaite exporter le billet en version PDF
                 DialogResult result = MessageBox.Show("Souhaitez-vous exporter ce billet en version PDF?", "Exporter vers PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 // Vérifiez la réponse de l'utilisateur
                 if (result == DialogResult.Yes)
                 {
                     // Créez un nouveau document PDF
                     Document doc = new Document();

                     try
                     {
                         // Créez un PdfWriter pour écrire dans le document
                         PdfWriter.GetInstance(doc, new FileStream("D:\\c# and react js\\Billet1.pdf", FileMode.Create));

                         // Ouvrez le document
                         doc.Open();

                         // Ajoutez le titre avec le nom du voyageur
                         Paragraph titre = new Paragraph($"Billet au nom de : {nomVoyageur}");
                         titre.Alignment = Element.ALIGN_CENTER;
                         doc.Add(titre);

                         // Ajoutez un saut de ligne
                         doc.Add(new Chunk("\n"));

                         // Ajoutez les données de la réservation (exemple avec l'ID de réservation)
                         Paragraph reservationInfo = new Paragraph($"ID de réservation : {idReservation}");
                         doc.Add(reservationInfo);

                         // Ajoutez d'autres données ou éléments au document ici

                         // Fermez le document
                         doc.Close();

                         MessageBox.Show("Le billet a été exporté avec succès en PDF.");
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Une erreur est survenue lors de l'exportation du billet en PDF : " + ex.Message);
                     }
                 }
             }
         }*/








        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Vérifiez d'abord si une ligne a été effectivement double-cliquée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtenez la valeur de la colonne "idRsvtion" de la ligne sélectionnée
                int idReservation = Convert.ToInt32(selectedRow.Cells["idRsvtion"].Value);

                // Affichez un message demandant si l'utilisateur souhaite exporter le billet en version PDF
                DialogResult result = MessageBox.Show("Souhaitez-vous exporter ce billet en version PDF?", "Exporter vers PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifiez la réponse de l'utilisateur
                if (result == DialogResult.Yes)
                {
                    // Créez un nouveau document PDF
                    Document doc = new Document();

                    try
                    {
                        // Créez un PdfWriter pour écrire dans le document
                        PdfWriter.GetInstance(doc, new FileStream("D:\\Billet\\MonBillet.pdf", FileMode.Create));

                        // Ouvrez le document
                        doc.Open();

                        // Ajoutez le titre avec le nom du voyageur
                        string nomVoyageur = selectedRow.Cells["Voyageur"].Value.ToString();
                        Paragraph titre = new Paragraph($"Billet au nom de : {nomVoyageur}");
                        titre.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titre);

                        // Ajoutez un saut de ligne
                        doc.Add(new Chunk("\n"));

                        // Créez un tableau PdfPTable pour afficher les données
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count - 1); // Exclure la colonne "NumBillet"
                        table.WidthPercentage = 100;

                        // Ajoutez les en-têtes de colonne
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.HeaderText != "NumBillet") // Exclure la colonne "NumBillet"
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                                table.AddCell(cell);
                            }
                        }

                        // Récupérez les données de la ligne sélectionnée et ajoutez-les au tableau
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.OwningColumn.HeaderText != "NumBillet") // Exclure la colonne "NumBillet"
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString()));
                                table.AddCell(pdfCell);
                            }
                        }

                        // Ajoutez le tableau au document
                        doc.Add(table);

                        // Fermez le document
                        doc.Close();

                        MessageBox.Show("Le billet a été exporté avec succès en PDF.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'exportation du billet en PDF : " + ex.Message);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
