using System.Text.Json.Serialization;

namespace ToDoForm
{
    public class UserItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
