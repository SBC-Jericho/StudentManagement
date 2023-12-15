using System.Text.Json.Serialization;

namespace BlazorWasmDotnet8AspNetCoreHosted.Server.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public Book Book { get; set; }
        public int BookId { get; set; } 
    }
}
