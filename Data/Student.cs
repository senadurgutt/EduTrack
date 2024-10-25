
namespace EduTrack.Data
{
    public class Student
    {
        // id; primary key
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
