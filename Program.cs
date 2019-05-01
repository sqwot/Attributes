using System;
using System.Linq;

namespace Attributes {
    class Program {
        static void Main() {
            Photo photo = new Photo("Penis.bmp") {
                Path = @"C:\Penis.bmp"
            };
            var type = typeof(Photo);
            var attrubutes = type.GetCustomAttributes(false);
            foreach (var attribute in attrubutes) {
                Console.WriteLine(attribute);
            }

            var properies = type.GetProperties();
            foreach(var prop in properies) {
                var attrs = prop.GetCustomAttributes(false);
                if(attrs.Any(x => x.GetType() == typeof(GeoAttribute))) {
                    Console.Write(prop.PropertyType + " " + prop.Name + " ");
                }


                //foreach (var attr in attrs) {
                //    Console.WriteLine(attr);
                //}
            }

            Console.ReadKey();
        }
    }
}
