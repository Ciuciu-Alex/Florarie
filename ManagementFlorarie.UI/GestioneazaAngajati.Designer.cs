
namespace ManagementFlorarie.UI
{
    partial class GestioneazaAngajati
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
            this.adaugaAngajatButton = new System.Windows.Forms.Button();
            this.modificaAngajatButton = new System.Windows.Forms.Button();
            this.stergeAngajatButton = new System.Windows.Forms.Button();
            this.angajatiDataGridView = new System.Windows.Forms.DataGridView();
            this.PreviewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaAngajatButton
            // 
            this.adaugaAngajatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.adaugaAngajatButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaAngajatButton.Location = new System.Drawing.Point(29, 35);
            this.adaugaAngajatButton.Name = "adaugaAngajatButton";
            this.adaugaAngajatButton.Size = new System.Drawing.Size(203, 47);
            this.adaugaAngajatButton.TabIndex = 0;
            this.adaugaAngajatButton.Text = "Adauga";
            this.adaugaAngajatButton.UseVisualStyleBackColor = true;
            this.adaugaAngajatButton.Click += new System.EventHandler(this.AdaugaAngajat_Click);
            // 
            // modificaAngajatButton
            // 
            this.modificaAngajatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.modificaAngajatButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaAngajatButton.Location = new System.Drawing.Point(307, 35);
            this.modificaAngajatButton.Name = "modificaAngajatButton";
            this.modificaAngajatButton.Size = new System.Drawing.Size(203, 47);
            this.modificaAngajatButton.TabIndex = 1;
            this.modificaAngajatButton.Text = "Modifica";
            this.modificaAngajatButton.UseVisualStyleBackColor = true;
            this.modificaAngajatButton.Click += new System.EventHandler(this.ModificaAngajat_Click);
            // 
            // stergeAngajatButton
            // 
            this.stergeAngajatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.stergeAngajatButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeAngajatButton.Location = new System.Drawing.Point(576, 35);
            this.stergeAngajatButton.Name = "stergeAngajatButton";
            this.stergeAngajatButton.Size = new System.Drawing.Size(203, 47);
            this.stergeAngajatButton.TabIndex = 2;
            this.stergeAngajatButton.Text = "Sterge";
            this.stergeAngajatButton.UseVisualStyleBackColor = true;
            this.stergeAngajatButton.Click += new System.EventHandler(this.StergeAngajat_Click);
            // 
            // angajatiDataGridView
            // 
            this.angajatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.angajatiDataGridView.Location = new System.Drawing.Point(-1, 197);
            this.angajatiDataGridView.Name = "angajatiDataGridView";
            this.angajatiDataGridView.Size = new System.Drawing.Size(800, 194);
            this.angajatiDataGridView.TabIndex = 3;
            this.angajatiDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PreviewButton
            // 
            this.PreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.PreviewButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewButton.Location = new System.Drawing.Point(13, 4);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(41, 25);
            this.PreviewButton.TabIndex = 4;
            this.PreviewButton.Text = "Back";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // GestioneazaAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManagementFlorarie.UI.Properties.Resources.ModificaComanda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 391);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.angajatiDataGridView);
            this.Controls.Add(this.stergeAngajatButton);
            this.Controls.Add(this.modificaAngajatButton);
            this.Controls.Add(this.adaugaAngajatButton);
            this.Name = "GestioneazaAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestioneazaAngajati";
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adaugaAngajatButton;
        private System.Windows.Forms.Button modificaAngajatButton;
        private System.Windows.Forms.Button stergeAngajatButton;
        private System.Windows.Forms.DataGridView angajatiDataGridView;
        private System.Windows.Forms.Button PreviewButton;
    }
}