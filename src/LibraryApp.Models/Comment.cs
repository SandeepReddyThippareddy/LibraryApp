﻿namespace LibraryApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public AppUser Author { get; set; }
        public Book Book { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
