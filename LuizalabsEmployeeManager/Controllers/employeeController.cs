using employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace employee.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeContext db = new EmployeeContext(); /*Conection*/
        private static List<Employee> employees = new List<Employee>();

        /*Insert Post Method*/
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); //Validate

            db.Employees.Add(employee); //Insert
            db.SaveChanges();           //Save Database changes
            return Created("Employee", employee); //Return Insertion
             
        }

        /*Recovere GET Method*/
        public IHttpActionResult GetEmployee(int page_size = 10, int page = 1)
        {
            if (page <= 0 || page_size <= 0) //Validate 
                return BadRequest("Os parâmetros pagina e tamanhoPagina devem ser maiores que zero.");

            var emloyeeList = db.Employees.OrderBy(x => x.Name).Skip(page_size * (page - 1)).Take(page_size).ToList();
            return Ok(emloyeeList); //Return Results

        }
        /*Delete Method*/
        public IHttpActionResult Delete(int id)
        {
            var teste = db.Employees.Find(id); //Search for id
            if (teste != null)
            {
                db.Employees.Remove(teste); //Delete case found
                db.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
