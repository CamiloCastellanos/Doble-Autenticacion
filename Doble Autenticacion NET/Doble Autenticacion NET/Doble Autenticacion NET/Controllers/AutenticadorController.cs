using Doble_Autenticacion_NET.Models;
using Google.Authenticator;
using System;
using System.Web.Mvc;

namespace Doble_Autenticacion_NET.Controllers
{
    public class AutenticadorController : Controller
    {
        public string nombreAplicacion = "Autenticacion Net";
        public string correoUsuario = "Prueba@gmail.com";
        public string claveAutenticador = "Prueba-Autenticacion-Net";

        // POST: Autenticador/Create
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar()
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GeneradorToken()
        {
            try
            {
                TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

                string nombreAplicacion = "Autenticacion Net";
                string correoUsuario = "Prueba@gmail.com";
                string clave = "Prueba-Autenticacion-Net";

                SetupCode setupCode = autenticador.GenerateSetupCode(nombreAplicacion, correoUsuario, clave, false);

                ViewBag.ImagenQR = setupCode.QrCodeSetupImageUrl;
                ViewBag.CodigoManual = setupCode.ManualEntryKey;
            }
            catch (Exception ex)
            {
            }
            return View();
        }

        [HttpPost]
        public ActionResult GeneradorToken(Autenticacion atenticacion)
        {
            try
            {
                TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

                SetupCode setupCode = autenticador.GenerateSetupCode(nombreAplicacion, correoUsuario, claveAutenticador, true);

                ViewBag.ImagenQR = setupCode.QrCodeSetupImageUrl;
                ViewBag.CofigoManual = setupCode.ManualEntryKey;

            }
            catch { }
            return View();
        }

        /// <summary>
        /// Valida la clave ingresada
        /// </summary>
        /// <param name="clave"></param>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public void ValidadorPing(string clave)
        {
            TwoFactorAuthenticator autenticador = new TwoFactorAuthenticator();

            bool pingCOrrecto = autenticador.ValidateTwoFactorPIN(claveAutenticador,clave);
        }

    }
}
