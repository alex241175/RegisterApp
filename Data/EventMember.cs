using System.ComponentModel.DataAnnotations;

namespace RegisterApp.Data
{
    public class EventMember
    {
        [Key]
        [Required]
        public int EventMemberId { get; set; }
        public int EventId {get;set;}
        [Required(ErrorMessage = "請輸入姓名。")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "請選擇性別。")]
        public string? Gender { get; set; }
        public string? School { get; set; } = "士C";
        public string? Remark { get; set; }
        public DateTime DateRegistered {get;set;}
        public int Attend {get;set;}

    }
      public static class Config
    {
        public static List<string> Schools = new(){"士C", "士D", "地南", "古來", "居鑾", "麻坡"};
    }
}