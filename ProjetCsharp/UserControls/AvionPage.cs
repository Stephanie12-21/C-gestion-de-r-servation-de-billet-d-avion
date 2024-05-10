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

namespace ProjetCsharp.UserControls
{
    public partial class AvionPage : UserControl
    {
        public AvionPage()
        {
            InitializeComponent();
        }
            SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");
            private string idAvionSelectionne;

        /*private void AjoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification si les champs sont vides
                if (string.IsNullOrWhiteSpace(textNomAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDepartAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDestination.Text) ||
                    string.IsNullOrWhiteSpace(textNbPlace.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return; // Arrêter l'exécution de la méthode si les champs sont vides
                }

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                // Correction de la commande SQL pour exclure la colonne idAvion
                command.CommandText = "INSERT INTO Avion(designAvion, depart, dateDep, destination, dateArr, nbPlace) VALUES (@DesignAvion, @Depart, @DateDepart, @Destination, @DateArrivee, @NbPlace)";
                // Utilisation des paramètres pour éviter les problèmes de sécurité et les erreurs de syntaxe
                command.Parameters.AddWithValue("@DesignAvion", textNomAvion.Text);
                command.Parameters.AddWithValue("@Depart", textDepartAvion.Text);
                command.Parameters.AddWithValue("@DateDepart", dateTimeDepart.Value.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@Destination", textDestination.Text);
                command.Parameters.AddWithValue("@DateArrivee", dateTimeArrivee.Value.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@NbPlace", int.Parse(textNbPlace.Text));
                command.ExecuteNonQuery();


                ClearForm();
                BindData();
                MessageBox.Show("Les données ont bien été ajoutées dans la base de données");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout des données : " + ex.Message);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }*/


        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification si les champs sont vides
                if (string.IsNullOrWhiteSpace(textNomAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDepartAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDestination.Text) ||
                    string.IsNullOrWhiteSpace(textNbPlace.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return; // Arrêter l'exécution de la méthode si les champs sont vides
                }

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                // Correction de la commande SQL pour exclure la colonne idAvion
                command.CommandText = "INSERT INTO Avion(designAvion, depart, dateDep, destination, nbPlace) VALUES (@DesignAvion, @Depart, @DateDepart, @Destination, @NbPlace)";
                // Utilisation des paramètres pour éviter les problèmes de sécurité et les erreurs de syntaxe
                command.Parameters.AddWithValue("@DesignAvion", textNomAvion.Text);
                command.Parameters.AddWithValue("@Depart", textDepartAvion.Text);
                command.Parameters.AddWithValue("@DateDepart", dateTimeDepart.Value.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@Destination", textDestination.Text);
                command.Parameters.AddWithValue("@NbPlace", int.Parse(textNbPlace.Text));
                command.ExecuteNonQuery();

                ClearForm();
                BindData();
                MessageBox.Show("Les données ont bien été ajoutées dans la base de données");

                // Actualiser le nombre total d'avions
                //panel1.Invalidate(); // Appel à la méthode Paint du Panel pour réafficher le nombre total d'avions
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout des données : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        void ClearForm()
        {
            textNomAvion.Text = "";
            textDepartAvion.Text = "";
            dateTimeDepart.Value = DateTime.Now;
            textDestination.Text = "";
            //dateTimeArrivee.Value = DateTime.Now;
            textNbPlace.Text = "";
        }

        private void AvionPage_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Avion", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableAvion = new DataTable();
                data.Fill(tableAvion);
                dataGridViewAvion.DataSource = tableAvion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);

            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNomAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDepartAvion.Text) ||
                    string.IsNullOrWhiteSpace(textDestination.Text) ||
                    string.IsNullOrWhiteSpace(textNbPlace.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return; // Arrêter l'exécution de la méthode si les champs sont vides
                }
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Avion SET designAvion = @DesignAvion, depart = @Depart, dateDep = @DateDepart, destination = @Destination, nbPlace = @NbPlace WHERE idAvion = @IdAvion";

                command.Parameters.AddWithValue("@DesignAvion", textNomAvion.Text);
                command.Parameters.AddWithValue("@Depart", textDepartAvion.Text);
                command.Parameters.AddWithValue("@DateDepart", dateTimeDepart.Value.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@Destination", textDestination.Text);
               // command.Parameters.AddWithValue("@DateArrivee", dateTimeArrivee.Value.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@NbPlace", int.Parse(textNbPlace.Text));
                command.Parameters.AddWithValue("@IdAvion", idAvionSelectionne); // Utilisez la variable idAvionSelectionne ici

                command.ExecuteNonQuery();

                BindData();

                MessageBox.Show("Les données ont bien été modifiées dans la base de données");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la modification des données : " + ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
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

                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM Avion WHERE idAvion = @IdAvion";
                    command.Parameters.AddWithValue("@IdAvion", idAvionSelectionne);

                    command.ExecuteNonQuery();

                    BindData();
                    MessageBox.Show("L'opération de suppression est réussie");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression des données : " + ex.Message);
                    Console.WriteLine(ex.Message);
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
                // L'utilisateur a annulé la suppression, donc rien ne se passe.
                ClearForm();
            }
        }


        private void dataGridViewAvion_DoubleClick_1(object sender, EventArgs e)
        {
            
                if (dataGridViewAvion.CurrentRow != null)
                {
                    int rowIndex = dataGridViewAvion.CurrentRow.Index;

                    idAvionSelectionne = dataGridViewAvion.Rows[rowIndex].Cells[0].Value.ToString();
                    string designAvion = dataGridViewAvion.Rows[rowIndex].Cells[1].Value.ToString();
                    string depart = dataGridViewAvion.Rows[rowIndex].Cells[2].Value.ToString();
                    DateTime dateDepart = Convert.ToDateTime(dataGridViewAvion.Rows[rowIndex].Cells[3].Value);
                    string destination = dataGridViewAvion.Rows[rowIndex].Cells[4].Value.ToString();
                    //DateTime dateArrivee = Convert.ToDateTime(dataGridViewAvion.Rows[rowIndex].Cells[5].Value);
                    string nbPlace = dataGridViewAvion.Rows[rowIndex].Cells[6].Value.ToString();


                    textNomAvion.Text = designAvion;
                    textDepartAvion.Text = depart;
                    dateTimeDepart.Value = dateDepart;
                    textDestination.Text = destination;
                    //dateTimeArrivee.Value = dateArrivee;
                    textNbPlace.Text = nbPlace;
                    // MessageBox.Show("Vous avez sélectionnée la ligne portant l'identifiant: " + idAvionSelectionne);
                }
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text;

            MessageBox.Show($"La valeur du champ de recherche est : {searchText}", "Résultat de la recherche");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                    con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Avion WHERE depart LIKE @search OR destination LIKE @search", con);
                command.Parameters.AddWithValue("@search", "%" + textSearch.Text + "%");

                    SqlDataAdapter data = new SqlDataAdapter(command);
                    DataTable tableAvion = new DataTable();
                    data.Fill(tableAvion);
                
                    dataGridViewAvion.DataSource = tableAvion;
                    con.Close();
                
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
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Avion", con);
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

        
    }
}
