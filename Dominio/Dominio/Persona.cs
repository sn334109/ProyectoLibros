using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona: IValidable, IComparable<Persona>

    {
        int id;
        static int ultimoId;
        string nombre;
        DateTime fechaNacimiento;
        string cedula;
        List<Prestamo> prestamos = new List<Prestamo>();

        public int Id { get => id; set => id = value; }
        public static int UltimoId { get => ultimoId; set => ultimoId = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public List<Prestamo> Prestamos { get => prestamos; set => prestamos = value; }

        public Persona(string nombre, DateTime fechaNacimiento, string cedula, List<Prestamo> librosPrestados)
        {
            this.id = ++ultimoId;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.cedula = cedula;
            this.prestamos = librosPrestados;
        }

        public Persona() 
        {
            this.id = ++ultimoId;
        }    


        private void ValidarDocumento() 
        {
            //validar que la cedula tenga solo digitos
            if (int.TryParse(cedula, out int nroCedula))
            {
                if (cedula.Length < 6) throw new Exception("La cantidad de digitos minimo debe ser de 6");
            }
            else
            {
                throw new Exception("El número de cedula solo debe contener digitos númericos");
            }
        }

        private void ValidarFechaNacimiento() {
            if (fechaNacimiento >= DateTime.Now) 
            {
                throw new Exception($"La fecha de nacimiento {fechaNacimiento} no es correcta teniendo en cuenta la fecha de hoy {DateTime.Now}");
            }
        }

        public void Validar()
        {
            ValidarDocumento();
            ValidarFechaNacimiento();
        }

        public int CompareTo(Persona? other)
        {
                return this.Nombre.CompareTo(other.Nombre);
        }
    }
}
