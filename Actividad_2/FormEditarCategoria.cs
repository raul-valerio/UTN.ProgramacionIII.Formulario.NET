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
    public partial class FormEditarCategoria : Form
    {
        private List<Categoria> listaCategoria;
        private Categoria seleccionada;
        public FormEditarCategoria()
        {
            InitializeComponent();
        }

        private void btnVolverEditarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEditarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaManager adminCategoria = new CategoriaManager();
            listaCategoria = adminCategoria.listar();
            dgvEditarCategoria.DataSource = listaCategoria;
        }

        private void dgvEditarCategoria_SelectionChanged(object sender, EventArgs e)
        {
            CategoriaManager adminCategoria = new CategoriaManager();

            seleccionada = (Categoria)dgvEditarCategoria.CurrentRow.DataBoundItem;
            textBoxEditarCategoria.Text = seleccionada.Descripcion;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria();
            CategoriaManager adminCategoria = new CategoriaManager();

            ArticuloManager articuloManager = new ArticuloManager();
            List<Articulo> listaArticulos = articuloManager.ListarArticulos();

            string descripcion;

            try
            {
                descripcion = textBoxEditarCategoria.Text;
                if (descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxEditarCategoria.Text.Trim().Length == 0)
                {

                    MessageBox.Show("No se permiten espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEditarCategoria.Clear();
                    
                }
                else
                {
                    bool validar = listaArticulos.Any(item => item.Categoria.Descripcion == descripcion);
                    if (validar)
                    {
                        MessageBox.Show("Ya existe esa categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        seleccionada.Descripcion = descripcion;
                        adminCategoria.editarCategoria(seleccionada);
                        MessageBox.Show("Se actualizó la categoria");
                        listaCategoria = adminCategoria.listar();
                        dgvEditarCategoria.DataSource = listaCategoria;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
