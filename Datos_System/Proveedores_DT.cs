using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_System1;
namespace Datos_System
{
    public class Proveedores_DT
    {


        sistema_facturacion1Entities db = new sistema_facturacion1Entities();


        public void InsertProveedores(proveedores mode)
        {

            db.proveedores.Add(mode);
            db.SaveChanges();
        }

        public List<proveedores> LeeProveedores()
        {
            return db.proveedores.ToList();

        }

        public proveedores SearchProveedores(int id)
        {

            return db.proveedores.Find(id);
        }

        public void UpdateProveedores(proveedores prove)
        {

            var dat = db.proveedores.Find(prove.Id);
            dat.Nombre = prove.Nombre;
            dat.Cedula = prove.Cedula;
            dat.Telefono = prove.Telefono;
            dat.Email = prove.Email;
            db.Entry(dat).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleProveedores(int id)
        {
            var dat = db.proveedores.Find(id);
            db.proveedores.Remove(dat);
            db.SaveChanges();
        }

        public List<proveedores> filterprove(String nam)
        {

            return db.proveedores.Where(a => a.Nombre == nam).ToList();

        }
    }
}
