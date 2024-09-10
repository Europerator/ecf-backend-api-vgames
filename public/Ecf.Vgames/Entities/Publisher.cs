using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ecf.Vgames.Entities
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [Required]
        public String Name { get; set; }
        [JsonIgnore]
        public ICollection<Gizmondo> Gizmondos { get; set; }
    }
}
