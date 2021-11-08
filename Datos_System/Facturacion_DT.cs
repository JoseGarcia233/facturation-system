using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_System1;
namespace Datos_System
{
    public  class Facturacion_DT
    {




        sistema_facturacion1Entities db = new sistema_facturacion1Entities();


        public void InsertFactura(factura mode)
        {

            db.factura.Add(mode);
            db.SaveChanges();
        }

        public List<factura> LeeFactura()
        {
            return db.factura.ToList();

        }

        public factura SearchFactura(int id)
        {

            return db.factura.Find(id);
        }

        public void UpdateFacturacin(factura fac)
        {

            var dat = db.factura.Find(fac.Id);
            dat.Nombre_producto = fac.Nombre_producto;
            dat.Categoria_Cliente = fac.Categoria_Cliente;
            dat.Catidad= fac.Catidad;
            dat.Monto_total = fac.Monto_total;

            db.Entry(dat).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleFactura(int id)
        {
            var dat = db.factura.Find(id);
            db.factura.Remove(dat);
            db.SaveChanges();
        }

        public List<factura> filterFactura(int nam)
        {

            return db.factura.Where(a => a.Nombre_producto == nam).ToList();

        }
    }
}
