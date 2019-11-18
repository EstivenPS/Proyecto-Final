namespace ProyectoFinalAP1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.Registrarselabel = new System.Windows.Forms.Label();
            this.VisualizarpictureBox = new System.Windows.Forms.PictureBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Accederbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(82, 41);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(174, 20);
            this.UsuariotextBox.TabIndex = 2;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(82, 67);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(174, 20);
            this.ContraseñatextBox.TabIndex = 3;
            // 
            // Registrarselabel
            // 
            this.Registrarselabel.AutoSize = true;
            this.Registrarselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarselabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Registrarselabel.Location = new System.Drawing.Point(86, 135);
            this.Registrarselabel.Name = "Registrarselabel";
            this.Registrarselabel.Size = new System.Drawing.Size(123, 13);
            this.Registrarselabel.TabIndex = 5;
            this.Registrarselabel.Text = "Crear un  nuevo usuario.";
            this.Registrarselabel.Click += new System.EventHandler(this.Registrarselabel_Click);
            // 
            // VisualizarpictureBox
            // 
            this.VisualizarpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VisualizarpictureBox.Image")));
            this.VisualizarpictureBox.Location = new System.Drawing.Point(262, 64);
            this.VisualizarpictureBox.Name = "VisualizarpictureBox";
            this.VisualizarpictureBox.Size = new System.Drawing.Size(24, 24);
            this.VisualizarpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.VisualizarpictureBox.TabIndex = 6;
            this.VisualizarpictureBox.TabStop = false;
            this.VisualizarpictureBox.Click += new System.EventHandler(this.VisualizarpictureBox_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Accederbutton
            // 
            this.Accederbutton.Location = new System.Drawing.Point(102, 95);
            this.Accederbutton.Name = "Accederbutton";
            this.Accederbutton.Size = new System.Drawing.Size(90, 34);
            this.Accederbutton.TabIndex = 7;
            this.Accederbutton.Text = "Acceder";
            this.Accederbutton.UseVisualStyleBackColor = true;
            this.Accederbutton.Click += new System.EventHandler(this.Accederbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Accederbutton);
            this.Controls.Add(this.VisualizarpictureBox);
            this.Controls.Add(this.Registrarselabel);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label Registrarselabel;
        private System.Windows.Forms.PictureBox VisualizarpictureBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Accederbutton;
        private System.Windows.Forms.Label label3;
    }
}