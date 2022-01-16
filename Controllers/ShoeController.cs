using ShoesStoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStoreWebApplication.Controllers
{
    public class ShoeController : Controller
    {
        // GET: Shoe
        public ActionResult BrandOfShoe()
        {
            try
            {
                ViewBag.brand =  SportShoe.listOsShoesSports[0].BrandName;
                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Shoe/ShowOneShoe/5
        public ActionResult ShowOneShoe(int id)
        {
            try
            {
                foreach (SportShoe shoe in SportShoe.listOsShoesSports)
                {
                    if (shoe.Id == id)
                    {
                        ViewBag.shoeById = $"{shoe.Id},{shoe.BrandName},{shoe.Company},{shoe.Size},{shoe.Price}";
                    }
                    ViewBag.Massage = "Not Found";

                }
                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Shoe/AllShoes
        public ActionResult AllShoes()
        {
            try
            {
                return View(SportShoe.listOsShoesSports);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }


    }
}
