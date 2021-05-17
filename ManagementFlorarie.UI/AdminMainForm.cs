using ManagementFlorarie.BusinessLogic;
using System;
using System.Windows.Forms;

namespace ManagementFlorarie.UI
{
    public partial class AdminMainForm : Form
    {
        private ContainerBL _containerBL;
        public AdminMainForm(ContainerBL containerBL)
        {
            InitializeComponent();
            _containerBL = containerBL;
        }
      
        private void GestioneazaAngajatiButton_Click(object sender, EventArgs e)
        {
            GestioneazaAngajati gestioneazaAngajatiFrom = new GestioneazaAngajati(_containerBL);
            gestioneazaAngajatiFrom.Show();
            this.Hide();
        }

        private void GestioneazaComenziButton_Click(object sender, EventArgs e)
        {
            GestioneazaComenzi gestioneazaComenzi = new GestioneazaComenzi(_containerBL);
            gestioneazaComenzi.Show();
            this.Hide();
        }

        private void GestioneazaFlorinButton_Click(object sender, EventArgs e)
        {
            GestioneazaFlori gestioneazaFlori = new GestioneazaFlori(_containerBL);
            gestioneazaFlori.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
