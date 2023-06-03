﻿using System.ComponentModel.DataAnnotations.Schema;

namespace My_Books.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsRead { get; set; }
        public string? Genre { get; set; }
        public string? Author { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string? CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
        //nevigation Properties
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}
