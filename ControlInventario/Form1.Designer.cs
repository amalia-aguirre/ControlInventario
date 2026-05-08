namespace ControlInventario
{
    partial class Form1
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
            lblProducto = new Label();
            txtProducto = new TextBox();
            txtCategoria = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            lblCategoria = new Label();
            label2 = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            btnRegistrar = new Button();
            btnStock = new Button();
            btnValorTotal = new Button();
            dvgInventario = new DataGridView();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(25, 61);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 25);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(166, 61);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(150, 31);
            txtProducto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(166, 122);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(150, 31);
            txtCategoria.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(166, 184);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(166, 246);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(25, 122);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 239);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(38, 246);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(27, 184);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(52, 317);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(248, 317);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(112, 34);
            btnStock.TabIndex = 10;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Location = new Point(453, 317);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(112, 34);
            btnValorTotal.TabIndex = 11;
            btnValorTotal.Text = "ValorTotal";
            btnValorTotal.UseVisualStyleBackColor = true;
            btnValorTotal.Click += btnValorTotal_Click;
            // 
            // dvgInventario
            // 
            dvgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventario.Location = new Point(52, 389);
            dvgInventario.Name = "dvgInventario";
            dvgInventario.RowHeadersWidth = 62;
            dvgInventario.Size = new Size(680, 267);
            dvgInventario.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(148, 674);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 731);
            Controls.Add(txtTotal);
            Controls.Add(dvgInventario);
            Controls.Add(btnValorTotal);
            Controls.Add(btnStock);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtCategoria);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProducto;
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label lblCategoria;
        private Label label2;
        private Label lblPrecio;
        private Label lblCantidad;
        private Button btnRegistrar;
        private Button btnStock;
        private Button btnValorTotal;
        private DataGridView dvgInventario;
        private TextBox txtTotal;
    }
}
