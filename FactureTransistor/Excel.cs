using OfficeOpenXml;
using FactureTransistor.Clients;

namespace FactureTransistor
{
    public class ExcelHandler
    {
        private ExcelPackage _package;
        private ExcelWorksheet _worksheet;

        public void OuvrirExcel(string filePath, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Créer le fichier s'il n'existe pas
            if (!File.Exists(filePath))
            {
                _package = new ExcelPackage();
                _worksheet = _package.Workbook.Worksheets.Add(sheetName); // Crée la feuille si le fichier est nouveau
                _package.SaveAs(new FileInfo(filePath));
            }
            else
            {
                // Ouvrir le fichier existant
                _package = new ExcelPackage(new FileInfo(filePath));

                // Vérifier si la feuille existe, sinon la créer
                _worksheet = _package.Workbook.Worksheets[sheetName];
                if (_worksheet == null)
                {
                    _worksheet = _package.Workbook.Worksheets.Add(sheetName); // Créer la feuille si elle n'existe pas
                }
            }
        }

        public void EcrireDonnees(List<string> donnees)
        {
            if (_worksheet == null)
            {
                throw new InvalidOperationException("La feuille Excel n'est pas ouverte.");
            }

            // Trouver la première ligne vide
            int ligneVide = _worksheet.Dimension?.End.Row + 1 ?? 1; // +1 pour aller à la ligne suivante ou commencer à 1 si la feuille est vide

            // Écrire chaque élément de la liste dans une colonne
            for (int i = 0; i < donnees.Count; i++)
            {
                _worksheet.Cells[ligneVide, i + 1].Value = donnees[i]; // i + 1 car les colonnes commencent à 1
            }
        }

        public void SauvegarderLeFichierExcel(string filePath)
        {
            if (_package != null)
            {
                _package.SaveAs(new FileInfo(filePath));
            }
            else
            {
                throw new InvalidOperationException("Le fichier Excel n'est pas ouvert.");
            }
        }

        public void FermerExcel()
        {
            if (_package != null)
            {
                _package.Dispose(); // Dispose de l'objet pour libérer les ressources
            }
        }

        public List<ClientDTO> LireClientsDepuisExcel()
        {
            var clients = new List<ClientDTO>();

            if (_worksheet == null)
            {
                throw new InvalidOperationException("La feuille Excel n'est pas ouverte.");
            }

            // Vérifier que la feuille contient des donnéesSS
            if (_worksheet.Dimension == null)
            {
                throw new InvalidOperationException("La feuille Excel est vide.");
            }

            // Parcourir chaque ligne à partir de la première ligne de données
            for (int row = 1; row <= _worksheet.Dimension.End.Row; row++) // Commencer à 2 pour ignorer l'en-tête
            {
                string numero = row.ToString();
                string pronoms = _worksheet.Cells[row, 1]?.Value?.ToString() ?? "";
                string prenom = _worksheet.Cells[row, 2]?.Value?.ToString() ?? "";
                string nom = _worksheet.Cells[row, 3]?.Value?.ToString() ?? "";
                string rue = _worksheet.Cells[row, 4]?.Value?.ToString() ?? "";
                string ville = _worksheet.Cells[row, 5]?.Value?.ToString() ?? "";
                string codePostale = _worksheet.Cells[row, 6]?.Value?.ToString() ?? "";
                string region = _worksheet.Cells[row, 7]?.Value?.ToString() ?? "";
                string province = _worksheet.Cells[row, 8]?.Value?.ToString() ?? "";
                string pays = _worksheet.Cells[row, 9]?.Value?.ToString() ?? "";
                string adresse = _worksheet.Cells[row, 10]?.Value?.ToString() ?? "";
                string telephone = _worksheet.Cells[row, 11]?.Value?.ToString() ?? "";

                // Ajouter un nouveau client à la liste
                clients.Add(new ClientDTO(numero,pronoms, prenom, nom, rue, ville, codePostale, region, province, pays, adresse, telephone));

            }

            return clients;
        }

    }
}
