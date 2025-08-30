// TITULO
// SEPARADOR
// VIDA
// MANA
/*
Console.WriteLine("Player Starts");
Console.WriteLine("--------------");
Console.WriteLine("HP          100");
Console.WriteLine("MP          100");
Console.WriteLine("Gold      2,550");
Console.WriteLine("Exp         150");
Console.WriteLine("--------------");

Console.Write("Player Starts\n--------------\nHP          100\nMP          100\nGold      2,550\nExp         150\n---------------\n");
Console.Write("Player Starts\n--------------\nHP          100\tMP          100\nGold      2,550\tExp         150\n---------------");
*/


//Ejericios de clase 
#region Ejercicios 
Atributos();
CaracterdeEscape();
BanderasdeColoresMexico();
DistintasBanderas();
EstadisticasdeJugador();
EstadisticasdelJugador2();



#endregion

#region Soluciones
void Atributos(){
    Console.WriteLine("Player Starts");
    Console.WriteLine("--------------");
    Console.WriteLine("HP          100");
    Console.WriteLine("MP          100");
    Console.WriteLine("Gold      2,550");
    Console.WriteLine("Exp         150");
    Console.WriteLine("--------------");
    
    Console.WriteLine();
    Console.WriteLine();
    }

void CaracterdeEscape()
{
    Console.WriteLine("Player Starts\n-------\nHP          100\nMP          100\nGold      2,550\nExp         150\n--------------\n");
    Console.WriteLine("Player Starts\n-------\nHP\t100\nMP\t100\nGold\t2,550\nExp\t150\n--------------\n");
    Console.WriteLine();
    Console.WriteLine();
}

void BanderasdeColoresMexico(){

Console.ForegroundColor =ConsoleColor.DarkGreen;
Console.Write("MÉ");
Console.ForegroundColor =ConsoleColor.White;
Console.Write("XI");
Console.ForegroundColor =ConsoleColor.DarkRed;
Console.Write("CO");
Console.ResetColor();

Console.WriteLine();

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Write("MÉ");
Console.BackgroundColor = ConsoleColor.White;
Console.Write("XI");
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.Write("CO");
Console.ResetColor();

Console.WriteLine();

Console.BackgroundColor=ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("Mé");
Console.BackgroundColor = ConsoleColor.White;
Console.Write("XI");
Console.BackgroundColor=ConsoleColor.DarkRed;
Console.Write("CO");
Console.ResetColor();

Console.WriteLine();

}

void DistintasBanderas(){
    
    Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("CA");
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor=ConsoleColor.Black;
Console.Write("NA");
Console.BackgroundColor=ConsoleColor.DarkRed;
Console.ForegroundColor=ConsoleColor.White;
Console.Write("DA");
Console.ResetColor();

Console.WriteLine();
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("CO");
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("LOM");
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("BIA");
Console.ResetColor();

Console.WriteLine();
Console.WriteLine();

}

void EstadisticasdeJugador(){
    string name         = "Chapperol";
    int    level        = 10;
    float  exp          = 10.0F;
    long   nextLevelExp = 85_161_316_813_168_663;
    sbyte  numPotion    = 123;
    string weapon       = "clownsword";
    
    Console.WriteLine(name);
    Console.WriteLine(level);
    Console.WriteLine(exp);
    Console.WriteLine(nextLevelExp);
    Console.WriteLine(numPotion);
    Console.WriteLine(weapon);


    level = 11;
    exp=0F;

    Console.WriteLine(name);
    Console.WriteLine(level);
    Console.WriteLine(exp);
    
    Console.WriteLine();
    Console.WriteLine();
    }
    
void EstadisticasdelJugador2(){
    
    string separator = "----------------";
    string name      = "Chapperol";
    int    hp        = 100;
    int    mp        = 50;
    float    gold      = 100.25f;
    float    exp       = 580f;
    
    Console.WriteLine("    Player starts");
    Console.WriteLine(separator);
    Console.WriteLine(name);
    Console.WriteLine($"HP:\t{hp}");
    Console.WriteLine($"MP:\t{mp}");
    Console.WriteLine($"Gold:\t{gold}");
    Console.WriteLine($"Exp:\t{exp}");
    Console.WriteLine(separator);
    
    Console.WriteLine();
    Console.WriteLine();
}

//Una línea
Console.WriteLine("Player Starts");Console.WriteLine("--------------");Console.WriteLine("HP          100");Console.WriteLine("MP          100");Console.WriteLine("Gold      2,550"); Console.WriteLine("Exp         150");Console.WriteLine("--------------"); Console.WriteLine();Console.WriteLine("Player Starts\n-------\nHP          100\nMP          100\nGold      2,550\nExp         150\n--------------\n");Console.WriteLine("Player Starts\n-------\nHP\t100\nMP\t100\nGold\t2,550\nExp\t150\n--------------\n");Console.WriteLine();Console.ForegroundColor =ConsoleColor.DarkGreen;Console.Write("MÉ"); Console.ForegroundColor =ConsoleColor.White; Console.Write("XI"); Console.ForegroundColor =ConsoleColor.DarkRed; Console.Write("CO"); Console.ResetColor(); Console.WriteLine(); Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Write("MÉ"); Console.BackgroundColor = ConsoleColor.White; Console.Write("XI"); Console.BackgroundColor = ConsoleColor.DarkRed; Console.Write("CO"); Console.ResetColor(); Console.WriteLine();



#endregion