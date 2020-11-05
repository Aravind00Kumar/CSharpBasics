using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
/*
namespace

    class
    enum
    interface
    IVehicle x = new IVehicle(); //Error
 */


namespace DemoTraining
{
    ///SOLID
    ///
    //interface 
    public interface IVehicle 
    {
        void Run();
    }

    public class Vehicle : IVehicle // base class // parent class 
    {
        public Vehicle() { }
        public void Run() 
        {
            Console.WriteLine("Running....");
        }
    }

    public class Car : Vehicle // derived 
    {
        public Car() { }
        public void OpenDoor()
        {
            Console.WriteLine("Opening....");
        }
    }


    public class SUV : Car // derived 
    {
        public SUV() { }
        public void GoReverse()
        {
            Console.WriteLine("Going reverse....");
        }
    }


    public class Bus: Vehicle
    {
        
    }


    public static class GenericsExample
    {
        public static void Execute() 
        {
            //string[] names = { "aaa", "bbb", "ccc" };
            //List<string> cities = new List<string> { "111", "222", "333" };

            //Print<string[]>(names);
            //Print<List<string>>(cities);
        
            

        
        
        
        }

        public static void Print<T>(T values) where T: IEnumerable 
        {
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
        }

    }
}

