﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car { Id = 1,BrandId=1,ColorId=1,DailyPrice=4500,ModelYear="2023",Description="5000 KM Hatcbak Car"},
            new Car { Id = 2,BrandId=1,ColorId=2,DailyPrice=6500,ModelYear="2024",Description="750 KM GT-Line Car"},
            new Car { Id = 3,BrandId=2,ColorId=2,DailyPrice=5000,ModelYear="2024",Description="4000 KM Premium Car"},
            new Car { Id = 4,BrandId=3,ColorId=3,DailyPrice=9000,ModelYear="2024",Description="1000 KM Premium Car"},
            new Car { Id = 5,BrandId=3,ColorId=3,DailyPrice=3500,ModelYear="2022",Description="12000 KM Hatcbak Car"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
        }
    }
}
