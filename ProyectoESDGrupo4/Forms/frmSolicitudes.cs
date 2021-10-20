﻿using ProyectoESDGrupo4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoESDGrupo4.Forms
{
    public partial class frmSolicitudes : Form
    {
        private Lista listaSolicitudes;
        public frmSolicitudes(Lista lista)
        {
            InitializeComponent();
            this.listaSolicitudes = lista;
        }

        private void frrmSolicitudes_Load(object sender, EventArgs e)
        {
            dgvSolicitudes.DataSource = listaSolicitudes.convertirATablaDatos();
        }
    }
}
