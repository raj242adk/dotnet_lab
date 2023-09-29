using System.ComponentModel.DataAnnotations;

namespace AdoCrud.Models
{
    public class Student { 

        [Key]
        public int Id{ get; set; }
    
        public string Name { get; set; }
 
        public string Gender { get; set; }
      
        public String Faculty { get; set;}
     
        public int Grade { get; set; }
    }
}
