using System.ComponentModel.DataAnnotations;

namespace ServerSide1.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "השם הוא שדה חובה")]  // שדה חובה
        [StringLength(100, ErrorMessage = "השם יכול להיות עד 100 תווים")]
        public string Name { get; set; }

        [Required(ErrorMessage = "הז'אנר הוא שדה חובה")]  // שדה חובה
        [StringLength(50, ErrorMessage = "הז'אנר יכול להיות עד 50 תווים")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "המחיר הוא שדה חובה")]  // שדה חובה
        [Range(0, double.MaxValue, ErrorMessage = "המחיר חייב להיות מספר חיובי")]
        public decimal Price { get; set; }
    }
}
