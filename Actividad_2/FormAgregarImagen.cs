using dominio;
using manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class FormAgregarImagen : Form
    {
        AccesoDatos datos = new AccesoDatos();
        private List<Articulo> listaArticulo;

        public FormAgregarImagen()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgregarImagen_Load(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();


            cboArticulos.DisplayMember = "Id";
            cboArticulos.ValueMember = "Id";
            cboArticulos.DataSource = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();


            dgvArticulos.DataSource = articuloManager.ListarArticulos().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
            dgvArticulos.Columns[3].Visible = false;
            dgvArticulos.Columns[4].Visible = false;
            dgvArticulos.Columns[5].Visible = false;
            dgvArticulos.Columns[6].Visible = false;
            dgvArticulos.Columns[7].Visible = false;
        }


        private void cboArtículos_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                
                pbxImagenes.Load(imagen);
            }
            catch (Exception)
            { 
                pbxImagenes.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg"); 
            }
        }

        public void AgregarImagenArtExistente(Articulo articulo)
        {
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", articulo.Id);
                datos.setearParametro("@ImagenUrl", articulo.Imagen);
                datos.cerrarConexion();
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            Imagen nuevaImagen = new Imagen();
            ArticuloManager imagenes = new ArticuloManager();

            try
            {
                if(txtUrlImagen.Text == "")
                {
                    MessageBox.Show("El campo Url Imagen no puede quedar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUrlImagen.Text.Trim().Length == 0)
                {
                    // Si solo contiene espacios en blanco, muestra un mensaje de error
                    MessageBox.Show("No se permiten espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Limpia el contenido del TextBox
                    txtUrlImagen.Clear();
                }
                if (txtUrlImagen.Text != "")
                {
                    seleccionado.Imagen = txtUrlImagen.Text;
                    seleccionado.Id = int.Parse(cboArticulos.Text);
                    AgregarImagenArtExistente(seleccionado);
                    MessageBox.Show("Nueva imagen agregada al articulo");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
