using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using BookClubMVC.Models;


namespace BookClubMVC.DAL
{


    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        
        public DbSet<Book> Book { get; set; }

    }


} 