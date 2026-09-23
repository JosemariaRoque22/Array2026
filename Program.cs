
 static void ImprimirNotas(int[] notasx)
{
 for(int i = 0; i < notasx.Length; i++)
    {
    Console.WriteLine($"Nota {i + 1}: {notasx[i]}");
    }
}

static double PromedioNotas(int[] notasx)
{
    int suma = 0;
    for(int i = 0; i < notasx.Length; i++) 
    {
        suma += notasx[i];
    }
    return (double)suma / notasx.Length;
}

int[] notas = {15,18,12,17,20};

ImprimirNotas(notas);

double Promedio = PromedioNotas(notas);
Console.WriteLine($"Promedio de las notas: {Promedio:F2}");