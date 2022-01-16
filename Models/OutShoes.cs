using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesStoreWebApplication.Models
{
    public class OutShoes
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Gender { get; set; }
        public bool IsHeels { get; set; }
        public bool IsExsist { get; set; }
        public int Price { get; set; }

        public int Size { get; set; }




    }
}