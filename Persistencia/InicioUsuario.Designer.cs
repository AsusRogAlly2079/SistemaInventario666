namespace SistemaInventarioColchones.Persistencia
{
    partial class InicioUsuario
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.userControl11 = new SistemaInventarioColchones.Persistencia.UserControl1();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(223, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 743);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnProveedores);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 677);
            this.panel2.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(12, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 33);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProveedores.Location = new System.Drawing.Point(16, 359);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(201, 33);
            this.btnProveedores.TabIndex = 13;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Location = new System.Drawing.Point(12, 301);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(201, 33);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 250);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(201, 33);
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Location = new System.Drawing.Point(12, 195);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(201, 33);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido, Administrador...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaInventarioColchones.Properties.Resources.imagenlogin;
            this.pictureBox1.Location = new System.Drawing.Point(67, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 45);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sistema de Inventario de Colchones BedWare | Portal del Vendedor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Maroon;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOff.Location = new System.Drawing.Point(1286, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(36, 22);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "X";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(226, 45);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1106, 680);
            this.userControl11.TabIndex = 5;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 722);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioUsuario";
            this.Load += new System.EventHandler(this.InicioUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOff;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private UserControl1 userControl11;
    }
}