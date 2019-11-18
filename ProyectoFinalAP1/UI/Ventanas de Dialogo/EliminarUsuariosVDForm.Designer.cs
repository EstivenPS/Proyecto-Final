namespace ProyectoFinalAP1.UI.Ventanas_de_Dialogo
{
    partial class EliminarUsuariosVDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuariosVDForm));
            this.DesactivarVDbutton = new System.Windows.Forms.Button();
            this.EliminarVDbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DesactivarVDbutton
            // 
            this.DesactivarVDbutton.Image = ((System.Drawing.Image)(resources.GetObject("DesactivarVDbutton.Image")));
            this.DesactivarVDbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DesactivarVDbutton.Location = new System.Drawing.Point(144, 52);
            this.DesactivarVDbutton.Name = "DesactivarVDbutton";
            this.DesactivarVDbutton.Size = new System.Drawing.Size(92, 33);
            this.DesactivarVDbutton.TabIndex = 5;
            this.DesactivarVDbutton.Text = "Desactivar";
            this.DesactivarVDbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DesactivarVDbutton.UseVisualStyleBackColor = true;
            this.DesactivarVDbutton.Click += new System.EventHandler(this.DesactivarVDbutton_Click);
            // 
            // EliminarVDbutton
            // 
            this.EliminarVDbutton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarVDbutton.Image")));
            this.EliminarVDbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarVDbutton.Location = new System.Drawing.Point(37, 52);
            this.EliminarVDbutton.Name = "EliminarVDbutton";
            this.EliminarVDbutton.Size = new System.Drawing.Size(70, 33);
            this.EliminarVDbutton.TabIndex = 4;
            this.EliminarVDbutton.Text = "Eliminar";
            this.EliminarVDbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarVDbutton.UseVisualStyleBackColor = true;
            this.EliminarVDbutton.Click += new System.EventHandler(this.EliminarVDbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Desea ELIMINAR o DESACTIVAR este usuario?";
            // 
            // EliminarUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 108);
            this.Controls.Add(this.DesactivarVDbutton);
            this.Controls.Add(this.EliminarVDbutton);
            this.Controls.Add(this.label1);
            this.Name = "EliminarUsuariosForm";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DesactivarVDbutton;
        private System.Windows.Forms.Button EliminarVDbutton;
        private System.Windows.Forms.Label label1;
    }
}