using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Prestamo
    {
        DateTime fecha;
        Libro libroPrestado;

        public Prestamo(DateTime fecha, Libro libroPrestado)
        {
            this.fecha = fecha;
            this.libroPrestado = libroPrestado;
        }

        public Prestamo()
        {

        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Libro LibroPrestado { get => libroPrestado; set => libroPrestado = value; }


        public override string ToString()
        {
            return $"<td>{fecha}</td> <td>{libroPrestado.Nombre}</td>";
        }
    }
}
