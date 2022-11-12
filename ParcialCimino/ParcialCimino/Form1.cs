using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialCimino.Clases;

namespace ParcialCimino
{
    public partial class Form1 : Form
    {
        GestorVentas Gestor = new GestorVentas();
        ObsAdulto ObsAdulto = new ObsAdulto();
        ObsJoven ObsJoven = new ObsJoven();
        ObsMayor ObsMayor = new ObsMayor();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gestor.Agregar(ObsAdulto);
            Gestor.Agregar(ObsJoven);
            Gestor.Agregar(ObsMayor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Gestor.GenerarVenta();
            }

            ActualizarLB1();
            ActualizarLB2();
            ActualizarLB3();
            ActualizarLB4();
            ActualizarModa();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Gestor.GenerarVenta();
            }

            ActualizarLB1();
            ActualizarLB2();
            ActualizarLB3();
            ActualizarLB4();
            ActualizarModa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < random.Next(1,99); i++)
            {
                Gestor.GenerarVenta();
            }
            ActualizarLB1();
            ActualizarLB2();
            ActualizarLB3();
            ActualizarLB4();
            ActualizarModa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestor.GenerarVenta();
            ActualizarLB1();
            ActualizarLB2();
            ActualizarLB3();
            ActualizarLB4();
            ActualizarModa();
        }

        public void ActualizarLB1()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Jovenes " + ObsJoven.listaVentas.Count.ToString());
            listBox1.Items.Add("Adultos " + ObsAdulto.listaVentas.Count.ToString());
            listBox1.Items.Add("Mayores " + ObsMayor.listaVentas.Count.ToString());
        }

        public void ActualizarLB2()
        {
            float totalAnd =0;
            float cantidadAnd = 0;
            float totalW = 0;
            float cantidadW = 0;
            float totalM = 0;
            float cantidadM = 0;
            float totalL = 0;
            float cantidadL = 0;

            foreach (var venta in ObsJoven.listaVentas)
            {
                if(venta.SO == "Android")
                {
                    cantidadAnd++;
                    totalAnd += venta.valor;
                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;
                    totalW += venta.valor;
                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;
                    totalM += venta.valor;
                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;
                    totalL += venta.valor;
                }
            }

            foreach (var venta in ObsAdulto.listaVentas)
            {
                if (venta.SO == "Android")
                {
                    cantidadAnd++;
                    totalAnd += venta.valor;
                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;
                    totalW += venta.valor;
                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;
                    totalM += venta.valor;
                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;
                    totalL += venta.valor;
                }
            }

            foreach (var venta in ObsMayor.listaVentas)
            {
                if (venta.SO == "Android")
                {
                    cantidadAnd++;
                    totalAnd += venta.valor;
                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;
                    totalW += venta.valor;
                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;
                    totalM += venta.valor;
                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;
                    totalL += venta.valor;
                }
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Android " + (totalAnd / cantidadAnd).ToString());
            listBox2.Items.Add("Windows " + (totalW / cantidadW).ToString());
            listBox2.Items.Add("Mac " + (totalM / cantidadM).ToString());
            listBox2.Items.Add("Linux " + (totalL / cantidadL).ToString());
        }

        public void ActualizarLB3()
        {
            float cantidad = ObsAdulto.listaVentas.Count + ObsJoven.listaVentas.Count + ObsMayor.listaVentas.Count;
            listBox3.Items.Clear();
            listBox3.Items.Add("Jovenes " + ((ObsJoven.listaVentas.Count/cantidad)*100).ToString());
            listBox3.Items.Add("Adultos " + ((ObsAdulto.listaVentas.Count / cantidad)*100).ToString());
            listBox3.Items.Add("Mayores " + ((ObsMayor.listaVentas.Count / cantidad)*100).ToString());

        }

        public void ActualizarLB4()
        {
            float totalA = 0;
            float cantidadA = 0;
            float totalD = 0;
            float cantidadD = 0;
            float totalE = 0;
            float cantidadE = 0;
           

            foreach (var venta in ObsJoven.listaVentas)
            {
                if (venta.tipo == "Arcade")
                {
                    cantidadA++;
                    totalA += venta.valor;
                }
                if (venta.tipo == "Deportes")
                {
                    cantidadD++;
                    totalD += venta.valor;
                }
                if (venta.tipo == "Estrategia")
                {
                    cantidadE++;
                    totalE+= venta.valor;
                }
               
            }

            foreach (var venta in ObsAdulto.listaVentas)
            {
                if (venta.tipo == "Arcade")
                {
                    cantidadA++;
                    totalA += venta.valor;
                }
                if (venta.tipo == "Deportes")
                {
                    cantidadD++;
                    totalD += venta.valor;
                }
                if (venta.tipo == "Estrategia")
                {
                    cantidadE++;
                    totalE += venta.valor;
                }
            }

            foreach (var venta in ObsMayor.listaVentas)
            {
                if (venta.tipo == "Arcade")
                {
                    cantidadA++;
                    totalA += venta.valor;
                }
                if (venta.tipo == "Deportes")
                {
                    cantidadD++;
                    totalD += venta.valor;
                }
                if (venta.tipo == "Estrategia")
                {
                    cantidadE++;
                    totalE += venta.valor;
                }
            }
            listBox4.Items.Clear();
            listBox4.Items.Add("Arcade " + (totalA / cantidadA).ToString());
            listBox4.Items.Add("Deportes " + (totalD / cantidadD).ToString());
            listBox4.Items.Add("Estrategia " + (totalD / cantidadD).ToString());
        }

        public void ActualizarModa()
        {
            int cantidadAnd = 0;
            int cantidadW = 0;
            int cantidadM = 0;
            int cantidadL = 0;
            foreach (var venta in ObsJoven.listaVentas)
            {
                if (venta.SO == "Android")
                {
                    cantidadAnd++;
  
                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;

                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;

                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;

                }
            }

            foreach (var venta in ObsAdulto.listaVentas)
            {
                if (venta.SO == "Android")
                {
                    cantidadAnd++;

                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;

                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;

                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;

                }
            }

            foreach (var venta in ObsMayor.listaVentas)
            {
                if (venta.SO == "Android")
                {
                    cantidadAnd++;

                }
                if (venta.SO == "Windows")
                {
                    cantidadW++;
    
                }
                if (venta.SO == "Mac")
                {
                    cantidadM++;
                  
                }
                if (venta.SO == "Linux")
                {
                    cantidadL++;
                  
                }
            }
            textBox1.Text = "Linux";
            if(cantidadAnd > cantidadW && cantidadAnd > cantidadM && cantidadAnd > cantidadL) { textBox1.Text = "Android"; }
            if (cantidadW > cantidadAnd && cantidadW > cantidadM && cantidadW > cantidadL) { textBox1.Text = "Windows"; }
            if (cantidadM > cantidadAnd && cantidadM > cantidadW && cantidadM > cantidadL) { textBox1.Text = "Mac"; }

        }

    }
}
