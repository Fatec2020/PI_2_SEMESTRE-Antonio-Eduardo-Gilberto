using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PI_QSV
{
    public partial class Login : Form
    {
        Thread nf;
        public Login()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            if (textBoxlogin.Text == "admin" && textBoxsenha.Text == "1234")
            {
                this.Close();
                nf = new Thread(novoForm);
                nf.SetApartmentState(ApartmentState.STA);
                nf.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha incorreto!");
            }
        }

        private void novoForm()
        {
            Application.Run(new Menu());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
