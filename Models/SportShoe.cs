using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesStoreWebApplication.Models
{
    public class SportShoe
    {
        public SportShoe(int id, string company, string brandName, int size, int price)
        {
            Id=id;
            Company=company;
            BrandName=brandName;
            Size=size;
            Price=price;
        }

        public int Id { get; set; }
        public string Company { get; set; }
        public string BrandName { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }


        public static List<SportShoe> listOsShoesSports = new List<SportShoe>()
        {
            new SportShoe(0,"Nike" , "SuperStar" , 40 , 500),
            new SportShoe(1,"Adidas" , "SuperStarAdidas" , 20 , 700),
            new SportShoe(2,"Nike" , "AirMax" , 90 , 800),
            new SportShoe(3,"Nike" , "SuperStarFour" , 50 , 1000),

        };
    }
}