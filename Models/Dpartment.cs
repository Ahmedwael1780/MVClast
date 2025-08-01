using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVClast.Models
{
    
        public class Department
        {
            
            [Key]
            [DisplayName("Department Id")]
            public int DeptId { get; set; }


            [DisplayName("Department Name")]
            public string DeptName { get; set; }
            
            public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
            
        }
    }

