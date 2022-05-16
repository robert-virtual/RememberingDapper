namespace RememberingDapper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n_precio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.n_cantidad = new System.Windows.Forms.NumericUpDown();
            this.id_categoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.d_productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // t_nombre
            // 
            this.t_nombre.Location = new System.Drawing.Point(913, 110);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(149, 27);
            this.t_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // n_precio
            // 
            this.n_precio.Location = new System.Drawing.Point(912, 194);
            this.n_precio.Name = "n_precio";
            this.n_precio.Size = new System.Drawing.Size(150, 27);
            this.n_precio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // n_cantidad
            // 
            this.n_cantidad.Location = new System.Drawing.Point(913, 262);
            this.n_cantidad.Name = "n_cantidad";
            this.n_cantidad.Size = new System.Drawing.Size(150, 27);
            this.n_cantidad.TabIndex = 2;
            // 
            // id_categoria
            // 
            this.id_categoria.FormattingEnabled = true;
            this.id_categoria.Location = new System.Drawing.Point(914, 325);
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Size = new System.Drawing.Size(151, 28);
            this.id_categoria.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categoria";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(969, 381);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // d_productos
            // 
            this.d_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_productos.Location = new System.Drawing.Point(68, 80);
            this.d_productos.Name = "d_productos";
            this.d_productos.RowHeadersWidth = 51;
            this.d_productos.RowTemplate.Height = 29;
            this.d_productos.Size = new System.Drawing.Size(741, 481);
            this.d_productos.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 672);
            this.Controls.Add(this.d_productos);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.id_categoria);
            this.Controls.Add(this.n_cantidad);
            this.Controls.Add(this.n_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_nombre);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox t_nombre;
        private Label label1;
        private NumericUpDown n_precio;
        private Label label2;
        private Label label3;
        private NumericUpDown n_cantidad;
        private ComboBox id_categoria;
        private Label label4;
        private Button btn_save;
        private DataGridView d_productos;
    }
}