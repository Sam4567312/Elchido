#region Ejercicios ClaseIII
NameandCountry();


#endregion


#region Soluciones



//Ejercicio #1
//Pedir nombre y saludar

//Ejercicio #2
//Pedir el nombre y el país de nacimiento:
//-Pedir Nombre
//-Pedir País
//-Esperar a que presione tecla
//- Utiliza: Consola.ReadKey
//-Mostrar en nuna misma cadena el nombre y el país
void NameandCountry (){
Console.Write("Dame tu nombre: ");
var name = Console.ReadLine();

Console.Write("Dame tu país:"); 
var country = Console.ReadLine();

Console.WriteLine($"Presiona una tecla para continuar......");
Console.ReadKey();

Console.WriteLine($"{name} es de {country}");
}



#endregion



