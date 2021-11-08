using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_System;
using Entidad_System1;
namespace Negocio_Sytem
{
    public class Proveedores_NG
    {

          Proveedores_DT obj = new Proveedores_DT();

        public void SetProveedores(proveedores paramtr)
        {

            obj.InsertProveedores(paramtr);

        }

        public List<proveedores> GetProveedores()
        {
            return obj.LeeProveedores();

        }

        public proveedores LookUpProvedores(int Id)
        {
            return obj.SearchProveedores(Id);
        }

        public void Update(proveedores paramtr)
        {
            obj.UpdateProveedores(paramtr);
        }

        public void RemoveProveedores(int id)
        {

            obj.DeleProveedores(id);

        }

        public List<proveedores> Filterprove(string nmb)
        {

            return obj.filterprove(nmb);
        }
    }
}
