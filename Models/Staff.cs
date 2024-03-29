using System.Text.Json.Serialization;

namespace CourseWork.Models
{
    public class Staff
    {
        public int? StaffId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Department? Department { get; set; }


        [JsonIgnore]
        public List<StaffSkill>? staffSkills {get; set;}
    }
}