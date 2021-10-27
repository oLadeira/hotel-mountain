
namespace SistemaHotelaria
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipHospedes = new System.Windows.Forms.ToolStripButton();
            this.tipCheckin = new System.Windows.Forms.ToolStripButton();
            this.tipCheckout = new System.Windows.Forms.ToolStripButton();
            this.tipQuartos = new System.Windows.Forms.ToolStripButton();
            this.tipServicos = new System.Windows.Forms.ToolStripButton();
            this.tipFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.tipFornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipHospedes,
            this.tipCheckin,
            this.tipCheckout,
            this.tipQuartos,
            this.tipServicos,
            this.tipFuncionarios,
            this.tipFornecedores});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1173, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipHospedes
            // 
            this.tipHospedes.Image = ((System.Drawing.Image)(resources.GetObject("tipHospedes.Image")));
            this.tipHospedes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipHospedes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipHospedes.Name = "tipHospedes";
            this.tipHospedes.Size = new System.Drawing.Size(68, 83);
            this.tipHospedes.Text = "Hóspedes";
            this.tipHospedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipHospedes.Click += new System.EventHandler(this.tipHospedes_Click);
            // 
            // tipCheckin
            // 
            this.tipCheckin.Image = ((System.Drawing.Image)(resources.GetObject("tipCheckin.Image")));
            this.tipCheckin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipCheckin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipCheckin.Name = "tipCheckin";
            this.tipCheckin.Size = new System.Drawing.Size(68, 83);
            this.tipCheckin.Text = "Check-In";
            this.tipCheckin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipCheckin.Click += new System.EventHandler(this.tipCheckin_Click);
            // 
            // tipCheckout
            // 
            this.tipCheckout.Image = ((System.Drawing.Image)(resources.GetObject("tipCheckout.Image")));
            this.tipCheckout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipCheckout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipCheckout.Name = "tipCheckout";
            this.tipCheckout.Size = new System.Drawing.Size(69, 83);
            this.tipCheckout.Text = "Check-Out";
            this.tipCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipCheckout.Click += new System.EventHandler(this.tipCheckout_Click);
            // 
            // tipQuartos
            // 
            this.tipQuartos.Image = ((System.Drawing.Image)(resources.GetObject("tipQuartos.Image")));
            this.tipQuartos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipQuartos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipQuartos.Name = "tipQuartos";
            this.tipQuartos.Size = new System.Drawing.Size(68, 83);
            this.tipQuartos.Text = "Quartos";
            this.tipQuartos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipQuartos.Click += new System.EventHandler(this.tipQuartos_Click);
            // 
            // tipServicos
            // 
            this.tipServicos.Image = ((System.Drawing.Image)(resources.GetObject("tipServicos.Image")));
            this.tipServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipServicos.Name = "tipServicos";
            this.tipServicos.Size = new System.Drawing.Size(68, 83);
            this.tipServicos.Text = "Serviços";
            this.tipServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipServicos.Click += new System.EventHandler(this.tipServicos_Click);
            // 
            // tipFuncionarios
            // 
            this.tipFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tipFuncionarios.Image")));
            this.tipFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipFuncionarios.Name = "tipFuncionarios";
            this.tipFuncionarios.Size = new System.Drawing.Size(79, 83);
            this.tipFuncionarios.Text = "Funcionários";
            this.tipFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipFuncionarios.Click += new System.EventHandler(this.tipFuncionarios_Click);
            // 
            // tipFornecedores
            // 
            this.tipFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("tipFornecedores.Image")));
            this.tipFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipFornecedores.Name = "tipFornecedores";
            this.tipFornecedores.Size = new System.Drawing.Size(82, 83);
            this.tipFornecedores.Text = "Fornecedores";
            this.tipFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipFornecedores.Click += new System.EventHandler(this.tipFornecedores_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1173, 642);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Mountain - Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tipHospedes;
        private System.Windows.Forms.ToolStripButton tipCheckin;
        private System.Windows.Forms.ToolStripButton tipCheckout;
        private System.Windows.Forms.ToolStripButton tipQuartos;
        private System.Windows.Forms.ToolStripButton tipServicos;
        private System.Windows.Forms.ToolStripButton tipFuncionarios;
        private System.Windows.Forms.ToolStripButton tipFornecedores;
    }
}