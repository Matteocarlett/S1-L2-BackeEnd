using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Matteo", "Carletti", 25);
            Console.WriteLine($"Nome:{persona.GetName()}");
            Console.WriteLine($"Surname:{persona.GetSurname()}");
            Console.WriteLine($"Age:{persona.GetAge()}");
            Console.WriteLine($"Details:{persona.GetDetails()}");

            persona.Riempi();
        }
    }

    public class Persona    

    {//Proprietà della classe

     //meglio get;set;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    
    //Costruttore per popolare oggetti
    //Attenzione a maiusole e minuscole
        public Persona(string name, string surname,int age)
        {
        Name = name;
        Surname = surname;
        Age = age;
        }

        //Metodi per informazione persona
        public string GetName() { return Name; }
        public string GetSurname() {  return Surname; }
        public int GetAge() { return Age;}
        public string GetDetails()
        {
            return $"Nome:{Name}, Cognome: {Surname}, Età {Age}";
        }

        //esempio spazio da riempire
        public void Riempi()
        {
            Console.Write("Nome: ");
            Name = Console.ReadLine();
        }
    }
}
