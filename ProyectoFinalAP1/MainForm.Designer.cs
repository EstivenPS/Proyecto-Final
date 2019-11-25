namespace ProyectoFinalAP1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem,
            this.registroDePrestamosToolStripMenuItem,
            this.registroDeCobradoresToolStripMenuItem,
            this.registroDeCobrosToolStripMenuItem,
            this.registroDeUsuariosToolStripMenuItem1});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDePrestamosToolStripMenuItem
            // 
            this.registroDePrestamosToolStripMenuItem.Name = "registroDePrestamosToolStripMenuItem";
            this.registroDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registroDePrestamosToolStripMenuItem.Text = "Registro de Prestamos";
            this.registroDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.registroDePrestamosToolStripMenuItem_Click);
            // 
            // registroDeCobradoresToolStripMenuItem
            // 
            this.registroDeCobradoresToolStripMenuItem.Name = "registroDeCobradoresToolStripMenuItem";
            this.registroDeCobradoresToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registroDeCobradoresToolStripMenuItem.Text = "Registro de Cobradores";
            this.registroDeCobradoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeCobradoresToolStripMenuItem_Click);
            // 
            // registroDeCobrosToolStripMenuItem
            // 
            this.registroDeCobrosToolStripMenuItem.Name = "registroDeCobrosToolStripMenuItem";
            this.registroDeCobrosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registroDeCobrosToolStripMenuItem.Text = "Registro de Cobros";
            this.registroDeCobrosToolStripMenuItem.Click += new System.EventHandler(this.registroDeCobrosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeClientesToolStripMenuItem,
            this.consultaDePrestamosToolStripMenuItem,
            this.consultaDeCobradoresToolStripMenuItem,
            this.consultaDeUsuariosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultaDeClientesToolStripMenuItem.Text = "Consulta de Clientes";
            this.consultaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // consultaDePrestamosToolStripMenuItem
            // 
            this.consultaDePrestamosToolStripMenuItem.Name = "consultaDePrestamosToolStripMenuItem";
            this.consultaDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultaDePrestamosToolStripMenuItem.Text = "Consulta de Prestamos";
            this.consultaDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.consultaDePrestamosToolStripMenuItem_Click);
            // 
            // consultaDeCobradoresToolStripMenuItem
            // 
            this.consultaDeCobradoresToolStripMenuItem.Name = "consultaDeCobradoresToolStripMenuItem";
            this.consultaDeCobradoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultaDeCobradoresToolStripMenuItem.Text = "Consulta de Cobradores";
            this.consultaDeCobradoresToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCobradoresToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem1
            // 
            this.registroDeUsuariosToolStripMenuItem1.Name = "registroDeUsuariosToolStripMenuItem1";
            this.registroDeUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.registroDeUsuariosToolStripMenuItem1.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem1_Click);
            // 
            // consultaDeUsuariosToolStripMenuItem1
            // 
            this.consultaDeUsuariosToolStripMenuItem1.Name = "consultaDeUsuariosToolStripMenuItem1";
            this.consultaDeUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.consultaDeUsuariosToolStripMenuItem1.Text = "Consulta de Usuarios";
            this.consultaDeUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

