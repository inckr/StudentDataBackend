namespace StudentDataBackend.Model
{
    public class Students 
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Age { get; set; }
        public StudentInFormation studentInFormations { get; set; }
    }
}
