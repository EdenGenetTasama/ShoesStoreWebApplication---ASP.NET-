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
    public class SportShoesController : ApiController
    {
        static string conectionString = "Data Source=DESKTOP-0MT6QTG;Initial Catalog=ShoesDataBase;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        List<SportShoe> sportShoeList = new List<SportShoe>();
        // GET: api/SportShoes
        public IHttpActionResult Get()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM SportShoes";
                    SqlCommand commend = new SqlCommand(query, connection);
                    SqlDataReader reader = commend.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            sportShoeList.Add(new SportShoe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4)));


                        }
                    }
                    connection.Close();
                    return Ok(new { sportShoeList });
                }
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

        // GET: api/SportShoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (SqlConnection dataContect = new SqlConnection(conectionString))
                {
                    dataContect.Open();
                    string query = $@"SELECT * FROM SportShoes WHERE Id ={id}";
                    SqlCommand sqlCommand = new SqlCommand(query, dataContect);
                    SqlDataReader getIdInfo = sqlCommand.ExecuteReader();
                    if (getIdInfo.HasRows)
                    {
                        while (getIdInfo.Read())
                        {

                            SportShoe objectId = new SportShoe(getIdInfo.GetInt32(0), getIdInfo.GetString(1), getIdInfo.GetString(2), getIdInfo.GetInt32(3), getIdInfo.GetInt32(4));
                            return Ok(objectId);
                        }
                    }
                    return Ok("Failed");

                }

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

        // POST: api/SportShoes
        public IHttpActionResult Post([FromBody] SportShoe shoe)
        {
            try
            {
                using (SqlConnection dbConext = new SqlConnection(conectionString))
                {
                    dbConext.Open();
                    string query = $@"INSERT INTO SportShoes (Company , BrandName , Price , Size) VALUES ('{shoe.Company}','{shoe.BrandName}',{shoe.Price},{shoe.Size})";
                    SqlCommand sqlCommand = new SqlCommand(query, dbConext);
                    sqlCommand.ExecuteNonQuery();
                    dbConext.Close();

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

        // PUT: api/SpoetShoes/5
        public IHttpActionResult Put(int id, [FromBody] SportShoe shoe)
        {
            try
            {
                //Company , BrandName , Price , Size
                using (SqlConnection dbConext = new SqlConnection(conectionString))
                {
                    dbConext.Open();
                    string query = $@"UPDATE SportShoes
                                      SET Company = '{shoe.Company}' , BrandName = '{shoe.BrandName}' , Price = {shoe.Size} , Size ={shoe.Price}
                                       WHERE Id={id}";
                    SqlCommand commend = new SqlCommand(query, dbConext);
                    commend.ExecuteNonQuery();
                    return Ok("Added");
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

        // DELETE: api/SpoetShoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string deleteQuery = $@"DELETE FROM SportShoes WHERE Id={id}";
                    SqlCommand sqlCommand = new SqlCommand(deleteQuery, connection);
                    sqlCommand.ExecuteNonQuery();
                    return Ok("DELETE");

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
