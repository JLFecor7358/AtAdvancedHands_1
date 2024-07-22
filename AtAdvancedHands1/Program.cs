using System;
namespace AtAdvancedHands1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Luis");
            //Person person = new Person("36");
            //Person person = new Perro("Tyson");
            try
            {
                if (person is Person)
                {
                    person.SetAge(36);
                    if (Equal(person))
                    {
                        Console.WriteLine("Se ingresó el mismo nombre y edad para la persona");
                    }
                    else
                    {
                        Console.WriteLine($"El nombre de la persona es: {person.GetName()}");
                        Console.WriteLine($"La edad de la persona es: {person.GetAge()}");
                        Console.WriteLine($"La persona puede caminar? {person.GetWalk()}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El tipo del objeto no es el correcto");
            }
        }
        static Boolean Equal(Person person)
        {
                String strAge = person.GetAge().ToString();
                    if (person.GetName().Equals(strAge))
                        return true;
                    else
                        return false;
        }
    }
}