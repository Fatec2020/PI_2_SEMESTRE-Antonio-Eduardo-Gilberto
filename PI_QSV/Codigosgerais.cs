using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_QSV
{
    class Codigosgerais
    {
        public bool campovazio(Control controle, string campo)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("Favor preencher o campo " + campo + " !");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
