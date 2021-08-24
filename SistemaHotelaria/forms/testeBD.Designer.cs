
namespace SistemaHotelaria.forms
{
    partial class testeBD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelMountainDataSet = new SistemaHotelaria.HotelMountainDataSet();
            this.funcionarioLoginTableAdapter = new SistemaHotelaria.HotelMountainDataSetTableAdapters.funcionarioLoginTableAdapter();
            this.hotelMountainDataSet1 = new SistemaHotelaria.HotelMountainDataSet1();
            this.loginFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFuncionariosTableAdapter = new SistemaHotelaria.HotelMountainDataSet1TableAdapters.loginFuncionariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMountainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMountainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFuncionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginFuncionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // funcionarioLoginBindingSource
            // 
            this.funcionarioLoginBindingSource.DataMember = "funcionarioLogin";
            this.funcionarioLoginBindingSource.DataSource = this.hotelMountainDataSet;
            // 
            // hotelMountainDataSet
            // 
            this.hotelMountainDataSet.DataSetName = "HotelMountainDataSet";
            this.hotelMountainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioLoginTableAdapter
            // 
            this.funcionarioLoginTableAdapter.ClearBeforeFill = true;
            // 
            // hotelMountainDataSet1
            // 
            this.hotelMountainDataSet1.DataSetName = "HotelMountainDataSet1";
            this.hotelMountainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginFuncionariosBindingSource
            // 
            this.loginFuncionariosBindingSource.DataMember = "loginFuncionarios";
            this.loginFuncionariosBindingSource.DataSource = this.hotelMountainDataSet1;
            // 
            // loginFuncionariosTableAdapter
            // 
            this.loginFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // testeBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 576);
            this.Controls.Add(this.dataGridView1);
            this.Name = "testeBD";
            this.Text = "testeBD";
            this.Load += new System.EventHandler(this.testeBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMountainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMountainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFuncionariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMountainDataSet hotelMountainDataSet;
        private System.Windows.Forms.BindingSource funcionarioLoginBindingSource;
        private HotelMountainDataSetTableAdapters.funcionarioLoginTableAdapter funcionarioLoginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private HotelMountainDataSet1 hotelMountainDataSet1;
        private System.Windows.Forms.BindingSource loginFuncionariosBindingSource;
        private HotelMountainDataSet1TableAdapters.loginFuncionariosTableAdapter loginFuncionariosTableAdapter;
    }
}