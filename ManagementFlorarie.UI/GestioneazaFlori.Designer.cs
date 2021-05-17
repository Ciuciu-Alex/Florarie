
namespace ManagementFlorarie.UI
{
    partial class GestioneazaFlori
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
            this.AdaugaFloareButton = new System.Windows.Forms.Button();
            this.ModificaFloareButton = new System.Windows.Forms.Button();
            this.StergeFloareButton = new System.Windows.Forms.Button();
            this.dataGridViewGestioneazaFlori = new System.Windows.Forms.DataGridView();
            this.PreviewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestioneazaFlori)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugaFloareButton
            // 
            this.AdaugaFloareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.AdaugaFloareButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaFloareButton.Location = new System.Drawing.Point(16, 80);
            this.AdaugaFloareButton.Name = "AdaugaFloareButton";
            this.AdaugaFloareButton.Size = new System.Drawing.Size(105, 41);
            this.AdaugaFloareButton.TabIndex = 0;
            this.AdaugaFloareButton.Text = "Adauga";
            this.AdaugaFloareButton.UseVisualStyleBackColor = true;
            this.AdaugaFloareButton.Click += new System.EventHandler(this.AdaugaFloareButton_Click);
            // 
            // ModificaFloareButton
            // 
            this.ModificaFloareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.ModificaFloareButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaFloareButton.Location = new System.Drawing.Point(354, 80);
            this.ModificaFloareButton.Name = "ModificaFloareButton";
            this.ModificaFloareButton.Size = new System.Drawing.Size(105, 41);
            this.ModificaFloareButton.TabIndex = 1;
            this.ModificaFloareButton.Text = "Modifica";
            this.ModificaFloareButton.UseVisualStyleBackColor = true;
            this.ModificaFloareButton.Click += new System.EventHandler(this.ModificaFloareButton_Click);
            // 
            // StergeFloareButton
            // 
            this.StergeFloareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.StergeFloareButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StergeFloareButton.Location = new System.Drawing.Point(686, 80);
            this.StergeFloareButton.Name = "StergeFloareButton";
            this.StergeFloareButton.Size = new System.Drawing.Size(105, 41);
            this.StergeFloareButton.TabIndex = 2;
            this.StergeFloareButton.Text = "Sterge";
            this.StergeFloareButton.UseVisualStyleBackColor = true;
            this.StergeFloareButton.Click += new System.EventHandler(this.StergeFloareButton_Click);
            // 
            // dataGridViewGestioneazaFlori
            // 
            this.dataGridViewGestioneazaFlori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGestioneazaFlori.Location = new System.Drawing.Point(-1, 169);
            this.dataGridViewGestioneazaFlori.Name = "dataGridViewGestioneazaFlori";
            this.dataGridViewGestioneazaFlori.Size = new System.Drawing.Size(801, 222);
            this.dataGridViewGestioneazaFlori.TabIndex = 3;
            this.dataGridViewGestioneazaFlori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGestioneazaFlori_CellClick);
            // 
            // PreviewButton
            // 
            this.PreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.PreviewButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewButton.Location = new System.Drawing.Point(12, 12);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(46, 23);
            this.PreviewButton.TabIndex = 4;
            this.PreviewButton.Text = "Back";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // GestioneazaFlori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManagementFlorarie.UI.Properties.Resources.GestioneazaAngajati;
            this.ClientSize = new System.Drawing.Size(799, 391);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.dataGridViewGestioneazaFlori);
            this.Controls.Add(this.StergeFloareButton);
            this.Controls.Add(this.ModificaFloareButton);
            this.Controls.Add(this.AdaugaFloareButton);
            this.Name = "GestioneazaFlori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestioneazaFlori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestioneazaFlori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugaFloareButton;
        private System.Windows.Forms.Button ModificaFloareButton;
        private System.Windows.Forms.Button StergeFloareButton;
        private System.Windows.Forms.DataGridView dataGridViewGestioneazaFlori;
        private System.Windows.Forms.Button PreviewButton;
    }
}