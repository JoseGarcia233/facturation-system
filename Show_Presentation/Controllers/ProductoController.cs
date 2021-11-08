using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad_System1;
using Negocio_Sytem;

namespace Show_Presentation.Controllers
{
    public class ProductoController : Controller
    {
        Producto_NG ng = new Producto_NG();

        // GET: Producto
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(productos product)
        {
            ng.SetProducto(product);
            return RedirectToAction("Show_Datos");
        }
        public ActionResult Show_Datos()
        {

            var DT = ng.GetProductos();
            return View(DT);
        }

        public ActionResult Update(int id)
        {
            var model = ng.LookUpProducto(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Update(productos product)
        {
            ng.Update(product);
            return RedirectToAction("Show_Datos");
        }

        public ActionResult Delete(int id)
        {
            var model = ng.LookUpProducto(id);

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOther(int id)
        {
            ng.RemoveProduct(id);

            return RedirectToAction("Show_Datos");
        }

        public ActionResult Filter(String Nombre)
        {
            var model = ng.FilterPdt(Nombre);

            if (model.Count == 0)
            {
                return RedirectToAction("Show_Datos");
            }

            else
            {
                return View(model);
            }
        }
    }
}