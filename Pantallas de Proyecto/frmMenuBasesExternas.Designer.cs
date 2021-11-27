
namespace Pantallas_de_Proyecto
{
    partial class frmMenuBasesExternas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarYSalir = new System.Windows.Forms.Button();
            this.btnBasesExternas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaEmpresasAdmin = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnCancelarYSalir);
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(196, 722);
            this.groupBox3.TabIndex = 123;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_de_Proyecto.Properties.Resources.logo_3__2_;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarYSalir
            // 
            this.btnCancelarYSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarYSalir.Location = new System.Drawing.Point(37, 446);
            this.btnCancelarYSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarYSalir.Name = "btnCancelarYSalir";
            this.btnCancelarYSalir.Size = new System.Drawing.Size(110, 84);
            this.btnCancelarYSalir.TabIndex = 15;
            this.btnCancelarYSalir.Text = "Cancelar y Salir";
            this.btnCancelarYSalir.UseVisualStyleBackColor = false;
            this.btnCancelarYSalir.Click += new System.EventHandler(this.btnCancelarYSalir_Click);
            // 
            // btnBasesExternas
            // 
            this.btnBasesExternas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBasesExternas.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasesExternas.Location = new System.Drawing.Point(241, 119);
            this.btnBasesExternas.Margin = new System.Windows.Forms.Padding(2);
            this.btnBasesExternas.Name = "btnBasesExternas";
            this.btnBasesExternas.Size = new System.Drawing.Size(194, 101);
            this.btnBasesExternas.TabIndex = 124;
            this.btnBasesExternas.Text = "Seguro Social";
            this.btnBasesExternas.UseVisualStyleBackColor = false;
            this.btnBasesExternas.Click += new System.EventHandler(this.btnBasesExternas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 101);
            this.button1.TabIndex = 125;
            this.button1.Text = "Lista De Empresas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 494);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 36);
            this.label1.TabIndex = 127;
            this.label1.Text = "PORFAVOR SELECCIONE UNA";
            // 
            // btnListaEmpresasAdmin
            // 
            this.btnListaEmpresasAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListaEmpresasAdmin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaEmpresasAdmin.Location = new System.Drawing.Point(410, 270);
            this.btnListaEmpresasAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaEmpresasAdmin.Name = "btnListaEmpresasAdmin";
            this.btnListaEmpresasAdmin.Size = new System.Drawing.Size(194, 101);
            this.btnListaEmpresasAdmin.TabIndex = 128;
            this.btnListaEmpresasAdmin.Text = "Lista De Empresas Administrativa";
            this.btnListaEmpresasAdmin.UseVisualStyleBackColor = false;
            this.btnListaEmpresasAdmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMenuBasesExternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 857);
            this.Controls.Add(this.btnListaEmpresasAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBasesExternas);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuBasesExternas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuBasesExternas";
            this.Load += new System.EventHandler(this.frmMenuBasesExternas_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarYSalir;
        private System.Windows.Forms.Button btnBasesExternas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaEmpresasAdmin;
    }
}