// See https://aka.ms/new-console-template for more information

//Colleciones

//Lista dinámicas
List<string> asistentes = new List<string>();
List<int> ints = new List<int>();
List<float> floats = new List<float>();

string nombre = string.Empty;
bool salir = false;
string letra = string.Empty;

do
{
    Console.WriteLine("Ingrese Nombre Asistente");
    nombre = Console.ReadLine();
    asistentes.Add(nombre);

    Console.WriteLine("Presiona la letra S para salir");
    letra = Console.ReadLine();

    if (letra.ToUpper() == "S")
        salir = true;
} while (!salir);

Console.WriteLine("La lista de Asistentes es:");

foreach (var item in asistentes)
{
    Console.WriteLine(item);
}
Console.Read();


