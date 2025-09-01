#region Ejercicios de Tarea 



#endregion









#region Respuestas

//Ejercicio 1
//Pide al usuario que ingrese su daño y fuerza.
//Calcula el daño fina (Daño+fuerza)
//Si alguno de los valores no es válido muestra un mensaje 

void Dañofinal(){
string input;
string input2;

Console.Write("Ingresa tu daño:");
input = Console.ReadLine();

Console.Write("Ingresa tu fuerza:");
input2 = Console.ReadLine();

bool isValid;
long daño;
long fuerza;

isValid = long.TryParse(input, out daño);
isValid = long.TryParse(input2, out fuerza);

if(isValid ==true)
{
    daño = (long)(fuerza + daño);
    Console.WriteLine($"Tu daño final es {daño}");
}

else
{
    Console.WriteLine($"El daño {input} no es un valor válido");
    Console.WriteLine($"La fuerza {input2} no es un valor válido");
}
}

//Ejercicio 2
//Declara el precio de posiciones como una constante entera y dale un valor
//Declara una variable para el oro del jugador y dale un valor
//Pide al usuario cuantas pociones quiere
//Verifica si es un número válido
//-Muestra un mensaje de error si no lo es
//Verifica si tiene suficiente dinero para comprar las pociones
//-Muestra un mensaje de error si no
//Muestra cuanto oro resta después de comprar las pociones

void Pociones() {


Console.Write($"Cada poción cuesta {poción}");
Console.WriteLine($"Tienes {oro} monedas de oro");
Console.WriteLine("¿Cuántas pociones vas a querer?");
string input = Console.ReadLine();


{
   
}




//Ejercicio #3 
//Pide la cantidad de oro y la cantidad de integrantes del equipo.
//Verifica que ambos valores sean correctos.
//Si son correctos,muestra: 
//-Cuánto le toca a cada persona
//-Cuánto oro sobra

    ////string input2;
    //bool isValid;
    //bool isValid2;

//Console.WriteLine("Hola,¿Cuántos integrantes son?");
//string input = Console.ReadLine();
//Console.WriteLine("¿Cuánto oro tienen en total?");
//string input2 = Console.ReadLine();

//nput.Parse(Console.ReadLine());
//input2.Parse(Console.ReadLine());


//Ejercicio #4
//Declara una constante para el daño crítico
//Muestra el daño antes y después del valor crítico



//Ejercicio#5
//Si la compra es correcta, en lugar de un mensaje genera un recibo personalizado:
//_Pide el nombre del usuario
//-Muestra el nombre de la tienda



//Ejercicio#6
//pide el nombre del lugar donde obtuvieron su botín.
//Si los valores (oro e integrantes) son correctos, muestra un resumen antes de mostrar la división









#endregion


