using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carmanager = new CarManager(new EfCarDal());

        
        foreach (var car in carmanager.GetAllByColorId(4))
        {
            Console.WriteLine(car.Description);
        }
    }
}