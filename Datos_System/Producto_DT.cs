using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_System1;


namespace Datos_System
{
    public class Producto_DT
    {

        sistema_facturacion1Entities db = new sistema_facturacion1Entities();
        public void InsertaProductos(productos mode)
        {
            db.productos.Add(mode);
            db.SaveChanges();


        }

        public List<productos> LeeProductos()
        {
            return db.productos.ToList();


        }

        public productos SearchProductos(int id)
        {

            return db.productos.Find(id);
        }


        public void UpdateProd(productos prod)
        {

            var dat = db.productos.Find(prod.ID);
            dat.Nombre = prod.Nombre;
            dat.Precio = prod.Precio;
            db.Entry(dat).State = EntityState.Modified;
            db.SaveChanges();


        }

        public void DeleteProd(int id)
        {
            var dat = db.productos.Find(id);
            db.productos.Remove(dat);
            db.SaveChanges();
        }

        public List<productos> filterProd(String nam)
        {

            return db.productos.Where(a => a.Nombre == nam).ToList();

        }


        //public void InsertInventario(inventario mode)
        //{
        //    db.inventario.Add(mode);
        //    db.SaveChanges();
        //}


        //public void InsertFactura(factura mode)
        //{
        //    db.factura.Add(mode);
        //    db.SaveChanges();

        //}








    }
}