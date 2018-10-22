namespace ManageTask
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grvDados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDados
            // 
            this.grvDados.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.grvDados.AllowUserToAddRows = false;
            this.grvDados.AllowUserToOrderColumns = true;
            this.grvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Senha,
            this.CPF});
            this.grvDados.Location = new System.Drawing.Point(12, 12);
            this.grvDados.Name = "grvDados";
            this.grvDados.Size = new System.Drawing.Size(776, 156);
            this.grvDados.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 373);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToOrderColumns = true;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 174);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(776, 106);
            this.advancedDataGridView1.TabIndex = 19;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource1_ListChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(63, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 57);
            this.dataGridView1.TabIndex = 22;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "id";
            this.Codigo.HeaderText = "id";
            this.Codigo.Name = "Codigo";
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 22;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grvDados);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.grvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDados;
        private System.Windows.Forms.Button btnBuscar;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}