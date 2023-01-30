using IteratorConsola;
using System;
namespace IteratorDesignPattern
{
    public class Program
    {
        static void Main()
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Empleado("Kevin", 100));
            collection.AddEmployee(new Empleado("Aaron", 101));
            collection.AddEmployee(new Empleado("Raisha", 102));
            collection.AddEmployee(new Empleado("Emilia", 103));
            collection.AddEmployee(new Empleado("Christian", 104));
            collection.AddEmployee(new Empleado("Amalia", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterando en la coleccion:");

            for (Empleado emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Nombre : {emp.Nombre}");
            }
            Console.Read();
        }
    }
}