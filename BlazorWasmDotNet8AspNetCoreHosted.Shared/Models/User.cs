namespace BlazorWasmDotnet8AspNetCoreHosted.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public Student? Students { get; set; }
        public Professor? Professors { get; set; }
    }
}
