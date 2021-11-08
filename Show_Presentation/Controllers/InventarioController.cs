using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad_System1;
using Negocio_Sytem;
using Show_Presentation.Models;
using inventario = Entidad_System1.inventario;

namespace Show_Presentation.Controllers
{
    public class InventarioController : Controller
    {
        Inventario_NG ngi = new Inventario_NG();
        // GET: Inventario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormI()
        {
            List < TableFork >  lst =  null; 
            using (sistema_facturacion1Entities1 db = new sistema_facturacion1Entities1())
            {

               lst = (from d in db.productos
                select new TableFork
                {
                    Id = d.ID,
                    Nombre_Producto = d.ID,
                                          

                }).ToList();


                
            }

            List<SelectListItem> items = lst.ConvertAll(d =>
           {
               return new SelectListItem()
               {
                   Text = d.Nombre_Producto.ToString(),
                   Value = d.Id.ToString(),
                   Selected = false
               };

           });

            ViewBag.items = items;

            List<TableFork> lst1  = null;
            using (sistema_facturacion1Entities1 db = new sistema_facturacion1Entities1())
            {

                lst1 = (from d in db.proveedores
                 select new TableFork
                 {
                  Id = d.Id,
                  Nombre_proveedor = d.Id,

                 }).ToList();



            }

            List<SelectListItem> items1 = lst1.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre_proveedor.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };

            });

            ViewBag.items1 = items1;

            return View();
        }
        [HttpPost]
        public ActionResult FormI(Entidad_System1.inventario paramtr)
        {
            ngi.SetInventario(paramtr);
            return RedirectToAction("Show_Datos_I");
        }


        public ActionResult Show_Datos_I()
        {

            var DTC = ngi.GetInventanrio();
            return View(DTC);
        }

        public ActionResult Update(int id)
        {
            var model = ngi.LookUpInventario(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(inventario paramtr)
        {
            ngi.Update(paramtr);
            return RedirectToAction("Show_Datos_I");
        }

        public ActionResult Delete(int id)
        {
            var model = ngi.LookUpInventario(id);

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOther(int id)
        {
            ngi.RemoveInventario(id);

            return RedirectToAction("Show_Datos_I");
        }

        public ActionResult Filter(int Nombre)
        {
            var model = ngi.Filterinv(Nombre);

            if (model.Count == 0)
            {
                return RedirectToAction("Show_Datos_I");
            }

            else
            {
                return View(model);
            }


        }
    }
}