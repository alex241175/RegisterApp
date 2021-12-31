using System.ComponentModel.DataAnnotations;

namespace RegisterApp.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string? UserName { get; set; }
        public string? Email { get; set; }  
        public string? Role { get; set; }   
        
    }
}