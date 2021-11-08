using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad_System1;
using Negocio_Sytem;
using Show_Presentation.Models;

namespace Show_Presentation.Controllers
{
    public class FacturacionController : Controller
    {
        Faturacion_NG ngf = new Faturacion_NG();
        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FormF()
        {
            List<TableFork> lst = null;
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
            List<TableFork> lst1 = null;
            using (sistema_facturacion1Entities1 db = new sistema_facturacion1Entities1())
            {

                lst1 = (from d in db.clientes
                        select new TableFork
                        {
                            Id = d.Id,
                            Categoria_Cliente = d.Id,

                        }).ToList();



            }

            List<SelectListItem> items1 = lst1.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Categoria_Cliente.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };

            });

            ViewBag.items1 = items1;


            //List<TableFork> lst2 = null;
            //using (sistema_facturacion1Entities1 db = new sistema_facturacion1Entities1())
            //{

            //    lst1 = (from d in db.inventario
            //            select new TableFork
            //            {
            //                Id = d.Id,
            //                Catidad = d.Id,

            //            }).ToList();



            //}

            //List<SelectListItem> items2 = lst2.ConvertAll(d =>
            //{
            //    return new SelectListItem()
            //    {
            //        Text = d.Catidad.ToString(),
            //        Value = d.Id.ToString(),
            //        Selected = false
            //    };

            //});



            //ViewBag.items2 = items2;




            return View();
        }
        [HttpPost]
        public ActionResult FormI(Entidad_System1.factura paramtr)
        {
            ngf.SetFactura(paramtr);
            return RedirectToAction("Show_Datos_F");
        }


        public ActionResult Show_Datos_F()
        {

            var DTC = ngf.GetFactura();
            return View(DTC);
        }

        public ActionResult Update(int id)
        {
            var model = ngf.Filterfc(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Entidad_System1.factura paramtr)
        {
            ngf.Update(paramtr);
            return RedirectToAction("Show_Datos_f");
        }

        public ActionResult Delete(int id)
        {
            var model = ngf.LookUpProvedores(id);

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOther(int id)
        {
            ngf.RemoveFactura(id);

            return RedirectToAction("Show_Datos_F");
        }

        public ActionResult Filter(int Nombre)
        {
            var model = ngf.Filterfc(Nombre);

            if (model.Count == 0)
            {
                return RedirectToAction("Show_Datos_f");
            }

            else
            {
                return View(model);
            }

        }


    }
}