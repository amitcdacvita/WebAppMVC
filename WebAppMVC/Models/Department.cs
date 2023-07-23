using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
       

    }
    
}
