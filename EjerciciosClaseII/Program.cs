#region EjerciciosClaseII
Preguntanombre();
Nombreynacimiento();
Edadanum();

#endregion



#region Soluciones
//Ejercicio #1
//Pregunta el nombre del usuario

void Preguntanombre(){
string nombre;

Console.WriteLine("Ingrese un nombre: ");
nombre = Console.ReadLine();

Console.WriteLine($"Hola {nombre} ");
}
#endregion

//Ejercicio #2
//Pregunta nombre y dónde nació

void Nombreynacimiento(){

string nombre;
string nacimiento;

Console.WriteLine("Escribe tu nombre: ");
nombre = Console.ReadLine();

Console.Write("Escribe tu lugar de nacimeinto: ");
nacimiento = Console.ReadLine();

Console.WriteLine($"Hola {nombre}, naciste en {nacimiento} ");
}

//Ejercicio #3
//Pedir ead al usuario y convertir a número

void Edadanum (){
Console.Write("Ingresa tu edad: ");
String input = Console.ReadLine();

bool isValid;
int edad;

isValid = int.TryParse(input, out edad);

Console.WriteLine($"El valor a convertir es {input}");
Console.WriteLine($"¿Es un valor válido?  {isValid}" );
Console.WriteLine($"El valor convertido es: {edad}");
}

//Ejercicio #4
//Pedir año con short y altura con float 

Console.Write("Ingresa tu edad:");
string input3 = Console.ReadLine();

Console.Write("Ingresa el año en el que naciste: ");
string input =Console.ReadLine();

Console.Write("Ingresa tu altura: ");
string input2 = Console.ReadLine();

bool isValid;
bool isValid2;
short año;
float altura;
bool isValid3;
int edad;

isValid = short.TryParse(input, out año);
isValid2= float.TryParse(input2,out altura);
isValid3=int.TryParse(input3,out edad);

Console.WriteLine($"El valor a convertir es {input3}");
Console.WriteLine($"¿Es un valor válido?:  {isValid3}");
Console.WriteLine($"El valor convertido es: {edad}");

Console.WriteLine($"El primer valor a convertir es:{input}");
Console.WriteLine($"¿Es un valor válido?:  {isValid}");
Console.WriteLine($"El valor convertido es: {año}");

Console.WriteLine($"El primer valor a convertir es:{input2}");
Console.WriteLine($"¿Es un valor válido?:  {isValid2}");
Console.WriteLine($"El valor convertido es: {altura}");
