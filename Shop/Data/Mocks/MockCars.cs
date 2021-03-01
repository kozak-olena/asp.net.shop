using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                 new Car
                {
                    Name ="Tesla Model S",
                    ShotrDesc = "Speed car",
                    LongDesc="beautiful, modern and speed car",
                    Img = "https://3dnews.ru/assets/external/illustrations/2020/09/23/1021277/tesla1.jpg",
                    Price=45000,
                    IsFavorite =true,
                    Availiable=true,
                    Category = _categoryCars.AllCategories.First()
                },
                 new Car
                {
                    Name="Ford Fiesta",
                    ShotrDesc = "quiet and calm car",
                    LongDesc = "Suitable for city life",
                    Img = "https://fordcms.blob.core.windows.net/media/Ukraine/_Profiles/13881260/6521fe91/420f553879438e172e63a07843cb9fbc_867x488.jpeg?v=636734656940000000",
                    Price = 11000,
                    IsFavorite = false,
                    Availiable = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                 new Car
                 {
                     Name = "BMW M3",
                     ShotrDesc = "cheeky and stylish",
                     LongDesc = "Suitable for city life",
                     Img = "https://www.bmw.ua/content/dam/bmw/common/all-models/m-series/m3-sedan/2017/driving-dynamics/BMW-m3-sedan-driving-dynamics-ts-01.jpg/_jcr_content/renditions/cq5dam.resized.img.1680.large.time1487343216919.jpg",
                     Price= 65000,
                     IsFavorite =true ,
                     Availiable = true,
                     Category = _categoryCars.AllCategories.Last()
                 },
                 new Car
                 {
                     Name = "Mercedes C class",
                     ShotrDesc = "Big and cozy",
                     LongDesc = "Suitable for city life",
                     Img = "https://kolesa-uploads.ru/-/29ab1f18-0742-4e72-9979-798e0146c14b/mercedes-benz-c-class-front2-mini.jpg.webp",
                     Price = 40000,
                     IsFavorite = false,
                     Availiable = false,
                     Category = _categoryCars.AllCategories.Last()

                 },
                 new Car
                 {
                     Name = "Nisan Leaf",
                     ShotrDesc = "noiseless and economical",
                     LongDesc  ="Suitable for city life",
                     Img = "https://cdn.motor1.com/images/mgl/m6gXo/s1/nissan-leaf-e.jpg",
                     Price = 14000,
                     IsFavorite = true,
                     Availiable = true,
                     Category = _categoryCars.AllCategories.First()
                 }
                };
            }
             
        }
        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int Id)
        {
            throw new NotImplementedException();
        }
    }

}
