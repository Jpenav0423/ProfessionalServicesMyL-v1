
namespace Pantallas_de_Proyecto
{
    partial class frmGestiones
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
            this.btnNuevaGestion = new System.Windows.Forms.Button();
            this.btnEditarDatos = new System.Windows.Forms.Button();
            this.btnGenerarDocumentos = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodDeudorBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNombreDeudor = new System.Windows.Forms.TextBox();
            this.btnSeguroYSeguimientos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodDeudor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRtn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumTelefono1 = new System.Windows.Forms.TextBox();
            this.txtNumTelefono2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtFechaUltimoPago = new System.Windows.Forms.TextBox();
            this.txtFechaAtraso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvReferencias = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaGestion
            // 
            this.btnNuevaGestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevaGestion.Location = new System.Drawing.Point(40, 162);
            this.btnNuevaGestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaGestion.Name = "btnNuevaGestion";
            this.btnNuevaGestion.Size = new System.Drawing.Size(107, 88);
            this.btnNuevaGestion.TabIndex = 0;
            this.btnNuevaGestion.Text = "Nueva Gestion";
            this.btnNuevaGestion.UseVisualStyleBackColor = false;
            this.btnNuevaGestion.Click += new System.EventHandler(this.btnNuevaGestion_Click);
            // 
            // btnEditarDatos
            // 
            this.btnEditarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarDatos.Location = new System.Drawing.Point(40, 275);
            this.btnEditarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarDatos.Name = "btnEditarDatos";
            this.btnEditarDatos.Size = new System.Drawing.Size(107, 89);
            this.btnEditarDatos.TabIndex = 1;
            this.btnEditarDatos.Text = "Editar Datos";
            this.btnEditarDatos.UseVisualStyleBackColor = false;
            this.btnEditarDatos.Click += new System.EventHandler(this.btnEditarDatos_Click);
            // 
            // btnGenerarDocumentos
            // 
            this.btnGenerarDocumentos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarDocumentos.Location = new System.Drawing.Point(40, 388);
            this.btnGenerarDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarDocumentos.Name = "btnGenerarDocumentos";
            this.btnGenerarDocumentos.Size = new System.Drawing.Size(107, 88);
            this.btnGenerarDocumentos.TabIndex = 2;
            this.btnGenerarDocumentos.Text = "Generar Documentos";
            this.btnGenerarDocumentos.UseVisualStyleBackColor = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTerminar.Location = new System.Drawing.Point(40, 497);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(107, 88);
            this.btnTerminar.TabIndex = 3;
            this.btnTerminar.Text = "Terminar Gestion";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "cod_deudor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodDeudorBuscar
            // 
            this.txtCodDeudorBuscar.Location = new System.Drawing.Point(327, 36);
            this.txtCodDeudorBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodDeudorBuscar.Name = "txtCodDeudorBuscar";
            this.txtCodDeudorBuscar.Size = new System.Drawing.Size(198, 20);
            this.txtCodDeudorBuscar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Deudor:";
            // 
            // txtBuscarNombreDeudor
            // 
            this.txtBuscarNombreDeudor.Location = new System.Drawing.Point(637, 38);
            this.txtBuscarNombreDeudor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarNombreDeudor.Name = "txtBuscarNombreDeudor";
            this.txtBuscarNombreDeudor.Size = new System.Drawing.Size(233, 20);
            this.txtBuscarNombreDeudor.TabIndex = 7;
            // 
            // btnSeguroYSeguimientos
            // 
            this.btnSeguroYSeguimientos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeguroYSeguimientos.Location = new System.Drawing.Point(784, 596);
            this.btnSeguroYSeguimientos.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeguroYSeguimientos.Name = "btnSeguroYSeguimientos";
            this.btnSeguroYSeguimientos.Size = new System.Drawing.Size(213, 37);
            this.btnSeguroYSeguimientos.TabIndex = 8;
            this.btnSeguroYSeguimientos.Text = "Informacion Seguro y Seguimientos";
            this.btnSeguroYSeguimientos.UseVisualStyleBackColor = false;
            this.btnSeguroYSeguimientos.Click += new System.EventHandler(this.btnSeguroYSeguimientos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datos Generales del Deudor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(371, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Codigo Deudor:";
            // 
            // txtCodDeudor
            // 
            this.txtCodDeudor.Location = new System.Drawing.Point(371, 117);
            this.txtCodDeudor.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodDeudor.Name = "txtCodDeudor";
            this.txtCodDeudor.Size = new System.Drawing.Size(296, 20);
            this.txtCodDeudor.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(371, 173);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 20);
            this.txtId.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de Identidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rtn:";
            // 
            // txtRtn
            // 
            this.txtRtn.Location = new System.Drawing.Point(371, 203);
            this.txtRtn.Margin = new System.Windows.Forms.Padding(2);
            this.txtRtn.Name = "txtRtn";
            this.txtRtn.Size = new System.Drawing.Size(102, 20);
            this.txtRtn.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "No. de Telefono:";
            // 
            // txtNumTelefono1
            // 
            this.txtNumTelefono1.Location = new System.Drawing.Point(371, 237);
            this.txtNumTelefono1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumTelefono1.Name = "txtNumTelefono1";
            this.txtNumTelefono1.Size = new System.Drawing.Size(102, 20);
            this.txtNumTelefono1.TabIndex = 20;
            // 
            // txtNumTelefono2
            // 
            this.txtNumTelefono2.Location = new System.Drawing.Point(558, 237);
            this.txtNumTelefono2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumTelefono2.Name = "txtNumTelefono2";
            this.txtNumTelefono2.Size = new System.Drawing.Size(109, 20);
            this.txtNumTelefono2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "No. de Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(371, 280);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(296, 20);
            this.txtCorreo.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 318);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cod Direccion:";
            // 
            // txtCodDireccion
            // 
            this.txtCodDireccion.Location = new System.Drawing.Point(371, 311);
            this.txtCodDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodDireccion.Name = "txtCodDireccion";
            this.txtCodDireccion.Size = new System.Drawing.Size(296, 20);
            this.txtCodDireccion.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(256, 383);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 14);
            this.label13.TabIndex = 29;
            this.label13.Text = "Saldo del Deudor:\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 409);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tipo de Prestamo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 437);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Saldo Total:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 462);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Fecha de Pago:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(256, 491);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Fecha de Ultimo Pago:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(256, 516);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Fecha de Atraso:";
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(383, 409);
            this.txtPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(296, 20);
            this.txtPrestamo.TabIndex = 35;
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(383, 433);
            this.txtSaldoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.Size = new System.Drawing.Size(116, 20);
            this.txtSaldoTotal.TabIndex = 36;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(383, 462);
            this.txtFechaPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaPago.TabIndex = 37;
            // 
            // txtFechaUltimoPago
            // 
            this.txtFechaUltimoPago.Location = new System.Drawing.Point(383, 491);
            this.txtFechaUltimoPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaUltimoPago.Name = "txtFechaUltimoPago";
            this.txtFechaUltimoPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaUltimoPago.TabIndex = 38;
            // 
            // txtFechaAtraso
            // 
            this.txtFechaAtraso.Location = new System.Drawing.Point(383, 516);
            this.txtFechaAtraso.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaAtraso.Name = "txtFechaAtraso";
            this.txtFechaAtraso.Size = new System.Drawing.Size(116, 20);
            this.txtFechaAtraso.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnNuevaGestion);
            this.groupBox1.Controls.Add(this.btnGenerarDocumentos);
            this.groupBox1.Controls.Add(this.btnEditarDatos);
            this.groupBox1.Controls.Add(this.btnTerminar);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 722);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
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
            // dgvReferencias
            // 
            this.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferencias.Location = new System.Drawing.Point(726, 125);
            this.dgvReferencias.Name = "dgvReferencias";
            this.dgvReferencias.Size = new System.Drawing.Size(240, 214);
            this.dgvReferencias.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(723, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Referencias Duedor:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(890, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Deudor";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1035, 749);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvReferencias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFechaAtraso);
            this.Controls.Add(this.txtFechaUltimoPago);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.txtSaldoTotal);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumTelefono2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumTelefono1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodDeudor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSeguroYSeguimientos);
            this.Controls.Add(this.txtBuscarNombreDeudor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodDeudorBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestiones";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiones ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaGestion;
        private System.Windows.Forms.Button btnEditarDatos;
        private System.Windows.Forms.Button btnGenerarDocumentos;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodDeudorBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNombreDeudor;
        private System.Windows.Forms.Button btnSeguroYSeguimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodDeudor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumTelefono1;
        private System.Windows.Forms.TextBox txtNumTelefono2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtFechaUltimoPago;
        private System.Windows.Forms.TextBox txtFechaAtraso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvReferencias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
    }
}