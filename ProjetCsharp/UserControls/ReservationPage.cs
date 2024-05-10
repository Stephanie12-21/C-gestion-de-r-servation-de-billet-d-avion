/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetCsharp.UserControls
{
    public partial class ReservationPage : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");
        private DateTime dateSelectionnee;
        private string idReservationSelectionne;

        public ReservationPage()
        {
            InitializeComponent();
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {
            FillComboBoxVoyageur();
            FillComboBoxAvion();
            FillComboBoxClasse();
           // FillComboBoxStatut();
            textFrais.Enabled = false;
            LoadReservationData();
        }

        private void FillComboBoxVoyageur()
        {
            cmbVoyageur.Items.Clear();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT idVoyageur, nomVoyageur, prenomVoyageur FROM Voyageur";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbVoyageur.Items.Add(dr["idVoyageur"].ToString() + " - " + dr["nomVoyageur"].ToString() + " " + dr["prenomVoyageur"].ToString());
                }
            }
            catch (Exception ex)

            {
                
               // MessageBox.Show("Erreur lors du chargement des voyageurs : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void FillComboBoxAvion()
        {
            cmbAvion.Items.Clear();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT idAvion, designAvion FROM Avion";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbAvion.Items.Add(dr["idAvion"].ToString() + " - " + dr["designAvion"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des avions : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillComboBoxClasse()
        {
            cmbClasse.Items.Clear();
            cmbClasse.Items.Add("Affaire ou Premium");
            cmbClasse.Items.Add("Economique");
        }

       

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedItem != null && cmbClasse.SelectedIndex != -1)
            {
                textFrais.Enabled = true;

                if (cmbClasse.SelectedItem.ToString() == "Affaire ou Premium")
                {
                    textFrais.Text = "5.000.000";
                }
                else if (cmbClasse.SelectedItem.ToString() == "Economique")
                {
                    textFrais.Text = "2.000.000";
                }
            }
        }



        *//* private void AjoutBtn_Click(object sender, EventArgs e)
         {
             StringBuilder message = new StringBuilder();
             message.AppendLine("Confirmez-vous cette réservation?");
             message.AppendLine($"Identité du voyageur : {cmbVoyageur.SelectedItem}");
             message.AppendLine($"Avion  : {cmbAvion.SelectedItem}");
             message.AppendLine($"Classe : {cmbClasse.SelectedItem}");
            // message.AppendLine($"Statut : {cmbStatut.SelectedItem}");

             int frais;
             if (int.TryParse(ExtractNumbers(textFrais.Text), out frais))
             {
                 message.AppendLine($"Frais : {frais}");
             }
             else
             {
                 message.AppendLine("Frais : Montant non valide");
             }

             message.AppendLine($"Date de réservation : {dateSelectionnee.ToString("dd/MM/yyyy HH:mm:ss")}");

             DialogResult result = MessageBox.Show(message.ToString(), "Confirmation de réservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {
                 if (cmbVoyageur.SelectedItem != null && cmbAvion.SelectedItem != null && cmbClasse.SelectedItem != null && !string.IsNullOrEmpty(textFrais.Text))
                 {
                     string[] voyageurParts = cmbVoyageur.SelectedItem.ToString().Split('-');
                     string voyageurId = voyageurParts[0].Trim();

                     string[] avionParts = cmbAvion.SelectedItem.ToString().Split('-');
                     string avionId = avionParts[0].Trim();

                     // Vérifier le nombre de places disponibles dans l'avion
                     int nombrePlacesAvion = 0;
                     using (SqlCommand sqlCommand = con.CreateCommand())
                     {
                         sqlCommand.CommandType = CommandType.Text;
                         sqlCommand.CommandText = "SELECT nbPlace FROM Avion WHERE idAvion = @AvionId";
                         sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                         try
                         {
                             con.Open();
                             nombrePlacesAvion = Convert.ToInt32(sqlCommand.ExecuteScalar());
                         }
                         catch (SqlException ex)
                         {
                             MessageBox.Show("Erreur lors de la récupération du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                         finally
                         {
                             con.Close();
                         }
                     }

                     // Vérifier si des places sont disponibles dans l'avion
                     if (nombrePlacesAvion > 0)
                     {
                         // Mettre à jour le nombre de places disponibles dans l'avion
                         int nouveauNombrePlaces = nombrePlacesAvion - 1;
                         using (SqlCommand sqlCommand = con.CreateCommand())
                         {
                             sqlCommand.CommandType = CommandType.Text;
                             sqlCommand.CommandText = "UPDATE Avion SET nbPlace = @NouveauNombrePlaces WHERE idAvion = @AvionId";
                             sqlCommand.Parameters.AddWithValue("@NouveauNombrePlaces", nouveauNombrePlaces);
                             sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                             try
                             {
                                 con.Open();
                                 sqlCommand.ExecuteNonQuery();
                             }
                             catch (SqlException ex)
                             {
                                 MessageBox.Show("Erreur lors de la mise à jour du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 return;
                             }
                             finally
                             {
                                 con.Close();
                             }
                         }

                         // Insérer la réservation dans la base de données
                         using (SqlCommand sqlCommand = con.CreateCommand())
                         {
                             sqlCommand.CommandType = CommandType.Text;
                             sqlCommand.CommandText = "INSERT INTO TableR(idVoyageur, idAvion, classe, frais, statut, dateRsvtion) VALUES (@Voyageur, @Avion, @Classe, @Frais, @Statut, @DateRsvtion )";

                             sqlCommand.Parameters.AddWithValue("@Voyageur", voyageurId);
                             sqlCommand.Parameters.AddWithValue("@Avion", avionId);
                             sqlCommand.Parameters.AddWithValue("@Classe", cmbClasse.SelectedItem);
                             sqlCommand.Parameters.AddWithValue("@Frais", frais);
                           //  sqlCommand.Parameters.AddWithValue("@Statut", cmbStatut.SelectedItem);
                             sqlCommand.Parameters.AddWithValue("@DateRsvtion", dateSelectionnee);

                             try
                             {
                                 con.Open();
                                 sqlCommand.ExecuteNonQuery();
                                 MessageBox.Show("Réservation effectuée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 LoadReservationData();
                                 ClearForm(); // Appel de ClearForm après une insertion réussie
                             }
                             catch (SqlException ex)
                             {
                                 MessageBox.Show("Erreur lors de l'insertion des données. Veuillez réessayer.\nErreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                             finally
                             {
                                 con.Close();
                             }
                         }
                     }
                     else
                     {
                         MessageBox.Show("L'avion sélectionné ne contient plus de place disponible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Veuillez remplir tous les champs avant de confirmer la réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 MessageBox.Show("Annulation de la réservation");
             }
         }
 *//*
       


        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Confirmez-vous cette réservation?");
            message.AppendLine($"Identité du voyageur : {cmbVoyageur.SelectedItem}");
            message.AppendLine($"Avion  : {cmbAvion.SelectedItem}");
            message.AppendLine($"Classe : {cmbClasse.SelectedItem}");
            int frais;
            if (int.TryParse(ExtractNumbers(textFrais.Text), out frais))
            {
                message.AppendLine($"Frais : {frais}");
            }
            else
            {
                message.AppendLine("Frais : Montant non valide");
            }
            message.AppendLine($"Date de réservation : {dateSelectionnee.ToString("dd/MM/yyyy HH:mm:ss")}");

            DialogResult result = MessageBox.Show(message.ToString(), "Confirmation de réservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cmbVoyageur.SelectedItem != null && cmbAvion.SelectedItem != null && cmbClasse.SelectedItem != null && !string.IsNullOrEmpty(textFrais.Text))
                {
                    string[] voyageurParts = cmbVoyageur.SelectedItem.ToString().Split('-');
                    string voyageurId = voyageurParts[0].Trim();

                    string[] avionParts = cmbAvion.SelectedItem.ToString().Split('-');
                    string avionId = avionParts[0].Trim();

                    // Vérifier le nombre de places disponibles dans l'avion
                    int nombrePlacesAvion = 0;
                    using (SqlCommand sqlCommand = con.CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "SELECT nbPlace FROM Avion WHERE idAvion = @AvionId";
                        sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                        try
                        {
                            con.Open();
                            nombrePlacesAvion = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erreur lors de la récupération du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                    // Vérifier si des places sont disponibles dans l'avion
                    if (nombrePlacesAvion > 0)
                    {
                        // Mettre à jour le nombre de places disponibles dans l'avion
                        int nouveauNombrePlaces = nombrePlacesAvion - 1;
                        using (SqlCommand sqlCommand = con.CreateCommand())
                        {
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.CommandText = "UPDATE Avion SET nbPlace = @NouveauNombrePlaces WHERE idAvion = @AvionId";
                            sqlCommand.Parameters.AddWithValue("@NouveauNombrePlaces", nouveauNombrePlaces);
                            sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                            try
                            {
                                con.Open();
                                sqlCommand.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Erreur lors de la mise à jour du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            finally
                            {
                                con.Close();
                            }
                        }

                        // Insérer la réservation dans la base de données
                        using (SqlCommand sqlCommand = con.CreateCommand())
                        {
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.CommandText = "INSERT INTO TableR(idVoyageur, idAvion, classe, frais, dateRsvtion) VALUES (@Voyageur, @Avion, @Classe, @Frais, @DateRsvtion )";

                            sqlCommand.Parameters.AddWithValue("@Voyageur", voyageurId);
                            sqlCommand.Parameters.AddWithValue("@Avion", avionId);
                            sqlCommand.Parameters.AddWithValue("@Classe", cmbClasse.SelectedItem);
                            sqlCommand.Parameters.AddWithValue("@Frais", frais);
                            sqlCommand.Parameters.AddWithValue("@DateRsvtion", dateSelectionnee);

                            try
                            {
                                con.Open();
                                sqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Réservation effectuée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadReservationData();
                                ClearForm(); // Appel de ClearForm après une insertion réussie
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Erreur lors de l'insertion des données. Veuillez réessayer.\nErreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'avion sélectionné ne contient plus de place disponible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs avant de confirmer la réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Annulation de la réservation");
            }
        }

        private string ExtractNumbers(string text)
        {
            return new string(text.Where(char.IsDigit).ToArray());
        }

        private void dateTimeReservation_ValueChanged(object sender, EventArgs e)
        {
            dateSelectionnee = dateTimeReservation.Value;
            Console.WriteLine("Date de réservation : " + dateSelectionnee.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        void LoadReservationData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TableR.idRsvtion, " +
                    "CONCAT(Voyageur.idVoyageur, ' - ', Voyageur.nomVoyageur, ' ', " +
                    "Voyageur.prenomVoyageur) AS Voyageur, Avion.designAvion as Avion, TableR.classe, " +
                    "TableR.frais, TableR.statut, TableR.dateRsvtion FROM TableR" +
                    " INNER JOIN Voyageur ON TableR.idVoyageur = Voyageur.idVoyageur " +
                    "INNER JOIN Avion ON TableR.idAvion = Avion.idAvion", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableReservation = new DataTable();
                data.Fill(tableReservation);
                DataGridViewR.DataSource = tableReservation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);
            }
        }

        void ClearForm()
        {
            cmbVoyageur.SelectedIndex = -1;
            cmbVoyageur.Items.Clear();
            FillComboBoxVoyageur();

            cmbAvion.SelectedIndex = -1;
            cmbAvion.Items.Clear();
            FillComboBoxAvion();

            cmbClasse.SelectedIndex = -1;
            cmbClasse.Items.Clear();
            FillComboBoxClasse();

            *//*cmbStatut.SelectedIndex = -1;
            cmbStatut.Items.Clear();
            FillComboBoxStatut();*//*

            textFrais.Text = "";
            textFrais.Enabled = false;

            dateTimeReservation.Value = DateTime.Now;
        }

        private void DataGridViewR_DoubleClick(object sender, EventArgs e)
        {
            if (DataGridViewR.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = DataGridViewR.SelectedRows[0];
                    idReservationSelectionne = selectedRow.Cells["idRsvtion"].Value.ToString();
                    string voyageur = selectedRow.Cells["Voyageur"].Value.ToString();
                    string avion = selectedRow.Cells["Avion"].Value.ToString();
                    string classe = selectedRow.Cells["classe"].Value.ToString();
                    string frais = selectedRow.Cells["frais"].Value.ToString();
                    //string statut = selectedRow.Cells["statut"].Value.ToString();
                    string dateReservation = selectedRow.Cells["dateRsvtion"].Value.ToString();

                    MessageBox.Show($"Informations de la réservation :\n" +
                                    $"ID : {idReservationSelectionne}\n" +
                                    $"Voyageur : {voyageur}\n" +
                                    $"Avion : {avion}\n" +
                                    $"Classe : {classe}\n" +
                                    $"Frais (en Ariary) : {frais}\n" +
                                  //  $"Statut : {statut}\n" +
                                    $"Date de réservation : {dateReservation}",
                                    "Informations de réservation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    cmbClasse.Text = classe;
                    //cmbStatut.Text = statut;
                    cmbAvion.Text = avion;
                    cmbVoyageur.Text = voyageur;
                    textFrais.Text = frais;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (idReservationSelectionne != null)
            {
                string voyageurId = cmbVoyageur.Text.Split('-')[0].Trim();
                string avionId = cmbAvion.Text.Split('-')[0].Trim();
                string classe = cmbClasse.Text;
                int frais;
                int.TryParse(ExtractNumbers(textFrais.Text), out frais);
               // string statut = cmbStatut.Text;

                using (SqlCommand sqlCommand = con.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "UPDATE TableR SET idVoyageur = @Voyageur, idAvion = @Avion, classe = @Classe, frais = @Frais WHERE idRsvtion = @ID";

                    sqlCommand.Parameters.AddWithValue("@Voyageur", voyageurId);
                    sqlCommand.Parameters.AddWithValue("@Avion", avionId);
                    sqlCommand.Parameters.AddWithValue("@Classe", classe);
                    sqlCommand.Parameters.AddWithValue("@Frais", frais);
                    //sqlCommand.Parameters.AddWithValue("@Statut", statut);
                    sqlCommand.Parameters.AddWithValue("@ID", idReservationSelectionne);

                    try
                    {
                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Réservation modifiée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReservationData();
                        ClearForm();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la modification des données. Veuillez réessayer.\nErreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une réservation à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    if (idReservationSelectionne != null)
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM TableR WHERE idRsvtion = @ID", con))
                        {
                            command.Parameters.AddWithValue("@ID", idReservationSelectionne);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("L'opération de suppression est réussie");
                                LoadReservationData();
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("Aucune ligne n'a été supprimée. Veuillez vérifier l'ID de réservation.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune réservation sélectionnée pour la suppression.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression des données : " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                ClearForm();
            }
        }

        
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net.Mail;
using System.Net;

namespace ProjetCsharp.UserControls
{
    public partial class ReservationPage : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");
        private DateTime dateSelectionnee;
        private string idReservationSelectionne;

        public ReservationPage()
        {
            InitializeComponent();
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {
            FillComboBoxVoyageur();
            FillComboBoxAvion();
            FillComboBoxClasse();
            textFrais.Enabled = false;
            LoadReservationData();
        }

        private void FillComboBoxVoyageur()
        {
            cmbVoyageur.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT idVoyageur, nomVoyageur, prenomVoyageur FROM Voyageur";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbVoyageur.Items.Add(dr["idVoyageur"].ToString() + " - " + dr["nomVoyageur"].ToString() + " " + dr["prenomVoyageur"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Erreur lors du chargement des voyageurs : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FillComboBoxAvion()
        {
            cmbAvion.Items.Clear();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT idAvion, designAvion FROM Avion";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbAvion.Items.Add(dr["idAvion"].ToString() + " - " + dr["designAvion"].ToString());
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Erreur lors du chargement des avions : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillComboBoxClasse()
        {
            cmbClasse.Items.Clear();
            cmbClasse.Items.Add("Affaire ou Premium");
            cmbClasse.Items.Add("Economique");
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedItem != null && cmbClasse.SelectedIndex != -1)
            {
                textFrais.Enabled = true;

                if (cmbClasse.SelectedItem.ToString() == "Affaire ou Premium")
                {
                    textFrais.Text = "5.000.000";
                }
                else if (cmbClasse.SelectedItem.ToString() == "Economique")
                {
                    textFrais.Text = "2.000.000";
                }
            }
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Confirmez-vous cette réservation?");
            message.AppendLine($"Identité du voyageur : {cmbVoyageur.SelectedItem}");
            message.AppendLine($"Avion  : {cmbAvion.SelectedItem}");
            message.AppendLine($"Classe : {cmbClasse.SelectedItem}");
            int frais;
            if (int.TryParse(ExtractNumbers(textFrais.Text), out frais))
            {
                message.AppendLine($"Frais : {frais}");
            }
            else
            {
                message.AppendLine("Frais : Montant non valide");
            }

            // Vérifier si dateSelectionnee est dans la plage autorisée
            if (dateSelectionnee < SqlDateTime.MinValue.Value || dateSelectionnee > SqlDateTime.MaxValue.Value)
            {
                MessageBox.Show("La date de réservation est en dehors de la plage autorisée.");
                return;
            }

            message.AppendLine($"Date de réservation : {dateSelectionnee.ToString("dd/MM/yyyy HH:mm:ss")}");

            DialogResult result = MessageBox.Show(message.ToString(), "Confirmation de réservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cmbVoyageur.SelectedItem != null && cmbAvion.SelectedItem != null && cmbClasse.SelectedItem != null && !string.IsNullOrEmpty(textFrais.Text))
                {
                    string[] voyageurParts = cmbVoyageur.SelectedItem.ToString().Split('-');
                    string voyageurId = voyageurParts[0].Trim();

                    string[] avionParts = cmbAvion.SelectedItem.ToString().Split('-');
                    string avionId = avionParts[0].Trim();

                    // Vérifier le nombre de places disponibles dans l'avion
                    int nombrePlacesAvion = 0;
                    using (SqlCommand sqlCommand = con.CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "SELECT nbPlace FROM Avion WHERE idAvion = @AvionId";
                        sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                        try
                        {
                            con.Open();
                            nombrePlacesAvion = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erreur lors de la récupération du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                    // Vérifier si des places sont disponibles dans l'avion
                    if (nombrePlacesAvion > 0)
                    {
                        // Mettre à jour le nombre de places disponibles dans l'avion
                        int nouveauNombrePlaces = nombrePlacesAvion - 1;
                        using (SqlCommand sqlCommand = con.CreateCommand())
                        {
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.CommandText = "UPDATE Avion SET nbPlace = @NouveauNombrePlaces WHERE idAvion = @AvionId";
                            sqlCommand.Parameters.AddWithValue("@NouveauNombrePlaces", nouveauNombrePlaces);
                            sqlCommand.Parameters.AddWithValue("@AvionId", avionId);

                            try
                            {
                                con.Open();
                                sqlCommand.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Erreur lors de la mise à jour du nombre de places de l'avion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            finally
                            {
                                con.Close();
                            }
                        }

                        // Insérer la réservation dans la base de données
                        using (SqlCommand sqlCommand = con.CreateCommand())
                        {
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.CommandText = "INSERT INTO TableR(idVoyageur, idAvion, classe, frais, dateRsvtion) VALUES (@Voyageur, @Avion, @Classe, @Frais, @DateRsvtion )";

                            sqlCommand.Parameters.AddWithValue("@Voyageur", voyageurId);
                            sqlCommand.Parameters.AddWithValue("@Avion", avionId);
                            sqlCommand.Parameters.AddWithValue("@Classe", cmbClasse.SelectedItem);
                            sqlCommand.Parameters.AddWithValue("@Frais", frais);
                            sqlCommand.Parameters.AddWithValue("@DateRsvtion", dateSelectionnee);

                            try
                            {
                                con.Open();
                                sqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Réservation effectuée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadReservationData();
                                ClearForm(); // Appel de ClearForm après une insertion réussie
                                //panel1.Invalidate();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Erreur lors de l'insertion des données. Veuillez réessayer.\nErreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'avion sélectionné ne contient plus de place disponible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs avant de confirmer la réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Annulation de la réservation");
            }
        }


        private string ExtractNumbers(string text)
        {
            return new string(text.Where(char.IsDigit).ToArray());
        }

        private void dateTimeReservation_ValueChanged(object sender, EventArgs e)
        {
            dateSelectionnee = dateTimeReservation.Value;
            Console.WriteLine("Date de réservation : " + dateSelectionnee.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        void LoadReservationData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TableR.idRsvtion, " +
                    "CONCAT(Voyageur.idVoyageur, ' - ', Voyageur.nomVoyageur, ' ', " +
                    "Voyageur.prenomVoyageur) AS Voyageur, Avion.designAvion as Avion, TableR.classe, " +
                    "TableR.frais, TableR.dateRsvtion FROM TableR" +
                    " INNER JOIN Voyageur ON TableR.idVoyageur = Voyageur.idVoyageur " +
                    "INNER JOIN Avion ON TableR.idAvion = Avion.idAvion", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableReservation = new DataTable();
                data.Fill(tableReservation);

                DataGridViewR.DataSource = tableReservation;

                // Définir AutoSizeMode à "Fill" pour chaque colonne
                foreach (DataGridViewColumn col in DataGridViewR.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);
            }
        }


        void ClearForm()
        {
            cmbVoyageur.SelectedIndex = -1;
            cmbVoyageur.Items.Clear();
            FillComboBoxVoyageur();

            cmbAvion.SelectedIndex = -1;
            cmbAvion.Items.Clear();
            FillComboBoxAvion();

            cmbClasse.SelectedIndex = -1;
            cmbClasse.Items.Clear();
            FillComboBoxClasse();

            textFrais.Text = "";
            textFrais.Enabled = false;

            dateTimeReservation.Value = DateTime.Now;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT TableR.idRsvtion, " +
                        "CONCAT(Voyageur.idVoyageur, ' - ', Voyageur.nomVoyageur, ' ', " +
                        "Voyageur.prenomVoyageur) AS Voyageur, Avion.designAvion as Avion, TableR.classe, " +
                        "TableR.frais, TableR.statut, TableR.dateRsvtion FROM TableR" +
                        " INNER JOIN Voyageur ON TableR.idVoyageur = Voyageur.idVoyageur " +
                        "INNER JOIN Avion ON TableR.idAvion = Avion.idAvion WHERE (Voyageur.nomVoyageur LIKE @search OR Voyageur.prenomVoyageur LIKE @search)", con);
                    command.Parameters.AddWithValue("@search", "%" + textSearch.Text + "%");

                    SqlDataAdapter data = new SqlDataAdapter(command);
                    DataTable tableReservation = new DataTable();
                    data.Fill(tableReservation);
                    DataGridViewR.DataSource = tableReservation;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du filtrage des données : " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        }

        private void DataGridViewR_DoubleClick(object sender, EventArgs e)
        {
            if (DataGridViewR.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = DataGridViewR.SelectedRows[0];
                    idReservationSelectionne = selectedRow.Cells["idReservation"].Value.ToString();
                    string voyageur = selectedRow.Cells["Voyageur"].Value.ToString();
                    string avion = selectedRow.Cells["Avion"].Value.ToString();
                    string classe = selectedRow.Cells["dgvDateDepart"].Value.ToString();
                    string frais = selectedRow.Cells["dgvDestination"].Value.ToString();
                    //string statut = selectedRow.Cells["statut"].Value.ToString();
                    string dateReservation = selectedRow.Cells["dgvNbPlace"].Value.ToString();

                    MessageBox.Show($"Informations de la réservation :\n" +
                                    $"ID : {idReservationSelectionne}\n" +
                                    $"Voyageur : {voyageur}\n" +
                                    $"Avion : {avion}\n" +
                                    $"Classe : {classe}\n" +
                                    $"Frais (en Ariary) : {frais}\n" +
                                    //  $"Statut : {statut}\n" +
                                    $"Date de réservation : {dateReservation}",
                                    "Informations de réservation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    cmbClasse.Text = classe;
                    //cmbStatut.Text = statut;
                    cmbAvion.Text = avion;
                    cmbVoyageur.Text = voyageur;
                    textFrais.Text = frais;



                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (idReservationSelectionne != null)
            {
                string voyageurId = cmbVoyageur.Text.Split('-')[0].Trim();
                string avionId = cmbAvion.Text.Split('-')[0].Trim();
                string classe = cmbClasse.Text;
                int frais;
                int.TryParse(ExtractNumbers(textFrais.Text), out frais);
                // string statut = cmbStatut.Text;

                using (SqlCommand sqlCommand = con.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "UPDATE TableR SET idVoyageur = @Voyageur, idAvion = @Avion, classe = @Classe, frais = @Frais WHERE idRsvtion = @ID";

                    sqlCommand.Parameters.AddWithValue("@Voyageur", voyageurId);
                    sqlCommand.Parameters.AddWithValue("@Avion", avionId);
                    sqlCommand.Parameters.AddWithValue("@Classe", classe);
                    sqlCommand.Parameters.AddWithValue("@Frais", frais);
                    //sqlCommand.Parameters.AddWithValue("@Statut", statut);
                    sqlCommand.Parameters.AddWithValue("@ID", idReservationSelectionne);

                    try
                    {
                        con.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Réservation modifiée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReservationData();
                        ClearForm();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la modification des données. Veuillez réessayer.\nErreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une réservation à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupBtn_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        if (idReservationSelectionne != null)
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM TableR WHERE idRsvtion = @ID", con))
                            {
                                command.Parameters.AddWithValue("@ID", idReservationSelectionne);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("L'opération de suppression est réussie");
                                    LoadReservationData();
                                    ClearForm();
                                }
                                else
                                {
                                    MessageBox.Show("Aucune ligne n'a été supprimée. Veuillez vérifier l'ID de réservation.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune réservation sélectionnée pour la suppression.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression des données : " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    ClearForm();
                }
            

        }

        private void emailSendBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /*private void emailSendBtn_Click(object sender, EventArgs e)
        {
            // Vérifiez d'abord si une ligne est sélectionnée dans le DataGridView
            if (DataGridViewR.SelectedRows.Count > 0)
            {
                // Récupérez l'idVoyageur de la ligne sélectionnée
                int idVoyageurSelectionne = Convert.ToInt32(DataGridViewR.SelectedRows[0].Cells["idVoyageur"].Value);

                // Ouvrez la connexion à la base de données
                
                    con.Open();

                    // Utilisez des paramètres pour éviter les attaques par injection SQL
                    SqlCommand command = new SqlCommand("SELECT emailVoyageur FROM Voyageur WHERE idVoyageur = @idVoyageurSelectionne", con);
                    command.Parameters.AddWithValue("@idVoyageurSelectionne", idVoyageurSelectionne);

                    // Exécutez la commande et récupérez l'emailVoyageur
                    string emailVoyageur = command.ExecuteScalar() as string;

                    // Affichez l'email du destinataire dans une MessageBox
                    MessageBox.Show("L'email du destinataire est : " + emailVoyageur);
                
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne dans le DataGridView.");
            }
        }*/



    }


}
