using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Servicios;

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

        // POST api/<CarreraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarreraController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/Carrera/1
        // elimina una carrera por id
        [HttpDelete("{id}")]
        public IActionResult DeleteCarreraById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest("Id es requerido!");
            }
            else
            {
                return Ok(servicio.EliminarCarrera(id));
            }
        }

        // GET api/Carrera/asignaturas
        // trae todas las asignaturas

        [HttpGet("/asignaturas/")]
        public IActionResult GetAsignaturas()
        {
            return Ok(servicio.ObtenerAsignaturas());
        }

        // GET api/Carrera/asignaturas/1
        // Elimina una asignatura por id
        [HttpDelete("/asignaturas/{id}")]
        public IActionResult DeleteAsignaturaById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest("Id es requerido!");
            }
            else
            {
                return Ok(servicio.EliminarAsignatura(id));
            }
        }
    }
}
