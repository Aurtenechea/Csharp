using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejecicio;

namespace CarreraInterface
{
    public partial class Form1 : Form
    {
        private Carrera miCarrera;

        public Form1()
        {
            InitializeComponent();
            
            // testing
            txtNombre.Text = "Dakar 2016";
            txtFecha.Text = "22/11/16";
            txtLugar.Text = "CABA";
            // end testing


            cmbResultado.Items.Add("Por Tiempo");
            cmbResultado.Items.Add("Por Km");
            cmbResultado.SelectedItem = 0;

            foreach (Efabricante item in Enum.GetValues(typeof(Efabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miCarrera = new Carrera(this.txtNombre.Text, this.txtLugar.Text, this.txtFecha.Text);
            grpCarrera.Enabled = false;
            grpAutos.Enabled = true;
        }

        private void btnAgregarAuto_MouseClick(object sender, MouseEventArgs e)
        {
            Auto autito = new Auto(this.txtNombrePiloto.Text, (Efabricante)cmbFabricante.SelectedItem);
            this.miCarrera = this.miCarrera + autito;
            listarAutos();
        }

        public void listarAutos()
        {
            lsbListaAutos.Items.Clear();
            foreach (Auto item in this.miCarrera.listaDeAutos)
            {
                lsbListaAutos.Items.Add(item.DatosEnString);
            }
        }
        private void btnCorrer_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (cmbResultado.SelectedIndex == 0)
            { 
                this.miCarrera.correrCarrera((Tiempo) 100) ;
            }
            else if (cmbResultado.SelectedIndex == 1)
            {
                this.miCarrera.correrCarrera((Kilometro)100); 
            }

            txtResultado.Text = this.miCarrera.mostrarCarrera();

        }
    }
}
