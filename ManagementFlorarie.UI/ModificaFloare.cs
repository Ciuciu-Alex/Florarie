using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class ModificaFloare : Form
    {
        private ContainerBL _contrainerBL;
        private PageMode _pageMode;
        private Guid _selectedFloareID;
        private Action _refreshViewDataSource;
        private bool _isNumeFloareChanged = false;

        public ModificaFloare(ContainerBL containerBL, PageMode pageMode, Guid selectedFloareID, Action refreshViewDataSource)
        {
            InitializeComponent();
            _contrainerBL = containerBL;
            _pageMode = pageMode;
            _selectedFloareID = selectedFloareID;
            _refreshViewDataSource = refreshViewDataSource;
        }

        private void SalveazaButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFloareInformation())
            {
                return;
            }
            if (PageMode.Create == _pageMode)
            {
                InsertFloare();
                MessageBox.Show("Floarea a fost adaugata cu succes!");
                this.Hide();
                _refreshViewDataSource();
                return;
            }
            UpdateFloare();
            MessageBox.Show("Floarea a fost modificata cu succes!!");
            this.Hide();
            _refreshViewDataSource();
        }

        private void PopulatePage(Floare floare)
        {
            numeFloareTextBox.Text = floare.Nume;
            tipFloareTextBox.Text = floare.Tip;
            culoareFloareTextBox.Text = floare.Culoare;
            stocFloareTextBox.Text = Convert.ToString(floare.Cantitate);
            pretFloareTextBox.Text = Convert.ToString(floare.Pret);
        }

        public void ShowPage()
        {
            if (PageMode.Create == _pageMode)
            {
                this.Show();
                return;
            }
            Floare floare = _contrainerBL.FloareBL.ReadFloareDupaID(_selectedFloareID);
            PopulatePage(floare);
            this.Show();
        }

        public void InsertFloare()
        {
            Floare floare = new Floare
            {
                ID_Floare = Guid.NewGuid(),
                Nume = numeFloareTextBox.Text.ToUpper(),
                Tip = tipFloareTextBox.Text,
                Culoare = culoareFloareTextBox.Text,
                Cantitate = Convert.ToInt32(stocFloareTextBox.Text),
                Pret = Convert.ToInt32(pretFloareTextBox.Text),
            };
            _contrainerBL.FloareBL.InsertFloare(floare);
        }

        public void UpdateFloare()
        {
            Floare floare = new Floare
            {
                ID_Floare = _selectedFloareID,
                Nume = numeFloareTextBox.Text.ToUpper(),
                Tip = tipFloareTextBox.Text,
                Culoare = culoareFloareTextBox.Text,
                Cantitate = Convert.ToInt32(stocFloareTextBox.Text),
                Pret = Convert.ToInt32(pretFloareTextBox.Text),
            };
            _contrainerBL.FloareBL.UpdateFloare(floare);
        }

        public bool ValidateFloareInformation()
        {
            if (numeFloareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Numele florii nu poate fi empty.");
                return false;
            }
            Floare floare = _contrainerBL.FloareBL.ReadFloareDupaNume(numeFloareTextBox.Text);
            if (_isNumeFloareChanged && floare != null && numeFloareTextBox.Text.ToUpper() == floare.Nume)
            {
                MessageBox.Show("Numele florii este deja folosit.");
                return false;
            }
            if (tipFloareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Tipul florii nu poate fi empty.");
                return false;
            }
            if (culoareFloareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Culoarea florii nu poate fi empty.");
                return false;
            }
            if (stocFloareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Stocul nu poate fi empty.");
                return false;
            }
            if (pretFloareTextBox.Text == string.Empty)
            {
                MessageBox.Show("Pretul nu poate fi empty.");
                return false;
            }
            return true;
        }

        protected override void OnLoad(EventArgs e)
        {
            numeFloareTextBox.TextChanged += NumeFloareTextBox_TextChanged;
        }

        private void NumeFloareTextBox_TextChanged(object sender, EventArgs e)
        {
            _isNumeFloareChanged = true;
        }
    }
}
