using System;
using System.Collections.Generic;

public class ListaInventarioLibro
{
    private List<string> partesLibro;

    public ListaInventarioLibro()
    {
        partesLibro = new List<string>();
    }

    public void RecolectarParte(string parte)
    {
        partesLibro.Add(parte);
        Console.WriteLine($"[Inventario] ¡Parte del libro encontrada y guardada!: {parte}");
    }

    public void MostrarPartes()
    {
        Console.WriteLine("\n--- Partes del Libro Mágico Recolectadas ---");
        if (partesLibro.Count == 0)
        {
            Console.WriteLine("Aún no se ha recolectado ninguna parte del libro.");
        }
        else
        {
            foreach (var parte in partesLibro)
            {
                Console.WriteLine($"- {parte}");
            }
        }
    }
}