namespace aspproj.Models
{
    public class Actor_Movie
    {
        public int ActorID { get; set; }
        public Movie Movie { get; set; } = null!;

        public int MovieID { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
