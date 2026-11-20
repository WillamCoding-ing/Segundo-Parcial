namespace Examen2doParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            dtpSalida = new DateTimePicker();
            chkCorporativo = new CheckBox();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            nudDias = new NumericUpDown();
            GroupBox1 = new GroupBox();
            label3 = new Label();
            rbnBasico = new RadioButton();
            rbnCompleto = new RadioButton();
            chkGps = new CheckBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            rbtSucursal = new RadioButton();
            rbtDomicilio = new RadioButton();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            GroupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(67, 26);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(290, 23);
            txtCliente.TabIndex = 0;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(67, 93);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(290, 23);
            dtpSalida.TabIndex = 1;
            dtpSalida.ValueChanged += dtpSalida_ValueChanged;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(12, 55);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(127, 19);
            chkCorporativo.TabIndex = 2;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            chkCorporativo.CheckedChanged += chkCorporativo_CheckedChanged;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(67, 132);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(290, 23);
            txtVehiculo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(67, 174);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(290, 23);
            txtTarifa.TabIndex = 4;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(67, 220);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(166, 23);
            nudDias.TabIndex = 5;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(label3);
            GroupBox1.Controls.Add(rbnBasico);
            GroupBox1.Controls.Add(rbnCompleto);
            GroupBox1.Location = new Point(23, 271);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(156, 98);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
            GroupBox1.Enter += GroupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 27;
            label3.Text = "Seguro";
            // 
            // rbnBasico
            // 
            rbnBasico.AutoSize = true;
            rbnBasico.Location = new Point(6, 37);
            rbnBasico.Name = "rbnBasico";
            rbnBasico.Size = new Size(59, 19);
            rbnBasico.TabIndex = 7;
            rbnBasico.TabStop = true;
            rbnBasico.Text = "Básico";
            rbnBasico.UseVisualStyleBackColor = true;
            // 
            // rbnCompleto
            // 
            rbnCompleto.AutoSize = true;
            rbnCompleto.Location = new Point(6, 62);
            rbnCompleto.Name = "rbnCompleto";
            rbnCompleto.Size = new Size(136, 19);
            rbnCompleto.TabIndex = 8;
            rbnCompleto.TabStop = true;
            rbnCompleto.Text = "Completo (+RD$300)";
            rbnCompleto.UseVisualStyleBackColor = true;
            rbnCompleto.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(23, 394);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(105, 19);
            chkGps.TabIndex = 7;
            chkGps.Text = "GPS (+RD$100)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Location = new Point(197, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(146, 98);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 28;
            label4.Text = "Entrega";
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(6, 37);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(69, 19);
            rbtSucursal.TabIndex = 7;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "Sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            rbtSucursal.CheckedChanged += rbtSucursal_CheckedChanged;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(6, 62);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(134, 19);
            rbtDomicilio.TabIndex = 8;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(517, 156);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(246, 15);
            lblEncabezado.TabIndex = 9;
            lblEncabezado.Text = "Dias     Vehiculo                             Tarifa     Total";
            lblEncabezado.Click += lblEncabezado_Click;
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(517, 174);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(249, 94);
            lstAlquileres.TabIndex = 10;
            lstAlquileres.SelectedIndexChanged += lstAlquileres_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Location = new Point(576, 299);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(117, 17);
            lblSubtotal.TabIndex = 11;
            lblSubtotal.Text = "Subtotal";
            lblSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Location = new Point(576, 326);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(117, 17);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "Descuento";
            lblDescuento.TextAlign = ContentAlignment.MiddleCenter;
            lblDescuento.Click += lblDescuento_Click;
            // 
            // lblDomicilio
            // 
            lblDomicilio.BorderStyle = BorderStyle.FixedSingle;
            lblDomicilio.Location = new Point(576, 355);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(117, 17);
            lblDomicilio.TabIndex = 13;
            lblDomicilio.Text = "Domicilio";
            lblDomicilio.TextAlign = ContentAlignment.MiddleCenter;
            lblDomicilio.Click += lblDomicilio_Click;
            // 
            // lblItbis
            // 
            lblItbis.BorderStyle = BorderStyle.FixedSingle;
            lblItbis.Location = new Point(576, 384);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(117, 17);
            lblItbis.TabIndex = 14;
            lblItbis.Text = "ITBIS (18%)";
            lblItbis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(576, 410);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 17);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "TOTAL A PAGAR";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(517, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 41);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(14, 419);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 23);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(157, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(296, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 20;
            label1.Text = "Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 21;
            label2.Text = "Salida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 27;
            label5.Text = "Vehiculo:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 177);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 28;
            label6.Text = "Tarifa:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 222);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 29;
            label7.Text = "Dias: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 300);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 30;
            label8.Text = "Subtotal";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 328);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 31;
            label9.Text = "Descuento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(470, 355);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 32;
            label10.Text = "Domicilio";
            label10.Click += label10_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(470, 384);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 33;
            label11.Text = "ITBIS (18%)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(470, 411);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 34;
            label12.Text = "TOTAL A PAGAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(groupBox2);
            Controls.Add(chkGps);
            Controls.Add(GroupBox1);
            Controls.Add(nudDias);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(chkCorporativo);
            Controls.Add(dtpSalida);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "RentaCar Express - Alquileres";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private DateTimePicker dtpSalida;
        private CheckBox chkCorporativo;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private NumericUpDown nudDias;
        private GroupBox GroupBox1;
        private RadioButton rbnBasico;
        private RadioButton rbnCompleto;
        private CheckBox chkGps;
        private GroupBox groupBox2;
        private RadioButton rbtSucursal;
        private RadioButton rbtDomicilio;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
