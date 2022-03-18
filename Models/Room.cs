using System.ComponentModel.DataAnnotations;
namespace RoomApi.Models
{
    public class Room
    {
        //properties
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? Image { get; set; }

    }
}
