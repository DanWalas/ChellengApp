using ChellengApp;
using System.ComponentModel.Design;

Employee Adam = new Employee("Adam", "Kowalski", "34");
Employee Daniel  = new Employee("Daniel", "Walas", "30");
Employee Kasia = new Employee("Kasia", "Walczak", "32");

Adam.AddScore(5);
Adam.AddScore(3);
Adam.AddScore(5);
Adam.AddScore(7);
Adam.AddScore(3);
Daniel.AddScore(6);
Daniel.AddScore(8);
Daniel.AddScore(1);
Daniel.AddScore(2);
Daniel.AddScore(5);
Kasia.AddScore(5);
Kasia.AddScore(8);
Kasia.AddScore(9);
Kasia.AddScore(9);
Kasia.AddScore(8);


var resultAdama = Adam.Result;
var resultDaniela = Daniel.Result;
var resultKasi = Kasia.Result;

if (resultAdama > resultDaniela && resultAdama > resultKasi)
{
    Console.WriteLine("Adam Kowalski 34 lat " + resultAdama + " pkt" );
}
if (resultDaniela > resultAdama && resultDaniela > resultKasi)
{
    Console.WriteLine("Daniel Walas 30 lat " + resultDaniela + " pkt");
}
if (resultKasi > resultAdama && resultKasi > resultDaniela) 
{
    Console.WriteLine("Kasia Walczak 32 lata " + resultKasi + " pkt");
}


