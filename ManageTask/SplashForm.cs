using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTask
{
    public partial class SplashForm : Form
    {
        private Login login = new Login();
        public SplashForm()
        {
            InitializeComponent();

            prgCarregar.Minimum = 0;
            prgCarregar.Maximum = 250;
           
            timer1.Start();
            
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.prgCarregar.Value == 250)
            {
                timer1.Stop();
                this.Visible = false;
                this.login.ShowDialog();
            }
            else
            {
                this.prgCarregar.Value++;
            }
           
        }
    }
}
