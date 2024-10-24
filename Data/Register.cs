using System.ComponentModel.DataAnnotations;

namespace EduTrack.Data
{
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime CourseRegister {  get; set; }
    }
}
