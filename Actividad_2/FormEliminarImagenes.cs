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
    public partial class FormEliminarImagenes : Form
    {
        
        public int idSeleccion { get; set; }

        AccesoDatos datos = new AccesoDatos();
        private List<Articulo> listaArticulo;
        private List<Imagen> listaImagenes;
        public FormEliminarImagenes()
        {
            InitializeComponent();
        }
       
        private void cargar()
        {
            ImagenManager imagenesManager = new ImagenManager();
            listaImagenes = imagenesManager.listarPorIdArticulo(idSeleccion);
            dgvArticulos.DataSource = imagenesManager.listarPorIdArticulo(idSeleccion);
            dgvArticulos.Columns[1].Visible = false;
            //dgvArticulos.Columns[2].Visible = false;
            //Imagen image = new Imagen();
            cargarImagen(listaImagenes[0].Url);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEliminarImagenes_Load(object sender, EventArgs e)
        {
            ImagenManager imagenManager = new ImagenManager();


        }

        private int indiceImagenActual = 0;
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int totalImagenes = seleccionado.Imagenes.Count;

            if (totalImagenes > 0)
            {
                indiceImagenActual--;

                if (indiceImagenActual < 0)
                {
                    indiceImagenActual = totalImagenes - 1;
                }
                cargarImagen(seleccionado.Imagenes[indiceImagenActual]);
            }
            else
            {
                MessageBox.Show("No hay imágenes disponibles para este artículo.");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            int totalImagenes = seleccionado.Imagenes.Count;

            if (totalImagenes > 0)
            {
                indiceImagenActual++;

                if (indiceImagenActual >= totalImagenes)
                {
                    indiceImagenActual = 0;
                }
                cargarImagen(seleccionado.Imagenes[indiceImagenActual]);
            }
            else
            {
                MessageBox.Show("No hay imágenes disponibles para este artículo.");
            }
        }

        private void cboArticulos_TextChanged(object sender, EventArgs e)
        {
            //cargarImagen(cboArticulos.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ImagenManager manager = new ImagenManager();
            Imagen imagen = new Imagen();

            Articulo seleccion;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminar la imagen seleccionada?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    manager.eliminarImagenes(seleccion.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormEliminarImagenes_Load_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Imagen seleccion = (Imagen)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Url);
            }
        }
    }
}
