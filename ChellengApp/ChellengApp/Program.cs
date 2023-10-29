string name = "Ewa";
var gender = "Mężczyzna";
int age = 17;
if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa ,lat 33");
}
else if (age < 18 && gender == "Mężczyzna")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (age < 30 && gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30");
}