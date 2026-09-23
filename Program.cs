
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

static int Maximo(int[] notasx)
{   
    int max= notasx[0];
    for(int i = 1; i < notasx.Length; i++)
    {
        if(notasx[i] > max)
        {
            max = notasx[i];
        }
    }
        return max;
}

static int Minima(int[] notasx)
{
    int min= notasx[0];
    for (int i  = 1;  i < notasx.Length; i++)
    {
        if (notasx[i] < min)
    {
        min = notasx[i];
    }
  
    }
      return min;
}

int[] notas = {15,18,12,17,20};
ImprimirNotas(notas);

int max= notas[0];
int min= notas[0];

int maximo = Maximo(notas);
int minimo = Minima(notas);
Console.WriteLine($"Minima nota: {minimo}");
Console.WriteLine($"Maximo nota: {maximo}");


double Promedio = PromedioNotas(notas);
Console.WriteLine($"Promedio de las notags: {Promedio:F2}");