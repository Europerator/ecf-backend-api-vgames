using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ecf.Vgames.Entities
{
    public class Gizmondo
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Game { get; set; }
        public int year { get; set; }
        public String dev {  get; set; }
        [ForeignKey(nameof(Publisher))]
        public int PublisherId { get; set; }
        [JsonIgnore]
        public Publisher? Publisher { get; set; }
    }
}
