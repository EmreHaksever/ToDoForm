using System.Text.Json.Serialization;

public class UserItem
{
    public int Id { get; set; }

    [JsonPropertyName("username")] // API JSON alan adıyla eşleştir
    public string Username { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("role")]
    public string Role { get; set; } = string.Empty;

    public override string ToString()
    {
        return Username; // ComboBox artık bunu gösterecek
    }
}
