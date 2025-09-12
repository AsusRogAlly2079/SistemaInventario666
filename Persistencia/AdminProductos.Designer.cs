namespace SistemaInventarioColchones.Persistencia
{
    partial class AdminProductos
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductos_Costo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductos_Material = new System.Windows.Forms.TextBox();
            this.txtProductos_Proveedor = new System.Windows.Forms.TextBox();
            this.txtProductos_Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductos_Marca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProductos_Limpiar = new System.Windows.Forms.Button();
            this.btnProductos_Modificar = new System.Windows.Forms.Button();
            this.btnProductos_Eliminar = new System.Windows.Forms.Button();
            this.btnProductos_Agregar = new System.Windows.Forms.Button();
            this.cmbProductos_Tamaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductos_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductos_Nombre = new System.Windows.Forms.TextBox();
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
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 311);
            this.panel2.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 261);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Todos los usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtProductos_Costo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtProductos_Material);
            this.panel1.Controls.Add(this.txtProductos_Proveedor);
            this.panel1.Controls.Add(this.txtProductos_Stock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProductos_Marca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnProductos_Limpiar);
            this.panel1.Controls.Add(this.btnProductos_Modificar);
            this.panel1.Controls.Add(this.btnProductos_Eliminar);
            this.panel1.Controls.Add(this.btnProductos_Agregar);
            this.panel1.Controls.Add(this.cmbProductos_Tamaño);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductos_Descripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductos_Nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 316);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Costo $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stock";
            // 
            // txtProductos_Costo
            // 
            this.txtProductos_Costo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Costo.Location = new System.Drawing.Point(158, 260);
            this.txtProductos_Costo.Name = "txtProductos_Costo";
            this.txtProductos_Costo.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Costo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cod. Proveedor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtProductos_Material
            // 
            this.txtProductos_Material.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Material.Location = new System.Drawing.Point(658, 83);
            this.txtProductos_Material.Name = "txtProductos_Material";
            this.txtProductos_Material.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Material.TabIndex = 15;
            // 
            // txtProductos_Proveedor
            // 
            this.txtProductos_Proveedor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Proveedor.Location = new System.Drawing.Point(658, 144);
            this.txtProductos_Proveedor.Name = "txtProductos_Proveedor";
            this.txtProductos_Proveedor.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Proveedor.TabIndex = 14;
            // 
            // txtProductos_Stock
            // 
            this.txtProductos_Stock.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Stock.Location = new System.Drawing.Point(158, 205);
            this.txtProductos_Stock.Name = "txtProductos_Stock";
            this.txtProductos_Stock.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Stock.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tamaño";
            // 
            // txtProductos_Marca
            // 
            this.txtProductos_Marca.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Marca.Location = new System.Drawing.Point(658, 29);
            this.txtProductos_Marca.Name = "txtProductos_Marca";
            this.txtProductos_Marca.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Marca.TabIndex = 11;
            this.txtProductos_Marca.TextChanged += new System.EventHandler(this.txtProductos_Marca_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cod. Marca";
            // 
            // btnProductos_Limpiar
            // 
            this.btnProductos_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnProductos_Limpiar.FlatAppearance.BorderSize = 0;
            this.btnProductos_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos_Limpiar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btnProductos_Limpiar.Location = new System.Drawing.Point(830, 250);
            this.btnProductos_Limpiar.Name = "btnProductos_Limpiar";
            this.btnProductos_Limpiar.Size = new System.Drawing.Size(134, 40);
            this.btnProductos_Limpiar.TabIndex = 9;
            this.btnProductos_Limpiar.Text = "Limpiar";
            this.btnProductos_Limpiar.UseVisualStyleBackColor = false;
            this.btnProductos_Limpiar.Click += new System.EventHandler(this.btnProductos_Limpiar_Click);
            // 
            // btnProductos_Modificar
            // 
            this.btnProductos_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnProductos_Modificar.FlatAppearance.BorderSize = 0;
            this.btnProductos_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos_Modificar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnProductos_Modificar.Location = new System.Drawing.Point(830, 195);
            this.btnProductos_Modificar.Name = "btnProductos_Modificar";
            this.btnProductos_Modificar.Size = new System.Drawing.Size(134, 40);
            this.btnProductos_Modificar.TabIndex = 8;
            this.btnProductos_Modificar.Text = "Modificar";
            this.btnProductos_Modificar.UseVisualStyleBackColor = false;
            this.btnProductos_Modificar.Click += new System.EventHandler(this.btnProductos_Modificar_Click);
            // 
            // btnProductos_Eliminar
            // 
            this.btnProductos_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnProductos_Eliminar.FlatAppearance.BorderSize = 0;
            this.btnProductos_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos_Eliminar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btnProductos_Eliminar.Location = new System.Drawing.Point(658, 250);
            this.btnProductos_Eliminar.Name = "btnProductos_Eliminar";
            this.btnProductos_Eliminar.Size = new System.Drawing.Size(134, 40);
            this.btnProductos_Eliminar.TabIndex = 7;
            this.btnProductos_Eliminar.Text = "Eliminar";
            this.btnProductos_Eliminar.UseVisualStyleBackColor = false;
            this.btnProductos_Eliminar.Click += new System.EventHandler(this.btnProductos_Eliminar_Click);
            // 
            // btnProductos_Agregar
            // 
            this.btnProductos_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.btnProductos_Agregar.FlatAppearance.BorderSize = 0;
            this.btnProductos_Agregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btnProductos_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos_Agregar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_Agregar.ForeColor = System.Drawing.Color.White;
            this.btnProductos_Agregar.Location = new System.Drawing.Point(658, 195);
            this.btnProductos_Agregar.Name = "btnProductos_Agregar";
            this.btnProductos_Agregar.Size = new System.Drawing.Size(134, 40);
            this.btnProductos_Agregar.TabIndex = 6;
            this.btnProductos_Agregar.Text = "Agregar";
            this.btnProductos_Agregar.UseVisualStyleBackColor = false;
            this.btnProductos_Agregar.Click += new System.EventHandler(this.btnUsuario_Agregar_Click);
            // 
            // cmbProductos_Tamaño
            // 
            this.cmbProductos_Tamaño.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos_Tamaño.FormattingEnabled = true;
            this.cmbProductos_Tamaño.Items.AddRange(new object[] {
            "90 x 120 cm",
            "160 x 190 cm",
            "180 x 200 cm"});
            this.cmbProductos_Tamaño.Location = new System.Drawing.Point(158, 143);
            this.cmbProductos_Tamaño.Name = "cmbProductos_Tamaño";
            this.cmbProductos_Tamaño.Size = new System.Drawing.Size(306, 31);
            this.cmbProductos_Tamaño.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod. Material ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductos_Descripcion
            // 
            this.txtProductos_Descripcion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Descripcion.Location = new System.Drawing.Point(158, 83);
            this.txtProductos_Descripcion.Name = "txtProductos_Descripcion";
            this.txtProductos_Descripcion.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtProductos_Nombre
            // 
            this.txtProductos_Nombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos_Nombre.Location = new System.Drawing.Point(158, 29);
            this.txtProductos_Nombre.Name = "txtProductos_Nombre";
            this.txtProductos_Nombre.Size = new System.Drawing.Size(306, 30);
            this.txtProductos_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // AdminProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminProductos";
            this.Size = new System.Drawing.Size(1107, 659);
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
        private System.Windows.Forms.Button btnProductos_Limpiar;
        private System.Windows.Forms.Button btnProductos_Modificar;
        private System.Windows.Forms.Button btnProductos_Eliminar;
        private System.Windows.Forms.Button btnProductos_Agregar;
        private System.Windows.Forms.ComboBox cmbProductos_Tamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductos_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductos_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductos_Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductos_Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductos_Material;
        private System.Windows.Forms.TextBox txtProductos_Proveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductos_Costo;
    }
}
