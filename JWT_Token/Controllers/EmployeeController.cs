using JWT_Token.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly MyDBContext myDBContext;

        public EmployeeController(MyDBContext myDBContext)
        {
            this.myDBContext = myDBContext;
        }

        [HttpGet]
        public  ActionResult GetEmployee()
        {
            try
            {
               // var data = await myDBContext.Employee.ToListAsync();
                var data =  myDBContext.Employee.ToList();

                return Ok(data);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

    }
}
