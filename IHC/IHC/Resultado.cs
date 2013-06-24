using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHC
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }
        int cont = 1;
        private void Resultado_Load(object sender, EventArgs e)
        {
            final.Text = "";
            foreach (int conte in Arrays.conjunto)
            {
                final.AppendText(cont.ToString() + ") " + Arrays.resp[conte].ToString());
                final.AppendText(Environment.NewLine);
                final.AppendText("Comentario: " + Arrays.comentario[conte].ToString());
                final.AppendText(Environment.NewLine);
                final.AppendText(Environment.NewLine);
                cont++;
            }
        }
    }
}
