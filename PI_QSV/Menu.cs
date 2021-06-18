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
    public partial class Menu : Form
    {
        Thread nM, nT, nV, nC;
        public Menu()
        {
            InitializeComponent();
        }

        private void btsac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, encaminhe sua solicitação para sac@qsvsystem.com.br");
        }

        private void btsaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcadastromoradores_Click(object sender, EventArgs e)
        {
            this.Close();
            nM = new Thread(novoFormM);
            nM.SetApartmentState(ApartmentState.STA);
            nM.Start();
        }

        private void novoFormM()
        {
            Application.Run(new Moradores());
        }

        private void btcadastrovisitantes_Click(object sender, EventArgs e)
        {
            this.Close();
            nT = new Thread(novoFormV);
            nT.SetApartmentState(ApartmentState.STA);
            nT.Start();
        }

        private void novoFormV()
        {
            Application.Run(new Visitantes());
        }

        private void btconsulta_Click(object sender, EventArgs e)
        {
            this.Close();
            nT = new Thread(novoFormC);
            nT.SetApartmentState(ApartmentState.STA);
            nT.Start();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void novoFormC()
        {
            Application.Run(new Consultas());
        }

        private void btcadastroterceiros_Click(object sender, EventArgs e)
        {
            this.Close();
            nT = new Thread(novoFormT);
            nT.SetApartmentState(ApartmentState.STA);
            nT.Start();
        }

        private void novoFormT()
        {
            Application.Run(new Terceiros());
        }
    }
}
