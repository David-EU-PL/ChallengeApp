string name = "Ewa";
int age = 33;
bool isMale = false;

if (isMale == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isMale == true && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("A o kogo chodzi ??? :)");
}
