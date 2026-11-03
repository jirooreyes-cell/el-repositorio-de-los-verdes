using System;

public class NodoHechizoCircular
{
    public string NombreHechizo;
    public NodoHechizoCircular Siguiente;

    public NodoHechizoCircular(string nombre)
    {
        NombreHechizo = nombre;
        Siguiente = null;
    }
}

public class ListaCircularHechizos
{
    private NodoHechizoCircular actual;

    public void AgregarHechizo(string nombre)
    {
        NodoHechizoCircular nuevo = new NodoHechizoCircular(nombre);
        if (actual == null)
        {
            actual = nuevo;
            actual.Siguiente = actual; // Apunta a sí mismo formando el círculo
        }
        else
        {
            NodoHechizoCircular temp = actual;
            while (temp.Siguiente != actual)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevo;
            nuevo.Siguiente = actual;
        }
        Console.WriteLine($"[Lista Circular Hechizos] Hechizo añadido al ciclo rápido: {nombre}");
    }

    public void SiguienteHechizo()
    {
        if (actual != null)
        {
            actual = actual.Siguiente;
            Console.WriteLine($"[Lista Circular Hechizos] Cambiando hechizo activo -> Equipado: {actual.NombreHechizo}");
        }
        else
        {
            Console.WriteLine("[Lista Circular Hechizos] No hay hechizos equipados.");
        }
    }
}