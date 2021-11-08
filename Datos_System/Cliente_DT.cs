using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad_System1;
namespace Datos_System
{
   public  class Cliente_DT
   {
        sistema_facturacion1Entities db = new sistema_facturacion1Entities();


        public void InsertClientes(clientes mode)
        {

            db.clientes.Add(mode);
            db.SaveChanges();
        }

        public List<clientes> LeeClientes()
        {
            return db.clientes.ToList();

        }

        public clientes SearchCliente(int id)
        {

            return db.clientes.Find(id);
        }

        public void UpdateCliente(clientes clien)
        {

            var dat = db.clientes.Find(clien.Id);
            dat.Nombre = clien.Nombre;
            dat.Cedula = clien.Cedula;
            dat.Telefono = clien.Telefono;
            dat.Categoria = clien.Categoria;
            dat.Email = clien.Email;
            db.Entry(dat).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleCliente(int id)
        {
            var dat = db.clientes.Find(id);
            db.clientes.Remove(dat);
            db.SaveChanges();
        }

        public List<clientes> filterClien(String nam)
        {

            return db.clientes.Where(a => a.Nombre == nam ).ToList();



        }

    }
}
