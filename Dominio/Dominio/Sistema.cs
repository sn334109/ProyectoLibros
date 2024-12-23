﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema instancia;
        public List<Persona> personas = new List<Persona>();
        public List<Libro> libros = new List<Libro>();

        #region Singleton
        public static Sistema Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Sistema();
                }
                return instancia;
            }
        }


        private Sistema()
        {
            PrecargaDeLibros();
            PrecargaDePersonas();
        }


        private void PrecargaDePersonas()
        {
            AgregarPersona(new Persona("Juan Pérez", new DateTime(1985, 5, 23), "12345678", CrearListaPrestamos()));
            AgregarPersona(new Persona("María González", new DateTime(1992, 8, 12), "23456789", CrearListaPrestamos()));
            AgregarPersona(new Persona("Carlos Ramírez", new DateTime(1979, 11, 3), "34567890", CrearListaPrestamos()));
            AgregarPersona(new Persona("Ana Fernández", new DateTime(1987, 1, 14), "45678901", CrearListaPrestamos()));
            AgregarPersona(new Persona("Luis Martínez", new DateTime(1990, 4, 9), "56789012", CrearListaPrestamos()));
            AgregarPersona(new Persona("Sofía Torres", new DateTime(1983, 10, 25), "67890123", CrearListaPrestamos()));
            AgregarPersona(new Persona("Javier López", new DateTime(1975, 12, 30), "78901234", CrearListaPrestamos()));
            AgregarPersona(new Persona("Valeria Castillo", new DateTime(1989, 7, 18), "89012345", CrearListaPrestamos() ));
            AgregarPersona(new Persona("Pedro Gutiérrez", new DateTime(1980, 6, 5), "90123456", CrearListaPrestamos()));
            AgregarPersona(new Persona("Camila Reyes", new DateTime(1991, 2, 20), "01234567", CrearListaPrestamos()));
            AgregarPersona(new Persona("Andrés García", new DateTime(1982, 9, 13), "13579246", CrearListaPrestamos()));
            AgregarPersona(new Persona("Laura Morales", new DateTime(1984, 3, 7), "24681357", CrearListaPrestamos()));
            AgregarPersona(new Persona("Diego Rojas", new DateTime(1978, 11, 23), "35792468", CrearListaPrestamos()));
            AgregarPersona(new Persona("Isabel Soto", new DateTime(1993, 5, 16), "46813579", CrearListaPrestamos()));
            AgregarPersona(new Persona("Fernando Álvarez", new DateTime(1986, 8, 28), "57924680", CrearListaPrestamos()));
            AgregarPersona(new Persona("Lucía Delgado", new DateTime(1981, 4, 11), "68035791", CrearListaPrestamos()));
            AgregarPersona(new Persona("Mateo Herrera", new DateTime(1995, 12, 6), "79146802", CrearListaPrestamos()));
            AgregarPersona(new Persona("Daniela Ortiz", new DateTime(1976, 7, 29), "80257913", CrearListaPrestamos()));
            AgregarPersona(new Persona("Sebastián Vargas", new DateTime(1988, 2, 2), "91368024", CrearListaPrestamos()));
            AgregarPersona(new Persona("Gabriela Muñoz", new DateTime(1994, 10, 17), "02479135", CrearListaPrestamos()));
        }

        private void PrecargaDeLibros()
        {
            AgregarLibro(new Libro("978-84-376-0494-7", "Cien años de soledad", "Gabriel García Márquez"));
            AgregarLibro(new Libro("978-84-339-7343-7", "Rayuela", "Julio Cortázar"));
            AgregarLibro(new Libro("978-84-670-5874-4", "Don Quijote de la Mancha", "Miguel de Cervantes"));
            AgregarLibro(new Libro("978-84-322-2227-6", "La sombra del viento", "Carlos Ruiz Zafón"));
            AgregarLibro(new Libro("978-84-938863-5-5", "El amor en los tiempos del cólera", "Gabriel García Márquez"));
            AgregarLibro(new Libro("978-84-233-5026-0", "La ciudad y los perros", "Mario Vargas Llosa"));
            AgregarLibro(new Libro("978-84-663-0163-1", "Crónica de una muerte anunciada", "Gabriel García Márquez"));
            AgregarLibro(new Libro("978-84-9069-489-6", "El juego del ángel", "Carlos Ruiz Zafón"));
            AgregarLibro(new Libro("978-84-206-8193-7", "Ficciones", "Jorge Luis Borges"));
            AgregarLibro(new Libro("978-84-376-1802-9", "Pedro Páramo", "Juan Rulfo"));
            AgregarLibro(new Libro("978-84-204-8709-6", "La casa de los espíritus", "Isabel Allende"));
            AgregarLibro(new Libro("978-84-339-7347-5", "2666", "Roberto Bolaño"));
            AgregarLibro(new Libro("978-84-7669-507-0", "El túnel", "Ernesto Sabato"));
            AgregarLibro(new Libro("978-84-339-7675-9", "Los detectives salvajes", "Roberto Bolaño"));
            AgregarLibro(new Libro("978-84-670-5897-3", "Fortunata y Jacinta", "Benito Pérez Galdós"));
            AgregarLibro(new Libro("978-84-376-0894-5", "El otoño del patriarca", "Gabriel García Márquez"));
            AgregarLibro(new Libro("978-84-206-8194-4", "El Aleph", "Jorge Luis Borges"));
            AgregarLibro(new Libro("978-84-376-1211-9", "La tía Julia y el escribidor", "Mario Vargas Llosa"));
            AgregarLibro(new Libro("978-84-204-8544-3", "La fiesta del Chivo", "Mario Vargas Llosa"));
            AgregarLibro(new Libro("978-84-339-7342-0", "El ruido de las cosas al caer", "Juan Gabriel Vásquez"));

        }

        private void PrecargaDePrestamos()
        {

        }
        #endregion


        public List<Persona> ordenarPersonasAlfabeticamente()
        {
            personas.Sort();
            return personas;

        }

        public List<Libro> ordenarLibrosPorISBN()
        {
            libros.Sort();
            return libros;
        }

        public void VerificarPersonaNoExiste(Persona unaP)
        {
            if (personas.Contains(unaP))
                throw new Exception("Persona ya existe.");
        }

        public void VerificarLibroNoExiste(Libro unL)
        {
            if (libros.Contains(unL))
                throw new Exception("Libro ya existe.");
        }


        public void AgregarPersona(Persona unaP)
        {
            try
            {
                unaP.Validar();
                CedulaUnica(unaP.Cedula);
                VerificarPersonaNoExiste(unaP);
                personas.Add(unaP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CedulaUnica(string cedula)
        {
            foreach (Persona unaPersona in personas)
            {
                if (unaPersona.Cedula == cedula)
                {
                    throw new Exception("La cédula ya existe en otro usuario");
                }
            }
        }

        public void AgregarLibro(Libro unLibro)
        {
            try
            {
                unLibro.Validar();
                VerificarLibroNoExiste(unLibro);
                libros.Add(unLibro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Persona? DevolverPersona(int id)
        {
            foreach (Persona unaP in personas)
            {
                if (unaP.Id == id) return unaP;
            }
            return null;
        }

        public string DevolverNombreDePersona(int id)
        {
            string nombreADevolver = "";
            Persona? unaP = DevolverPersona(id);
            if (unaP != null)
            {
                nombreADevolver = unaP.Nombre;
            }
            return nombreADevolver;
        }
        public List<Prestamo> DevolverPrestamosPersona(int id)
        {
            return DevolverPersona(id).Prestamos;
        }



        public Libro DevolverLibroPorId(int id)
        {
            foreach (Libro unLibro in libros)
            {
                if (unLibro.Id == id)
                {
                    return unLibro;
                }
            }
            return null; 
        }



        //METODO PARA CREAR LISTAS DE prestamos
        Random random = new Random();
        public List<Prestamo> CrearListaPrestamos()
        {
            List<int> idUsados = new List<int>();
            List<Prestamo> aux = new List<Prestamo>();

            int contadorRandom = 0;

            while (contadorRandom < 5)
            {
                int idAleatorio = random.Next(1, libros.Count +1);
                if (!idUsados.Contains(idAleatorio))
                {
                    idUsados.Add(idAleatorio);

                    contadorRandom++;
                    Prestamo nuevoPrestamo = new Prestamo(DateTime.Now.Date.AddDays(-idAleatorio), DevolverLibroPorId(idAleatorio)); 
                    aux.Add(nuevoPrestamo);
                }
            }
            return aux;
        }

    }
}
