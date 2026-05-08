using ControlInventario.Modelo;
using ControlInventario.Repositories;

namespace ControlInventario
{
    public partial class Form1 : Form
    {
        IInventarioRepository repo = new InventarioRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Inventario producto = new Inventario();
            producto.Producto = txtProducto.Text;
            producto.Categoria = txtCategoria.Text;
            producto.Cantidad = int.Parse(txtCantidad.Text);
            producto.PrecioCompra = decimal.Parse(txtPrecio.Text);

            repo.RegistrarProducto(producto);

            MessageBox.Show("Producto registrado correctamente");
             LimpiarCampos();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            dvgInventario.DataSource = null;

            dvgInventario.DataSource = repo.ObtenerStockMenorA5();
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            decimal total =
                repo.ObtenerValorTotalInventario();

            txtTotal.Text = total.ToString();
        }
        public void LimpiarCampos()
        {
            txtProducto.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();

            txtProducto.Focus();
        }
    }
}
