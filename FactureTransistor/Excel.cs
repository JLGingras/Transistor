using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

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
    }
}
