using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class ModificaComanda : Form
    {
        private ContainerBL _containerBL;
        private PageMode _pageMode;
        private Guid _selectedComandaID;
        private Action _refreshViewDataSource;
        private bool _isNumeComandaChanged = false;

        public ModificaComanda(ContainerBL containerBL, PageMode pageMode, Guid selectedComandaID, Action refreshViewDataSource)
        {
            InitializeComponent();
            _containerBL = containerBL;
            _pageMode = pageMode;
            _selectedComandaID = selectedComandaID;
            _refreshViewDataSource = refreshViewDataSource;
        }

        public Guid GetSelectedFloare()
        {
            Floare floare = floriComboBox.SelectedItem as Floare;
            return floare.ID_Floare;
        }

        public int GetCantitateFloare()
        {
            Floare floare = floriComboBox.SelectedItem as Floare;
            return floare.Cantitate;
        }

        public int GetPretFloare()
        {
            Floare floare = floriComboBox.SelectedItem as Floare;
            return floare.Pret;
        }

        public int GetSelectedStatus()
        {
            Concept selectedStatus = statusComandaComboBox.SelectedItem as Concept;
            return selectedStatus.ID;
        }

        private void SalveazaButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFloareInformation())
            {
                return;
            }
            if (PageMode.Create == _pageMode)
            {
                InsertComanda();
                MessageBox.Show("Comanda a fost adaugata cu succes!");
                this.Hide();
                _refreshViewDataSource();
                return;
            }
            UpdateComanda();
            MessageBox.Show("Comanda a fost modificata cu succes!!");
            this.Hide();
            _refreshViewDataSource();
        }

        public void InsertComanda()
        {
            int cantitateFloare = 0;
            int pretFloare = GetPretFloare();
            ComandaAngajatFloare comanda = new ComandaAngajatFloare()
            {
                ID_Comanda = Guid.NewGuid(),
                ID_Floare = GetSelectedFloare(),
                ID_Angajat = _containerBL.CurrentUser.ID_Angajat,
                NumeComanda = numeComandaTextBox.Text.ToUpper(),
                DataComenzii = Convert.ToDateTime(dateTimePickerDataComenzii.Text),
                DataRidicariiComenzii = Convert.ToDateTime(dateTimePickerDataRidicariiComenzii.Text),
                Cantitate = Convert.ToInt32(cantitateTextBox.Text),
                Observatii = obesrvatiiTextBox.Text,
                Status = StatusComanda.Procesare,
                PretTotal = Convert.ToInt32(cantitateTextBox.Text) * pretFloare

        };
            _containerBL.ComandaBL.InsertComanda(comanda);
            cantitateFloare = GetCantitateFloare();
            cantitateFloare -= comanda.Cantitate;
            _containerBL.FloareBL.UpdateCantitateFloare(cantitateFloare,comanda.ID_Floare);
        }

        public void UpdateComanda()
        {
            int cantitateFloare = 0;
            int pretFloare = GetPretFloare();
            ComandaAngajatFloare comanda = new ComandaAngajatFloare()
            {
                ID_Comanda = _selectedComandaID,
                ID_Floare = GetSelectedFloare(),
                ID_Angajat = _containerBL.CurrentUser.ID_Angajat,
                NumeComanda = numeComandaTextBox.Text.ToUpper(),
                DataComenzii = Convert.ToDateTime(dateTimePickerDataComenzii.Text),
                DataRidicariiComenzii = Convert.ToDateTime(dateTimePickerDataRidicariiComenzii.Text),
                Cantitate = Convert.ToInt32(cantitateTextBox.Text),
                Observatii = obesrvatiiTextBox.Text,
                Status = (StatusComanda)GetSelectedStatus(),
            };
            comanda.PretTotal = Convert.ToInt32(cantitateTextBox.Text) * pretFloare;
            _containerBL.ComandaBL.UpdateComanda(comanda);
            cantitateFloare = GetCantitateFloare();
            cantitateFloare -= comanda.Cantitate;
            _containerBL.FloareBL.UpdateCantitateFloare(cantitateFloare, comanda.ID_Floare);
        }

        private void PopulatePage(ComandaAngajatFloare comanda)
        {
            PopulateComboBoxFlori();
            PopulateComboBoxStatus();
            if (_pageMode == PageMode.Edit)
            {
                Floare selectedFloare = new Floare
                {
                    ID_Floare = comanda.ID_Floare,
                    Nume = _containerBL.FloareBL.ReadFloareDupaID(comanda.ID_Floare).Nume,
                };
                Concept selectedStatus = new Concept
                {
                    ID = (int)comanda.Status,
                    Nume = Enum.GetName(typeof(StatusComanda), comanda.Status)
                };
                numeComandaTextBox.Text = comanda.NumeComanda;
                floriComboBox.SelectedIndex = floriComboBox.FindStringExact(selectedFloare.Nume);
                dateTimePickerDataComenzii.Text = Convert.ToString(comanda.DataComenzii);
                dateTimePickerDataRidicariiComenzii.Text = Convert.ToString(comanda.DataRidicariiComenzii);
                cantitateTextBox.Text = Convert.ToString(comanda.Cantitate);
                obesrvatiiTextBox.Text = comanda.Observatii;
                statusComandaComboBox.SelectedIndex = statusComandaComboBox.FindStringExact(selectedStatus.Nume);
            }
        }

        public void PopulateComboBoxFlori()
        {
            floriComboBox.DataSource = _containerBL.FloareBL.ReadFlori();
            floriComboBox.DisplayMember = "Nume";
            floriComboBox.ValueMember = "ID_Floare";
            floriComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PopulateComboBoxStatus()
        {
            statusComandaComboBox.DataSource = GetStatusComandaAsList();
            statusComandaComboBox.DisplayMember = "Nume";
            statusComandaComboBox.ValueMember = "ID";
            statusComandaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public List<Concept> GetStatusComandaAsList()
        {
            List<Concept> concepte = new List<Concept>();

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

        public void ShowPage()
        {
            if (PageMode.Create == _pageMode)
            {
                PopulatePage(null);
                this.Show();
                return;
            }
            ComandaAngajatFloare comanda = _containerBL.ComandaBL.ReadComandaDupaID(_selectedComandaID);
            PopulatePage(comanda);
            this.Show();
        }

        public bool ValidateFloareInformation()
        {
            if (numeComandaTextBox.Text == string.Empty)
            {
                MessageBox.Show("Numele comenzii nu poate fi empty!");
                return false;
            }
            ComandaAngajatFloare comanda = _containerBL.ComandaBL.ReadComandaDupaNume(numeComandaTextBox.Text);
            if (_isNumeComandaChanged && comanda!= null && numeComandaTextBox.Text.ToUpper() == comanda.NumeComanda)
            {
                MessageBox.Show("Exista deja acest nume pentru comanda!");
                return false;
            }
            if (dateTimePickerDataComenzii.Text == string.Empty)
            {
                MessageBox.Show("Selectati o data pentru comanda!");
                return false;
            }
            if (Convert.ToDateTime(dateTimePickerDataComenzii.Text) < DateTime.Today && _pageMode == PageMode.Create)
            {
                MessageBox.Show("Data comenzii este invalida!");
                return false;
            }
            if (dateTimePickerDataRidicariiComenzii.Text == string.Empty)
            {
                MessageBox.Show("Selectati data ridicarii comenzii!");
                return false;
            }
            if (dateTimePickerDataRidicariiComenzii.Value < dateTimePickerDataComenzii.Value && _pageMode == PageMode.Create)
            {
                MessageBox.Show("Data ridicarii comenzii este invalida!");
                return false;
            }
            if (cantitateTextBox.Text == string.Empty)
            {
                MessageBox.Show("Introduceti o cantitate!");
                return false;
            }
            int cantitate = Convert.ToInt32(cantitateTextBox.Text);
            if (cantitate > GetCantitateFloare())
            {
                MessageBox.Show($"Cantitatea introdusa este prea mare!\nMai avem: {GetCantitateFloare()}!");
                return false;
            }
            if (obesrvatiiTextBox.Text == string.Empty)
            {
                MessageBox.Show("Observatii nu poate fi empty.");
                return false;
            }
            return true;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            numeComandaTextBox.TextChanged += NumeComandaTextBox_TextChanged;
        }

        private void NumeComandaTextBox_TextChanged(object sender, EventArgs e)
        {
            _isNumeComandaChanged = true;
        }
    }
}
