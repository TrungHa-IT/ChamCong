namespace ChamCong.Models
{
    public class Department
    {
        public string Name { get; set; }    
        public string Description { get; set; }

        // Mối quan hệ 1-nhiều với Employee
        public virtual ICollection<Employee>? Employees { get; set; }  // Một CategoriesRoom có thể có nhiều Room
    }
}
