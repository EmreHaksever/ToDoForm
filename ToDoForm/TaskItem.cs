using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ToDoForm
{
    public class TaskItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        [JsonConverter(typeof(StatusConverter))]  
        public int Status { get; set; }

        [JsonPropertyName("dueDate")]
        public DateTime DueDate { get; set; }

        [JsonPropertyName("userName")]
        public string userName { get; set; }

        public string StatusText
        {
            get
            {
                return Status switch
                {
                    0 => "Todo",
                    1 => "InProgress",
                    2 => "Done",
                    _ => "Unknown"
                };
            }
        }
    }

    
    public class StatusConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string value = reader.GetString();
                return value switch
                {
                    "Todo" => 0,
                    "InProgress" => 1,
                    "Done" => 2,
                    _ => int.TryParse(value, out int result) ? result : 0
                };
            }
            return reader.GetInt32();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}