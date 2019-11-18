namespace ProyectoFinalAP1.UI.Registros
{
    partial class RCobrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCobrosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CobroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrestamoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsuarioIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.NumeroCuotacomboBox = new System.Windows.Forms.ComboBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MontotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cobro Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Préstamo Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de cuota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // CobroIdnumericUpDown
            // 
            this.CobroIdnumericUpDown.Location = new System.Drawing.Point(111, 7);
            this.CobroIdnumericUpDown.Name = "CobroIdnumericUpDown";
            this.CobroIdnumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.CobroIdnumericUpDown.TabIndex = 5;
            // 
            // PrestamoIdnumericUpDown
            // 
            this.PrestamoIdnumericUpDown.Location = new System.Drawing.Point(111, 33);
            this.PrestamoIdnumericUpDown.Name = "PrestamoIdnumericUpDown";
            this.PrestamoIdnumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.PrestamoIdnumericUpDown.TabIndex = 6;
            this.PrestamoIdnumericUpDown.ValueChanged += new System.EventHandler(this.PrestamoIdnumericUpDown_ValueChanged);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(323, 7);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.FechadateTimePicker.TabIndex = 7;
            // 
            // UsuarioIdnumericUpDown
            // 
            this.UsuarioIdnumericUpDown.Location = new System.Drawing.Point(111, 59);
            this.UsuarioIdnumericUpDown.Name = "UsuarioIdnumericUpDown";
            this.UsuarioIdnumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.UsuarioIdnumericUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario Id:";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(325, 142);
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
            this.Guardarbutton.Location = new System.Drawing.Point(176, 142);
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
            this.Nuevobutton.Location = new System.Drawing.Point(17, 142);
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
            this.Buscarbutton.Location = new System.Drawing.Point(192, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(64, 25);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // NumeroCuotacomboBox
            // 
            this.NumeroCuotacomboBox.FormattingEnabled = true;
            this.NumeroCuotacomboBox.Location = new System.Drawing.Point(111, 85);
            this.NumeroCuotacomboBox.Name = "NumeroCuotacomboBox";
            this.NumeroCuotacomboBox.Size = new System.Drawing.Size(72, 21);
            this.NumeroCuotacomboBox.TabIndex = 16;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(111, 112);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(293, 20);
            this.MontotextBox.TabIndex = 17;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            this.MontotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontotextBox_KeyPress);
            // 
            // RCobrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 192);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.NumeroCuotacomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.UsuarioIdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PrestamoIdnumericUpDown);
            this.Controls.Add(this.CobroIdnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RCobrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de cobros";
            this.Load += new System.EventHandler(this.RCobrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobroIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
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
        private System.Windows.Forms.NumericUpDown PrestamoIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown UsuarioIdnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox NumeroCuotacomboBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.TextBox MontotextBox;
    }
}