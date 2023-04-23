using Newtonsoft.Json;

namespace BlazorFun.Models
{
    public class TaskItem
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public string Sid { get; set; }
        public string TaskValue { get; set; }
        public bool IsChecked { get; set; }
    }
}
