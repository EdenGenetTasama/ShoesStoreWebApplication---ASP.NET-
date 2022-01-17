using ShoesStoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoesStoreWebApplication.Controllers.api
{
    public class KidShoesController : ApiController
    {
        static string connectionString = "Data Source=DESKTOP-0MT6QTG;Initial Catalog=ShoesDataBase;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        KidShoesDataContext DBkidShoes = new KidShoesDataContext(connectionString);

        // GET: api/KidShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<KidShoe> listOfKidShoes = DBkidShoes.KidShoes.ToList();
                return Ok(listOfKidShoes);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/KidShoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                KidShoe shoeById = DBkidShoes.KidShoes.First(item => item.Id==id);
                if (shoeById != null)
                {
                    return Ok(new { shoeById });
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/KidShoes
        public IHttpActionResult Post([FromBody] KidShoe shoeToAdd)
        {
            try
            {
                if (shoeToAdd != null)
                {
                    DBkidShoes.KidShoes.InsertOnSubmit(shoeToAdd);
                    DBkidShoes.SubmitChanges();
                    return Ok("ADDED");

                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/KidShoes/5
        public IHttpActionResult Put(int id, [FromBody] KidShoe shoe)
        {
            try
            {
                KidShoe shoeToUpdate = DBkidShoes.KidShoes.First(item => item.Id == id);
                if (shoeToUpdate != null)
                {
                    shoeToUpdate.ComanyName = shoe.ComanyName;
                    shoeToUpdate.Matirial = shoe.Matirial;
                    shoeToUpdate.IsExsist = shoe.IsExsist;
                    shoeToUpdate.Price= shoe.Price;
                    shoeToUpdate.Size = shoe.Size;

                    DBkidShoes.SubmitChanges();
                    return Ok("UpDated");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/KidShoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                KidShoe shoeToDelete = DBkidShoes.KidShoes.First(item => item.Id==id);
                if (shoeToDelete != null)
                {
                DBkidShoes.KidShoes.DeleteOnSubmit(shoeToDelete);
                DBkidShoes.SubmitChanges();
                return Ok("Delete");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
