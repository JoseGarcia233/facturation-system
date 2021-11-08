using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_System;
using Entidad_System1;

namespace Negocio_Sytem
{
    public  class Faturacion_NG
    {

        Facturacion_DT obj = new Facturacion_DT();

        public void SetFactura(factura paramtr)
        {

            obj.InsertFactura(paramtr);

        }

        public List<factura> GetFactura()
        {
            return obj.LeeFactura();

        }

        public factura LookUpProvedores(int Id)
        {
            return obj.SearchFactura(Id);
        }

        public void Update(factura paramtr)
        {
            obj.UpdateFacturacin(paramtr);
        }

        public void RemoveFactura(int id)
        {

            obj.DeleFactura(id);

        }

        public List<factura> Filterfc(int nmb)
        {

            return obj.filterFactura(nmb);
        }
    }
}
