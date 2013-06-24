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
        public Preg_res()
        {
            InitializeComponent();
            //Metal
            Arrays.preguntas.Add("Ponga Mucha énfasis en lo siguiente: \n mire fijamente su texto por 15 segundos, se vé mas borroso el texto?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("Deberia cambiar su color a uno con menos azul en su composición");
            Arrays.comentario.Add("Trate de usar colores e iconos estandarizados");



            Arrays.preguntas.Add("Si su aplicación esta dirigida a varios paises: \n Ud. A investigado sobre lo que significa sus iconos y textos en dichos paises?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Deberia investigar lo antes dicho debido a que en alguno de esos países puede ser\ntomado como algo impropio según su cultura");
            Arrays.comentario.Add("Trate de utilizar iconos comunes en todo el mundo");
            
            //TuPapa
            Arrays.preguntas.Add("Su producto contiene simbolos?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("Investigue con los iconos y simbolos que existen en su sistema.");
            Arrays.comentario.Add("Para algunas culturas algunos simbolos son ofensivos.");

            Arrays.preguntas.Add("Su producto contiene varios idiomas?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Debe saber que su software esta limitado para usuarios de su mismo idioma.");
            Arrays.comentario.Add("Si usted desea que su sistema sea internacionalizado debera modificar ciertos\n criteros.");


            Arrays.preguntas.Add("Su sistema es una guia interactiva?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("Si su software es interactivo debera incluir algunas opciones para que este sea mas atractivo");
            Arrays.comentario.Add("Se recomienda incluir dispositivos externos para una mayor experiencia de usuario.");
            
            //JACKSITO 
            Arrays.preguntas.Add("Tu aplicacion cuenta con desplazamiento entre pantallas?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Su aplicacion puede funcionar mas correctamente puesto que sin navegacion el usuario no sabra en que pantalla se encuentra ni donde esta la informacion que deseaba");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Tu aplicacion se descuadra de acuerdo a la horientacion de la pantalla?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("bueno su aplicacion no cuenta con navegacion, le faltan agrupar elementos por paneles");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Tu aplicacion tiene soporte tecnico?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Tiene que tener su aplicacion para que sea versatil y con apoyo que lo ayudara a se popular");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Su aplicacion puede ser personalizable de acuerdo a diferentes gustos?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("puede funcionar normalmente pero con una porcion menos de usuarios");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Su aplicacion no tiene progreso como niveles?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("Su aplicacion sera agradable a los usuarios que no le gustan siempre lo mismo");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Su aplicacion es complicada de entender o tiene alguna guia al comienzo?");
            Arrays.sino.Add("si");
            Arrays.resp.Add("Su aplicacion no tendra mucha afluencia de usuarios puesto que no estan dispuestos a entregar mucho tiempo a aprender mas solo a usar");
            Arrays.comentario.Add("");

            Arrays.preguntas.Add("Su aplicacion esta disponible en varios dispositivos (smartphones, tables, etc)?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Su aplicancion funcionara correctamente pero no tendra la misma afluencia de usuarios que los que si disponen");
            Arrays.comentario.Add("");
            //Pollo
            //Pregunta metafora 1
            Arrays.preguntas.Add("Se usan o usaran, iconos, etiquetas o imagenes referidos a \nutiles, personas, lugares o accesorios de la vida cotidiana?");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Su aplicacion no contiene metaforas de las que se pueda apoyar para la comprension de su programa");
            Arrays.comentario.Add("Seria mejor factible si tubiera algunas para que sea mucho mas amigable");
            //Pregunta metafora 2
            Arrays.preguntas.Add("Se usan referencias sobre acciones de la vida cotidiana");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Su aplicacion no contiene una metaforas globales para la comprension de su programa");
            Arrays.comentario.Add("Seria mejor factible si tubiera algunas para que sea mucho mas amigable");
            //Pregunta Discapacidades 1
            Arrays.preguntas.Add("La Aplicacion tiene mas de una forma de uso(sentidos humanos)");
            Arrays.sino.Add("no");
            Arrays.resp.Add(" Podia existir el caso que una persona con discapacidad pueda usar su aplicacion lo cual no es accesible para todo tiepo de usuarios");
            Arrays.comentario.Add("Evaluando el objetivo de su aplicacion quiza pueda extender un poco mas su campo de usuarios que lo usaran creando mayor accesabilidad");
            //Pregunta Discapacidades 2
            Arrays.preguntas.Add("Su Aplicacion tiene un Manual de usuario");
            Arrays.sino.Add("no");
            Arrays.resp.Add("Puede que usuarios no entrenados en el tipo de aplicaciones que usa, desconoscan su manejo por lo cual una ayuda pueda ser el manual con toda la navegacion de la aplicacion ");
            Arrays.comentario.Add("Cree un Manual de usuario, teniendo una diferente profundidad segun su objetivo");



        }

        private void RDrespuesta2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDrespuesta1.Checked == true)
            {
                RDrespuesta2.Checked = false;
                Arrays.radios = "si";
            }
        }

        private void RDrespuesta2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RDrespuesta2.Checked == true)
            {
                RDrespuesta1.Checked = false;
                Arrays.radios = "no";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Arrays.sino[Arrays.cont].ToString() == Arrays.radios)
            {
                Arrays.conjunto.Add(Arrays.cont);
            }
            Arrays.cont++;
            if (Arrays.cont < Arrays.preguntas.Count)
            {
                preg.Text = Arrays.preguntas[Arrays.cont].ToString();
            }
            else {
                Resultado a = new Resultado();
                a.Show();
                this.Visible = false;
            }
            
        }

        private void Preg_res_Load(object sender, EventArgs e)
        {
            preg.Text = Arrays.preguntas[Arrays.cont].ToString();
        }
    }
}
