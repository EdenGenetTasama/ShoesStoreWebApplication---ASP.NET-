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
    public class OutShoesController : ApiController
    {
        ShoesContext DbContext = new ShoesContext();

        // GET: api/OutShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<OutShoes> shoesList = DbContext.OutShoes.ToList();
                return Ok(new { shoesList });

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

        // GET: api/OutShoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                OutShoes shoeById = DbContext.OutShoes.Find(id);
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

        // POST: api/OutShoes
        public IHttpActionResult Post([FromBody] OutShoes shoe)
        {
            try
            {
                DbContext.OutShoes.Add(shoe);
                DbContext.SaveChanges();
                return Ok("ADDED");
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

        // PUT: api/OutShoes/5
        public IHttpActionResult Put(int id, [FromBody] OutShoes shoe)
        {
            try
            {
                OutShoes shoeToUpdate = DbContext.OutShoes.Find(id);
                if (shoeToUpdate != null)
                {
                    shoeToUpdate.Company = shoe.Company;
                    shoeToUpdate.Gender = shoe.Gender;
                    shoeToUpdate.IsExsist = shoe.IsExsist;
                    shoeToUpdate.IsHeels = shoe.IsHeels;
                    shoeToUpdate.Price = shoe.Price;
                    shoeToUpdate.Size = shoe.Size;
                    DbContext.SaveChanges();
                    return Ok(shoeToUpdate);
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

        // DELETE: api/OutShoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                OutShoes shoeToDelete = DbContext.OutShoes.Find(id);
                if (shoeToDelete !=null)
                {
                    DbContext.OutShoes.Remove(shoeToDelete);
                    DbContext.SaveChanges();
                    return Ok();

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
