using System.ComponentModel.DataAnnotations.Schema;

namespace ChamCong.Models
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Role {  get; set; }
        public string Image {  get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
