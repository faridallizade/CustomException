using System;

namespace CustomExcp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] people = new Human[0];


            try
            {
                Human person = new Human("Ferid", "Elizade", -670);
                Human person2 = new Human("Murad", "Haciyev", 64);
                Human person3 = new Human("Nadir", "Abbasov", 24);
                Human person4 = new Human("Abbas", "Nadirov", 42);
                Human[] human = { person, person2, person3, person4 };

                Console.Write("Enter the name : ");
                string name = Console.ReadLine();

                bool search = false;
                foreach (var item in human)
                {
                    if (item.Name == name)
                    {
                        search = true;
                        Console.WriteLine($"{item.Name}  {item.Surname}  {item.Age}");
                        break;
                    }
                }
                if (!search)
                {

                    throw new DataNOtFoundException("The user not found");
                }

            }
            catch(DataNOtFoundException excMessage)
            {
                Console.WriteLine("Warning : " + excMessage.Message);
            }
            catch (AgeException excep)
            {
                Console.WriteLine("Warning: " + excep.Message);
            }
        }
    }
}