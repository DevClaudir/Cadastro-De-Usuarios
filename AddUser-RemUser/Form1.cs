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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" ||  txtSenha.Text == "")
            {
                lblErro.Text = "Verifique os campos abaixo";
                return;
            }
            userDataTableAdapter usuarios = new userDataTableAdapter();
            var dados = from linha in usuarios.GetData() select linha;
            SHA256 criptografandoSenha = SHA256.Create();
            byte[] hashbytes; string textoSemCriptografia = txtSenha.Text;

            hashbytes = criptografandoSenha.ComputeHash(Encoding.UTF8.GetBytes(textoSemCriptografia));
            string textoCriptografado = Encoding.Unicode.GetString(hashbytes);
            foreach (var dado in dados) {
                if (dado.userEmail == txtEmail.Text && dado.userPassword == textoCriptografado && dado.userRegister == true)
                {
                    Principal principal = new Principal();
                    principal.Closed += new System.EventHandler(FecharFormulario);
                    this.Hide();
                    principal.Show();
                }
            }
        }
        private void FecharFormulario(object sender, System.EventArgs e) { 
            this.Dispose();
            this.Close();
        }
    }
}