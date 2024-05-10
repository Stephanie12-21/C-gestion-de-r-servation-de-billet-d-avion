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
    public partial class VoyageurPage : UserControl
    {
        public VoyageurPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ROSEBUD\ESTF2024;Initial Catalog=ProjetReservationBillet;Integrated Security=True;Encrypt=False");
        private string idVoyageurSelectionne;

        private void dataGridViewVoyageur_DoubleClick(object sender, EventArgs e)
        {
            {
                if (dataGridViewVoyageur.CurrentRow != null)
                {
                    int rowIndex = dataGridViewVoyageur.CurrentRow.Index;

                    //string idAvion = dataGridViewAvion.Rows[rowIndex].Cells[0].Value.ToString();
                    idVoyageurSelectionne = dataGridViewVoyageur.Rows[rowIndex].Cells[0].Value.ToString();
                    string nomVoyageur = dataGridViewVoyageur.Rows[rowIndex].Cells[1].Value.ToString();
                    string prenomVoyageur = dataGridViewVoyageur.Rows[rowIndex].Cells[2].Value.ToString();
                    string emailVoyageur = dataGridViewVoyageur.Rows[rowIndex].Cells[3].Value.ToString();


                    textNomVoyageur.Text = nomVoyageur;
                    textPrenomVoyageur.Text = prenomVoyageur;
                    textEmailVoyageur.Text = emailVoyageur;
                    
                }
            }
        }

        private void AjoutBtn_Click(object sender, EventArgs e)
        {
            
                try
                {
                    
                    if (string.IsNullOrWhiteSpace(textNomVoyageur.Text) ||
                        string.IsNullOrWhiteSpace(textPrenomVoyageur.Text) ||
                        string.IsNullOrWhiteSpace(textEmailVoyageur.Text))
                       
                    {
                        MessageBox.Show("Veuillez remplir tous les champs.");
                        return; 
                    }

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandType = CommandType.Text;
                   
                    command.CommandText = "INSERT INTO Voyageur (nomVoyageur, prenomVoyageur, emailVoyageur) VALUES (@NomVoyageur, @PrenomVoyageur, @EmailVoyageur)";
                    command.Parameters.AddWithValue("@NomVoyageur", textNomVoyageur.Text);
                    command.Parameters.AddWithValue("@PrenomVoyageur", textPrenomVoyageur.Text);
                    command.Parameters.AddWithValue("@EmailVoyageur", textEmailVoyageur.Text);
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
            
        }
        void ClearForm()
        {
            textNomVoyageur.Text = "";
            textPrenomVoyageur.Text = "";
            textEmailVoyageur.Text = "";
        }

        void BindData ()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Voyageur", con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tableVoyageur = new DataTable();
                data.Fill(tableVoyageur);
                dataGridViewVoyageur.DataSource = tableVoyageur;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données : " + ex.Message);

            }

        }

        private void VoyageurPage_Load(object sender, EventArgs e)
        {
            BindData();
        }


        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNomVoyageur.Text) ||
                    string.IsNullOrWhiteSpace(textPrenomVoyageur.Text) ||
                    string.IsNullOrWhiteSpace(textEmailVoyageur.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return; // Arrêter l'exécution de la méthode si les champs sont vides
                }

                // Assurez-vous que la connexion est ouverte
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Voyageur SET nomVoyageur = @NomVoyageur, prenomVoyageur = @PrenomVoyageur, emailVoyageur = @EmailVoyageur WHERE idVoyageur = @IdVoyageur";

                // Utilisez des paramètres pour éviter les injections SQL
                command.Parameters.AddWithValue("@NomVoyageur", textNomVoyageur.Text);
                command.Parameters.AddWithValue("@PrenomVoyageur", textPrenomVoyageur.Text);
                command.Parameters.AddWithValue("@EmailVoyageur", textEmailVoyageur.Text);

                // Assurez-vous que idVoyageurSelectionne est correctement initialisé
                if (idVoyageurSelectionne != null)
                {
                    command.Parameters.AddWithValue("@IdVoyageur", idVoyageurSelectionne);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un voyageur.");
                    return;
                }

                // Exécutez la commande SQL
                command.ExecuteNonQuery();

                // Rafraîchissez vos données après la mise à jour
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
                // Assurez-vous de fermer la connexion
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
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

                    SqlCommand command = new SqlCommand();
                    command.Connection = con;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM Voyageur WHERE idVoyageur = @IdVoyageur";
                    command.Parameters.AddWithValue("@IdVoyageur", idVoyageurSelectionne);

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
