namespace ControlInventarioUniversidad
{
    partial class AgregarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarInventario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rTBnota = new System.Windows.Forms.RichTextBox();
            this.tBcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBmateria = new System.Windows.Forms.ComboBox();
            this.cBcarreras = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.linkLabelAyuda = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rTBnota);
            this.groupBox1.Controls.Add(this.tBcantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBmateria);
            this.groupBox1.Controls.Add(this.cBcarreras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del material a agregar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota:";
            // 
            // rTBnota
            // 
            this.rTBnota.Location = new System.Drawing.Point(100, 140);
            this.rTBnota.Name = "rTBnota";
            this.rTBnota.Size = new System.Drawing.Size(283, 96);
            this.rTBnota.TabIndex = 3;
            this.rTBnota.Text = "";
            // 
            // tBcantidad
            // 
            this.tBcantidad.Location = new System.Drawing.Point(100, 101);
            this.tBcantidad.Name = "tBcantidad";
            this.tBcantidad.Size = new System.Drawing.Size(283, 20);
            this.tBcantidad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Material:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carrera:";
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
            this.cBmateria.Location = new System.Drawing.Point(100, 60);
            this.cBmateria.Name = "cBmateria";
            this.cBmateria.Size = new System.Drawing.Size(283, 21);
            this.cBmateria.TabIndex = 1;
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
            this.cBcarreras.Location = new System.Drawing.Point(100, 19);
            this.cBcarreras.Name = "cBcarreras";
            this.cBcarreras.Size = new System.Drawing.Size(283, 21);
            this.cBcarreras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 267);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(163, 267);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(101, 23);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Ver Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(353, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelAyuda
            // 
            this.linkLabelAyuda.AutoSize = true;
            this.linkLabelAyuda.Location = new System.Drawing.Point(291, 272);
            this.linkLabelAyuda.Name = "linkLabelAyuda";
            this.linkLabelAyuda.Size = new System.Drawing.Size(37, 13);
            this.linkLabelAyuda.TabIndex = 9;
            this.linkLabelAyuda.TabStop = true;
            this.linkLabelAyuda.Text = "Ayuda";
            this.linkLabelAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAyuda_LinkClicked);
            // 
            // AgregarInventario
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(413, 303);
            this.Controls.Add(this.linkLabelAyuda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBcarreras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rTBnota;
        private System.Windows.Forms.TextBox tBcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBmateria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel linkLabelAyuda;
    }
}