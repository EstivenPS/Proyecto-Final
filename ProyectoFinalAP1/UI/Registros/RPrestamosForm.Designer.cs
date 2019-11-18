namespace ProyectoFinalAP1.UI.Registros
{
    partial class RPrestamosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPrestamosForm));
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.CuotasgroupBox = new System.Windows.Forms.GroupBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.NumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.PrestamoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularCuotasbutton = new System.Windows.Forms.Button();
            this.CantidadCuotasnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.CobradorcomboBox = new System.Windows.Forms.ComboBox();
            this.UsuarioIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Intereslabel = new System.Windows.Forms.Label();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.CuotasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCuotasnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // CuotasgroupBox
            // 
            this.CuotasgroupBox.Controls.Add(this.DetalledataGridView);
            this.CuotasgroupBox.Location = new System.Drawing.Point(12, 219);
            this.CuotasgroupBox.Name = "CuotasgroupBox";
            this.CuotasgroupBox.Size = new System.Drawing.Size(473, 210);
            this.CuotasgroupBox.TabIndex = 8;
            this.CuotasgroupBox.TabStop = false;
            this.CuotasgroupBox.Text = "Cuotas:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.ColumnHeadersHeight = 35;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCuota,
            this.Fecha,
            this.Capital,
            this.Interes,
            this.Balance});
            this.DetalledataGridView.Location = new System.Drawing.Point(14, 21);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.RowHeadersWidth = 10;
            this.DetalledataGridView.Size = new System.Drawing.Size(445, 176);
            this.DetalledataGridView.TabIndex = 0;
            // 
            // NumeroCuota
            // 
            this.NumeroCuota.HeaderText = "Numero de Cuota";
            this.NumeroCuota.Name = "NumeroCuota";
            this.NumeroCuota.ReadOnly = true;
            this.NumeroCuota.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 75;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 150;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(397, 8);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.FechadateTimePicker.TabIndex = 11;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(406, 435);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 39);
            this.Eliminarbutton.TabIndex = 28;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(215, 435);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 39);
            this.Guardarbutton.TabIndex = 27;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 435);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 39);
            this.Nuevobutton.TabIndex = 26;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cobrador:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(221, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(64, 27);
            this.Buscarbutton.TabIndex = 36;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // PrestamoIdnumericUpDown
            // 
            this.PrestamoIdnumericUpDown.Location = new System.Drawing.Point(127, 8);
            this.PrestamoIdnumericUpDown.Name = "PrestamoIdnumericUpDown";
            this.PrestamoIdnumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.PrestamoIdnumericUpDown.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Préstamo Id:";
            // 
            // CalcularCuotasbutton
            // 
            this.CalcularCuotasbutton.Image = ((System.Drawing.Image)(resources.GetObject("CalcularCuotasbutton.Image")));
            this.CalcularCuotasbutton.Location = new System.Drawing.Point(178, 190);
            this.CalcularCuotasbutton.Name = "CalcularCuotasbutton";
            this.CalcularCuotasbutton.Size = new System.Drawing.Size(37, 23);
            this.CalcularCuotasbutton.TabIndex = 49;
            this.CalcularCuotasbutton.UseVisualStyleBackColor = true;
            this.CalcularCuotasbutton.Click += new System.EventHandler(this.CalcularCuotasbutton_Click);
            // 
            // CantidadCuotasnumericUpDown
            // 
            this.CantidadCuotasnumericUpDown.Location = new System.Drawing.Point(127, 192);
            this.CantidadCuotasnumericUpDown.Name = "CantidadCuotasnumericUpDown";
            this.CantidadCuotasnumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.CantidadCuotasnumericUpDown.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Cantidad de cuotas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Interes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Monto:";
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(127, 60);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(348, 21);
            this.ClientecomboBox.TabIndex = 34;
            // 
            // CobradorcomboBox
            // 
            this.CobradorcomboBox.FormattingEnabled = true;
            this.CobradorcomboBox.Location = new System.Drawing.Point(127, 87);
            this.CobradorcomboBox.Name = "CobradorcomboBox";
            this.CobradorcomboBox.Size = new System.Drawing.Size(348, 21);
            this.CobradorcomboBox.TabIndex = 51;
            // 
            // UsuarioIdnumericUpDown
            // 
            this.UsuarioIdnumericUpDown.Location = new System.Drawing.Point(127, 34);
            this.UsuarioIdnumericUpDown.Name = "UsuarioIdnumericUpDown";
            this.UsuarioIdnumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.UsuarioIdnumericUpDown.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Usuario Id:";
            // 
            // Intereslabel
            // 
            this.Intereslabel.AutoSize = true;
            this.Intereslabel.Location = new System.Drawing.Point(124, 143);
            this.Intereslabel.Name = "Intereslabel";
            this.Intereslabel.Size = new System.Drawing.Size(28, 13);
            this.Intereslabel.TabIndex = 54;
            this.Intereslabel.Text = "0.00";
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(124, 169);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(28, 13);
            this.Balancelabel.TabIndex = 55;
            this.Balancelabel.Text = "0.00";
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(127, 114);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(348, 20);
            this.MontotextBox.TabIndex = 56;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            this.MontotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontotextBox_KeyPress);
            // 
            // RPrestamosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 480);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.Intereslabel);
            this.Controls.Add(this.UsuarioIdnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CobradorcomboBox);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CalcularCuotasbutton);
            this.Controls.Add(this.CantidadCuotasnumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrestamoIdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CuotasgroupBox);
            this.Name = "RPrestamosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de préstamos";
            this.Load += new System.EventHandler(this.RPrestamosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.CuotasgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCuotasnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CuotasgroupBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button CalcularCuotasbutton;
        private System.Windows.Forms.NumericUpDown CantidadCuotasnumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PrestamoIdnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CobradorcomboBox;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.NumericUpDown UsuarioIdnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label Intereslabel;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}