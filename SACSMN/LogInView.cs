using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACSMN
{
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Aquí va la verficación de usuario y contraseña

            bool credentialsAreValid = true;

            if (credentialsAreValid)
            {
                this.Hide();
                DashboardView dashboardView = new DashboardView();
                dashboardView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserView createUserView = new CreateUserView();
            createUserView.ShowDialog();
        }
    }
}
