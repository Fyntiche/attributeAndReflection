﻿using System;
using System.Linq;

namespace attributeAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                

                var attrs = prop.GetCustomAttributes(false);
                //prop.Attributes
                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }
                
                //foreach (var attr in attrs)
                //{
                //    Console.WriteLine(attr);
                //}


            }

            Console.ReadLine(); 



        }
    }
}
