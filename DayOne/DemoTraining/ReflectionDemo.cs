using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTraining
{

    public class ReflectionClass 
    {
        public int MyProperty { get; set; }
    }

    static class ReflectionDemo
    {
        public static void Execute()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(ReflectionDemo));
            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item.Name);
            //}

            ReflectionClass refObject = new ReflectionClass { MyProperty = 20 };

            //refObject.MyProperty = 20;

            Console.WriteLine($" My property Value is : {refObject.MyProperty}");


            Type refType = assembly.GetTypes().FirstOrDefault(x => x.Name == "ReflectionClass");
            PropertyInfo info = refType.GetProperty("MyProperty");
            var refObj = Activator.CreateInstance(refType);
            info.SetValue(refObj, 10);

            Console.WriteLine($" My property Value is : {info.GetValue(refObj)}");

        }

    }
}