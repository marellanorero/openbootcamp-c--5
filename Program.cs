/* Console.WriteLine("Introduce your name");
string nombre = Console.ReadLine();

Console.WriteLine("Introduce your email");
string email = Console.ReadLine();

Console.WriteLine("Do you have a cupon descount? (respond yes or no)");
string cupon = Console.ReadLine();

if( cupon == "no"){
    Console.WriteLine("Prince: $3000");
} else {
    Console.WriteLine("Price: $1500 (Descount: 50%)" );
} */

Console.WriteLine("¿Qué lenguaje de programación prefieres? Si es c# escoge 1, Java escoge 2 o C++ escoge 3");
int respuesta = Convert.ToInt32(Console.ReadLine());

switch(respuesta)
{
    case 1:
        Console.WriteLine("C#");
        break;
    case 2:
        Console.WriteLine("Java");
        break;
    default:
        Console.WriteLine("C++");
        break;
}

