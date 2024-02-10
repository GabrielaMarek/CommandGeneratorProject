using System;
using System.ComponentModel.DataAnnotations;

namespace CommandGenerator.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Comment is required")]
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
