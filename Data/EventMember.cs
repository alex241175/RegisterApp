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
        public string Name { get; set; }
        [Required(ErrorMessage = "請選擇性別。")]
        public string Gender { get; set; }
        public string Remark { get; set; }
        public DateTime DateRegistered {get;set;}
        public bool Attended {get;set;}

    }
}