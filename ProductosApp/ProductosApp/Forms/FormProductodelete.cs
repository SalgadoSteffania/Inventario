using Domain.Entities;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FormProductodelete : Form
    {
        public ProductoModel ProductoModel { get; set; }
        public FormProductodelete()
        {
            InitializeComponent();
        }
        private void FormProductodelete_Load(object sender, EventArgs e)
        {
            comboBoxdelete.Items.AddRange(ProductoModel.GetAll());

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = ProductoModel.GetLastProductoId(),
            };

            ProductoModel.Delete(p);

            Dispose();
        }
    }
}
