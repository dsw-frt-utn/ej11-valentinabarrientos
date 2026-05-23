using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno a2 = new Alumno(2, "Maria Lopez", 9.2);
        Alumno a3 = new Alumno(3, "Carlos Gomez", 7.0);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("--- Lista de Alumnos ---");
        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n--- Buscar Alumno Existente ---");
        Alumno encontrado = casoList.BuscarPorNombre("Maria Lopez");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar Alumno Inexistente ---");
        Alumno noEncontrado = casoList.BuscarPorNombre("Pedro Rodriguez");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar un Alumno (Maria Lopez) y listar ---");
        casoList.EliminarAlumno(a2);
        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n--- Eliminar el primer elemento y listar ---");
        casoList.EliminarEnPosicion(0);
        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDic = new CasoDictionary();

        Alumno a1 = new Alumno(101, "Ana Martinez", 8.0);
        Alumno a2 = new Alumno(102, "Bruno Diaz", 7.5);
        Alumno a3 = new Alumno(103, "Cecilia Ortega", 9.6);

        casoDic.AgregarAlumno(101, a1);
        casoDic.AgregarAlumno(102, a2);
        casoDic.AgregarAlumno(103, a3);

        Console.WriteLine("--- Lista de Alumnos en Diccionario ---");
        foreach (var par in casoDic.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave (Legajo): {par.Key} -> {par.Value}");
        }

        Console.WriteLine("\n--- Buscar Alumno por Clave Existente (102) ---");
        Alumno encontrado = casoDic.BuscarPorLegajo(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar Alumno por Clave Inexistente (999) ---");
        Alumno noEncontrado = casoDic.BuscarPorLegajo(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar Alumno por Clave (101) y listar ---");
        casoDic.EliminarPorLegajo(101);
        foreach (var par in casoDic.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave (Legajo): {par.Key} -> {par.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();
        List<Libro> listaLibros = Libro.CrearLista();

        Console.WriteLine("1. Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero(listaLibros));

        Console.WriteLine("\n2. Último libro:");
        Console.WriteLine(casoLinq.GetUltimo(listaLibros));

        Console.WriteLine("\n3. Suma de precios:");
        Console.WriteLine($"{casoLinq.GetTotalPrecios(listaLibros):C}");

        Console.WriteLine("\n4. Promedio de precios:");
        Console.WriteLine($"{casoLinq.GetPromedioPrecios(listaLibros):C}");

        Console.WriteLine("\n5. Libros con Id mayor a 15:");
        foreach (var libro in casoLinq.GetListById(listaLibros))
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n6. Título y precio en formato moneda (Lista de strings):");
        foreach (var linea in casoLinq.GetLibros(listaLibros))
        {
            Console.WriteLine(linea);
        }

        Console.WriteLine("\n7. Libro con el precio más alto:");
        Console.WriteLine(casoLinq.GetMayorPrecio(listaLibros));

        Console.WriteLine("\n8. Libro con el precio más bajo:");
        Console.WriteLine(casoLinq.GetMenorPrecio(listaLibros));

        Console.WriteLine("\n9. Libros cuyo precio supera al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio(listaLibros))
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n10. Libros ordenados por título de forma descendente:");
        foreach (var libro in casoLinq.GetLibrosOrdenadosPorTituloDescendente(listaLibros))
        {
            Console.WriteLine(libro);
        }
    }
}
