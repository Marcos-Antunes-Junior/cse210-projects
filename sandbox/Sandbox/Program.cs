using System;

class Program
{
    static void Main(string[] args)
    {    
        
       List<CarKMCity> car = new List<CarKMCity>();
       car.Add(new CarKMCity());
       car.Add(new CarKMRoad());

       foreach (CarKMCity cars in car)
       {
         float totalKM = cars.KmPerLiter();
         Console.WriteLine(totalKM);
       }
    
    }
}