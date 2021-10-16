using Domain.Entities;
using Domain.Enums;
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
 
    public partial class FrmProductoUpdate : Form
    {
        public ProductoModel ProductoModel { get; set; }
        public FrmProductoUpdate()
        {
            InitializeComponent();
        }

        private void FrmProductoUpdate_Load(object sender, EventArgs e)
        {

           cmbActualizar.Items.AddRange(ProductoModel.GetAll());
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                            .Cast<object>().ToArray()
                                       );
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
             Producto p = new Producto()
            {
                Id = ProductoModel.GetLastProductoId() + 1,
                Nombre = txtName.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExist.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida) cmbMeasureUnit.SelectedIndex
            };

            ProductoModel.Add(p);

            Dispose();
        }
    }
}
