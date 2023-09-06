using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDataBackend.Model;

namespace StudentDataBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            //List<Students> students = new List<Students>();

            List<Students> students1 = new List<Students>
            {
                new Students
                {
                    StudentId = "1",
                    StudentName = "Alper",
                    StudentSurname ="Yurtdaş",
                    studentInFormations = new StudentInFormation
                    {
                    StudentEmail = "alper@gmail",
                    StudentPhone = "05512351846",
                    GradeAverage = "3.29",
                    },
                    
                   
                    Age = 24
                },
                new Students
                {
                    StudentId = "2",
                    StudentName = "Ahmet",
                    StudentSurname ="İncekara",
                    studentInFormations = new StudentInFormation
                    {
                    StudentEmail = "ahmet@gmail",
                    StudentPhone = "05124351846",
                    GradeAverage = "3.39",
                    },


                    Age = 21
                },
                new Students
                {
                    StudentId = "3",
                    StudentName = "Mehmet",
                    StudentSurname ="Yılmaz",
                    studentInFormations = new StudentInFormation
                    {
                    StudentEmail = "mehmet@gmail",
                    StudentPhone = "05123351846",
                    GradeAverage = "3.22",
                    },


                    Age = 23
                },
                new Students
                {
                    StudentId = "4",
                    StudentName = "Berk",
                    StudentSurname ="Yıldırım",
                    studentInFormations = new StudentInFormation
                    {
                    StudentEmail = "berk@gmail",
                    StudentPhone = "05514564846",
                    GradeAverage = "3.79",
                    },


                    Age = 22
                }
            };
            //Students student1 = new Students();
            //student1.StudentId = "1";
            //student1.StudentName = "Alper";
            //student1.StudentEmail = "alper@gmail";
            //student1.StudentPhone = "05376543627";
            //student1.GradeAverage = "3.24";

            //Students student2 = new Students();
            //student2.StudentId = "2";
            //student2.StudentName = "Ahmet";
            //student2.StudentEmail = "ahmet@gmail";
            //student2.StudentPhone = "05234563627";
            //student2.GradeAverage = "3.89";

            //students.Add(student1);
            //students.Add(student2);

            return Ok(students1);
        }
      
    }
  
}
