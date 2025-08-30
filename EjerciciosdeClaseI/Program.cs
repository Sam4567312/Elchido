#region EjerciciosdeClaseI
// Ejercicio #1
ArboldeNavidad();
// Ejercicio #2
Personajeficticio();
// Ejercicio #3
Atributosdeunarma();
#endregion

#region Soluciones

// Ejercicio #1
// Descripción imprimir un árbol de navidad
void ArboldeNavidad() { 
    Console.WriteLine("       *");
    Console.WriteLine("     (   )");
    Console.WriteLine("    ( *   )");
    Console.WriteLine("   (    *° )");
    Console.WriteLine("  (      °*  )");
    Console.WriteLine(" (____________)");
    Console.WriteLine( "     |   |" );
    Console.WriteLine( "     |   |" );
}




// Ejercicio #2
//Variables para un personaje ficticio
void Personajeficticio()
{
    string nombre = "Sia";
    byte edad = 35;
    string ocupacion = "cantante";
    string ubicacion = "thunderclouds";
    
    Console.WriteLine($"nombre:\t\t{nombre}");
    Console.WriteLine($"edad:\t\t{edad}");
    Console.WriteLine($"ocupacion:\t{ocupacion}");
    Console.WriteLine($"ubicacion:\t{ubicacion}");
}




// Ejercicio #3
//Declara variables para los atributos de un arma

void Atributosdeunarma() {


    string name      ="Jinx";
    string rareza    = "Épica";
    int    daño      = 1000;
    float  velocidad = 1.75F;
    double   costo     = 1234567.34567;

    Console.WriteLine($"name:\t\t{name}");
    Console.WriteLine($"rareza:\t\t{rareza}");
    Console.WriteLine($"daño:\t\t{daño}");
    Console.WriteLine($"velocidad:\t{velocidad}");
    Console.WriteLine($"costo:\t\t{costo}");
}

#endregion