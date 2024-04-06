using System.Collections;

int[] notas;

double CalcularPromedioForEach(int[] notas)
{
    int sumaNotas = 0;
    float promedio = 0;
    int cantidad = notas.Length;
    int menor = 0;
    int mayor = 0;

    menor = notas[0];
    mayor = notas[0];
   
    foreach (var item in notas)
    {
        //Calculando la nota menor
        if (item < menor)
            menor = item;

        //Calculando la nota mayor
        if (item > mayor)
            mayor = item;

        //Sumando todo
        sumaNotas = sumaNotas + item;
    }

    promedio = (sumaNotas - mayor - menor) / (cantidad - 2);
    return promedio;
}
double CalcularPromedio(int[] notas)
{
    int sumaNotas = 0;
    float promedio = 0;
    int cantidad = notas.Length;
    int menor = 0;
    int mayor = 0;

    menor = notas[0];
    mayor = notas[0];

    //Identificar el menor
    for (int i = 0; i < cantidad; i++)
    {
        //Calculando la nota menor
        if (notas[i] < menor)
            menor = notas[i];

        //Calculando la nota mayor
        if (notas[i] > mayor)
            mayor = notas[i];

        //Sumando todo
        sumaNotas = sumaNotas + notas[i];
    }


    promedio = (sumaNotas - mayor - menor) / (cantidad - 2);
    return promedio;
}
void IngresarNotas()
{
    int cantidad = 0;
    Console.WriteLine("INGRESE CANTIDAD DE NOTAS");
    cantidad = Convert.ToInt32(Console.ReadLine());

    //Arreglos 
    notas = new int[cantidad]; //Usando For
    
    for (int i = 0; i < cantidad; i++)
    {
        int numeroNota = i + 1;
        Console.WriteLine("INGRESE NOTA[" + numeroNota + "]: ");
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }
}

//Encapsular(agrupar)
double promedio = 0;

IngresarNotas();
promedio = CalcularPromedio(notas);

Console.WriteLine("PROMEDIO ES: ");
Console.WriteLine(promedio);
Console.ReadLine(); // Para que el programa no se cierre inmediatamente
