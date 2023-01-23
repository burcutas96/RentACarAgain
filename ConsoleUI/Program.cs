using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

carManager.Add(
    new Car
    {
        BrandId = 1,
        ColorId = 2,
        DailyPrice = 8000,
        ModelYear = "2020",
        Description = "Mercedes AMG"
    }
);

carManager.Update(new Car
{
    Id = 25,
    BrandId = 1,
    ColorId = 2,
    DailyPrice = 8000,
    ModelYear = "2020",
    Description = "Mercedes AMG"
});

carManager.Delete(new Car
{
    Id = 25
});

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName);
}



