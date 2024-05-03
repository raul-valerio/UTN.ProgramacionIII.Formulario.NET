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
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            //FUNCION PARA ACTUALIZAR LA LISTA AL MOMENTO DE AGREGAR, ACTUALIZAR, ELIMINAR, ETC
            MarcaManager marca = new MarcaManager();
            dgdMarcas.DataSource = marca.ListarMarcas();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FormAgregarMarca formAgregarMarca = new FormAgregarMarca();
            formAgregarMarca.ShowDialog();
            cargar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            FormEditarMarca formEditarMarca = new FormEditarMarca();
            formEditarMarca.ShowDialog();
            cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            FormEliminarMarca formEliminarMarca = new FormEliminarMarca();
            formEliminarMarca.ShowDialog();
            cargar();
        }
    }
}
