using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

carManager.Add(
    new Car
    {
        Id = 17,
        BrandId = 1,
        ColorId = 2,
        DailyPrice = 8000,
        ModelYear = "2020",
        Description = "Mercedes AMG"
    }
); 

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}



