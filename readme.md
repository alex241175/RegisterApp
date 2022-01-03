things to improve


end date start from start date
   public class Result
    {
        public string? Class { get; set; }
        public string? Title { get; set; }
        public DateTime? Start { get; set; }
        public string? Date {get;set;}
        public DateTime? End { get; set; }
        public string? Speaker { get; set; }
        public string? Gender { get; set; }
        public string? Member { get; set; }
        public int No { get; set; }
    }
    protected async void RunReport()
    {
        var events = from e in DbContext.Events
        join m in DbContext.EventMembers on e.EventId equals m.EventId
        orderby e.Start
        select new Result {
            No = e.EventId,
            Class = e.Class,
            Title = e.Title,
            Start = e.Start,
            End = e.End,
            Date = e.Start.Value.AddHours(8).ToString("dd/MM/yy"),
            Speaker = e.Speaker,
            Gender = m.Gender,
            Member = m.Name
        };

        if (!string.IsNullOrWhiteSpace(filterClass)){
            events = events.Where(x => x.Class == filterClass);
        }
        if (!string.IsNullOrWhiteSpace(filterTitle)){
            events = events.Where(x => x.Title.Contains(filterTitle));
        }
        if (filterStart != null){
            events = events.Where(x => x.Start >= filterStart);
        }
         if (filterEnd != null){
            events = events.Where(x => x.End <= filterEnd);
        }
        var result = events.AsEnumerable().OrderBy(x => x.Member, StringComparer.Create(CultureInfo.CurrentCulture, false))
        .ToArray();

 