
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
