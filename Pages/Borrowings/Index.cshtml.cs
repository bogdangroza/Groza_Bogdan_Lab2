﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Groza_Bogdan_Lab2.Data;
using Groza_Bogdan_Lab2.Models;

namespace Groza_Bogdan_Lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Groza_Bogdan_Lab2.Data.Groza_Bogdan_Lab2Context _context;

        public IndexModel(Groza_Bogdan_Lab2.Data.Groza_Bogdan_Lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                    .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}