﻿
using Proyecto_Planilla.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Planilla
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;



            listClientes.Items.Add(cliente);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listClientes.SelectedIndex;
            listClientes.Items.RemoveAt(indice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesDao baseDeDatos = new ClientesDao();
            baseDeDatos.Conectar();

        }
    }
}
