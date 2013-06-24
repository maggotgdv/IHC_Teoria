﻿using System;
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
        ArrayList sino = new ArrayList();
        ArrayList resp = new ArrayList();
        ArrayList comentario = new ArrayList();
        ArrayList conjunto = new ArrayList();
        string radios = "";
        int cont = 0;
        public Preg_res()
        {
            InitializeComponent();
            //Metal
            preguntas.Add( "Ponga Mucha énfasis en lo siguiente: \n mire fijamente su texto por 15 segundos, se vé mas borroso el texto?");
            sino.Add("si");
            resp.Add("Deveria cambiar su color a uno con menos azul en su composición");
            comentario.Add("Trate de usar colores e iconos estandarizados");



            preguntas.Add( "Si su aplicación esta dirigida a varios paises: \n Ud. A investigado sobre lo que significa sus iconos y textos en dichos paises?");
            sino.Add("no");
            resp.Add( "Deveria investigar lo antes dicho debido a que en alguno de esos países puede ser tomado como algo impropio según su cultura");
            comentario.Add("Trate de utilizar iconos comunes en todo el mundo");
            //TuPapa
            preguntas.Add("Su producto contiene simbolos?");
            sino.Add("si");
            resp.Add("Investigue con los iconos y simbolos que existen en su sistema.");
            comentario.Add("Para algunas culturas algunos simbolos son ofensivos.");

            preguntas.Add("Su producto contiene varios idiomas?");
            sino.Add("no");
            resp.Add("Debe saber que su software esta limitado para usuarios de su mismo idioma.");
            comentario.Add("Si usted desea que su sistema sea internacionalizado debera modificar ciertos criteros.");


            preguntas.Add("Su sistema es una guia interactiva?");
            sino.Add("si");
            resp.Add("Si su software es interactivo debera incluir algunas opciones para que este sea mas atractivo");
            comentario.Add("Se recomienda incluir dispositivos externos para una mayor experiencia de usuario.");
        }

        private void RDrespuesta2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDrespuesta1.Checked == true)
            {
                RDrespuesta2.Checked = false;
                radios = "si";
            }
        }

        private void RDrespuesta2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RDrespuesta2.Checked == true)
            {
                RDrespuesta1.Checked = false;
                radios = "no";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (sino[cont].ToString() == radios)
            {
                conjunto.Add(cont);
            }
            cont++;
            if (cont == 1) // tope de preguntas
            {
                preg.Text = preguntas[cont].ToString();
            }
            else {
                panel1.Hide();
                panel3.Hide();
                panel2.Show();
                panel2.Location = new System.Drawing.Point(4,0);
                final.Text = "";
                foreach (int conte in conjunto)
                {
                    final.Text += resp[conte].ToString();
                    final.Text += "\n";
                }
            }
            
        }

        private void Preg_res_Load(object sender, EventArgs e)
        {
            preg.Text = preguntas[cont].ToString();
            panel1.Show();
            panel3.Show();
            panel2.Hide();
        }
    }
}
