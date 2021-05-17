using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class GestioneazaAngajati : Form
    {
        private ContainerBL _containerBL;
        private Guid _selectedAngajatID = Guid.Empty;

        public GestioneazaAngajati(ContainerBL containerBL)
        {
            InitializeComponent();
            _containerBL = containerBL;
            PopulateViewDataSource();
            EnableButtons(false);
        }

        public void EnableButtons(bool enable)
        {
            modificaAngajatButton.Enabled = enable;
            stergeAngajatButton.Enabled = enable;
        }

        private void AdaugaAngajat_Click(object sender, EventArgs e)
        {
            ModificaAngajat modificaAngajatForm = new ModificaAngajat(_containerBL, PageMode.Create, Guid.Empty, PopulateViewDataSource);
            modificaAngajatForm.ShowPage();
        }

        private void ModificaAngajat_Click(object sender, EventArgs e)
        {
            ModificaAngajat modificaAngajatForm = new ModificaAngajat(_containerBL, PageMode.Edit, _selectedAngajatID, PopulateViewDataSource);
            modificaAngajatForm.ShowPage();
        }

        private void StergeAngajat_Click(object sender, EventArgs e)
        {
            _containerBL.AngajatBL.Delete(_selectedAngajatID);
            MessageBox.Show("Angajatul a fost stres cu succes!");
            PopulateViewDataSource();
        }

        public void PopulateViewDataSource()
        {
            List<Angajat> angajati = _containerBL.AngajatBL.ReadAngajati();
            angajatiDataGridView.DataSource = angajati;
            for (int i = 0; i < angajatiDataGridView.Columns.Count; i++)
            {
                angajatiDataGridView.Columns[i].Width = 190;
            }
            HideColumnID();
        }

        public void HideColumnID()
        {
            angajatiDataGridView.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridView dataGridView = sender as DataGridView;
            List<Angajat> angajati = dataGridView.DataSource as List<Angajat>;
            Guid selectedAngajat = angajati[indexRow].ID_Angajat;
            _selectedAngajatID = selectedAngajat;
            EnableButtons(true);
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm(_containerBL);
            adminMainForm.Show();
            this.Hide();
        }
    }
}
