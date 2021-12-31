namespace Tp2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillacontenedores = new System.Windows.Forms.DataGridView();
            this.grillaclientes = new System.Windows.Forms.DataGridView();
            this.grilla_cont_cliente = new System.Windows.Forms.DataGridView();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descripciontxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_ingreso_picker = new System.Windows.Forms.DateTimePicker();
            this.pesotxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alta_contenedor = new System.Windows.Forms.Button();
            this.baja_contenedor = new System.Windows.Forms.Button();
            this.mod_contenedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_tipo_contenedor = new System.Windows.Forms.ComboBox();
            this.legajotxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.razonsocialtxt = new System.Windows.Forms.TextBox();
            this.alta_cliente = new System.Windows.Forms.Button();
            this.mod_cliente = new System.Windows.Forms.Button();
            this.baja_cliente = new System.Windows.Forms.Button();
            this.combo_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.asignar_contenedor = new System.Windows.Forms.Button();
            this.desasignar_contenedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillacontenedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cont_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grillacontenedores
            // 
            this.grillacontenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillacontenedores.Location = new System.Drawing.Point(52, 35);
            this.grillacontenedores.MultiSelect = false;
            this.grillacontenedores.Name = "grillacontenedores";
            this.grillacontenedores.ReadOnly = true;
            this.grillacontenedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillacontenedores.Size = new System.Drawing.Size(341, 150);
            this.grillacontenedores.TabIndex = 0;
            this.grillacontenedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillacontenedores_CellClick);
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(482, 35);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(312, 150);
            this.grillaclientes.TabIndex = 1;
            this.grillaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_CellClick);
            // 
            // grilla_cont_cliente
            // 
            this.grilla_cont_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_cont_cliente.Location = new System.Drawing.Point(305, 362);
            this.grilla_cont_cliente.Name = "grilla_cont_cliente";
            this.grilla_cont_cliente.ReadOnly = true;
            this.grilla_cont_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_cont_cliente.Size = new System.Drawing.Size(240, 133);
            this.grilla_cont_cliente.TabIndex = 2;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(75, 200);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contenedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // descripciontxt
            // 
            this.descripciontxt.Location = new System.Drawing.Point(267, 199);
            this.descripciontxt.Name = "descripciontxt";
            this.descripciontxt.Size = new System.Drawing.Size(100, 20);
            this.descripciontxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(189, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(49, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Ingreso";
            // 
            // fecha_ingreso_picker
            // 
            this.fecha_ingreso_picker.Location = new System.Drawing.Point(157, 236);
            this.fecha_ingreso_picker.Name = "fecha_ingreso_picker";
            this.fecha_ingreso_picker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ingreso_picker.TabIndex = 10;
            // 
            // pesotxt
            // 
            this.pesotxt.Location = new System.Drawing.Point(99, 271);
            this.pesotxt.Name = "pesotxt";
            this.pesotxt.Size = new System.Drawing.Size(64, 20);
            this.pesotxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(49, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso";
            // 
            // alta_contenedor
            // 
            this.alta_contenedor.Location = new System.Drawing.Point(75, 313);
            this.alta_contenedor.Name = "alta_contenedor";
            this.alta_contenedor.Size = new System.Drawing.Size(75, 23);
            this.alta_contenedor.TabIndex = 13;
            this.alta_contenedor.Text = "Alta";
            this.alta_contenedor.UseVisualStyleBackColor = true;
            this.alta_contenedor.Click += new System.EventHandler(this.alta_contenedor_Click);
            // 
            // baja_contenedor
            // 
            this.baja_contenedor.Location = new System.Drawing.Point(177, 313);
            this.baja_contenedor.Name = "baja_contenedor";
            this.baja_contenedor.Size = new System.Drawing.Size(75, 23);
            this.baja_contenedor.TabIndex = 14;
            this.baja_contenedor.Text = "Baja";
            this.baja_contenedor.UseVisualStyleBackColor = true;
            this.baja_contenedor.Click += new System.EventHandler(this.baja_contenedor_Click);
            // 
            // mod_contenedor
            // 
            this.mod_contenedor.Location = new System.Drawing.Point(267, 313);
            this.mod_contenedor.Name = "mod_contenedor";
            this.mod_contenedor.Size = new System.Drawing.Size(75, 23);
            this.mod_contenedor.TabIndex = 15;
            this.mod_contenedor.Text = "Modificacion";
            this.mod_contenedor.UseVisualStyleBackColor = true;
            this.mod_contenedor.Click += new System.EventHandler(this.mod_contenedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(189, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo";
            // 
            // combo_tipo_contenedor
            // 
            this.combo_tipo_contenedor.FormattingEnabled = true;
            this.combo_tipo_contenedor.Items.AddRange(new object[] {
            "A",
            "B"});
            this.combo_tipo_contenedor.Location = new System.Drawing.Point(236, 270);
            this.combo_tipo_contenedor.Name = "combo_tipo_contenedor";
            this.combo_tipo_contenedor.Size = new System.Drawing.Size(50, 21);
            this.combo_tipo_contenedor.TabIndex = 17;
            // 
            // legajotxt
            // 
            this.legajotxt.Location = new System.Drawing.Point(482, 217);
            this.legajotxt.Name = "legajotxt";
            this.legajotxt.Size = new System.Drawing.Size(63, 20);
            this.legajotxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Legajo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(591, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(582, 217);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(76, 20);
            this.nombretxt.TabIndex = 21;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(582, 268);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(76, 20);
            this.apellidotxt.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(591, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(479, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Razon Social";
            // 
            // razonsocialtxt
            // 
            this.razonsocialtxt.Location = new System.Drawing.Point(478, 271);
            this.razonsocialtxt.Name = "razonsocialtxt";
            this.razonsocialtxt.Size = new System.Drawing.Size(77, 20);
            this.razonsocialtxt.TabIndex = 25;
            // 
            // alta_cliente
            // 
            this.alta_cliente.Location = new System.Drawing.Point(480, 313);
            this.alta_cliente.Name = "alta_cliente";
            this.alta_cliente.Size = new System.Drawing.Size(75, 23);
            this.alta_cliente.TabIndex = 26;
            this.alta_cliente.Text = "Alta";
            this.alta_cliente.UseVisualStyleBackColor = true;
            this.alta_cliente.Click += new System.EventHandler(this.alta_cliente_Click);
            // 
            // mod_cliente
            // 
            this.mod_cliente.Location = new System.Drawing.Point(673, 313);
            this.mod_cliente.Name = "mod_cliente";
            this.mod_cliente.Size = new System.Drawing.Size(75, 23);
            this.mod_cliente.TabIndex = 27;
            this.mod_cliente.Text = "Modificacion";
            this.mod_cliente.UseVisualStyleBackColor = true;
            this.mod_cliente.Click += new System.EventHandler(this.mod_cliente_Click);
            // 
            // baja_cliente
            // 
            this.baja_cliente.Location = new System.Drawing.Point(567, 313);
            this.baja_cliente.Name = "baja_cliente";
            this.baja_cliente.Size = new System.Drawing.Size(75, 23);
            this.baja_cliente.TabIndex = 28;
            this.baja_cliente.Text = "Baja";
            this.baja_cliente.UseVisualStyleBackColor = true;
            this.baja_cliente.Click += new System.EventHandler(this.baja_cliente_Click);
            // 
            // combo_tipo_cliente
            // 
            this.combo_tipo_cliente.FormattingEnabled = true;
            this.combo_tipo_cliente.Items.AddRange(new object[] {
            "Persona Fisica",
            "Empresa"});
            this.combo_tipo_cliente.Location = new System.Drawing.Point(673, 268);
            this.combo_tipo_cliente.Name = "combo_tipo_cliente";
            this.combo_tipo_cliente.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_cliente.TabIndex = 29;
            this.combo_tipo_cliente.SelectionChangeCommitted += new System.EventHandler(this.combo_tipo_cliente_SelectionChangeCommitted);
            this.combo_tipo_cliente.SelectedValueChanged += new System.EventHandler(this.combo_tipo_cliente_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(696, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tipo de Cliente";
            // 
            // asignar_contenedor
            // 
            this.asignar_contenedor.Location = new System.Drawing.Point(401, 61);
            this.asignar_contenedor.Name = "asignar_contenedor";
            this.asignar_contenedor.Size = new System.Drawing.Size(75, 69);
            this.asignar_contenedor.TabIndex = 31;
            this.asignar_contenedor.Text = "Asignar contenedor a cliente";
            this.asignar_contenedor.UseVisualStyleBackColor = true;
            this.asignar_contenedor.Click += new System.EventHandler(this.asignar_contenedor_Click);
            // 
            // desasignar_contenedor
            // 
            this.desasignar_contenedor.Location = new System.Drawing.Point(604, 409);
            this.desasignar_contenedor.Name = "desasignar_contenedor";
            this.desasignar_contenedor.Size = new System.Drawing.Size(118, 55);
            this.desasignar_contenedor.TabIndex = 32;
            this.desasignar_contenedor.Text = "Desasignar contenedor del cliente ";
            this.desasignar_contenedor.UseVisualStyleBackColor = true;
            this.desasignar_contenedor.Click += new System.EventHandler(this.desasignar_contenedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 507);
            this.Controls.Add(this.desasignar_contenedor);
            this.Controls.Add(this.asignar_contenedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.combo_tipo_cliente);
            this.Controls.Add(this.baja_cliente);
            this.Controls.Add(this.mod_cliente);
            this.Controls.Add(this.alta_cliente);
            this.Controls.Add(this.razonsocialtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.legajotxt);
            this.Controls.Add(this.combo_tipo_contenedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mod_contenedor);
            this.Controls.Add(this.baja_contenedor);
            this.Controls.Add(this.alta_contenedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pesotxt);
            this.Controls.Add(this.fecha_ingreso_picker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripciontxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.grilla_cont_cliente);
            this.Controls.Add(this.grillaclientes);
            this.Controls.Add(this.grillacontenedores);
            this.Name = "Form1";
            this.Text = "TP2 Contenedores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillacontenedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cont_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillacontenedores;
        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.DataGridView grilla_cont_cliente;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripciontxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha_ingreso_picker;
        private System.Windows.Forms.TextBox pesotxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button alta_contenedor;
        private System.Windows.Forms.Button baja_contenedor;
        private System.Windows.Forms.Button mod_contenedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_tipo_contenedor;
        private System.Windows.Forms.TextBox legajotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox razonsocialtxt;
        private System.Windows.Forms.Button alta_cliente;
        private System.Windows.Forms.Button mod_cliente;
        private System.Windows.Forms.Button baja_cliente;
        private System.Windows.Forms.ComboBox combo_tipo_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button asignar_contenedor;
        private System.Windows.Forms.Button desasignar_contenedor;
    }
}

