using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad_System1;
using Negocio_Sytem;
namespace Show_Presentation.Controllers
{
    public class ProveedorController : Controller
    {
        Proveedores_NG ngp = new Proveedores_NG();
        // GET: Proveedor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormP(proveedores paramtr)
        {
            ngp.SetProveedores(paramtr);
            return RedirectToAction("Show_Datos_P");
        }


        public ActionResult Show_Datos_P()
        {

            var DTC = ngp.GetProveedores();
            return View(DTC);
        }

        public ActionResult Update(int id)
        {
            var model = ngp.LookUpProvedores(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(proveedores paramtr)
        {
            ngp.Update(paramtr);
            return RedirectToAction("Show_Datos_P");
        }

        public ActionResult Delete(int id)
        {
            var model = ngp.LookUpProvedores(id);

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOther(int id)
        {
            ngp.RemoveProveedores(id);

            return RedirectToAction("Show_Datos_P");
        }

        public ActionResult Filter(String Nombre)
        {
            var model = ngp.Filterprove(Nombre);

            if (model.Count == 0)
            {
                return RedirectToAction("Show_Datos_C");
            }

            else
            {
                return View(model);
            }

     
        }
}    }