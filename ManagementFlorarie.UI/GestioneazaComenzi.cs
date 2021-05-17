using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class GestioneazaComenzi : Form
    {
        private ContainerBL _containerBL;
        private Guid _selectedIdComanda = Guid.Empty;
        private List<ComandaAngajatFloare> _comenzi = new List<ComandaAngajatFloare>();

        public GestioneazaComenzi(ContainerBL containerBL)
        {
            InitializeComponent();
            _containerBL = containerBL;
            PopulateComboBoxStatus();
            PopulateViewDataSource();
            EnableButtons(false);
        }

        private void AdaugaComandaButton_Click(object sender, EventArgs e)
        {
            ModificaComanda modificaComanda = new ModificaComanda(_containerBL, PageMode.Create, Guid.Empty, PopulateViewDataSource);
            modificaComanda.ShowPage();
        }

        private void ModificaComandaButton_Click(object sender, EventArgs e)
        {
            ModificaComanda modificaComanda = new ModificaComanda(_containerBL, PageMode.Edit, _selectedIdComanda, PopulateViewDataSource);
            modificaComanda.ShowPage();
        }

        private void StergereComandaButton_Click(object sender, EventArgs e)
        {
            _containerBL.ComandaBL.DeleteComanda(_selectedIdComanda);
            MessageBox.Show("Comanda a fost stearsa cu succes!");
            PopulateViewDataSource();
        }

        private void PopulateViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.ReadComenzi();
            HideColumnsAboutID();

            dataGridViewGestioneazaComenzi.DataSource = comenzi;
            _comenzi = comenzi;
        }

        public void HideColumnsAboutID()
        {
            dataGridViewGestioneazaComenzi.Columns[0].Visible = false;
            dataGridViewGestioneazaComenzi.Columns[1].Visible = false;
            dataGridViewGestioneazaComenzi.Columns[4].Visible = false;
        }

        public void EnableButtons(bool enable)
        {
            ModificaComandaButton.Enabled = enable;
            StergereComandaButton.Enabled = enable;
            PrinteazaComandaButton.Enabled = enable;
        }

        private void dataGridViewGestioneazaComenzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridView dataGridView = sender as DataGridView;
            List<ComandaAngajatFloare> comenzi = dataGridView.DataSource as List<ComandaAngajatFloare>;
            Guid selectedComanda = comenzi[indexRow].ID_Comanda;
            _selectedIdComanda = selectedComanda;
            EnableButtons(true);
        }

        private void PreviewForm_Click(object sender, EventArgs e)
        {
            if (_containerBL.CurrentUser.Rol == Rol.Admin)
            {
                AdminMainForm adminMainForm = new AdminMainForm(_containerBL);
                adminMainForm.Show();
                this.Hide();
                return;
            }
            UserMainForm userMainForm = new UserMainForm(_containerBL);
            userMainForm.Show();
            this.Hide();

        }

        private void FiltrazaComenziButton_Click(object sender, EventArgs e)
        {
            FiltreazaComenzi filtreazaComenziForm = new FiltreazaComenzi(_containerBL);
            filtreazaComenziForm.Show();
        }

        public Guid GetSelectedComanda()
        {
            ComandaAngajatFloare comanda = new ComandaAngajatFloare { ID_Comanda = _selectedIdComanda };
            return comanda.ID_Comanda;
        }

        public void PopulateComboBoxStatus()
        {
            statusComandaComboBox.DataSource = GetStatusComandaAsList();
            statusComandaComboBox.DisplayMember = "Nume";
            statusComandaComboBox.ValueMember = "ID";
            statusComandaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public int GetSelectedStatus()
        {
            return statusComandaComboBox.SelectedIndex;
        }

        public List<Concept> GetStatusComandaAsList()
        {
            List<Concept> concepte = new List<Concept>();

            concepte.Add(new Concept
            {
                ID = (int)StatusComanda.Toate,
                Nume = "Toate"
            });

            concepte.Add(new Concept
            {
                ID = (int)StatusComanda.Procesare,
                Nume = "Procesare"
            });

            concepte.Add(new Concept
            {
                ID = (int)StatusComanda.Anulata,
                Nume = "Anulata"
            });

            concepte.Add(new Concept
            {
                ID = (int)StatusComanda.Finalizata,
                Nume = "Finalizata"
            });
            return concepte;
        }

        private void printeazaComandaButton_Click(object sender, EventArgs e)
        {

            List<ComandaAngajatFloare> comanda = new List<ComandaAngajatFloare>();
            Guid selectedComanda = GetSelectedComanda();
            EnableButtons(true);
            comanda.Add(_containerBL.ComandaBL.ReadComandaDupaID(selectedComanda));
            ComandaAngajatFloare comandaAngajatFloare = _containerBL.ComandaBL.ReadComandaDupaID(selectedComanda);

            #region Doar comenzile finalizate
            /*if (comandaAngajatFloare.Status != StatusComanda.Finalizata)
            //{
            //    MessageBox.Show("Comanda este: " + comandaAngajatFloare.Status+"\nComanda trebuie sa fie finalizata.");
            //    return;
            }*/
            #endregion

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void statusComandaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Concept selectedStatus = statusComandaComboBox.SelectedItem as Concept;

            if (selectedStatus.ID == (int)StatusComanda.Toate)
            {
                RefreshGridDataSourceByStatus(_comenzi);
                return;
            }

            List<ComandaAngajatFloare> comenziFiltrateDupaStatus = new List<ComandaAngajatFloare>();
            foreach (ComandaAngajatFloare comanda in _comenzi)
            {
                if (selectedStatus.ID == (int)comanda.Status)
                {
                    comenziFiltrateDupaStatus.Add(comanda);
                }
            }
            RefreshGridDataSourceByStatus(comenziFiltrateDupaStatus);
        }

        private void RefreshGridDataSourceByStatus(List<ComandaAngajatFloare> comenzi)
        {
            dataGridViewGestioneazaComenzi.DataSource = comenzi;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<ComandaAngajatFloare> comanda = new List<ComandaAngajatFloare>();
            Guid selectedComanda = GetSelectedComanda();
            EnableButtons(true);
            comanda.Add(_containerBL.ComandaBL.ReadComandaDupaID(selectedComanda));
            ComandaAngajatFloare comandaAngajatFloare = _containerBL.ComandaBL.ReadComandaDupaID(selectedComanda);

            Bitmap bitmap = Properties.Resources.Bill;
            Image image = bitmap;

            e.Graphics.DrawImage(image, 25, 25, image.Width, image.Height);
            e.Graphics.DrawString("Nume comanda: " + comandaAngajatFloare.NumeComanda, new Font("Arial", 12 , FontStyle.Regular),Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("Nume angajat: " + comandaAngajatFloare.NumeAngajat, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 310));
            e.Graphics.DrawString("Nume floare: " + comandaAngajatFloare.NumeFloare, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));
            e.Graphics.DrawString("Data comenzii: " + comandaAngajatFloare.DataComenzii.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 370));
            e.Graphics.DrawString("Data ridicarii comenzii: " + comandaAngajatFloare.DataRidicariiComenzii.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Cantitate: " + comandaAngajatFloare.Cantitate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Pret: " + comandaAngajatFloare.PretTotal + " lei", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));
            e.Graphics.DrawString("Status: " + comandaAngajatFloare.Status.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 490));
        }
    }
}
