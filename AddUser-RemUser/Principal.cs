using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddUser_RemUser.cadastrandoUsuariosDataSetTableAdapters;

namespace AddUser_RemUser
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Cancelar") {
                txtCargo.Text = "";
                txtEmail.Text = "";
                txtID.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
                cbAtivo.Checked = false;
                dtpDataCadastro.Value = DateTime.Now;
                btnAdicionar.Text = "Adicionar";
                lboUsuarios.Clear();
            }
        }
    }
}
