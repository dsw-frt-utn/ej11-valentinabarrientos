//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave

using System.Collections.Generic;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnosDiccionario = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        _alumnosDiccionario.Add(legajo, alumno);
    }

    public Alumno BuscarPorLegajo(int legajo)
    {
        _alumnosDiccionario.TryGetValue(legajo, out Alumno alumno);
        return alumno;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnosDiccionario;
    }

    public bool EliminarPorLegajo(int legajo)
    {
        return _alumnosDiccionario.Remove(legajo);
    }
}
