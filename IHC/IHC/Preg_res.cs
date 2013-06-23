using System;
using System.Collections;
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
    public partial class Preg_res : Form
    {
        ArrayList preguntas = new ArrayList();
        public Preg_res()
        {
            InitializeComponent();
            
        }

        private void RDrespuesta2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDrespuesta1.Checked == true)
            {
                RDrespuesta2.Checked = false;
                RDrespuesta3.Checked = false;
                RDrespuesta4.Checked = false;
            }
        }

        private void RDrespuesta2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RDrespuesta2.Checked == true)
            {
                RDrespuesta1.Checked = false;
                RDrespuesta3.Checked = false;
                RDrespuesta4.Checked = false;
            }
        }

        private void RDrespuesta3_CheckedChanged(object sender, EventArgs e)
        {
            if (RDrespuesta3.Checked == true)
            {
                RDrespuesta2.Checked = false;
                RDrespuesta1.Checked = false;
                RDrespuesta4.Checked = false;
            }
        }

        private void RDrespuesta4_CheckedChanged(object sender, EventArgs e)
        {
            if (RDrespuesta4.Checked == true)
            {
                RDrespuesta2.Checked = false;
                RDrespuesta3.Checked = false;
                RDrespuesta1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
