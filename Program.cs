using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("     FOREST OF CURSES - ESTRUCTURAS DE DATOS      ");
        Console.WriteLine("==================================================\n");

        // 1. PRUEBA DE LISTAS (Inventario de partes del libro)
        Console.WriteLine("--- 1. RAMA DE LISTAS ---");
        ListaInventarioLibro inventarioLibro = new ListaInventarioLibro();
        inventarioLibro.RecolectarParte("Página Mágica de Hechizos");
        inventarioLibro.RecolectarParte("Lomo del Libro Antiguo");
        inventarioLibro.MostrarPartes();
        Console.WriteLine();

        // 2. PRUEBA DE PILAS (Pociones LIFO)
        Console.WriteLine("--- 2. RAMA DE PILAS ---");
        PilaPociones pilaPociones = new PilaPociones();
        pilaPociones.ObtenerPocion("Poción de Regeneración menor");
        pilaPociones.ObtenerPocion("Poción de Vuelo (Especial)");
        pilaPociones.UsarPocion();
        Console.WriteLine();

        // 3. PRUEBA DE COLAS (Enemigos FIFO)
        Console.WriteLine("--- 3. RAMA DE COLAS ---");
        ColaEnemigos colaEnemigos = new ColaEnemigos();
        colaEnemigos.RegistrarEnemigo("Esqueleto con Espada");
        colaEnemigos.RegistrarEnemigo("Esqueleto con Lanza");
        colaEnemigos.AtacarSiguienteEnemigo();
        Console.WriteLine();

        // 4. PRUEBA DE DICCIONARIOS (Registro de Objetos)
        Console.WriteLine("--- 4. RAMA DE DICCIONARIOS ---");
        DiccionarioHabilidades diccionario = new DiccionarioHabilidades();
        diccionario.ConsultarItem("Poción de Regeneración");
        diccionario.ConsultarItem("Llave Dorada");

        Console.WriteLine("\n==================================================");
        Console.WriteLine(" ¡Estructuras operando correctamente sin listas enlazadas!");
        Console.WriteLine("==================================================");
    }
}