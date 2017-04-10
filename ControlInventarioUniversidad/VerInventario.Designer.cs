namespace ControlInventarioUniversidad
{
    partial class VerInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerInventario));
            this.dGVinventario = new System.Windows.Forms.DataGridView();
            this.btnTodoInventario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBcarreras = new System.Windows.Forms.ComboBox();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBmateria = new System.Windows.Forms.ComboBox();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarreraMaterial = new System.Windows.Forms.Button();
            this.cBmaterial2 = new System.Windows.Forms.ComboBox();
            this.cBcarrera2 = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVinventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVinventario
            // 
            this.dGVinventario.AllowUserToAddRows = false;
            this.dGVinventario.AllowUserToDeleteRows = false;
            this.dGVinventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVinventario.Location = new System.Drawing.Point(13, 144);
            this.dGVinventario.Name = "dGVinventario";
            this.dGVinventario.ReadOnly = true;
            this.dGVinventario.Size = new System.Drawing.Size(660, 264);
            this.dGVinventario.TabIndex = 0;
            // 
            // btnTodoInventario
            // 
            this.btnTodoInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnTodoInventario.Image")));
            this.btnTodoInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodoInventario.Location = new System.Drawing.Point(180, 107);
            this.btnTodoInventario.Name = "btnTodoInventario";
            this.btnTodoInventario.Size = new System.Drawing.Size(146, 23);
            this.btnTodoInventario.TabIndex = 4;
            this.btnTodoInventario.Text = "Ver todo el Inventario";
            this.btnTodoInventario.UseVisualStyleBackColor = true;
            this.btnTodoInventario.Click += new System.EventHandler(this.btnTodoInventario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBcarreras);
            this.groupBox1.Controls.Add(this.btnCarrera);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 43);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver materiales de la carrera";
            // 
            // cBcarreras
            // 
            this.cBcarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcarreras.FormattingEnabled = true;
            this.cBcarreras.Items.AddRange(new object[] {
            "Sistemas Computacionales",
            "Mecatronica",
            "Comercio Internacional",
            "Gastronomia"});
            this.cBcarreras.Location = new System.Drawing.Point(6, 19);
            this.cBcarreras.Name = "cBcarreras";
            this.cBcarreras.Size = new System.Drawing.Size(221, 21);
            this.cBcarreras.TabIndex = 0;
            // 
            // btnCarrera
            // 
            this.btnCarrera.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrera.Image")));
            this.btnCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrera.Location = new System.Drawing.Point(233, 18);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnCarrera.TabIndex = 1;
            this.btnCarrera.Text = "Ver Inventario";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBmateria);
            this.groupBox2.Controls.Add(this.btnMaterial);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver cantidades del material de todas la carreras";
            // 
            // cBmateria
            // 
            this.cBmateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBmateria.FormattingEnabled = true;
            this.cBmateria.Items.AddRange(new object[] {
            "Mesas",
            "Bancos",
            "Pintarrones",
            "Proyectores"});
            this.cBmateria.Location = new System.Drawing.Point(6, 20);
            this.cBmateria.Name = "cBmateria";
            this.cBmateria.Size = new System.Drawing.Size(221, 21);
            this.cBmateria.TabIndex = 2;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(233, 18);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnMaterial.TabIndex = 3;
            this.btnMaterial.Text = "Ver Inventario";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCarreraMaterial);
            this.groupBox3.Controls.Add(this.cBmaterial2);
            this.groupBox3.Controls.Add(this.cBcarrera2);
            this.groupBox3.Location = new System.Drawing.Point(347, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Material de una Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ver Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "De la Carrera";
            // 
            // btnCarreraMaterial
            // 
            this.btnCarreraMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnCarreraMaterial.Image")));
            this.btnCarreraMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreraMaterial.Location = new System.Drawing.Point(248, 96);
            this.btnCarreraMaterial.Name = "btnCarreraMaterial";
            this.btnCarreraMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnCarreraMaterial.TabIndex = 7;
            this.btnCarreraMaterial.Text = "Ver Inventario";
            this.btnCarreraMaterial.UseVisualStyleBackColor = true;
            this.btnCarreraMaterial.Click += new System.EventHandler(this.btnCarreraMaterial_Click);
            // 
            // cBmaterial2
            // 
            this.cBmaterial2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBmaterial2.FormattingEnabled = true;
            this.cBmaterial2.Items.AddRange(new object[] {
            "Mesas",
            "Bancos",
            "Pintarrones",
            "Proyectores"});
            this.cBmaterial2.Location = new System.Drawing.Point(9, 42);
            this.cBmaterial2.Name = "cBmaterial2";
            this.cBmaterial2.Size = new System.Drawing.Size(233, 21);
            this.cBmaterial2.TabIndex = 6;
            // 
            // cBcarrera2
            // 
            this.cBcarrera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcarrera2.FormattingEnabled = true;
            this.cBcarrera2.Items.AddRange(new object[] {
            "Sistemas Computacionales",
            "Mecatronica",
            "Comercio Internacional",
            "Gastronomia"});
            this.cBcarrera2.Location = new System.Drawing.Point(9, 96);
            this.cBcarrera2.Name = "cBcarrera2";
            this.cBcarrera2.Size = new System.Drawing.Size(233, 21);
            this.cBcarrera2.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(598, 414);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::ControlInventarioUniversidad.Properties.Resources.Save_6530;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(13, 414);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar a archivo";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "El Archivo se guardara en C:\\reportes\\reporte inventario.txt";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(537, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ayuda";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(685, 449);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTodoInventario);
            this.Controls.Add(this.dGVinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dGVinventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVinventario;
        private System.Windows.Forms.Button btnTodoInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.ComboBox cBcarreras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBmateria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarreraMaterial;
        private System.Windows.Forms.ComboBox cBmaterial2;
        private System.Windows.Forms.ComboBox cBcarrera2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}