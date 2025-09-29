using System.Text.Json.Serialization;

namespace ToDoForm
{
    using System.Text.Json.Serialization;

    public class UserItem
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Role")] // API JSON'da "role" ise
        public string Role { get; set; } = string.Empty;
    }
}