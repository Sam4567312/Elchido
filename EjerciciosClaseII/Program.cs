#region EjerciciosClaseII
Preguntanombre();
Nombreynacimiento();
Edadanum();
Edadmas10();
Level();
Agehighbirth();
#endregion

#region Soluciones
//Ejercicio #1
//Pregunta el nombre del usuario y saludar

void Preguntanombre(){
string input;

Console.Write("Dame tu nombre: ");
input= Console.ReadLine();

Console.WriteLine($"Hola {input} ");
}


//Ejercicio #2
//Pregunta nombre y dónde nació

void Nombreynacimiento(){
    

Console.Write("Escribe tu nombre: ");
var nombre = Console.ReadLine();

Console.Write("Escribe tu lugar de nacimeinto: ");
var country = Console.ReadLine();

Console.WriteLine($"Presiona una tecla para continuar...");
Console.ReadKey();

Console.WriteLine($"Hola {nombre}, naciste en {country} ");
}

//Ejercicio #3
//Pedir edad al usuario e intentar convertir el valor

void Edadanum (){
Console.Write("Dame tu edad: ");
String input = Console.ReadLine();

//Declaro edad y si se pudo
bool isValid;
int age;

//Conversión
isValid = int.TryParse(input, out age);

//IMpresión de resultado
Console.WriteLine($"El valor a convertir es {input}");
Console.WriteLine($"¿Es un valor válido?  {isValid}" );
Console.WriteLine($"El valor convertido es: {age}");
}

//Ejercicio #4
//Pedir edad y sumar 10 si es válida 

void Edadmas10()
{
    Console.WriteLine("Dame tu edad:");
    string input = Console.ReadLine();
    
    
    bool isValid;
    int age;
    
    isValid = int.TryParse(input, out age);
    
    if (isValid==true)
    {
        age = age + 10;
        Console.WriteLine($"La edad en 10 años es: {age}");
    }
    else
    {
        Console.WriteLine($"El valor de \"{input}\" no es una edad válida");
    }
    
}

//Ejercicio #5
//Pide al usuario su nivel en forma de byte
//-Si la entrada es válida,muestra su vida máxima: ´nivel*5´
//-Si no es válida, muestra un mensaje de error}

void Level(){
    Console.WriteLine("Ingresa tu nivel: ");
    string input =Console.ReadLine();

    bool isValid;
    byte nivel;

    isValid = byte.TryParse(input, out nivel);

    if(isValid== true)
    {
        nivel =(byte)(nivel * 5);
        Console.WriteLine($"La vida es: {nivel}");
    }

    else
    {
        Console.WriteLine($"El nivel {input} no es un valor válido");
    }
}

//Ejercicio #6
//Cuanto mides ,edad año de nacimiento
void Agehighbirth() {
Console.Write("Ingresa el año en el que naciste: ");
string input = Console.ReadLine();

Console.Write("Ingresa tu altura: ");
string input2 = Console.ReadLine();

Console.Write("Ingresa tu edad: ");
string input3 = Console.ReadLine();

bool isValid;
bool isValid2;
short año;
float altura;
bool isValid3;
int edad;

isValid = short.TryParse(input, out año);
isValid2 = float.TryParse(input2, out altura);
isValid3 = int.TryParse(input3, out edad);

Console.WriteLine($"El valor a convertir es {input3}");
Console.WriteLine($"¿Es un valor válido?:  {isValid3}");
Console.WriteLine($"El valor convertido es: {edad}");

Console.WriteLine($"El primer valor a convertir es:{input}");
Console.WriteLine($"¿Es un valor válido?:  {isValid}");
Console.WriteLine($"El valor convertido es: {año}");

Console.WriteLine($"El primer valor a convertir es:{input2}");
Console.WriteLine($"¿Es un valor válido?:  {isValid2}");
Console.WriteLine($"El valor convertido es: {altura}");
}

#endregion