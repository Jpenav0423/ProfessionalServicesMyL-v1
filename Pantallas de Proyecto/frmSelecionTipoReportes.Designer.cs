
namespace Pantallas_de_Proyecto
{
    partial class frmSelecionTipoReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRequerimientolegal2 = new System.Windows.Forms.RadioButton();
            this.rbnEmbargo = new System.Windows.Forms.RadioButton();
            this.rbnLegalAval = new System.Windows.Forms.RadioButton();
            this.rbnLegalCliente = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 29);
            this.label1.TabIndex = 97;
            this.label1.Text = "Seleccionar Tipo de Reporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRequerimientolegal2);
            this.groupBox1.Controls.Add(this.rbnEmbargo);
            this.groupBox1.Controls.Add(this.rbnLegalAval);
            this.groupBox1.Controls.Add(this.rbnLegalCliente);
            this.groupBox1.Location = new System.Drawing.Point(322, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(397, 294);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Requerimientos";
            // 
            // rdbRequerimientolegal2
            // 
            this.rdbRequerimientolegal2.AutoSize = true;
            this.rdbRequerimientolegal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRequerimientolegal2.Location = new System.Drawing.Point(18, 92);
            this.rdbRequerimientolegal2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRequerimientolegal2.Name = "rdbRequerimientolegal2";
            this.rdbRequerimientolegal2.Size = new System.Drawing.Size(312, 28);
            this.rdbRequerimientolegal2.TabIndex = 3;
            this.rdbRequerimientolegal2.Text = "Requerimeinto Legal del Cliente 2";
            this.rdbRequerimientolegal2.UseVisualStyleBackColor = true;
            this.rdbRequerimientolegal2.CheckedChanged += new System.EventHandler(this.rdbRequerimientolegal2_CheckedChanged);
            // 
            // rbnEmbargo
            // 
            this.rbnEmbargo.AutoSize = true;
            this.rbnEmbargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEmbargo.Location = new System.Drawing.Point(18, 207);
            this.rbnEmbargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnEmbargo.Name = "rbnEmbargo";
            this.rbnEmbargo.Size = new System.Drawing.Size(356, 28);
            this.rbnEmbargo.TabIndex = 2;
            this.rbnEmbargo.Text = "Requerimiento de Embargo del Cliente";
            this.rbnEmbargo.UseVisualStyleBackColor = true;
            this.rbnEmbargo.CheckedChanged += new System.EventHandler(this.rbnEmbargo_CheckedChanged);
            // 
            // rbnLegalAval
            // 
            this.rbnLegalAval.AutoSize = true;
            this.rbnLegalAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLegalAval.Location = new System.Drawing.Point(18, 147);
            this.rbnLegalAval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnLegalAval.Name = "rbnLegalAval";
            this.rbnLegalAval.Size = new System.Drawing.Size(280, 28);
            this.rbnLegalAval.TabIndex = 1;
            this.rbnLegalAval.Text = "Requerimiento Legal del Aval ";
            this.rbnLegalAval.UseVisualStyleBackColor = true;
            this.rbnLegalAval.CheckedChanged += new System.EventHandler(this.rbnLegalAval_CheckedChanged);
            // 
            // rbnLegalCliente
            // 
            this.rbnLegalCliente.AutoSize = true;
            this.rbnLegalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLegalCliente.Location = new System.Drawing.Point(18, 41);
            this.rbnLegalCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnLegalCliente.Name = "rbnLegalCliente";
            this.rbnLegalCliente.Size = new System.Drawing.Size(297, 28);
            this.rbnLegalCliente.TabIndex = 0;
            this.rbnLegalCliente.Text = "Requerimeinto Legal del Cliente";
            this.rbnLegalCliente.UseVisualStyleBackColor = true;
            this.rbnLegalCliente.CheckedChanged += new System.EventHandler(this.rbnLegalCliente_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(38, 406);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 84);
            this.button3.TabIndex = 109;
            this.button3.Text = "Cancelar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(38, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 84);
            this.button2.TabIndex = 108;
            this.button2.Text = "Guardar Y Salir ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(196, 722);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_de_Proyecto.Properties.Resources.logo_3__2_;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmSelecionTipoReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSelecionTipoReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Tipos de Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnEmbargo;
        private System.Windows.Forms.RadioButton rbnLegalAval;
        private System.Windows.Forms.RadioButton rbnLegalCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbRequerimientolegal2;
    }
}