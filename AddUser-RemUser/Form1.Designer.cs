namespace AddUser_RemUser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(89, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Digite seu Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(93, 135);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(88, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Digite sua Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(92, 151);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Location = new System.Drawing.Point(93, 193);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(92, 13);
            this.lblEsqueciSenha.TabIndex = 4;
            this.lblEsqueciSenha.TabStop = true;
            this.lblEsqueciSenha.Text = "Esquecei a senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(106, 219);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(78, 34);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 319);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.LinkLabel lblEsqueciSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblErro;
    }
}

