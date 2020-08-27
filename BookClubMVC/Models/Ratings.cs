using System;

namespace BookClubMVC.Models
{
    public class Ratings
    {
        public Guid Id { get; set; }

        public Guid BooksId { get; set; }

        public string Username { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }

        public DateTime DateRated { get; set; }

        public bool IsDeleted { get; set; }

    }
}
