namespace BlazorWasmDotnet8AspNetCoreHosted.Server.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Subject? Subjects { get; set; }
    }
}
