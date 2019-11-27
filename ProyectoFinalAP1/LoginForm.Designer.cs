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
            this.VisualizarpictureBox = new System.Windows.Forms.PictureBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Accederbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(83, 85);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(174, 20);
            this.UsuariotextBox.TabIndex = 2;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(83, 111);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(174, 20);
            this.ContraseñatextBox.TabIndex = 3;
            // 
            // VisualizarpictureBox
            // 
            this.VisualizarpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VisualizarpictureBox.Image")));
            this.VisualizarpictureBox.Location = new System.Drawing.Point(263, 108);
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
            this.Accederbutton.Location = new System.Drawing.Point(104, 139);
            this.Accederbutton.Name = "Accederbutton";
            this.Accederbutton.Size = new System.Drawing.Size(90, 34);
            this.Accederbutton.TabIndex = 7;
            this.Accederbutton.Text = "Acceder";
            this.Accederbutton.UseVisualStyleBackColor = true;
            this.Accederbutton.Click += new System.EventHandler(this.Accederbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 181);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Accederbutton);
            this.Controls.Add(this.VisualizarpictureBox);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.PictureBox VisualizarpictureBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Accederbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}