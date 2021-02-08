using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryJose
{
    public class DataAccess
    {
        //  SqlConnectionStringBuilder Connexion = 

        /*  <connectionStrings>
    <add name = "AdventureWork" connectionString="Server=tcp:spdvi2021sqlserverjose.database.windows.net,1433;Initial Catalog=AdventureWorks2016;Persist Security Info=False;User ID=jose;Password=TankeVS97;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" providerName="System.Data.SqlClient" />
    <add name = "AdventureWorkMysql" connectionString="Server=spdvi2021sqlserverjose.database.windows.net;Port=1433;Database=AdventureWorks2016;Uid=jose;Pwd=TankeVS97;" />

  </connectionStrings>*/
        private string ConexionString = "Server=tcp:spdvi2021sqlserverjose.database.windows.net,1433;Initial Catalog = AdventureWorks2016; Persist Security Info=False;User ID = jose; Password=TankeVS97;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        //Obtener todos los productos de una categoria especifica.

        public List<Producto> ObtenerProductosNotNull()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexionString))
                {
                    string sql = $"SELECT DISTINCT Production.Product.ProductModelID " +
                $" FROM " +
                $" Production.Product " +
                $" WHERE " +
                $" ProductModelID IS NOT NULL ";

                    List<Producto> products = new List<Producto>();
                    products = connection.Query<Producto>(sql).ToList();


                    return products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas con la Obtención de Productos");
                MessageBox.Show("Problemas con la Obtención de Productos" + ex.Message);

                throw;
            }

        }
        public ProductModel ObtenerProductModel(int productModelId)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexionString))
                {
                    string sql = $"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name , ProductPhoto.LargePhoto " +
                $" FROM " +
                $" Production.ProductModel " +
                $" JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID " +
                $" JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID " +
                $" JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID " +
                $" WHERE " +
                $" Product.ProductModelID = {productModelId}";

                    
                    var products = connection.Query<ProductModel>(sql).FirstOrDefault();


                    return products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas con la Obtención de Productos");
                MessageBox.Show("Problemas con la Obtención de Productos" + ex.Message);

                throw;
            }

        }
        public List<Producto> ObtenerSizeProductos(int productModelId)
        {

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexionString))
                {
                    string sql = $"SELECT ProductId, Size, ListPrice " +
                $" FROM " +
                $" Production.Product " +
                $" WHERE Product.ProductModelID = {productModelId}" +
                $" ORDER BY Size";

                    //Obtenemos todas las Size del productModelId especifico.
                    List<Producto> products = new List<Producto>();
                    products = connection.Query<Producto>(sql).ToList();


                    //Borramos duplicados
                    List<Producto> productosFinal = new List<Producto>();//Contiene productos sin repetir las Sizes.
                    
                    string primer , segundo;
                    Boolean Size;
                    foreach (var item in products)
                    {
                        if (item.Size != null) {
                            Size = false;
                            foreach (Producto product in productosFinal)
                            {
                                //Comprobar si el Size ya esta introducido.
                                primer = product.Size.ToString();
                                segundo = item.Size.ToString();
                                    if (primer.Equals(segundo))
                                    {
                                        Size = true;
                                    }

                            }
                            if (Size != true) {
                                productosFinal.Add(item);
                            }
                        }
                    }
 
                    return productosFinal;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas con la Obtención de Productos");
                MessageBox.Show("Problemas con la Obtención de Productos" + ex.Message);

                throw;
            }

        }

     

        


    }
}
