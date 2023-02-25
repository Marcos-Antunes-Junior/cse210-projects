using System;

class Program
{
    static void Main(string[] args)
    {
       Brand brand = new Brand();
       string car = brand.GetCar();
       string brandName = brand.GetBrand();
       Console.WriteLine(car);
       Console.WriteLine(brandName);
    }
}