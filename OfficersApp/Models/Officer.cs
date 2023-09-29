using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficersApp.Models
{
    public class Officer
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Position { get; set; }
            

    }
}
