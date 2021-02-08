using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryJose
{
    public partial class UserImageProduct : UserControl
    {
        List<Producto> AllProducts = new List<Producto>();

        List<Product> productos = new List<Product>();

        public UserImageProduct()
        {
            InitializeComponent();
        }

        private void UserImageProduct_Load(object sender, EventArgs e)
        {
            //Preparar el acceso a la bbdd
            DataAccess db = new DataAccess();
            //Este contenido se guarda en la lista de productos.Que no son null.
            AllProducts = db.ObtenerProductosNotNull();

            ObtenerProducto();

        }
        private void ObtenerProducto()
        {
            idSizeProductLabel.Text = " ";

            //Inicializamos el random
            Random random = new Random();
            //Obtenemos un numero entre el 1 y el total de Productos no Null
            int numero = random.Next(1, AllProducts.Count());
            Boolean existe = false;
            while (existe == false)
            {
                foreach (var allProduct in AllProducts)
                {
                    if (allProduct.ProductModelID == numero)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe == false) {
                    numero = random.Next(1, AllProducts.Count());

                }

            }
            // AllProducts.Remove(ProductModel);

            //Preparar el acceso a la bbdd
            DataAccess db = new DataAccess();
            //Obtener la info del Producto.
            var ProductModel = db.ObtenerProductModel(numero);



            //Obtener la imagen y pasar a imagen.
            if (ProductModel.LargePhoto != null) {
                MemoryStream ms = new MemoryStream(ProductModel.LargePhoto);
                Image largePhoto = Image.FromStream(ms);
                imageProductPictureBox.Image = largePhoto;
            }

            nameProductTextBox.Text = ProductModel.Name;
            nameProductTextBox.Enabled = false;
            /*
            foreach (var item in AllProducts)
            {
                listView1.Items.Add(item.ProductModelID + "");

            }*/

            //No duplicar size.
            List<Producto> Sizes = db.ObtenerSizeProductos(numero);
            sizeProductFlowLayoutPanel.Controls.Clear();
            Decimal Precio = 0;
            foreach (Producto size in Sizes)
            {
                if (size.Size != null) {
                    //Creación del botón
                    Button sizeButton = new Button();
                    sizeButton.Text = size.Size.ToString();
                    sizeButton.Name = size.ProductID.ToString();
                    sizeButton.BackColor = Color.Black;
                    sizeButton.ForeColor = Color.White;
                    //Añadir el evento.
                    sizeButton.Click += new EventHandler(this.sizeButton_Click);

                    sizeProductFlowLayoutPanel.Controls.Add(sizeButton);
                }
                //Comprobar si ya se ha guardado un precio
                if (Precio != 0) {
                    //En el caso de que si, comprobar si el precio es menor al actual
                    if (Precio > size.ListPrice)
                    {
                        Precio = size.ListPrice;
                    }
                }//En el caso que no guardamos el precio.
                else { Precio = size.ListPrice; }
            }
            int precioInt = Decimal.ToInt32(Precio);
            if (precioInt != 0) { 
                precioMinimoLabel.Text = precioInt + " €";
            }//En caso de que no haya precio.
            else { precioMinimoLabel.Text = " "; }

        }
        protected void cambiarColorBoton(object sender, EventArgs e)
        {
            //Realizamos la instancia del boton
            //Para poder obtener sus datos y realizar los cambios
            Button botonClick = (Button)sender;

            idSizeProductLabel.Text = botonClick.Name;
            botonClick.BackColor = Color.Red;
            botonClick.ForeColor = Color.White;

        }

        //Cuando se realiza un click 
        //Este metodo esta puesto en todos los botones de Size
        public void sizeButton_Click(object sender, EventArgs e)
        {
            cambiarColorBoton(sender, e);
        }
        private void imageProductPictureBox_Click(object sender, EventArgs e)
        {
            ObtenerProducto();
        }
        private void imageProduct_MouseEnter(object sender, EventArgs ex)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.imageProductPictureBox, "Click to display another product");
        }

        //Funcionalidad a añadir.
        /*
         Obtener todos los productos que tengan info / no sea null.
        
         Obtener su información y castear en caso de que tenga algún valor null. Ej : imagen /null , Sizes /Null
         
        Obtener la cantidad de sizes y crear button con (ID, Para obtener la información de ese Producto en específico.)
         
         Una vez se carga el form cargar un product aleatorio.
         
         Si se da click sobre la imagen cambiar el producto por otro aleatorio.

        */
    }
}
