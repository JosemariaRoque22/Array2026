
 static void ImprimirNotas(int[] notasx)
{
 for(int i = 0; i < notasx.Length; i++)
    {
    Console.WriteLine($"Nota {i + 1}: {notasx[i]}");
    }
}

int[] notas = {15,18,12,17,20};

ImprimirNotas(notas);

int suma = 0;
for(int i = 0; i < notas.Length; i++) 
{
    suma += notas[i];
}

Console.WriteLine($"Promedio de las notas: {(double)suma / notas.Length:F2}");