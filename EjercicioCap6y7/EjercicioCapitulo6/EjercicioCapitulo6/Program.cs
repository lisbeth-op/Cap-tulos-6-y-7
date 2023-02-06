
int[][] calificaciones = new int[2][];






for (int i = 0; i < 2; i++)
{
    Console.Write("Cuantos tiene la clase " + (i + 1) + ": ");
    int numAlumnos = int.Parse(Console.ReadLine());
    calificaciones[i] = new int[numAlumnos];
    for (int j = 0; j < numAlumnos; j++)
    {
        Console.Write("Escriba  la calificacion del alumno " + (j + 1) + ": ");
        calificaciones[i][j] = int.Parse(Console.ReadLine());
    }
}



Console.Clear();
Imprime(calificaciones);

Console.WriteLine("\n\nEl promedio de todas las clases es: " + Promedio(calificaciones));


Console.WriteLine("\nLa calificacion menor es: " + Menor(calificaciones));



static void Imprime(int[][] arreglo)
{
  
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine("Clase " + (i + 1));
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            Console.WriteLine("La calificcion del alumno " + (j + 1) + " es: " + arreglo[i][j]);
        }
    }
}


static double Promedio(int[][] arreglo)
{
   
    double suma = 0.0;
    int total = 0;
    for (int i = 0; i < 2; i++)
    {
        for ( int j = 0; j < arreglo[i].Length; j++)
        {
            suma += arreglo[i][j];
            total++;
        }
    }
    return suma / total;
}
static int Menor(int[][] arreglo)
{
    int menor = int.MaxValue;
    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            if (arreglo[i][j] < menor)
                menor = arreglo[i][j];
        }
    }
    return menor;
}
