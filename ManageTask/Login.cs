using ClassLibraryTask;
using ClassLibraryTask.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTask
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Process.GetCurrentProcess().Kill();
            //this.Close();
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Seu sistema será encerrado.", "Aplicação fechada!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 UsuarioRepository usr = new UsuarioRepository();

                   Pessoa model = new Pessoa();
                   model.cpf = txtCpf.Text;
                   model.senha = txtSenha.Text;
                      
                if(model.cpf.Trim().ToString().Length > 0 && model.senha.Trim().ToString().Length > 0)
                {

                    Boolean validationUser = usr.ValidarAcesso(model.cpf, model.senha);
              
                        //   Console.WriteLine(validationUser);
                        if (validationUser==true)
                        {
                            Form1 form1 = new Form1();
                            this.Visible = false;
                            form1.ShowDialog();
                            MessageBox.Show("Usuario Logado com sucesso!");
                        }
                        else
                        {
                        MessageBox.Show("Login ou Senha invalidas");
                            this.Visible = true;
                        }
                }
                else
                {
                    MessageBox.Show("Digite Login e senha !");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar conta:" + ex);
            }
        }
    }
}
