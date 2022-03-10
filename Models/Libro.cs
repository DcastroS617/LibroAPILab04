using LibroAPILab04.Data;
using System.Collections.Generic;

namespace LibroAPILab04.Models
{
    public class Libro
    {
        public string title { get; set; }
        public string isbn { get; set; }
        public string autor { get; set; }
        public string publisher { get; set; }

        public static Libro DecryptLibro(Libro libro)
        {
            return new Libro { 
                autor = Crypt.Decrypt(libro.autor),
                title= Crypt.Decrypt(libro.title),
                isbn= Crypt.Decrypt(libro.isbn),
                publisher= Crypt.Decrypt(libro.publisher)
            };
        }
        public static Libro EncryptLibro(Libro libro)
        {
            return new Libro
            {
                autor = Crypt.Encrypt(libro.autor),
                title = Crypt.Encrypt(libro.title),
                isbn = Crypt.Encrypt(libro.isbn),
                publisher = Crypt.Encrypt(libro.publisher)
            };
        }
        
    }
    public class LibroTransaction
    {
        public static List<Libro> libros = new List<Libro>();
    }
}