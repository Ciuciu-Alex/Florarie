
namespace ManagementFlorarie.UI
{
    partial class GestioneazaComenzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestioneazaComenzi));
            this.AdaugaComandaButton = new System.Windows.Forms.Button();
            this.ModificaComandaButton = new System.Windows.Forms.Button();
            this.StergereComandaButton = new System.Windows.Forms.Button();
            this.dataGridViewGestioneazaComenzi = new System.Windows.Forms.DataGridView();
            this.PreviewForm = new System.Windows.Forms.Button();
            this.FiltrazaComenziButton = new System.Windows.Forms.Button();
            this.PrinteazaComandaButton = new System.Windows.Forms.Button();
            this.statusComandaComboBox = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestioneazaComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugaComandaButton
            // 
            this.AdaugaComandaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.AdaugaComandaButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaComandaButton.Location = new System.Drawing.Point(12, 74);
            this.AdaugaComandaButton.Name = "AdaugaComandaButton";
            this.AdaugaComandaButton.Size = new System.Drawing.Size(115, 35);
            this.AdaugaComandaButton.TabIndex = 0;
            this.AdaugaComandaButton.Text = "Adauga";
            this.AdaugaComandaButton.UseVisualStyleBackColor = true;
            this.AdaugaComandaButton.Click += new System.EventHandler(this.AdaugaComandaButton_Click);
            // 
            // ModificaComandaButton
            // 
            this.ModificaComandaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.ModificaComandaButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaComandaButton.Location = new System.Drawing.Point(175, 74);
            this.ModificaComandaButton.Name = "ModificaComandaButton";
            this.ModificaComandaButton.Size = new System.Drawing.Size(115, 35);
            this.ModificaComandaButton.TabIndex = 1;
            this.ModificaComandaButton.Text = "Modifica";
            this.ModificaComandaButton.UseVisualStyleBackColor = true;
            this.ModificaComandaButton.Click += new System.EventHandler(this.ModificaComandaButton_Click);
            // 
            // StergereComandaButton
            // 
            this.StergereComandaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.StergereComandaButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StergereComandaButton.Location = new System.Drawing.Point(342, 73);
            this.StergereComandaButton.Name = "StergereComandaButton";
            this.StergereComandaButton.Size = new System.Drawing.Size(115, 35);
            this.StergereComandaButton.TabIndex = 2;
            this.StergereComandaButton.Text = "Sterge";
            this.StergereComandaButton.UseVisualStyleBackColor = true;
            this.StergereComandaButton.Click += new System.EventHandler(this.StergereComandaButton_Click);
            // 
            // dataGridViewGestioneazaComenzi
            // 
            this.dataGridViewGestioneazaComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGestioneazaComenzi.Location = new System.Drawing.Point(-1, 134);
            this.dataGridViewGestioneazaComenzi.Name = "dataGridViewGestioneazaComenzi";
            this.dataGridViewGestioneazaComenzi.Size = new System.Drawing.Size(802, 257);
            this.dataGridViewGestioneazaComenzi.TabIndex = 3;
            this.dataGridViewGestioneazaComenzi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGestioneazaComenzi_CellClick);
            // 
            // PreviewForm
            // 
            this.PreviewForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.PreviewForm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewForm.Location = new System.Drawing.Point(12, 12);
            this.PreviewForm.Name = "PreviewForm";
            this.PreviewForm.Size = new System.Drawing.Size(44, 35);
            this.PreviewForm.TabIndex = 4;
            this.PreviewForm.Text = "Back";
            this.PreviewForm.UseVisualStyleBackColor = true;
            this.PreviewForm.Click += new System.EventHandler(this.PreviewForm_Click);
            // 
            // FiltrazaComenziButton
            // 
            this.FiltrazaComenziButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.FiltrazaComenziButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrazaComenziButton.Location = new System.Drawing.Point(501, 73);
            this.FiltrazaComenziButton.Name = "FiltrazaComenziButton";
            this.FiltrazaComenziButton.Size = new System.Drawing.Size(115, 36);
            this.FiltrazaComenziButton.TabIndex = 5;
            this.FiltrazaComenziButton.Text = "Filtreaza Comenzi";
            this.FiltrazaComenziButton.UseVisualStyleBackColor = true;
            this.FiltrazaComenziButton.Click += new System.EventHandler(this.FiltrazaComenziButton_Click);
            // 
            // PrinteazaComandaButton
            // 
            this.PrinteazaComandaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.PrinteazaComandaButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinteazaComandaButton.Location = new System.Drawing.Point(657, 11);
            this.PrinteazaComandaButton.Name = "PrinteazaComandaButton";
            this.PrinteazaComandaButton.Size = new System.Drawing.Size(121, 36);
            this.PrinteazaComandaButton.TabIndex = 6;
            this.PrinteazaComandaButton.Text = "Printeaza Comanda";
            this.PrinteazaComandaButton.UseVisualStyleBackColor = true;
            this.PrinteazaComandaButton.Click += new System.EventHandler(this.printeazaComandaButton_Click);
            // 
            // statusComandaComboBox
            // 
            this.statusComandaComboBox.FormattingEnabled = true;
            this.statusComandaComboBox.Location = new System.Drawing.Point(657, 82);
            this.statusComandaComboBox.Name = "statusComandaComboBox";
            this.statusComandaComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComandaComboBox.TabIndex = 7;
            this.statusComandaComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComandaComboBox_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // GestioneazaComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManagementFlorarie.UI.Properties.Resources.Flower_shop_banner_DealerInspire_FullThrottle;
            this.ClientSize = new System.Drawing.Size(799, 391);
            this.Controls.Add(this.statusComandaComboBox);
            this.Controls.Add(this.PrinteazaComandaButton);
            this.Controls.Add(this.FiltrazaComenziButton);
            this.Controls.Add(this.PreviewForm);
            this.Controls.Add(this.dataGridViewGestioneazaComenzi);
            this.Controls.Add(this.StergereComandaButton);
            this.Controls.Add(this.ModificaComandaButton);
            this.Controls.Add(this.AdaugaComandaButton);
            this.Name = "GestioneazaComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestioneazaComenzi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestioneazaComenzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugaComandaButton;
        private System.Windows.Forms.Button ModificaComandaButton;
        private System.Windows.Forms.Button StergereComandaButton;
        private System.Windows.Forms.DataGridView dataGridViewGestioneazaComenzi;
        private System.Windows.Forms.Button PreviewForm;
        private System.Windows.Forms.Button FiltrazaComenziButton;
        private System.Windows.Forms.Button PrinteazaComandaButton;
        private System.Windows.Forms.ComboBox statusComandaComboBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}