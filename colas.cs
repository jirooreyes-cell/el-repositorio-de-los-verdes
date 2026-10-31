using System;
using System.Collections.Generic;

public class ColaEnemigos
{
    private Queue<string> colaEsqueletos;

    public ColaEnemigos()
    {
        colaEsqueletos = new Queue<string>();
    }

    public void RegistrarEnemigo(string esqueleto)
    {
        colaEsqueletos.Enqueue(esqueleto);
        Console.WriteLine($"[Cola] Enemigo acechando en el bosque: {esqueleto}");
    }

    public void AtacarSiguienteEnemigo()
    {
        if (colaEsqueletos.Count > 0)
        {
            string esqueletoAtacando = colaEsqueletos.Dequeue();
            Console.WriteLine($"[Cola] El mago ataca y derrota al enemigo en fila: {esqueletoAtacando}");
        }
        else
        {
            Console.WriteLine("[Cola] No hay más enemigos en la fila del bosque.");
        }
    }
}