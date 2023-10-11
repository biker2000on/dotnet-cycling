namespace Cycling.Data
{
    public class Tour
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Boolean IsPublic { get; set; }

        public required string UserID { get; set; }
        //public virtual ApplicationUser User { get; set; }

    }
}

