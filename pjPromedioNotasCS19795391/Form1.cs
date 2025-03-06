using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioNotasCS19795391
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void procesar_Click(object sender, EventArgs e)
        {
            double promedios;
            double menor;
            Promedio Datos = new Promedio();
            Datos.Nombre = Nombre.Text;
            Datos.Nota1 = double.Parse(nota1.Text);
            Datos.Nota2 = double.Parse(nota2.Text);
            Datos.Nota3 = double.Parse(nota3.Text);
            Datos.Nota4 = double.Parse(nota4.Text);
            promedios = Datos.PromedioNotas();
            Promedio.Text = promedios.ToString();
            menor = Datos.NotaMasBaja();
            NotaBaja.Text = menor.ToString();
            Condicion.Text = Datos.Condicion();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Nombre.Clear();
            nota1.Clear();
            nota2.Clear();
            nota3.Clear();
            nota4.Clear();
            Promedio.Text = "lblPromedio";
            NotaBaja.Text = "lblMasBaja";
            Condicion.Text = "lblCondicion";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    public class Promedio
    {
        public string Nombre;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public double MasBaja;
        public double promedio;
        public string mensaje;

        public double NotaMasBaja()
        {
            if (Nota1 < Nota2 && Nota1 < Nota3 && Nota1 < Nota4)
            {
                this.MasBaja = Nota1;
            }else if(Nota2 < Nota1 && Nota2 < Nota3 && Nota2 < Nota4)
            {
                this.MasBaja = Nota2;
            }else if(Nota3 < Nota2 && Nota3 < Nota1 && Nota3 < Nota4)
            {
                this.MasBaja = Nota3;
            }
            else
            {
                this.MasBaja = Nota4;
            }
            return MasBaja;
        }
        public double PromedioNotas()
        {
            this.promedio = (Nota1 + Nota2 + Nota3 + Nota4 - this.MasBaja) / 3.0;
            return promedio;
        }
        public string Condicion()
        {
            if(promedio <= 10)
            {
                this.mensaje = "Desaprobado";
            }else if(promedio <= 12.5 )
            {
                this.mensaje = "Recuperacion";
            }else if(promedio > 12.5)
            {
                this.mensaje = "Aprobado";
            }
            return mensaje;
        }
    }
}
