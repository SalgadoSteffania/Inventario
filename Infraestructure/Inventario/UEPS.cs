using Domain.Entities.Invetory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public class UEPS : InventarioModel
    {
        public override void CalcularValorTotal()
        {

            foreach (Salida e in inventario)
            {
                e.ValorUnidad = 
            }
        }
    }
}
