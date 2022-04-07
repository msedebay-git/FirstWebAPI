using FirstWebAPI.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        //[HttpGet("getById")]
        //public string Get(int id)
        //{
        //    return "Welcome Talent Network!" + id.ToString();
        //}

        //[HttpGet("getByIdAndName")]
        //public string Get(int id, string name)//action
        //{
        //    return "Welcome Talent Network!" + id.ToString() + " " + name.ToString();
        //} 
        // http://localhost:5117/api/first/getById?id=89
        // http://localhost:5117/api/first/getByIdAndName?id=10&Name=Mohamed


        //[HttpGet("getById/{id?}")]
        //public string Get(int id)
        //{
        //    return "Welcome Talent Network!" + id.ToString();
        //}

        //[HttpGet("getByIdAndName/{id}/{name}")]
        //public string Get(int id, string name)//action
        //{
        //    return "Welcome Talent Network!" + id.ToString() + " " + name.ToString();
        //}
        // http://localhost:5117/api/first/getByIdAndName/10/Mohammed

        //[HttpGet("getById/{id?}")]
        //public string Get(int id)
        //{
        //    return "Welcome Talent Network!" + id.ToString();
        //}

        //[HttpGet("getByIdAndName/{id}/{name}")]
        //public string Get(int id, string name)//action
        //{
        //    return "Welcome Talent Network!" + id.ToString() + " " + name.ToString();
        //}

        //[HttpGet("getEmployee")]
        //public Employee Get() //Action
        //{
        //    var E = new Employee() { Id = 102, Name = "Mohammed" };
        //    return E;
        //}

        [HttpGet("getAllEmployees/{id?}")]
        public IActionResult Get(int id) //Action
        {
            List<Employee> emps = new List<Employee> { 
                new Employee() { Id = 102, Name = "Mohammed" },
                new Employee() { Id =103, Name="Jack"},
                new Employee() { Id =104, Name="Lily"},
                new Employee() { Id =105, Name="Mark"}
            };
            if(id == 0)
            return Ok(emps);
            else
                return Ok(emps.Where(x => x.Id == id));

            //http://localhost:5117/api/first/getAllEmployees/
            // http://localhost:5117/api/first/getAllEmployees/103 to get a particular record
        }
    }
}
