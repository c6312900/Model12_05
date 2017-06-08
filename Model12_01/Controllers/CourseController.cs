using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model12_01.Models;

namespace Model12_01.Controllers
{
    public class CourseController : ApiController
    {  //Test Data
        private static List<Course> courses = new List<Course>
        {
            new Course {Id=1,Name="MVC" },
            new Course {Id=2,Name="WebForm" },
            new Course {Id=3,Name="WebApi" }
        };

        // GET: api/Course
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET: api/Course/5
        public Course Get(int id)
        {
            var result = courses.Find(c => c.Id == id);
            //var query = from c in courses
            //            where c.Id == id
            //            select c;
            //var result = query.First();
            return result;
        }

        // POST: api/Course
        public void Post([FromBody]Course course)
        {
            courses.Add(course);
        }

        // PUT: api/Course/5
        public void Put([FromBody]Course course)
        {
            var item = courses.Find(c => c.Id == course.Id);
            item.Name = course.Name;
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
            var course = courses.Find(c => c.Id==id );
            courses.Remove(course);
        }
    }
}
