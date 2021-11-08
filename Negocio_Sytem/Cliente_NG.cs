using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_System;
using Entidad_System1;

namespace Negocio_Sytem
{
    public class Cliente_NG
    {

        Cliente_DT obj = new Cliente_DT();

        public void SetClientes(clientes paramtr)
        {

            obj.InsertClientes(paramtr);

        }

        public List<clientes> GetClientes()
        {
            return obj.LeeClientes();

        }

        public clientes LookUpClientes(int Id)
        {
            return obj.SearchCliente(Id);
        }

        public void Update(clientes paramtr)
        {
            obj.UpdateCliente(paramtr);
        }

        public void RemoveCliente(int id)
        {

            obj.DeleCliente(id);

        }

        public List<clientes> Filterclt(string nmb)
        {

            return obj.filterClien(nmb);
        }

    }
}
