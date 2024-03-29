using System.Text.Json.Serialization;

namespace CourseWork.Models
{
    public class Skill
    {
        public int? SkillId { get; set; }
        public string? Type { get; set; }
        public string? Level { get; set; }
        public string? Description { get; set; }


        [JsonIgnore]
        public List<StaffSkill>? staffSkills {get; set;}
    }
}