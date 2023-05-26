using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
             new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=950,Descripton="Toyota"},
             new Car {CarId=2,BrandId=1,ColorId=3,ModelYear=1999,DailyPrice=750,Descripton="Tempra"},
             new Car {CarId=3,BrandId=2,ColorId=1,ModelYear=2002,DailyPrice=900,Descripton="Fiat"},
             new Car {CarId=4,BrandId=2,ColorId=1,ModelYear=2022,DailyPrice=2400,Descripton="Tesla"},
             new Car {CarId=5,BrandId=3,ColorId=2,ModelYear=2023,DailyPrice=2999,Descripton="Mercedes"}
            };    
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int CarId)
        {
           return _cars.Where(c => c.CarId ==  CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;    
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
