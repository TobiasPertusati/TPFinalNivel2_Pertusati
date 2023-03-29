using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmVerArticulo : Form
    {
        private Articulo articulo_main = null;
        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo_main = articulo;
        }

        public void cargar_elementos()
        {
            Helper helper = new Helper();
            try
            {
                helper.cargarImagen(articulo_main.UrlImagen, pbxImagen);
                lbEncabezado.Text += articulo_main.Codigo;
                txtCategoria.Text = articulo_main.Categoria.Descripcion;
                txtNombre.Text = articulo_main.Nombre;
                txtPrecio.Text = articulo_main.Precio.ToString();
                txtDescripcion.Text = articulo_main.Descripcion;
                txtMarca.Text = articulo_main.Marca.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            cargar_elementos();
        }
    }
}
