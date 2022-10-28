using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        EstacionamientoBLL miestacionamientoBLL = new EstacionamientoBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{ 
                Estacionamiento miestacionamiento = new Estacionamiento();

                miestacionamiento.Patentee = txtpatente.Text;

                miestacionamiento.Marca = txtmarca.Text;

                miestacionamiento.Modelo = txtmodelo.Text;

                miestacionamiento.Color = txtColor.Text;

                miestacionamiento.Nombre = txtNombre.Text;

                miestacionamiento.CantHoras = Convert.ToInt16(txtCantH.Text);

                miestacionamiento.Fecha = DateTime.Now;

                miestacionamientoBLL.Crear(miestacionamiento);
                MessageBox.Show("Se cargaron los datos correctamente");

            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

    }
}
