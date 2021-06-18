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
    public partial class Visitantes : Form
    {
        Thread nf;
        public Visitantes()
        {
            InitializeComponent();
        }

        private void tB_VISITANTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_VISITANTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PIDataSet);

            Codigosgerais c = new Codigosgerais();
            if (c.campovazio(iD_VISITANTETextBox, "ID VISITANTE "))
                return;
            if (c.campovazio(nOMETextBox, "NOME "))
                return;
            if (c.campovazio(cPFMaskedTextBox, "ID VISITANTE "))
                return;
            if (c.campovazio(tELEFONEMaskedTextBox, "TELEFONE "))
                return;
            if (c.campovazio(iD_VISITANTETextBox, "ID VISITANTE "))
                return;
            if (c.campovazio(nOME_RESPONSAVEL_ESTADIATextBox, "NOME DO RESPONSAVEL PELA ESTADIA "))
                return;
            if (c.campovazio(pLACA_VEICULOMaskedTextBox, "PLACA VEICULO "))
                return;
            if (c.campovazio(mODELOTextBox, "MODELO "))
                return;
            if (c.campovazio(aNOTextBox, "ANO "))
                return;

            MessageBox.Show("Cadastro realizado");
        }

        private void Visitantes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_PIDataSet.TB_VISITANTES'.
            this.tB_VISITANTESTableAdapter.Fill(this.dB_PIDataSet.TB_VISITANTES);

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
