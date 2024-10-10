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
        public AjouterUnClient()
        {
            InitializeComponent();
        }

        private void boutonAnnuler_Click(object sender, EventArgs e)
        {
    
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

            excel.EcrireDonnees(client);
            excel.SauvegarderLeFichierExcel(fichier);
            excel.FermerExcel();
        }
    }
}
