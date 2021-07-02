using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using App588.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace App588.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index(int? page)
        {
            var bd = new netsenaContext();
            
            //Lista y pagina clientes
            var pagenumber = page ?? 1;
            int pagesize = 6;
            var lisclientes = bd.Clientes.ToPagedList(pagenumber, pagesize);
            return View(lisclientes);
        }

        [Authorize]
        public IActionResult Crear()
        {
            var bd = new netsenaContext();
            //Cargar Roles de la base de datos
            var listaRoles = bd.Roles.ToList();
            ViewBag.Roles = listaRoles;
            return View();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult Crear(Clientes mycliente)
        {
            var bd = new netsenaContext();
            var Existe = bd.Clientes.Find(mycliente.Codigo);
            if (Existe == null)
            {
                bd.Clientes.Add(mycliente);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["msj"] = $"El Codigo{mycliente.Codigo} ya Existe";
                return View();
            }  
        }

        [Authorize(Roles = "Administrador, Coordinador")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var bd = new netsenaContext();
            var mycliente = bd.Clientes.Find(id);
            return View(mycliente);
        }

        [Authorize(Roles = "Administrador, Coordinador")]
        [HttpPost]
        public IActionResult Editar(Clientes mycliente)
        {
            var bd = new netsenaContext();
            var objcliente = bd.Clientes.Find(mycliente.Codigo);
            objcliente.Nombre = mycliente.Nombre;
            objcliente.Correo = mycliente.Correo;
            bd.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador, Vendedor")]
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var bd = new netsenaContext();
            var mycliente = bd.Clientes.Find(id);
            return View(mycliente);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Borrar(int id)
        {
            var bd = new netsenaContext();
            var mycliente = bd.Clientes.Find(id);
            return View(mycliente);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Borrar")]
        public IActionResult ConfirmarBorrar(int id)
        {
            var bd = new netsenaContext();
            var mycliente = bd.Clientes.Find(id);
            bd.Remove(mycliente);
            bd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
