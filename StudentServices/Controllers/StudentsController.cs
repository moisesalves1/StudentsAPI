using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace StudentServices.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Student.ToList();
            }
        }

        public Student Get(int id)
        {
            using(StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Student.FirstOrDefault(e => e.ID == id);
            }
        }


    }
}
