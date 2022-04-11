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
        public int Mode{get;set;}   // default 0, preset members -  1 是否固定人員
        public bool? HideDate {get;set;} = false; // 不是報名班會，如要收集一些資料
        public string? Survey1Question {get;set;}
        public string? Survey1Option {get;set;}
        public string? Survey1Default {get;set;}
        public string? Survey2Question {get;set;}
        public string? Survey2Option {get;set;}
        public string? Survey2Default {get;set;}
        
        
        public virtual ICollection<EventMember>? EventMembers { get; set; }
        public Event DeepCopy()
        {
            Event temp = (Event) this.MemberwiseClone();
            temp.EventId = this.EventId;
            temp.Class = this.Class;
            temp.Title = this.Title;
            temp.Start = this.Start;
            temp.End = this.End;
            temp.Location = this.Location;
            temp.Head = this.Head;
            temp.Speaker = this.Speaker;
            temp.Service = this.Service;
            temp.Remark = this.Remark;
            temp.Entity = this.Entity;
            temp.Mode = this.Mode;
            temp.EventMembers = this.EventMembers;
            return temp;
        }

    }
}