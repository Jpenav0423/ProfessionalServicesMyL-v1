
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.label1.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "Seleccionar Tipo de Reporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRequerimientolegal2);
            this.groupBox1.Controls.Add(this.rbnEmbargo);
            this.groupBox1.Controls.Add(this.rbnLegalAval);
            this.groupBox1.Controls.Add(this.rbnLegalCliente);
            this.groupBox1.Location = new System.Drawing.Point(328, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 236);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Requerimientos";
            // 
            // rdbRequerimientolegal2
            // 
            this.rdbRequerimientolegal2.AutoSize = true;
            this.rdbRequerimientolegal2.Location = new System.Drawing.Point(24, 89);
            this.rdbRequerimientolegal2.Name = "rdbRequerimientolegal2";
            this.rdbRequerimientolegal2.Size = new System.Drawing.Size(242, 21);
            this.rdbRequerimientolegal2.TabIndex = 3;
            this.rdbRequerimientolegal2.Text = "Requerimeinto Legal del Cliente 2";
            this.rdbRequerimientolegal2.UseVisualStyleBackColor = true;
            this.rdbRequerimientolegal2.CheckedChanged += new System.EventHandler(this.rdbRequerimientolegal2_CheckedChanged);
            // 
            // rbnEmbargo
            // 
            this.rbnEmbargo.AutoSize = true;
            this.rbnEmbargo.Location = new System.Drawing.Point(24, 173);
            this.rbnEmbargo.Name = "rbnEmbargo";
            this.rbnEmbargo.Size = new System.Drawing.Size(272, 21);
            this.rbnEmbargo.TabIndex = 2;
            this.rbnEmbargo.Text = "Requerimiento de Embargo del Cliente";
            this.rbnEmbargo.UseVisualStyleBackColor = true;
            this.rbnEmbargo.CheckedChanged += new System.EventHandler(this.rbnEmbargo_CheckedChanged);
            // 
            // rbnLegalAval
            // 
            this.rbnLegalAval.AutoSize = true;
            this.rbnLegalAval.Location = new System.Drawing.Point(24, 129);
            this.rbnLegalAval.Name = "rbnLegalAval";
            this.rbnLegalAval.Size = new System.Drawing.Size(218, 21);
            this.rbnLegalAval.TabIndex = 1;
            this.rbnLegalAval.Text = "Requerimiento Legal del Aval ";
            this.rbnLegalAval.UseVisualStyleBackColor = true;
            this.rbnLegalAval.CheckedChanged += new System.EventHandler(this.rbnLegalAval_CheckedChanged);
            // 
            // rbnLegalCliente
            // 
            this.rbnLegalCliente.AutoSize = true;
            this.rbnLegalCliente.Location = new System.Drawing.Point(24, 51);
            this.rbnLegalCliente.Name = "rbnLegalCliente";
            this.rbnLegalCliente.Size = new System.Drawing.Size(230, 21);
            this.rbnLegalCliente.TabIndex = 0;
            this.rbnLegalCliente.Text = "Requerimeinto Legal del Cliente";
            this.rbnLegalCliente.UseVisualStyleBackColor = true;
            this.rbnLegalCliente.CheckedChanged += new System.EventHandler(this.rbnLegalCliente_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Plazo Para Notificar al Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "24 Horas",
            "48 Horas"});
            this.comboBox1.Location = new System.Drawing.Point(924, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(780, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Datos Generales del Banco:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 516);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 39);
            this.textBox1.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Nombre del Banco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Nombre del Apoderado Legal:\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 588);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(541, 40);
            this.textBox2.TabIndex = 107;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(50, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 104);
            this.button3.TabIndex = 109;
            this.button3.Text = "Cancelar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(50, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 104);
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 888);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_de_Proyecto.Properties.Resources.logo_3__2_;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmSelecionTipoReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1180, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbRequerimientolegal2;
    }
}