// See https://aka.ms/new-console-template for more information
using System;
    
/*
 
int a;
int b;
int tmp;
Console.WriteLine("Entrez le nombre a"); // print  dans la console




String nomDuMembre; //declaration serie de charact
float kilogrammes; //declaration type reel a virgule
Console.WriteLine("Quel est le nom du nouveau membre?"); // print  dans la console
nomDuMembre = Console.ReadLine(); //affecte reponse usager dans vriable nomdumembre
Console.WriteLine("quel est le poids de"+nomDuMembre+"?"); // print  dans la console texte + variable nom du membre
String poids = Console.ReadLine(); //declaration variable poids + initiation avec texte rentre par l'usager
kilogrammes = float.Parse(poids); //assigne variable poids dans kilogrammes mais transforme en chiffres
Console.WriteLine("Bienvenue a " + nomDuMembre+" pesant " +kilogrammes); //affiche txt bienvenue + variable nomdumembre+pesant+variable kg

*/

/*
 
double a;
double b;
decimal c;
double d;

a = (10 / 3f + 3) / 5d;
b = (10 / 3 + 3) / 5;
c = 10.99m + 11.11m;
d = 10f * 2;



Console.WriteLine("\n a: "+a + "\n b: "+ b + "\n c: "+ c+ "\n d:" + d);


int x = 5, y = 8;
int tmp = y;
console.writeline 
y = x;
x = tmp;
Console.WriteLine("\n x:" + x + "\n y:" + y );




int a = 5, b = 10, c =2;
int tmp = b;
b = a;
a = tmp;
tmp = c;
c = a;
a = tmp;

Console.WriteLine("\n a:" + a + "\n b:" + b + "\n c:" + c );


int a = 2, b = 10, c = 15;
if
 */   
int chiffre;
Console.WriteLine("Entrez un nombre : ");
chiffre = int.Parse(Console.ReadLine());
Console.WriteLine("Le carré de " + chiffre + " est " chiffre * chiffre);