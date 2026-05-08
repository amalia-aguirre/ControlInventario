using System.Data.SqlClient;
using ControlInventario.Data;
using ControlInventario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Repositories
{
    public class InventarioRepository : IInventarioRepository
    {
        Conexion conexion = new Conexion();

        // Registrar producto
        public void RegistrarProducto(Inventario producto)
        {
            using (SqlConnection conn =
                new SqlConnection(conexion.cadena))
            {
                string query =
                    @"INSERT INTO Inventario
                    (Producto, Categoria, Cantidad, PrecioCompra)
                    VALUES
                    (@Producto, @Categoria, @Cantidad, @PrecioCompra)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Producto", producto.Producto);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Productos con stock menor a 5
        public List<Inventario> ObtenerStockMenorA5()
        {
            List<Inventario> lista = new List<Inventario>();

            using (SqlConnection conn =
                new SqlConnection(conexion.cadena))
            {
                string query =
                    "SELECT * FROM Inventario WHERE Cantidad < 5";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Inventario item = new Inventario();

                    item.Id = Convert.ToInt32(reader["Id"]);
                    item.Producto = reader["Producto"].ToString();
                    item.Categoria = reader["Categoria"].ToString();
                    item.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                    item.PrecioCompra =
                        Convert.ToDecimal(reader["PrecioCompra"]);

                    lista.Add(item);
                }
            }

            return lista;
        }

        // Valor total inventario
        public decimal ObtenerValorTotalInventario()
        {
            decimal total = 0;

            using (SqlConnection conn =
                new SqlConnection(conexion.cadena))
            {
                string query =
                    "SELECT SUM(Cantidad * PrecioCompra) FROM Inventario";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    total = Convert.ToDecimal(resultado);
                }
            }

            return total;
        }
    }
}
      
   
