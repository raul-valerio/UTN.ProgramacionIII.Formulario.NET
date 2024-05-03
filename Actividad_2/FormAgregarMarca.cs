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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad_2
{
    public partial class FormAgregarMarca : Form
    {
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca nueva = new Marca();
            MarcaManager manager = new MarcaManager();
            List<Marca> lista = new List<Marca>();

            lista = manager.ListarMarcas();

            try
            {
                nueva.Descripcion = txtAgregarMarca.Text;
                if (nueva.Descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAgregarMarca.Text.Trim().Length == 0)
                {
                    // Si solo contiene espacios en blanco, muestra un mensaje de error
                    MessageBox.Show("No se permiten espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Limpia el contenido del TextBox
                    txtAgregarMarca.Clear();
                }
                else
                {
                    if(!lista.Any(m => m.Descripcion.Equals(nueva.Descripcion, StringComparison.OrdinalIgnoreCase)))
                    {
                        manager.agregarMarcas(nueva);
                        MessageBox.Show("Agregada");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Esa marca ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void FormAgregarMarca_Load(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaManager adminMarcas = new MarcaManager();
        }

    }
}
