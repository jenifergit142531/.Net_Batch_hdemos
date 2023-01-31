using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week9day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        static List<string> course = new List<string>()
        {
            "C#","Java","Python","Rubyonrails"
        };

        [HttpGet]
        [Route("getall")]
        public IEnumerable<string> GetAll()
        {
            return course;
        }

        [HttpGet]
        [Route("Getbyid/{id}")]
        public IEnumerable<string> GetById(int id)
        {
            yield return course[id];
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            course.RemoveAt(id);
        }
    }
}
