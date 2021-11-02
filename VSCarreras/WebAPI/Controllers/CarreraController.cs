using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Servicios;
using Newtonsoft.Json;
using Backend.Dominio;
using System.Net.Mime;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private IService servicio;
        public CarreraController()
        {
            servicio = new ServiceFactory().CrearService();
        }

        //GET: api/Carrera
        //Trae todas las carreras
        [HttpGet]
        public IActionResult GetCarreras()
        {
            return Ok(servicio.ObtenerCarreras());
        }

        // GET api/Carrera/5
        // Trae todos los datos de una carrera por id
        [HttpGet("{id}")]
        public IActionResult GetCarreraById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest("Id es requerido!");
            }
            else
            {
                return Ok(servicio.BuscarCarreraPorId(id));
            }
        }

        // POST api/Carrera
        [HttpPost]
        public IActionResult AgregarCarrera(Carrera oCarrera)
        {
            if (oCarrera.AnioMaximo == null || oCarrera.AnioMaximo <= 0 || oCarrera.AnioMaximo >= 100 || oCarrera.Nombre.Trim() == "")
            {
                return BadRequest("missingParam");
            }
            else if (servicio.GuardarCarrera(oCarrera))
            {
                return Ok(true);
            }
            else {
                return BadRequest(false);
            }               
        }

        // DELETE api/Carrera/1
        // elimina una carrera por id
        [HttpDelete("{id}")]
        public IActionResult DeleteCarreraById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest("missingParam");
            }
            else
            {
                return Ok(servicio.EliminarCarrera(id));
            }
        }

        // GET api/Carrera/asignaturas
        // trae todas las asignaturas

        [HttpGet("asignaturas")]
        public IActionResult GetAsignaturas()
        {
            return Ok(servicio.ObtenerAsignaturas());
        }

        [HttpPost("asignaturas")]
        public IActionResult PostAsignatura(Asignatura oAsignatura)
        {
            if (oAsignatura.Nombre.Trim() == "")
            {
                return BadRequest("missingParam");
            }
            else 
            {
                if (servicio.GuardarAsignatura(oAsignatura))
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest(false);
                }
                
            }
        }

        // GET api/Carrera/asignaturas/1
        // Elimina una asignatura por id
        [HttpDelete("asignaturas/{id}")]
        public IActionResult DeleteAsignaturaById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest("missingId");
            }
            else
            {
                return Ok(servicio.EliminarAsignatura(id));
            }
        }

        [HttpPost("/login/")]
        public IActionResult PostLogin(Credenciales oCredenciales)
        {
            if ( oCredenciales.Usuario.Trim() == "" || oCredenciales.Password.Trim() == "")
            {
                return BadRequest("missingParam");
            }
            else if (servicio.IniciarSesion(oCredenciales))
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
    }
}
