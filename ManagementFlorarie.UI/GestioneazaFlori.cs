using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class GestioneazaFlori : Form
    {
        private ContainerBL _containerBL;
        private Guid _selectedIdFloare = Guid.Empty;
        public GestioneazaFlori(ContainerBL containerBL)
        {
            InitializeComponent();
            _containerBL = containerBL;
            PopulateViewDataSource();
            EnableButtons(false);
        }

        private void AdaugaFloareButton_Click(object sender, EventArgs e)
        {
            ModificaFloare modificaFloare = new ModificaFloare(_containerBL,PageMode.Create,Guid.Empty, PopulateViewDataSource);
            modificaFloare.ShowPage();
        }

        private void ModificaFloareButton_Click(object sender, EventArgs e)
        {
            ModificaFloare modificaFloare = new ModificaFloare(_containerBL, PageMode.Edit, _selectedIdFloare, PopulateViewDataSource);
            modificaFloare.ShowPage();
        }

        private void StergeFloareButton_Click(object sender, EventArgs e)
        {
            _containerBL.FloareBL.DeleteFloare(_selectedIdFloare);
            MessageBox.Show("Floare a fost stearsa cu succes!");
            PopulateViewDataSource();
        }

        private void dataGridViewGestioneazaFlori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridView dataGridView = sender as DataGridView;
            List<Floare> flori = dataGridView.DataSource as List<Floare>;
            Guid selectedFloare = flori[indexRow].ID_Floare;
            _selectedIdFloare = selectedFloare;
            EnableButtons(true);
        }

        private void PopulateViewDataSource()
        {
            List<Floare> flori = _containerBL.FloareBL.ReadFlori();
            dataGridViewGestioneazaFlori.DataSource = flori;
            for (int i = 0; i < dataGridViewGestioneazaFlori.Columns.Count; i++)
            {
                dataGridViewGestioneazaFlori.Columns[i].Width = 155;
            }
            HideColumnID();

        }

        public void HideColumnID()
        {
            dataGridViewGestioneazaFlori.Columns[0].Visible = false;
        }

        public void EnableButtons(bool enable)
        {
            ModificaFloareButton.Enabled = enable;
            StergeFloareButton.Enabled = enable;
        }

        private void PreviewButton_Click(object sender, EventArgs e)
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
    }
}
