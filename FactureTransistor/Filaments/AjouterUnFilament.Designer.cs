namespace FactureTransistor.Filaments
{
    partial class AjouterUnFilament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filamentGroupBox = new GroupBox();
            typeComboBox = new ComboBox();
            marqueTextBox = new TextBox();
            identifiantTextBox = new TextBox();
            identifiantLabel = new Label();
            label3 = new Label();
            marqueLabel = new Label();
            typeLabel = new Label();
            inventaireGroupBox = new GroupBox();
            inventaireDataGridView = new DataGridView();
            enregistrerBouton = new Button();
            annulerBouton = new Button();
            descriptionGroupBox = new GroupBox();
            descriptionRichTextBox = new RichTextBox();
            filamentGroupBox.SuspendLayout();
            inventaireGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventaireDataGridView).BeginInit();
            descriptionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filamentGroupBox
            // 
            filamentGroupBox.Controls.Add(typeComboBox);
            filamentGroupBox.Controls.Add(marqueTextBox);
            filamentGroupBox.Controls.Add(identifiantTextBox);
            filamentGroupBox.Controls.Add(identifiantLabel);
            filamentGroupBox.Controls.Add(label3);
            filamentGroupBox.Controls.Add(marqueLabel);
            filamentGroupBox.Controls.Add(typeLabel);
            filamentGroupBox.Location = new Point(12, 12);
            filamentGroupBox.Name = "filamentGroupBox";
            filamentGroupBox.Size = new Size(370, 126);
            filamentGroupBox.TabIndex = 0;
            filamentGroupBox.TabStop = false;
            filamentGroupBox.Text = "Filament";
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Aucun sélection", "PLA", "ABS", "PETG ( PET, PETT )", "TPE, TPU, TPC (Flexible)", "Nylon (PA)", "PC (Polycarbonate)", "Wood-Filled", "Metal-Filled", "Environmentally-Friendly ( Recycled ) ", "Conductive", "Glow-in-the-Dark", "Magnetic", "Color-Changing", "Dichromatic", "Clay/Ceramic", "Carbon Fiber", "Glass Fiber", "Metal", "HIPS", "PVA", "High-Speed/ Draft", "Cleaning", "Wax/Castable", "ASA", "Polypropylene (PP)", "PC / ABS", "Acetal (POM)", "PMMA (Acrylic)" });
            typeComboBox.Location = new Point(149, 53);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(215, 28);
            typeComboBox.TabIndex = 7;
            // 
            // marqueTextBox
            // 
            marqueTextBox.Location = new Point(149, 87);
            marqueTextBox.Name = "marqueTextBox";
            marqueTextBox.Size = new Size(215, 27);
            marqueTextBox.TabIndex = 6;
            // 
            // identifiantTextBox
            // 
            identifiantTextBox.Location = new Point(149, 20);
            identifiantTextBox.Name = "identifiantTextBox";
            identifiantTextBox.Size = new Size(215, 27);
            identifiantTextBox.TabIndex = 4;
            // 
            // identifiantLabel
            // 
            identifiantLabel.AutoSize = true;
            identifiantLabel.Location = new Point(6, 27);
            identifiantLabel.Name = "identifiantLabel";
            identifiantLabel.Size = new Size(77, 20);
            identifiantLabel.TabIndex = 3;
            identifiantLabel.Text = "Identifiant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 23);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // marqueLabel
            // 
            marqueLabel.AutoSize = true;
            marqueLabel.Location = new Point(6, 89);
            marqueLabel.Name = "marqueLabel";
            marqueLabel.Size = new Size(60, 20);
            marqueLabel.TabIndex = 1;
            marqueLabel.Text = "Marque";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(6, 56);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(40, 20);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Type";
            // 
            // inventaireGroupBox
            // 
            inventaireGroupBox.Controls.Add(inventaireDataGridView);
            inventaireGroupBox.Location = new Point(389, 12);
            inventaireGroupBox.Name = "inventaireGroupBox";
            inventaireGroupBox.Size = new Size(370, 487);
            inventaireGroupBox.TabIndex = 1;
            inventaireGroupBox.TabStop = false;
            inventaireGroupBox.Text = "Inventaire";
            // 
            // inventaireDataGridView
            // 
            inventaireDataGridView.AllowUserToResizeColumns = false;
            inventaireDataGridView.AllowUserToResizeRows = false;
            inventaireDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventaireDataGridView.BackgroundColor = SystemColors.Control;
            inventaireDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventaireDataGridView.GridColor = SystemColors.HighlightText;
            inventaireDataGridView.Location = new Point(6, 26);
            inventaireDataGridView.MultiSelect = false;
            inventaireDataGridView.Name = "inventaireDataGridView";
            inventaireDataGridView.RowHeadersWidth = 51;
            inventaireDataGridView.Size = new Size(358, 455);
            inventaireDataGridView.TabIndex = 0;
            // 
            // enregistrerBouton
            // 
            enregistrerBouton.Location = new Point(565, 505);
            enregistrerBouton.Name = "enregistrerBouton";
            enregistrerBouton.Size = new Size(94, 29);
            enregistrerBouton.TabIndex = 2;
            enregistrerBouton.Text = "Enregistrer";
            enregistrerBouton.UseVisualStyleBackColor = true;
            enregistrerBouton.Click += Enregistrer_Click;
            // 
            // annulerBouton
            // 
            annulerBouton.Location = new Point(665, 505);
            annulerBouton.Name = "annulerBouton";
            annulerBouton.Size = new Size(94, 29);
            annulerBouton.TabIndex = 3;
            annulerBouton.Text = "Annuler";
            annulerBouton.UseVisualStyleBackColor = true;
            annulerBouton.Click += button1_Click;
            // 
            // descriptionGroupBox
            // 
            descriptionGroupBox.Controls.Add(descriptionRichTextBox);
            descriptionGroupBox.Location = new Point(12, 144);
            descriptionGroupBox.Name = "descriptionGroupBox";
            descriptionGroupBox.Size = new Size(370, 355);
            descriptionGroupBox.TabIndex = 4;
            descriptionGroupBox.TabStop = false;
            descriptionGroupBox.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(6, 26);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(358, 323);
            descriptionRichTextBox.TabIndex = 0;
            descriptionRichTextBox.Text = "";
            // 
            // AjouterUnFilament
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(771, 542);
            Controls.Add(descriptionGroupBox);
            Controls.Add(annulerBouton);
            Controls.Add(enregistrerBouton);
            Controls.Add(inventaireGroupBox);
            Controls.Add(filamentGroupBox);
            Name = "AjouterUnFilament";
            Text = "Ajouter un filament";
            filamentGroupBox.ResumeLayout(false);
            filamentGroupBox.PerformLayout();
            inventaireGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inventaireDataGridView).EndInit();
            descriptionGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filamentGroupBox;
        private Label label3;
        private Label marqueLabel;
        private Label typeLabel;
        private TextBox marqueTextBox;
        private TextBox identifiantTextBox;
        private Label identifiantLabel;
        private GroupBox inventaireGroupBox;
        private ComboBox typeComboBox;
        private DataGridView inventaireDataGridView;
        private Button enregistrerBouton;
        private Button annulerBouton;
        private GroupBox descriptionGroupBox;
        private RichTextBox descriptionRichTextBox;
    }
}