using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Interfaz
{
    public partial class frmAdd_Modify : Form
    {
        private Helper helper = new Helper();
        private Articulo articulo_main = null;
        private OpenFileDialog archivo = null;

        public frmAdd_Modify()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
            lbEncabezadoAdd.Visible = true;
            lbEncabezadoModificar.Visible = false;
        }
        
        public frmAdd_Modify(Articulo articulo)
        {
            InitializeComponent();
            this.articulo_main = articulo;
            Text = "Modificar Articulo";
            lbEncabezadoModificar.Visible = true;
            lbEncabezadoAdd.Visible = false;
        }

        private void frmAdd_Modify_Load(object sender, EventArgs e)
        {
            marcaNegocio marcaNegocio = new marcaNegocio();
            categoriaNegocio categoriaNegocio = new categoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar_marcas();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar_categorias();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;

                if (articulo_main != null)
                {
                    helper.cargarImagen(articulo_main.UrlImagen, pbxImagen);
                    txtCodigo.Text = articulo_main.Codigo;
                    txtDescripcion.Text = articulo_main.Descripcion;
                    txtNombre.Text = articulo_main.Nombre;
                    txtUrlImagen.Text = articulo_main.UrlImagen;
                    txtPrecio.Text = articulo_main.Precio.ToString();
                    cboCategoria.SelectedValue = articulo_main.Categoria.Id;
                    cboMarca.SelectedValue = articulo_main.Marca.Id;
                }
                else
                {
                    helper.cargarImagen("", pbxImagen);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                string codigo = txtCodigo.Text.ToUpper();
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;
                string url = txtUrlImagen.Text;
                if (codigo != "" && nombre != "" && descripcion != "" && precio != "" && cboCategoria.SelectedIndex != -1 && cboMarca.SelectedIndex != -1)
                {
                    if (articulo_main == null)
                        articulo_main = new Articulo();

                    articulo_main.Codigo = codigo;
                    articulo_main.Nombre = nombre;
                    articulo_main.Descripcion = descripcion;
                    articulo_main.UrlImagen = url;
                    articulo_main.Precio = (double)decimal.Parse(precio);
                    articulo_main.Categoria = (Categoria)cboCategoria.SelectedItem;
                    articulo_main.Marca = (Marca)cboMarca.SelectedItem;

                    if (articulo_main.Id != 0)
                    {
                        negocio.modificar(articulo_main);
                        MessageBox.Show("Modificado con éxito!");
                    }
                    else
                    {
                        negocio.agregar(articulo_main);
                        MessageBox.Show("Agregado con éxito!");
                    }
                    if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + txtCodigo.Text + archivo.SafeFileName );
                        
                    Close();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para continuar");
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la acción?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes) 
            {
                Close();
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            helper.cargarImagen(txtUrlImagen.Text, pbxImagen);
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            helper.validadEmptyTxt(txtCodigo, lbFaltaCodigo);
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            helper.validadEmptyTxt(txtNombre, lbFaltaNombre);
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            helper.validadEmptyTxt(txtDescripcion, lbFaltaDescripcion);
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            helper.validadEmptyTxt(txtPrecio, lbFaltaPrecio);
        }

        private void cboMarca_Leave(object sender, EventArgs e)
        {
            helper.validarCbo(cboMarca, lbFaltaMarca);
        }

        private void cboCategoria_Leave(object sender, EventArgs e)
        {
            helper.validarCbo(cboCategoria, lbFaltaCategoria);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void btnImagenArchivo_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png;|jpeg|*.jpeg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                helper.cargarImagen(archivo.FileName, pbxImagen);
            }
        }
    }
}
