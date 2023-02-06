using System.Collections;


ArrayList calificaciones = new ArrayList();


int numEstudiantes = 0;
string calif = "";

Console.WriteLine("Escriba la cantidad de estudiantes de la clase");
numEstudiantes=int.Parse(Console.ReadLine());
for (int i = 0; i < numEstudiantes; i++)
{
    Console.WriteLine("Ingrese la calificación del estudiante " + (i + 1));
    calif = Console.ReadLine();
    calificaciones.Add(Convert.ToInt32(calif));
}

Console.WriteLine("El promedio de las calificaciones es: " + Promedio(calificaciones));

Console.WriteLine("La calificación mas baja es: " + calificacionMAsBaja(calificaciones));

Console.WriteLine("La calificación mas alta es: " + CalificacionMasAlta(calificaciones));


static double Promedio(ArrayList calificaciones)
{
    double suma = 0.0;

    for (int i = 0; i < calificaciones.Count; i++)
    {
        suma += (int)calificaciones[i];
    }

    return suma / calificaciones.Count;
}

static int calificacionMAsBaja(ArrayList calificaciones)
{
    int CalifBaj = (int)calificaciones[0];

    for (int i = 1; i < calificaciones.Count; i++)
    {
        if ((int)calificaciones[i] < CalifBaj)
        {
            CalifBaj = (int)calificaciones[i];
        }
    }

    return CalifBaj;
}

static int CalificacionMasAlta(ArrayList calificaciones)
{
    int CalifAlt = (int)calificaciones[0];

    for (int i = 1; i < calificaciones.Count; i++)
    {
        if ((int)calificaciones[i] > CalifAlt)
        {
            CalifAlt = (int)calificaciones[i];
        }
    }

    return CalifAlt;
}
