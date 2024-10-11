using FactureTransistor.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactureTransistor.Filaments
{
    public partial class AjouterUnFilament : Form
    {
        Filament _filament;
        public AjouterUnFilament( Filament filament)
        {
            InitializeComponent();

            inventaireDataGridView.Columns.Add("Couleur", "Couleur");
            inventaireDataGridView.Columns.Add("Quantité", "Quantité ( G )");

            inventaireDataGridView.Columns["Quantité"].ValueType = typeof(int);

            inventaireDataGridView.AllowUserToAddRows = true;
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            ExcelHandler excel = new ExcelHandler();

            string fichier = "transistor.xlsx";

            excel.OuvrirExcel(fichier, "filaments");

            List<string> filament = new List<string>
            {
                identifiantTextBox.Text,
                typeComboBox.Text,
                marqueTextBox.Text,
                descriptionGroupBox.Text,
            };

            if (_filament == null)
            {
                excel.EcrireDonneesALaFin(filament);
            }
            else
            {
                excel.EcrireDonneesALaCellule(filament, int.Parse(_filament.Numero));
            }

            excel.SauvegarderLeFichierExcel(fichier);
            excel.FermerExcel();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
