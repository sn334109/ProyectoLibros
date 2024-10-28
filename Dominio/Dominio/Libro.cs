using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Libro: IValidable, IComparable<Libro>  
    {
        int id;
        static int ultimoId;
        string isbn;
        string nombre;
        string autor;

        public int Id { get => id; set => id = value; }
        public static int UltimoId { get => ultimoId; set => ultimoId = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }

        public Libro(string isbn, string nombre, string autor)
        {
            this.id = ++ultimoId;
            this.isbn = isbn;
            this.nombre = nombre;
            this.autor = autor;
        }
        public Libro() 
        {
            this.id = ++ultimoId;
        }

        private void ValidarISBN() 
        {
            if (isbn.Length < 8) 
                throw new Exception("El codigo ISBN no tiene el largo adecuado (minimo 8 numeros)");
        }

        private void ValidarCamposVacios()
        {
            if (nombre == "" || autor == "") 
                throw new Exception();
        }

        public void Validar()
        {
            ValidarISBN();
            ValidarCamposVacios();
        }

        public int CompareTo(Libro? other)
        {
            return this.isbn.CompareTo(other.isbn);
        }

    }
}
