using LibroAPILab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace LibroAPILab04.Controllers
{
    public class LibroEncryptController : ApiController
    {
        // GET: api/Libro
        public List<Libro> Get()
        {          
            return LibroTransaction.libros;
        }      

        // GET: api/Libro/5
        public Libro Get(int id)
        {
            return LibroTransaction.libros.ElementAt(id);           
        }

        // POST: api/Libro
        public IHttpActionResult Post([FromBody]Libro libro)
        {
            if (libro == null) throw new Exception("Debe introducir los datos para continuar...");
            LibroTransaction.libros.Add(Libro.EncryptLibro(libro));
            return Ok(libro);
        }
    }
}
