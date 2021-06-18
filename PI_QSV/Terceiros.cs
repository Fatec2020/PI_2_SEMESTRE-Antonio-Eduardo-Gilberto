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
    public partial class Terceiros : Form
    {
        Thread nf;
        public Terceiros()
        {
            InitializeComponent();
        }

        private void tB_TERCEIROSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_TERCEIROSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PIDataSet);

            Codigosgerais c = new Codigosgerais();
            if (c.campovazio(iD_TERCEIROTextBox, "ID TERCEIRO "))
                return;
            if (c.campovazio(nOMETextBox, "NOME "))
                return;
            if (c.campovazio(cPFMaskedTextBox, "CPF "))
                return;
            if (c.campovazio(cNPJMaskedTextBox, "CNPJ "))
                return;
            if (c.campovazio(nOME_RESPONSAVEL_ESTADIATextBox, "ID VISITANTE "))
                return;
            if (c.campovazio(tELEFONEMaskedTextBox, "TELEFONE "))
                return;
            if (c.campovazio(eNDERECOTextBox, "ENDEREÇO "))
                return;
            if (c.campovazio(nUMEROTextBox, "NOME "))
                return;
            if (c.campovazio(pLACA_VEICULOMaskedTextBox, "PLACA VEICULO "))
                return;
            if (c.campovazio(mODELOTextBox, "MODELO "))
                return;
            if (c.campovazio(aNOTextBox, "ANO "))
                return;

            MessageBox.Show("Cadastro realizado");

        }

        private void Terceiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_TERCEIROS'.
            this.tB_TERCEIROSTableAdapter.Fill(this.dB_PIDataSet.TB_TERCEIROS);

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
