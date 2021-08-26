
namespace SistemaHotelaria.forms
{
    partial class opcoesHospedes
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
            this.btnCadastrarHospede = new System.Windows.Forms.Button();
            this.btnVisualizarHospede = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarHospede
            // 
            this.btnCadastrarHospede.Location = new System.Drawing.Point(43, 69);
            this.btnCadastrarHospede.Name = "btnCadastrarHospede";
            this.btnCadastrarHospede.Size = new System.Drawing.Size(166, 39);
            this.btnCadastrarHospede.TabIndex = 0;
            this.btnCadastrarHospede.Text = "Cadastrar Hóspede";
            this.btnCadastrarHospede.UseVisualStyleBackColor = true;
            this.btnCadastrarHospede.Click += new System.EventHandler(this.btnCadastrarHospede_Click);
            // 
            // btnVisualizarHospede
            // 
            this.btnVisualizarHospede.Location = new System.Drawing.Point(253, 69);
            this.btnVisualizarHospede.Name = "btnVisualizarHospede";
            this.btnVisualizarHospede.Size = new System.Drawing.Size(166, 39);
            this.btnVisualizarHospede.TabIndex = 1;
            this.btnVisualizarHospede.Text = "Visualizar Hóspede";
            this.btnVisualizarHospede.UseVisualStyleBackColor = true;
            this.btnVisualizarHospede.Click += new System.EventHandler(this.btnVisualizarHospede_Click);
            // 
            // opcoesHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 185);
            this.Controls.Add(this.btnVisualizarHospede);
            this.Controls.Add(this.btnCadastrarHospede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "opcoesHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Mountain - escolha uma opção!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarHospede;
        private System.Windows.Forms.Button btnVisualizarHospede;
    }
}