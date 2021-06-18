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
    public partial class Consultas : Form
    {
        Thread nf;
        public Consultas()
        {
            InitializeComponent();
        }

        private void tB_MORADORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_MORADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PIDataSet);

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_VISITANTES'.
            this.tB_VISITANTESTableAdapter.Fill(this.dB_PIDataSet.TB_VISITANTES);
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_TERCEIROS'.
            this.tB_TERCEIROSTableAdapter.Fill(this.dB_PIDataSet.TB_TERCEIROS);
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_MORADORES'.
            this.tB_MORADORESTableAdapter.Fill(this.dB_PIDataSet.TB_MORADORES);

        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(novoForm);
            nf.SetApartmentState(ApartmentState.STA);
            nf.Start();
        }

        private void novoForm()
        {
            Application.Run(new Menu());
        }
    }
}
