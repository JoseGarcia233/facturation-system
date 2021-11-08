using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_System1;
namespace Datos_System
{
    public class Inventario_DT
    {


        sistema_facturacion1Entities db = new sistema_facturacion1Entities();


        public void InsertInventario(inventario mode)
        {

            db.inventario.Add(mode);
            db.SaveChanges();
        }

        public List<inventario> LeeInventario()
        {
            return db.inventario.ToList();

        }

        public inventario SearchInventario(int id)
        {

            return db.inventario.Find(id);
        }

        public void UpdateInventario(inventario inve)
        {

            var dat = db.inventario.Find(inve.Id);
            dat.Nombre_proveedor = inve.Nombre_proveedor;
            dat.Nombre_poducto= inve.Nombre_poducto;
            dat.Cantidad_A= inve.Cantidad_A;
            
            db.Entry(dat).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleInventario(int id)
        {
            var dat = db.inventario.Find(id);
            db.inventario.Remove(dat);
            db.SaveChanges();
        }

        public List<inventario> filterInve(int nam)
        {

            return db.inventario.Where(a => a.Nombre_poducto == nam   ).ToList();

        }

      
    }
}
