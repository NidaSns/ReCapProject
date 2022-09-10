using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,DailyPrice=100,Description="Araba 1",Id=1,ModelYear=1995 },
                new Car{BrandId=2,ColorId=2,DailyPrice=50,Description="Araba 2",Id=3,ModelYear=2005 },
                new Car{BrandId=2,ColorId=3,DailyPrice=20,Description="Araba 3",Id=2,ModelYear=2020 },
                new Car{BrandId=3,ColorId=4,DailyPrice=30,Description="Araba 4",Id=4,ModelYear=2022 },
                
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carID)
        {
            return _cars.Where(c => c.Id == carID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
