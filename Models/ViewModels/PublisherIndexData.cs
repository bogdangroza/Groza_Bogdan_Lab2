﻿using Groza_Bogdan_Lab2.Models;

namespace Groza_Bogdan_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}