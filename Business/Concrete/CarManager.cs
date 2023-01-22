﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length > 2 && car.DailyPrice > 0)
            {
                car.Id = 0;    //Veritabanında id otomatik olarak verildiği için kullanıcının verdiği değeri sıfırlıyoruz.
                _carDal.Add(car);
            }
            else
            {
                throw new Exception("Arabanın ismi 2 karakterden uzun ve günlük fiyatı 0'dan büyük olmak zorunda!");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car Get(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
