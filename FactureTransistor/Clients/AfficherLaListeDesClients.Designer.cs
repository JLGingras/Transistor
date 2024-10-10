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
            SuspendLayout();
            // 
            // clientListView
            // 
            clientListView.FullRowSelect = true;
            clientListView.GridLines = true;
            clientListView.Location = new Point(12, 12);
            clientListView.Name = "clientListView";
            clientListView.Size = new Size(1041, 426);
            clientListView.TabIndex = 0;
            clientListView.UseCompatibleStateImageBehavior = false;
            clientListView.View = View.Details;
            // 
            // afficherLaListeDesClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 452);
            Controls.Add(clientListView);
            Name = "afficherLaListeDesClients";
            Text = "AfficherLaListeDesClients";
            ResumeLayout(false);
        }

        #endregion

        private ListView clientListView;
    }
}