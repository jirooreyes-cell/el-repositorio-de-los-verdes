using System;
using System.Collections.Generic;

public class DiccionarioHabilidades
{
    private Dictionary<string, string> registroItems;

    public DiccionarioHabilidades()
    {
        registroItems = new Dictionary<string, string>();
        registroItems.Add("Poción de Vida Menor", "Restaura salud y da un pequeño impulso defensivo.");
        registroItems.Add("Poción de Regeneración", "Restaura salud y maná de forma continua durante un tiempo breve (Duración: 30s).");
        registroItems.Add("Llave Dorada", "Llave resplandeciente obtenida al vencer al Jefe Esqueleto para pasar al siguiente nivel.");
    }

    public void ConsultarItem(string nombreItem)
    {
        if (registroItems.ContainsKey(nombreItem))
        {
            Console.WriteLine($"[Diccionario] Información de '{nombreItem}': {registroItems[nombreItem]}");
        }
        else
        {
            Console.WriteLine($"[Diccionario] El objeto '{nombreItem}' no está registrado en el inventario.");
        }
    }
}