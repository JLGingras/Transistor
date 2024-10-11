using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureTransistor.Clients
{
    public partial class afficherLaListeDesClients : Form
    {

        List<ClientDTO> clients = new List<ClientDTO>();

        int index;


        private void afficherLesClients(List<ClientDTO> clients)
        {
            // Clear previous items and columns
            clientListView.Items.Clear();
            clientListView.Columns.Clear();

            // Define columns
            clientListView.Columns.Add("Numéro");
            clientListView.Columns.Add("Pronoms");
            clientListView.Columns.Add("Prénom");
            clientListView.Columns.Add("Nom");
            clientListView.Columns.Add("Rue");
            clientListView.Columns.Add("Ville");
            clientListView.Columns.Add("Code Postale");
            clientListView.Columns.Add("Région");
            clientListView.Columns.Add("Province");
            clientListView.Columns.Add("Pays");
            clientListView.Columns.Add("Adresse Email");
            clientListView.Columns.Add("Téléphone");

            // Insert each client data in the ListView
            foreach (var client in clients)
            {
                var item = new ListViewItem(client.Numero);
                item.SubItems.Add(client.Pronoms);
                item.SubItems.Add(client.Prenom);
                item.SubItems.Add(client.Nom);
                item.SubItems.Add(client.Rue);
                item.SubItems.Add(client.Ville);
                item.SubItems.Add(client.CodePostale);
                item.SubItems.Add(client.Region);
                item.SubItems.Add(client.Province);
                item.SubItems.Add(client.Pays);
                item.SubItems.Add(client.Adresse);
                item.SubItems.Add(client.Telephone);

                // Attach the client object to the item for easy retrieval
                item.Tag = client;

                clientListView.Items.Add(item);
            }

            // Auto resize columns to fit content
            clientListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Ensure single selection mode
            clientListView.MultiSelect = false;

            foreach (ColumnHeader column in clientListView.Columns)
            {
                column.Width = -2; // -2 automatically adjusts the column to the header and content
            }


        }


        public afficherLaListeDesClients()
        {
            InitializeComponent();

            ExcelHandler excel = new ExcelHandler();

            excel.OuvrirExcel("transistor.xlsx", "clients");

            clients = excel.LireClientsDepuisExcel();

            afficherLesClients(clients);


            excel.SauvegarderLeFichierExcel("transistor.xlsx");
            excel.FermerExcel();
        }

        private void listeDesClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = clientListView.SelectedIndices[0];
        }

        private void ajouterBouton_Click(object sender, EventArgs e)
        {
            AjouterUnClient ajouterUnClient = new AjouterUnClient(null);

            ajouterUnClient.Show();
        }

        private void modifierBouton_Click(object sender, EventArgs e)
        {
            AjouterUnClient ajouterUnClient = new AjouterUnClient(clients[index]);

            ajouterUnClient.Show();

        }
    }
}
