using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Entry.Any())
                {
                    return;   // DB has been seeded
                }

                context.Entry.AddRange(
                    new Entry
                    {
                        Note = "God is everlasting and without change",
                        Book = "Doctrine and Covenants",
                        Chapter = 20,
                        Verse = 17,
                        NoteDate = DateTime.Parse("2017-5-2")
                    },

                    new Entry
                    {
                        Note = "Jesus died so we may become his subjects",
                        Book = "2 Nephi",
                        Chapter = 9,
                        Verse = 5,
                        NoteDate = DateTime.Parse("2017-5-9")
                    },

                    new Entry
                    {
                        Note = "Atonement is needed to ",
                        Book = "Alma",
                        Chapter = 34,
                        Verse = 9,
                        NoteDate = DateTime.Parse("2017-2-23")
                    },

                    new Entry
                    {
                        Note = "Hearken unto the voice of the lord and his only begotten son",
                        Book = "Moses",
                        Chapter = 5,
                        Verse = 57,
                        NoteDate = DateTime.Parse("2010-9-19")
                    },

                    new Entry
                    {
                        Note = "The Holy ghost guides us to knowing Jesus is the lord",
                        Book = "1 Corinthians",
                        Chapter = 12,
                        Verse = 3,
                        NoteDate = DateTime.Parse("1989-2-12")
                    },

                    new Entry
                    {
                        Note = "Give all that we have for the betterment of others",
                        Book = "1 Corinthians",
                        Chapter = 13,
                        Verse = 3,
                        NoteDate = DateTime.Parse("1993-12-24")
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
