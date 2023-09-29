using System.ComponentModel.DataAnnotations;

namespace OfficersApp.Models
{
    public class AddOfficerViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Gender { get; set; }
      
        public string Phone { get; set; }
     
        public string Department { get; set; }
      
        public string Position { get; set; }
    }
}
