using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using manager;

namespace Actividad_2
{
    public partial class FormEliminarMarca : Form
    {
        public FormEliminarMarca()
        {
            InitializeComponent();
        }
        private void FormEliminarMarca_Load(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            List<Marca> listaMarcas = adminMarcas.ListarMarcas();
            dgvEliminarMarca.DataSource = listaMarcas;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca seleccionada = (Marca)dgvEliminarMarca.CurrentRow.DataBoundItem;

            ArticuloManager articuloManager = new ArticuloManager();
            MarcaManager marcamanager = new MarcaManager();

            List<Articulo> listaArticulos = articuloManager.ListarArticulos();


            bool enUso = listaArticulos.Any(item => item.Marca.Descripcion == seleccionada.Descripcion);


            if (!enUso)
            {
                marcamanager.eliminarMarca(seleccionada.Id);
                MessageBox.Show("Marca eliminada correctamente");
            }
            else
            {
                MessageBox.Show("No se puede eliminar una marca en uso");
            }

            List<Marca> listaMarcas = marcamanager.ListarMarcas();
            dgvEliminarMarca.DataSource = listaMarcas;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
