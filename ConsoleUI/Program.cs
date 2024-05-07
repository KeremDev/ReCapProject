using Business.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carmanager = new CarManager(new InMemoryCarDal());
        foreach (var car in carmanager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}