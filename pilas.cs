using System;
using System.Collections.Generic;

public class PilaPociones
{
    private Stack<string> pilaPocionesVuelo;

    public PilaPociones()
    {
        pilaPocionesVuelo = new Stack<string>();
    }

    public void ObtenerPocion(string pocion)
    {
        pilaPocionesVuelo.Push(pocion);
        Console.WriteLine($"[Pila] Poción guardada en la mochila: {pocion}");
    }

    public void UsarPocion()
    {
        if (pilaPocionesVuelo.Count > 0)
        {
            string pocionUsada = pilaPocionesVuelo.Pop();
            Console.WriteLine($"[Pila] El mago ha consumido/usado: {pocionUsada} (Efecto aplicado).");
        }
        else
        {
            Console.WriteLine("[Pila] No quedan pociones en la pila para usar.");
        }
    }
}