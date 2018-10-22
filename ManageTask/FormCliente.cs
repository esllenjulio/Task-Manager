using ClassLibraryTask;
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
    public partial class FormCliente : Form
    {
        private PessoaRepository dao = new PessoaRepository();
        public FormCliente()
        {
            InitializeComponent();
            grvDados.DataSource = dao.Consultar();
            bindingSource1.DataSource = dao.Consultar();

            //  MessageBox.Show("1");
         //    DataTable table = new DataTable();
            //   table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //   table. = dao.Consultar();
         //   bindingSource1.DataSource = table;
         //   advancedDataGridView1.DataSource = dao.Consultar();
            //dataGridView1.DataSource = dao.Consultar();
            Console.WriteLine(dao.Consultar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //advancedDataGridView1.DataSource = dao.Consultar();
          //  this.bindingSource1.List.Clear();
            advancedDataGridView1.DataSource = bindingSource1.DataSource;
            //lblTotal.Text = this.bindingSource1.DataSource.ToString();
           // bindingSource1.Filter = "id like '%" + '8' + "%'";
          //  lblTotal.Text = string.Format("Total: {0}", this.bindingSource1.List.Count);
           
        
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("filter: "+ this.bindingSource1.Filter);
              bindingSource1.Filter = this.advancedDataGridView1.FilterString;
             
            //  MessageBox.Show("filter2: "+ bindingSource1.DataSource);
            //   MessageBox.Show("filter2: "+ e);

            // bindingSource1.DataSource = bindingSource1.Filter;

            // this.bindingSource1.Filter = this.advancedDataGridView1.FilterString;
            //  advancedDataGridView1.DataSource = this.advancedDataGridView1.FilterString; 

            // this.advancedDataGridView1.DataSource = this.bindingSource1.DataSource;


        }



        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
             this.bindingSource1.Sort = this.advancedDataGridView1.SortString;
            //this.bindingSource1.Sort
            // MessageBox.Show(advancedDataGridView1.Rows[0].Cells[1].Value.ToString());
            //  MessageBox.Show("Sort");
            // Console.WriteLine(this.bindingSource1);
            // advancedDataGridView1.DataSource = null;
            //bindingSource1.DataSource = null;
           
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = string.Format("Total: {0}",this.bindingSource1.List.Count);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            advancedDataGridView1.DataSource = bindingSource1;
        
           // this.bindingSource1.DataSource = List.FindAll(t => tx == yourValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(this.bindingSource1.Filter);
            /// advancedDataGridView1.DataSource = this.bindingSource1.Filter;

            bindingSource1.Remove(2);
           
            Console.Read();
        }
    }
}
