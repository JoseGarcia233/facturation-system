using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_System;
using Entidad_System1;

namespace Negocio_Sytem
{
    public class Producto_NG
    {

        Producto_DT obj = new Producto_DT();

        public void SetProducto(productos paramtr)
        {

            obj.InsertaProductos(paramtr);

        }



        public List<productos> GetProductos()
        {
            return obj.LeeProductos();

        }

        public productos LookUpProducto(int Id)
        {
            return obj.SearchProductos(Id);
        }

        public void Update(productos paramtr)
        {
            obj.UpdateProd(paramtr);
        }

        public void RemoveProduct(int id)
        {

            obj.DeleteProd(id);
        }

        public List<productos> FilterPdt(string nmb)
        {

            return obj.filterProd(nmb);
        }


    }
}

