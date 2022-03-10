using LibroAPILab04.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace LibroAPILab04.Controllers
{
    public class LibroDecryptController : ApiController
    {
        // GET: api/LibroDecrypt
        public List<Libro> Get()
        {
            var decrypted = new List<Libro>();
            foreach (var libro in LibroTransaction.libros)
            {
                decrypted.Add(Libro.DecryptLibro(libro));
            }
            return decrypted;
        }

        // GET: api/LibroDecrypt/5
        
        public Libro Get(int id)
        {
            var libro = LibroTransaction.libros.ElementAt(id);
            if (libro == null) throw new KeyNotFoundException();
            return Libro.DecryptLibro(libro);
        }     
    }
}
