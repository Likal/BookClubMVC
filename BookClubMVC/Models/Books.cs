using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace BookClubMVC.Models
{
    public class Books
    {

        public Guid Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public List<Ratings> Ratings { get; set; }
        public bool IsDeleted { get; set; }
    }

}


     