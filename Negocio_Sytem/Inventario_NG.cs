using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_System;
using Entidad_System1;
namespace Negocio_Sytem
{
    public class Inventario_NG
    {

        Inventario_DT obj = new Inventario_DT();

        public void SetInventario(inventario paramtr)
        {

            obj.InsertInventario(paramtr);

        }

        public List<inventario> GetInventanrio()
        {
            return obj.LeeInventario();

        }

        public inventario LookUpInventario(int Id)
        {
            return obj.SearchInventario(Id);
        }

        public void Update(inventario paramtr)
        {
            obj.UpdateInventario(paramtr);
        }

        public void RemoveInventario(int id)
        {

            obj.DeleInventario(id);

        }

        public List<inventario> Filterinv(int nmb)
        {

            return obj.filterInve(nmb);
        }
    }
}
