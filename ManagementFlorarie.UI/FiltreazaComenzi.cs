using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class FiltreazaComenzi : Form
    {
        private ContainerBL _containerBL;

        public FiltreazaComenzi(ContainerBL containerBL)
        {
            InitializeComponent();
            _containerBL = containerBL;
            PopulateComenziIeftineViewDataSource();
            PopulateComenziScumpeViewDataSource();
            PopulateComenziDupaCeaMaiScumpaFloareViewDataSource();
            PopulateComenziDupaFloareScumpaViewDataSource();
            PopulateComenziDupaCeaMaiIeftinaFloareViewDataSource();
        }

        private void PopulateComenziIeftineViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.ReadComenziIeftine();
            ieftineDataGridView.DataSource = comenzi;
            ieftineDataGridView.Refresh();
            HideColumnsAboutID(ieftineDataGridView);

        }

        private void PopulateComenziScumpeViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.ReadComenziScumpe();
            scumpeDataGridView.DataSource = comenzi;
            scumpeDataGridView.Refresh();
            HideColumnsAboutID(scumpeDataGridView);
        }

        private void PopulateComenziDupaCeaMaiScumpaFloareViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.ReadComenziDupaCeaMaiScumpaFloare();
            celeMaiVanduteFloriDataGridView.DataSource = comenzi;
            celeMaiVanduteFloriDataGridView.Refresh();
            HideColumnsAboutID(celeMaiVanduteFloriDataGridView);
        }

        private void PopulateComenziDupaFloareScumpaViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.DupaFloareScumpa();
            celeMaiScumpeFloriDataGridView.DataSource = comenzi;
            celeMaiScumpeFloriDataGridView.Refresh();
            HideColumnsAboutID(celeMaiScumpeFloriDataGridView);
        }

        private void PopulateComenziDupaCeaMaiIeftinaFloareViewDataSource()
        {
            List<ComandaAngajatFloare> comenzi = _containerBL.ComandaBL.ReadComenziDupaCeaMaiIeftinaFloare();
            celeMaiIeftineFloriDataGridView.DataSource = comenzi;
            celeMaiIeftineFloriDataGridView.Refresh();
            HideColumnsAboutID(celeMaiIeftineFloriDataGridView);
        }

        public void HideColumnsAboutID(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[4].Visible = false;
        }
    }
}
