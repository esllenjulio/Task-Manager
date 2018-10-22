using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTask;
using ClassLibraryTask.Entities;

namespace ManageTask
{
    public partial class Form1 : Form
    {
        private PessoaRepository dao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            FormCliente frmCli = new FormCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
           // MessageBox.Show("tewtew");
            //frmCli.IsMdiChild = this;
        }

       
    }
}
