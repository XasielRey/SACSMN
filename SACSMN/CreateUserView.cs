using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACSMN
{
    public partial class CreateUserView : Form
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInView logInView = new LogInView();
            logInView.ShowDialog();
        }
    }
}
