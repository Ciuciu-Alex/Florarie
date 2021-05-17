using ManagementFlorarie.BusinessLogic;
using ManagementFlorarie.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class ModificaAngajat : Form
    {
        private ContainerBL _contrainerBL;
        private PageMode _pageMode;
        private Guid _selectedAngajatID;
        private Action _refreshViewDataSource;
        private bool _isUserNameChanged = false;

        public ModificaAngajat(ContainerBL containerBL,PageMode pageMode, Guid selectedAngajatID, Action refreshViewDataSource)
        {
            InitializeComponent();
            _contrainerBL = containerBL;
            _pageMode = pageMode;
            _selectedAngajatID = selectedAngajatID;
            _refreshViewDataSource = refreshViewDataSource;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            usernameTextBox.TextChanged += UsernameTextBox_TextChanged;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
          _isUserNameChanged = true;
        }

        public void ShowPage()
        {
            if (PageMode.Create == _pageMode)
            {
                this.Show();
                return;
            }
            UserAngajat userAngajat = _contrainerBL.AngajatBL.ReadAngajatDupaID(_selectedAngajatID);
            PopulatePage(userAngajat);
            this.Show();
        }

        private void PopulatePage(UserAngajat userAngajat)
        {
            numeAngajatTextBox.Text = userAngajat.Nume;
            emailTextBox.Text = userAngajat.Email;
            numarTelefonTextBox.Text = userAngajat.NumarTelefon;
            adresaTextBox.Text = userAngajat.Adresa;
            usernameTextBox.Text = userAngajat.Username;
            parolaTextBox.Text = userAngajat.Parola;
            adminRadioButton.Checked = userAngajat.Rol == Rol.Admin ? true : false;
        }

        private void SalveazaAngajat_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInformation())
            {
                return;
            }
            if (PageMode.Create == _pageMode)
            {
                InsertUserAngajat();
                MessageBox.Show("Angajatul a fost creat cu succes!");
                this.Hide();
                _refreshViewDataSource();
                return;
            }
            UpdateUserAngajat();
            MessageBox.Show("Angajatul a fost modificat cu succes!!");
            this.Hide();
            _refreshViewDataSource();
        }

        public void InsertUserAngajat()
        {
            Angajat angajat = new Angajat
            {
                ID_Angajat = Guid.NewGuid(),
                Nume = numeAngajatTextBox.Text.ToUpper(),
                Email = emailTextBox.Text,
                NumarTelefon = numarTelefonTextBox.Text,
                Adresa = adresaTextBox.Text,
            };
            _contrainerBL.AngajatBL.Insert(angajat);
            Utilizator user = new Utilizator
            {
                ID_Angajat = angajat.ID_Angajat,
                Username = usernameTextBox.Text.ToUpper(),
                Parola = parolaTextBox.Text,
                Rol = adminRadioButton.Checked ? Rol.Admin : Rol.Angajat,
            };
            _contrainerBL.UserBL.Insert(user);
        }

        public void UpdateUserAngajat()
        {
            Angajat angajat = new Angajat
            {
                ID_Angajat = _selectedAngajatID,
                Nume = numeAngajatTextBox.Text.ToUpper(),
                Email = emailTextBox.Text,
                NumarTelefon = numarTelefonTextBox.Text,
                Adresa = adresaTextBox.Text,
            };
            _contrainerBL.AngajatBL.Update(angajat);
            Utilizator user = new Utilizator
            {
                ID_Angajat = angajat.ID_Angajat,
                Username = usernameTextBox.Text.ToUpper(),
                Parola = parolaTextBox.Text,
                Rol = adminRadioButton.Checked ? Rol.Admin : Rol.Angajat,
            };
            _contrainerBL.UserBL.Update(user);
        }

        public bool ValidateUserInformation()
        {
            if (numeAngajatTextBox.Text == string.Empty)
            {
                MessageBox.Show("Numele nu poate fi gol.");
                return false;
            }
            if (emailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Email-ul nu poate fi gol.");
                return false;
            }
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = emailRegex.Match(emailTextBox.Text);
            if (!emailMatch.Success)
            {
                MessageBox.Show("Email-ul este invalid.");
                return false;
            }
            if (numarTelefonTextBox.Text == string.Empty)
            {
                MessageBox.Show("Numar telefon nu poate fi gol.");
                return false;
            }
            Regex numberRegex = new Regex(@"^(?<paren>\()?0(?:(?:72|73|74|75|76|77|78)(?(paren)\))(?<first>\d)(?!\k<first>{6})\d{6}|(?:251|351)(?(paren)\))(?<first>\d)(?!\k<first>{5})\d{5})$");
            Match numberMatch = numberRegex.Match(numarTelefonTextBox.Text);
            if (!numberMatch.Success)
            {
                MessageBox.Show("Numarul este invalid.");
                return false;
            }
            if (adresaTextBox.Text == string.Empty)
            {
                MessageBox.Show("Adresa nu poate fi gol.");
                return false;
            }
            if (usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Username nu poate fi gol.");
                return false;
            }
            Utilizator utilizator = _contrainerBL.UserBL.ReadByUsername(usernameTextBox.Text);
            if (_isUserNameChanged && utilizator != null && usernameTextBox.Text.ToUpper() == utilizator.Username)
            {
                MessageBox.Show("Exista deja acest nume de utilizator.");
                return false;
            }
            if (parolaTextBox.Text == string.Empty)
            {
                MessageBox.Show("Parola nu poate fi gol.");
                return false;
            }
            if (parolaTextBox.Text != string.Empty && parolaTextBox.Text.Length < 5)
            {
                MessageBox.Show("Parola este prea slaba\nIntroduceti una care sa aiba cel putin 5 caractere.");
                return false;
            }
            return true;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                parolaTextBox.UseSystemPasswordChar = true;
                CheckBox checkBox = (CheckBox)sender;
                checkBox.Text = "Hide";
            }
            else
            {
                parolaTextBox.UseSystemPasswordChar = false;
                CheckBox checkBox = (CheckBox)sender;
                checkBox.Text = "View";
            }
        }
    }
}
