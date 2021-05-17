
namespace ManagementFlorarie.UI
{
    partial class AdminMainForm
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
            this.GestioneazaAngajatiButton = new System.Windows.Forms.Button();
            this.GestioneazaComenziButton = new System.Windows.Forms.Button();
            this.GestioneazaFlorinButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GestioneazaAngajatiButton
            // 
            this.GestioneazaAngajatiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GestioneazaAngajatiButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneazaAngajatiButton.Location = new System.Drawing.Point(574, 69);
            this.GestioneazaAngajatiButton.Name = "GestioneazaAngajatiButton";
            this.GestioneazaAngajatiButton.Size = new System.Drawing.Size(157, 45);
            this.GestioneazaAngajatiButton.TabIndex = 0;
            this.GestioneazaAngajatiButton.Text = "Gestioneaza Angajati";
            this.GestioneazaAngajatiButton.UseVisualStyleBackColor = true;
            this.GestioneazaAngajatiButton.Click += new System.EventHandler(this.GestioneazaAngajatiButton_Click);
            // 
            // GestioneazaComenziButton
            // 
            this.GestioneazaComenziButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GestioneazaComenziButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneazaComenziButton.Location = new System.Drawing.Point(574, 171);
            this.GestioneazaComenziButton.Name = "GestioneazaComenziButton";
            this.GestioneazaComenziButton.Size = new System.Drawing.Size(157, 45);
            this.GestioneazaComenziButton.TabIndex = 1;
            this.GestioneazaComenziButton.Text = "Gestioneaza Comenzi";
            this.GestioneazaComenziButton.UseVisualStyleBackColor = true;
            this.GestioneazaComenziButton.Click += new System.EventHandler(this.GestioneazaComenziButton_Click);
            // 
            // GestioneazaFlorinButton
            // 
            this.GestioneazaFlorinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GestioneazaFlorinButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneazaFlorinButton.Location = new System.Drawing.Point(574, 274);
            this.GestioneazaFlorinButton.Name = "GestioneazaFlorinButton";
            this.GestioneazaFlorinButton.Size = new System.Drawing.Size(157, 45);
            this.GestioneazaFlorinButton.TabIndex = 3;
            this.GestioneazaFlorinButton.Text = "Gestioneaza Flori";
            this.GestioneazaFlorinButton.UseVisualStyleBackColor = true;
            this.GestioneazaFlorinButton.Click += new System.EventHandler(this.GestioneazaFlorinButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(67, 171);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(157, 45);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManagementFlorarie.UI.Properties.Resources.FiltreazaComenzi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 391);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.GestioneazaFlorinButton);
            this.Controls.Add(this.GestioneazaComenziButton);
            this.Controls.Add(this.GestioneazaAngajatiButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GestioneazaAngajatiButton;
        private System.Windows.Forms.Button GestioneazaComenziButton;
        private System.Windows.Forms.Button GestioneazaFlorinButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}