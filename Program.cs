using System;

// Definición de la estructura Trabajador
struct Trabajador
{
    public string nombre;
    public char sexo;
    public double sueldo;
}

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario la cantidad de trabajadores
        Console.Write("Ingrese la cantidad de trabajadores: ");
        int cantidadTrabajadores = Convert.ToInt32(Console.ReadLine());

        // Declarar un arreglo de trabajadores
        Trabajador[] trabajadores = new Trabajador[cantidadTrabajadores];

        // Variables para contar la cantidad de mujeres
        int mujeres = 0;

        // Solicitar los datos de cada trabajador
        for (int i = 0; i < cantidadTrabajadores; i++)
        {
            Console.WriteLine($"Ingrese los datos del trabajador {i + 1}:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Sexo (M/F): ");
            char sexo = Convert.ToChar(Console.ReadLine());
            Console.Write("Sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            // Guardar los datos en el arreglo de trabajadores
            trabajadores[i].nombre = nombre;
            trabajadores[i].sexo = sexo;
            trabajadores[i].sueldo = sueldo;

            // Contar la cantidad de mujeres
            if (sexo == 'F' || sexo == 'f')
            {
                mujeres++;
            }
        }

        // Calcular y mostrar el sueldo neto de cada trabajador
        Console.WriteLine("\nSueldo neto de cada trabajador:");
        for (int i = 0; i < cantidadTrabajadores; i++)
        {
            double sueldoNeto = CalcularSueldoNeto(trabajadores[i].sueldo);
            Console.WriteLine($"{trabajadores[i].nombre}: {sueldoNeto:C}");
        }

        // Mostrar la cantidad de mujeres en la empresa
        Console.WriteLine($"\nCantidad de mujeres en la empresa: {mujeres}");

        Console.ReadLine();
    }

    // Función para calcular el sueldo neto aplicando los descuentos
    static double CalcularSueldoNeto(double sueldo)
    {
        const double SeguroSocial = 0.05;
        const double AhorroHabitacional = 0.07;
        const double CajaAhorro = 0.1;

        double totalDescuentos = sueldo * (SeguroSocial + AhorroHabitacional + CajaAhorro);
        double sueldoNeto = sueldo - totalDescuentos;
        return sueldoNeto;
    }
}
