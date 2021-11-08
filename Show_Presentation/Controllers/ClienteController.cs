using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad_System1;
using Negocio_Sytem;

namespace Show_Presentation.Controllers
{
    public class ClienteController : Controller
    {
        Cliente_NG ngc = new Cliente_NG();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FormC()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormC(clientes paramtr)
        {
            ngc.SetClientes(paramtr);
            return RedirectToAction("Show_Datos_C");
        }

        public ActionResult Show_Datos_C()
        {

            var DTC = ngc.GetClientes();
            return View(DTC);
        }

        public ActionResult UpdateC(int id)
        {
            var model = ngc.LookUpClientes(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateC(clientes paramtr)
        {
            ngc.Update(paramtr);
            return RedirectToAction("Show_Datos_C");
        }

        public ActionResult Delete(int id)
        {
            var model = ngc.LookUpClientes(id);

            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOther(int id)
        {
            ngc.RemoveCliente(id);

            return RedirectToAction("Show_Datos_C");
        }

        public ActionResult Filter(String Nombre)
        {
            var model = ngc.Filterclt(Nombre);

            if (model.Count == 0)
            {
                return RedirectToAction("Show_Datos_C");
            }

            else
            {
                return View(model);
            }




        }
    
    

    }
}