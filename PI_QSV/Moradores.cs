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
    public partial class Moradores : Form
    {
        Thread nf;
        public Moradores()
        {
            InitializeComponent();
        }

        private void tB_MORADORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_MORADORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PIDataSet);

            Codigosgerais c = new Codigosgerais();
            if (c.campovazio(iD_MORADORTextBox, "ID MORADOR"))
                return;
            if (c.campovazio(nOMETextBox, "NOME"))
                return;
            if (c.campovazio(cPFMaskedTextBox, "CPF"))
                return;
            if (c.campovazio(tELEFONEMaskedTextBox, "TELEFONE"))
                return;
            if (c.campovazio(eMAILTextBox, "EMAIL"))
                return;
            if (c.campovazio(eNDERECOTextBox, "ENDERECO"))
                return;
            if (c.campovazio(nUMEROTextBox, "NUMERO"))
                return;
            if (c.campovazio(iD_VEICULOTextBox, "ID VEICULO"))
                return;
            if (c.campovazio(pLACA_VEICULOMaskedTextBox, "PLACA VEICULO"))
                return;
            if (c.campovazio(aNOTextBox, "ANO"))
                return;
            if (c.campovazio(cORTextBox, "COR"))
                return;

            MessageBox.Show("Cadastro realizado");
        }

        private void Moradores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_MORADORES'. Você pode movê-la ou removê-la conforme necessário.
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

