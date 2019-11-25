namespace ProyectoFinalAP1.UI.Registros
{
    partial class rCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCobros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CobroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UsuariopictureBox = new System.Windows.Forms.PictureBox();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.PrestamoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BalancePrestamolabel = new System.Windows.Forms.Label();
            this.NumeroCuotacomboBox = new System.Windows.Forms.ComboBox();
            this.BalanceCuotalabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cobro Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Préstamo Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de cuota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto cobrado:";
            // 
            // CobroIdnumericUpDown
            // 
            this.CobroIdnumericUpDown.Location = new System.Drawing.Point(156, 40);
            this.CobroIdnumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CobroIdnumericUpDown.Name = "CobroIdnumericUpDown";
            this.CobroIdnumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.CobroIdnumericUpDown.TabIndex = 5;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(368, 40);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.FechadateTimePicker.TabIndex = 7;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(253, 200);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 39);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(137, 200);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 39);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(19, 199);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 39);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(246, 37);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(64, 25);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolabel.Location = new System.Drawing.Point(261, 10);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(55, 16);
            this.Usuariolabel.TabIndex = 39;
            this.Usuariolabel.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Usuario:";
            // 
            // UsuariopictureBox
            // 
            this.UsuariopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UsuariopictureBox.Image")));
            this.UsuariopictureBox.Location = new System.Drawing.Point(180, 5);
            this.UsuariopictureBox.Name = "UsuariopictureBox";
            this.UsuariopictureBox.Size = new System.Drawing.Size(24, 24);
            this.UsuariopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UsuariopictureBox.TabIndex = 37;
            this.UsuariopictureBox.TabStop = false;
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.DecimalPlaces = 2;
            this.MontonumericUpDown.Location = new System.Drawing.Point(157, 169);
            this.MontonumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(293, 20);
            this.MontonumericUpDown.TabIndex = 40;
            this.MontonumericUpDown.ValueChanged += new System.EventHandler(this.MontonumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cliente:";
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(156, 66);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(293, 21);
            this.ClientecomboBox.TabIndex = 42;
            this.ClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientecomboBox_SelectedIndexChanged);
            // 
            // PrestamoIdcomboBox
            // 
            this.PrestamoIdcomboBox.FormattingEnabled = true;
            this.PrestamoIdcomboBox.Location = new System.Drawing.Point(156, 93);
            this.PrestamoIdcomboBox.Name = "PrestamoIdcomboBox";
            this.PrestamoIdcomboBox.Size = new System.Drawing.Size(84, 21);
            this.PrestamoIdcomboBox.TabIndex = 43;
            this.PrestamoIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.PrestamoIdcomboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Balance del préstamo:";
            // 
            // BalancePrestamolabel
            // 
            this.BalancePrestamolabel.AutoSize = true;
            this.BalancePrestamolabel.Location = new System.Drawing.Point(153, 146);
            this.BalancePrestamolabel.Name = "BalancePrestamolabel";
            this.BalancePrestamolabel.Size = new System.Drawing.Size(28, 13);
            this.BalancePrestamolabel.TabIndex = 45;
            this.BalancePrestamolabel.Text = "0.00";
            // 
            // NumeroCuotacomboBox
            // 
            this.NumeroCuotacomboBox.FormattingEnabled = true;
            this.NumeroCuotacomboBox.Location = new System.Drawing.Point(368, 93);
            this.NumeroCuotacomboBox.Name = "NumeroCuotacomboBox";
            this.NumeroCuotacomboBox.Size = new System.Drawing.Size(81, 21);
            this.NumeroCuotacomboBox.TabIndex = 46;
            this.NumeroCuotacomboBox.SelectedValueChanged += new System.EventHandler(this.NumeroCuotacomboBox_SelectedValueChanged);
            // 
            // BalanceCuotalabel
            // 
            this.BalanceCuotalabel.AutoSize = true;
            this.BalanceCuotalabel.Location = new System.Drawing.Point(153, 123);
            this.BalanceCuotalabel.Name = "BalanceCuotalabel";
            this.BalanceCuotalabel.Size = new System.Drawing.Size(28, 13);
            this.BalanceCuotalabel.TabIndex = 48;
            this.BalanceCuotalabel.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Balance de la cuota:";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirbutton.Image")));
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.Location = new System.Drawing.Point(376, 200);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(80, 38);
            this.Imprimirbutton.TabIndex = 49;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // rCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 259);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.BalanceCuotalabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumeroCuotacomboBox);
            this.Controls.Add(this.BalancePrestamolabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrestamoIdcomboBox);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UsuariopictureBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.CobroIdnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de cobros";
            this.Load += new System.EventHandler(this.RCobrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CobroIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox UsuariopictureBox;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label BalancePrestamolabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PrestamoIdcomboBox;
        private System.Windows.Forms.ComboBox NumeroCuotacomboBox;
        private System.Windows.Forms.Label BalanceCuotalabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Imprimirbutton;
    }
}