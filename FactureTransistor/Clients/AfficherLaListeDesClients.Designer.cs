namespace FactureTransistor.Clients
{
    partial class afficherLaListeDesClients
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
            clientListView = new ListView();
            supprimerBouton = new Button();
            modifierBouton = new Button();
            ajouterBouton = new Button();
            sleectionnerBouton = new Button();
            SuspendLayout();
            // 
            // clientListView
            // 
            clientListView.FullRowSelect = true;
            clientListView.GridLines = true;
            clientListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            clientListView.Location = new Point(12, 12);
            clientListView.Name = "clientListView";
            clientListView.Size = new Size(1041, 404);
            clientListView.TabIndex = 0;
            clientListView.UseCompatibleStateImageBehavior = false;
            clientListView.View = View.Details;
            // 
            // supprimerBouton
            // 
            supprimerBouton.Location = new Point(966, 422);
            supprimerBouton.Name = "supprimerBouton";
            supprimerBouton.Size = new Size(87, 23);
            supprimerBouton.TabIndex = 1;
            supprimerBouton.Text = "Supprimer";
            supprimerBouton.UseVisualStyleBackColor = true;
            // 
            // modifierBouton
            // 
            modifierBouton.Location = new Point(873, 422);
            modifierBouton.Name = "modifierBouton";
            modifierBouton.Size = new Size(87, 23);
            modifierBouton.TabIndex = 2;
            modifierBouton.Text = "Modifier";
            modifierBouton.UseVisualStyleBackColor = true;
            modifierBouton.Click += modifierBouton_Click;
            // 
            // ajouterBouton
            // 
            ajouterBouton.Location = new Point(780, 422);
            ajouterBouton.Name = "ajouterBouton";
            ajouterBouton.Size = new Size(87, 23);
            ajouterBouton.TabIndex = 3;
            ajouterBouton.Text = "Ajouter";
            ajouterBouton.UseVisualStyleBackColor = true;
            ajouterBouton.Click += ajouterBouton_Click;
            // 
            // sleectionnerBouton
            // 
            sleectionnerBouton.Location = new Point(687, 422);
            sleectionnerBouton.Name = "sleectionnerBouton";
            sleectionnerBouton.Size = new Size(87, 23);
            sleectionnerBouton.TabIndex = 4;
            sleectionnerBouton.Text = "Sélectionner";
            sleectionnerBouton.UseVisualStyleBackColor = true;
            // 
            // afficherLaListeDesClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 452);
            Controls.Add(sleectionnerBouton);
            Controls.Add(ajouterBouton);
            Controls.Add(modifierBouton);
            Controls.Add(supprimerBouton);
            Controls.Add(clientListView);
            Name = "afficherLaListeDesClients";
            Text = "Liste des clients";
            ResumeLayout(false);
        }

        #endregion

        private ListView clientListView;
        private Button supprimerBouton;
        private Button modifierBouton;
        private Button ajouterBouton;
        private Button sleectionnerBouton;
    }
}