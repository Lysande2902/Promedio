using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar los números
        List<double> numeros = new List<double>();

        // Mensaje inicial al usuario
        Console.WriteLine("Este programa calculará el promedio de los números que ingreses.");
        
        while (true)
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa un número (o escribe 'fin' para terminar): ");
            string input = Console.ReadLine();

            // Verificar si el usuario escribió "fin" para terminar
            if (input.ToLower() == "fin")
            {
                break; // Salir del ciclo si el usuario termina
            }

            // Intentar convertir la entrada a un número
            if (double.TryParse(input, out double numero))
            {
                // Agregar el número a la lista
                numeros.Add(numero);
            }
            else
            {
                // Informar al usuario si la entrada no es válida
                Console.WriteLine("Por favor ingresa un número válido.");
            }
        }

        // Calcular y mostrar el promedio si se ingresaron números
        if (numeros.Count > 0)
        {
            double promedio = CalcularPromedio(numeros);
            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números para calcular el promedio.");
        }
    }

    // Función para calcular el promedio de una lista de números
    static double CalcularPromedio(List<double> numeros)
    {
        double suma = 0;

        // Sumar todos los números de la lista
        foreach (double numero in numeros)
        {
            suma += numero;
        }

        // Calcular el promedio
        return suma / numeros.Count;
    }
}
