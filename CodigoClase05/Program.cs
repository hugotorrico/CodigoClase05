


using System.Xml;

void EjemploArreglos()
{
    int n = 5;
    // Declaración e inicialización de un arreglo de números enteros
   

    int[] numeros = new int[n];

    // Asignación de valores al arreglo
    numeros[0] = 10;
    numeros[1] = 20;
    numeros[2] = 30;
    numeros[3] = 40;
    numeros[4] = 50;

    // Recorriendo el arreglo para mostrar sus elementos
    Console.WriteLine("Elementos del arreglo:");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }

    // Declaración e inicialización de un arreglo de strings
    string[] nombres = { "Juan", "María", "Carlos", "Luisa" };

    // Recorriendo el arreglo de nombres para mostrar sus elementos
    Console.WriteLine("\nNombres en el arreglo:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }

}

void EjemploListas()
{
    // Declaración e inicialización de una lista de números enteros
    List<int> numeros = new List<int>();

    // Agregar elementos a la lista
    numeros.Add(10);
    numeros.Add(20);
    numeros.Add(30);

    // Mostrar los elementos de la lista
    Console.WriteLine("Elementos de la lista:");
    foreach (int num in numeros)
    {
        Console.WriteLine(num);
    }

    // Agregar un elemento en una posición específica
    numeros.Insert(1, 15);

    // Mostrar los elementos de la lista después de la inserción
    Console.WriteLine("\nElementos de la lista después de insertar:");
    foreach (int num in numeros)
    {
        Console.WriteLine(num);
    }

    // Eliminar un elemento de la lista
    numeros.Remove(20);

    // Mostrar los elementos de la lista después de la eliminación
    Console.WriteLine("\nElementos de la lista después de eliminar:");
    foreach (int num in numeros)
    {
        Console.WriteLine(num);
    }
}

void EjemploMulti()
{
    // Declaración e inicialización de un arreglo bidimensional de enteros
    int[,] matriz = new int[3, 3];

    // Asignación de valores a la matriz
    matriz[0, 0] = 1;
    matriz[0, 1] = 2;
    matriz[0, 2] = 3;
    matriz[1, 0] = 4;
    matriz[1, 1] = 5;
    matriz[1, 2] = 6;
    matriz[2, 0] = 7;
    matriz[2, 1] = 8;
    matriz[2, 2] = 9;

    // Mostrar la matriz en la consola
    Console.WriteLine("Matriz:");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(matriz[i, j] + "\t");
        }
        Console.WriteLine();
    }

}






//Arreglos o Array
int sumaNotas = 0;
float promedio = 0;
int cantidad = 10;
int menor = 0;
int mayor = 0;
int[] notas = new int[cantidad];

notas[0] = 20;
notas[1] = 10;
notas[2] = 10;
notas[3] = 10;
notas[4] = 10;
notas[5] = 10;
notas[6] = 10;
notas[7] = 10;
notas[8] = 10;
notas[9] = 08;

menor = notas[0];
mayor = notas[0];

//Identificar el menor
for (int i = 0; i < notas.Length; i++)
{
    //Calculando la nota menor
    if (notas[i]<menor) 
        menor = notas[i];

    //Calculando la nota mayor
    if (notas[i] > mayor)
        mayor = notas[i];
    
    //Sumando todo
    sumaNotas = sumaNotas + notas[i];
}

promedio = (sumaNotas-mayor-menor) / (cantidad-2);

Console.WriteLine(menor);
Console.WriteLine(mayor);
Console.WriteLine(promedio);

Console.ReadLine(); // Para que el programa no se cierre inmediatamente
