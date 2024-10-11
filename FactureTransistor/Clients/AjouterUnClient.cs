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
        ClientDTO _clientDTO;
        public AjouterUnClient(ClientDTO clientDTO)
        {
            _clientDTO = clientDTO;

            InitializeComponent();
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
