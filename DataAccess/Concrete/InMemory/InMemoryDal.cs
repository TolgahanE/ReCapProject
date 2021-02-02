using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _car;
        public InMemoryDal()
        {
            _car = new List<Car>()
            {
                new Car{Id = 1,BrandId =1 ,ColorId = 1,DailyPrice = 400, Descripton="Mazda",    ModelYear ="2015"},
                new Car{Id = 2,BrandId =1 ,ColorId = 2,DailyPrice = 600, Descripton="Toyota",   ModelYear ="2010"},
                new Car{Id = 3,BrandId =2 ,ColorId = 2,DailyPrice = 500, Descripton="Bmw",      ModelYear ="2009"},
                new Car{Id = 4,BrandId =1 ,ColorId = 3,DailyPrice = 350, Descripton="Mercedes", ModelYear ="2000"},
                new Car{Id = 5,BrandId =2 ,ColorId = 2,DailyPrice = 1500,Descripton="Ford",     ModelYear ="2020"},
            };

        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(CarToDelete);
        }
        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Descripton = car.Descripton;
            CarToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }
    }
}
