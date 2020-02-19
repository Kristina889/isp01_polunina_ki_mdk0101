using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D myVector = new Vector3D(x: 34.43, y: 43.43, z: 34.43);
            Vector3D other = new Vector3D(x: 43.34, y: 43.34, z: 43.43);

            Console.WriteLine($"Расчет длины векторов: " + myVector.GetLength());
            Console.WriteLine($"Расчет скалярного произведения: " + myVector.ScalarProduct(other));
            Console.WriteLine($"Расчет произведения: " + myVector.Composition(other));


            Console.ReadKey();
        }
    }
}
