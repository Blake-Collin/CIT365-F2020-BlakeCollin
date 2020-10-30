using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Model;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Book { get; set; }

        //Sorting Books and Dates
        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public string CurrentBook { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentString, string currentSort, string searchString, string book, int? pageIndex)
        {
            //Save our Variables
            CurrentSort = sortOrder;
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if(searchString == null)
            {
                searchString = currentString;
            }
            SearchString = searchString;
            Book = book;

            //Get entires
            IQueryable<Entry> entriesIQ = from s in _context.Entry
                                             select s;

            //Filter by keyword
            if (!string.IsNullOrEmpty(SearchString))
            {
                entriesIQ = entriesIQ.Where(s => s.Note.Contains(SearchString));
            }

            //Filter by Book
            if (!string.IsNullOrEmpty(Book))
            {
                entriesIQ = entriesIQ.Where(x => x.Book == Book);
            }

            //Sort depending on which
            switch (sortOrder)
            {
                case "name_desc":
                    entriesIQ = entriesIQ.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    entriesIQ = entriesIQ.OrderBy(s => s.NoteDate);
                    break;
                case "date_desc":
                    entriesIQ = entriesIQ.OrderByDescending(s => s.NoteDate);
                    break;
                default:
                    entriesIQ = entriesIQ.OrderBy(s => s.Book);
                    break;
            }
            //Get all books
            IQueryable<string> bookQuery = from m in _context.Entry
                                            orderby m.Book
                                            select m.Book;
            //Add Books to selection choices
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());            
            
            //Add all entries to list for page creation
            Entry = await entriesIQ.AsNoTracking().ToListAsync();
        }
    }
}
