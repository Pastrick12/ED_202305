using System;
using System.Collections;

class EjemploDePila
{
    static void Main()
    {
        string texto;
        Stack miPila = new Stack();
        do
        {
            Console.Write("Introduce texto (o \"fin.\" para finalizar): ");
            texto = Console.ReadLine();

            if (texto != "fin.")
                miPila.Push(texto);

        } while (texto != "fin.");

        while (miPila.Count > 0)
            Console.WriteLine(miPila.Pop());

    }
}