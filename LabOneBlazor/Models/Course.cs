using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LabOneBlazor.Models
{
    public class Course
    {
        public int id { get; set; }
        [Required]
        public string crS_Name { get; set; }
        [Required]
        public string crS_Desc { get; set; }
        public int duration { get; set; }
        public override string ToString()
        {
            return $"Id {id} Name {crS_Name} desc {crS_Desc} duration {duration} ";
        }

    }
}
