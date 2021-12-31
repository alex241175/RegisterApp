using System.ComponentModel.DataAnnotations;

namespace RegisterApp.Data
{
    public class Event
    {
        [Key]
        [Required]
        public int EventId {get;set;}
        [Required]
        public string? Class {get;set;}
        public string? Title {get;set;}
        public DateTime? Start { get; set; }
        public DateTime? End {get;set;}
        public string? Location {get;set;}
        public string? Head {get;set;}
        public string? Speaker {get;set;}
        public string? Service {get;set;}
        public string? Remark{get;set;}
        public string? Entity{get;set;}
        public virtual ICollection<EventMember>? EventMembers { get; set; }

    }
}