namespace SistemaInventarioColchones.Persistencia
{
    partial class AdminUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuario_Limpiar = new System.Windows.Forms.Button();
            this.btnUsuario_Modificar = new System.Windows.Forms.Button();
            this.btnUsuario_Eliminar = new System.Windows.Forms.Button();
            this.btnUsuario_Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUsuarios_Usuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña_Usuarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarios_Usuarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(389, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 630);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(662, 570);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Todos los usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnUsuario_Limpiar);
            this.panel1.Controls.Add(this.btnUsuario_Modificar);
            this.panel1.Controls.Add(this.btnUsuario_Eliminar);
            this.panel1.Controls.Add(this.btnUsuario_Agregar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbUsuarios_Usuarios);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContraseña_Usuarios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsuarios_Usuarios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 630);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUsuario_Limpiar
            // 
            this.btnUsuario_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnUsuario_Limpiar.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Limpiar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btnUsuario_Limpiar.Location = new System.Drawing.Point(23, 442);
            this.btnUsuario_Limpiar.Name = "btnUsuario_Limpiar";
            this.btnUsuario_Limpiar.Size = new System.Drawing.Size(306, 40);
            this.btnUsuario_Limpiar.TabIndex = 9;
            this.btnUsuario_Limpiar.Text = "Limpiar";
            this.btnUsuario_Limpiar.UseVisualStyleBackColor = false;
            this.btnUsuario_Limpiar.Click += new System.EventHandler(this.btnUsuario_Limpiar_Click);
            // 
            // btnUsuario_Modificar
            // 
            this.btnUsuario_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnUsuario_Modificar.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Modificar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnUsuario_Modificar.Location = new System.Drawing.Point(23, 350);
            this.btnUsuario_Modificar.Name = "btnUsuario_Modificar";
            this.btnUsuario_Modificar.Size = new System.Drawing.Size(306, 40);
            this.btnUsuario_Modificar.TabIndex = 8;
            this.btnUsuario_Modificar.Text = "Modificar";
            this.btnUsuario_Modificar.UseVisualStyleBackColor = false;
            this.btnUsuario_Modificar.Click += new System.EventHandler(this.btnUsuario_Modificar_Click);
            // 
            // btnUsuario_Eliminar
            // 
            this.btnUsuario_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnUsuario_Eliminar.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Eliminar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnUsuario_Eliminar.Location = new System.Drawing.Point(23, 396);
            this.btnUsuario_Eliminar.Name = "btnUsuario_Eliminar";
            this.btnUsuario_Eliminar.Size = new System.Drawing.Size(306, 40);
            this.btnUsuario_Eliminar.TabIndex = 7;
            this.btnUsuario_Eliminar.Text = "Eliminar";
            this.btnUsuario_Eliminar.UseVisualStyleBackColor = false;
            this.btnUsuario_Eliminar.Click += new System.EventHandler(this.btnUsuario_Eliminar_Click);
            // 
            // btnUsuario_Agregar
            // 
            this.btnUsuario_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnUsuario_Agregar.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Agregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnUsuario_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Agregar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario_Agregar.ForeColor = System.Drawing.Color.White;
            this.btnUsuario_Agregar.Location = new System.Drawing.Point(23, 304);
            this.btnUsuario_Agregar.Name = "btnUsuario_Agregar";
            this.btnUsuario_Agregar.Size = new System.Drawing.Size(306, 40);
            this.btnUsuario_Agregar.TabIndex = 6;
            this.btnUsuario_Agregar.Text = "Agregar";
            this.btnUsuario_Agregar.UseVisualStyleBackColor = false;
            this.btnUsuario_Agregar.Click += new System.EventHandler(this.btnUsuario_Agregar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbUsuarios_Usuarios
            // 
            this.cmbUsuarios_Usuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios_Usuarios.FormattingEnabled = true;
            this.cmbUsuarios_Usuarios.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cmbUsuarios_Usuarios.Location = new System.Drawing.Point(23, 240);
            this.cmbUsuarios_Usuarios.Name = "cmbUsuarios_Usuarios";
            this.cmbUsuarios_Usuarios.Size = new System.Drawing.Size(306, 31);
            this.cmbUsuarios_Usuarios.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol";
            // 
            // txtContraseña_Usuarios
            // 
            this.txtContraseña_Usuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña_Usuarios.Location = new System.Drawing.Point(23, 167);
            this.txtContraseña_Usuarios.Name = "txtContraseña_Usuarios";
            this.txtContraseña_Usuarios.Size = new System.Drawing.Size(306, 30);
            this.txtContraseña_Usuarios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuarios_Usuarios
            // 
            this.txtUsuarios_Usuarios.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios_Usuarios.Location = new System.Drawing.Point(23, 92);
            this.txtUsuarios_Usuarios.Name = "txtUsuarios_Usuarios";
            this.txtUsuarios_Usuarios.Size = new System.Drawing.Size(306, 30);
            this.txtUsuarios_Usuarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminUsuarios";
            this.Size = new System.Drawing.Size(1107, 655);
            this.Load += new System.EventHandler(this.AdminUsuarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsuario_Limpiar;
        private System.Windows.Forms.Button btnUsuario_Modificar;
        private System.Windows.Forms.Button btnUsuario_Eliminar;
        private System.Windows.Forms.Button btnUsuario_Agregar;
        private System.Windows.Forms.ComboBox cmbUsuarios_Usuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseña_Usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarios_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
