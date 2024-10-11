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
    public partial class AjouterUnClient : Form
    {
        Client _clientDTO;
        public AjouterUnClient(Client clientDTO)
        {
            _clientDTO = clientDTO;

            InitializeComponent();

            if (clientDTO != null)
            {

                pronomsTextBox.Text = clientDTO.Pronoms ?? "";
                nomTextBox.Text = clientDTO.Nom ?? "";
                prenomTextBox.Text = clientDTO.Prenom ?? "";

                rueTextBox.Text = clientDTO.Rue ?? "";
                villeTextBox.Text = clientDTO.Ville ?? "";
                codePostaleTextBox.Text = clientDTO.CodePostale ?? "";

                adresseEmailTexbox.Text = clientDTO.Adresse ?? "";
                telephonetextBox.Text = clientDTO.Telephone ?? "";
            }
        }

        private void boutonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enregistrerClient_Click(object sender, EventArgs e)
        {
            ExcelHandler excel = new ExcelHandler();

            string fichier = "transistor.xlsx";

            excel.OuvrirExcel(fichier,"clients");

            List<string>  client = new List<string>
            { 
                pronomsTextBox.Text,
                nomTextBox.Text,
                prenomTextBox.Text,

                rueTextBox.Text,
                villeTextBox.Text,
                codePostaleTextBox.Text,
                regionTextBox.Text,
                provinceTextBox.Text,
                paysTextBox.Text,

                adresseEmailTexbox.Text,
                telephonetextBox.Text,
            };

            if(_clientDTO == null)
            {
                excel.EcrireDonneesALaFin(client);
            }
            else
            {
                excel.EcrireDonneesALaCellule(client, int.Parse(_clientDTO.Numero));
            }
            
            excel.SauvegarderLeFichierExcel(fichier);
            excel.FermerExcel();

            this.Close();
        }
    }
}
