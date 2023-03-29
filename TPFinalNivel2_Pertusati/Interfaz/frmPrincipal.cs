using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Interfaz
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> articulosList;
        private Helper helper = new Helper();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista_filtrada;
            string filtro = txtFiltroRapido.Text;
            if (filtro.Length > 2)
            {
                lista_filtrada = articulosList.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                lista_filtrada = articulosList;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = lista_filtrada;
            ajustarDgv(dgvArticulos);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cargarArticulos();
        }

        private void cargarArticulos()
        {
            articuloNegocio negocioArticulo = new articuloNegocio();
            try
            {
                articulosList = negocioArticulo.listarArticulos();
                dgvArticulos.DataSource = articulosList;
                ajustarDgv(dgvArticulos);
                helper.cargarImagen(articulosList[0].UrlImagen, pbxImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ajustarDgv(DataGridView dataGridView)
        {
            dataGridView.Columns["Descripcion"].Visible = false;
            dataGridView.Columns["UrlImagen"].Visible = false;
            dataGridView.Columns["Id"].Visible = false;
            //dataGridView.AutoResizeColumns();
            //dataGridView.AutoResizeRows();
        }

        private void btnBusquedaFiltrada_Click(object sender, EventArgs e)
        {
            if (pnlBusquedaDB.Visible == true)
                pnlBusquedaDB.Visible = false;
            else
                pnlBusquedaDB.Visible = true;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        { 
            try
            {
                if (dgvArticulos.CurrentCell != null) 
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    helper.cargarImagen(seleccionado.UrlImagen, pbxImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBusquedaDB_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                if (helper.validarEmptyCbo(cboCampo, "campo"))
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                if (helper.validarEmptyCbo(cboCriterio, "criterio"))
                    return;
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroDB.Text;
                if (filtro == "" && cboCampo.SelectedItem.ToString() == "Precio")
                    return;
                dgvArticulos.DataSource = negocio.listarFiltrado(campo, criterio, filtro);
                pnlBusquedaDB.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());  
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                txtFiltroRapido.Clear();
                cargarArticulos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdd_Modify frmAdd = new frmAdd_Modify();
                frmAdd.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally 
            { 
                cargarArticulos(); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo_modify;
                articulo_modify = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAdd_Modify frmModify = new frmAdd_Modify(articulo_modify);
                frmModify.ShowDialog();

            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("No hay seleccionado ningun articulo para modificar", "¡Atención!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            { 
                cargarArticulos(); 
            }
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo;
                articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmVerArticulo frmVerArticulo = new frmVerArticulo(articulo);
                frmVerArticulo.ShowDialog();
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("No hay seleccionado ningun articulo para ver en detalle", "¡Atención!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio artnegocio = new articuloNegocio();
            Articulo articulo = new Articulo();
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el articulo?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    artnegocio.eliminarFisico(articulo.Id);
                    MessageBox.Show("Eliminado con éxito");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No hay seleccionado ningun articulo para eliminar", "¡Atención!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
            finally
            {
                cargarArticulos();
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCampo.SelectedItem.ToString() == "Precio")
                {
                    txtFiltroDB.Clear();
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Igual a");
                }
                else
                {
                    txtFiltroDB.Clear();
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Empieza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltroDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cboCampo.SelectedIndex > -1) 
            {
                if (cboCampo.SelectedItem.ToString() == "Precio")
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                        e.Handled = true;
                }
            }
        }

    }
}
