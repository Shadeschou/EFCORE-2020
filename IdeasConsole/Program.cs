using System;
using System.Collections.Generic;
using System.Linq;
using IdeasApp.Data;
using IdeasApp.Domain;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace IdeasConsole
{
    class Program
    {
        private static DatabaseContext context = new DatabaseContext();
        private static IdeaLogic _methodGrabber = new IdeaLogic();


        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            var idea = new Idea {CompanyID = "Torben"};
            context.Ideas.Add(idea);
            context.SaveChanges();

            var ideas = context.Ideas.ToList();
            //can be used for count, selecting etc.
            
            var firm = ideas.Where(b => b.CompanyID == "Torben").Select(s => s.CompanyID).ToList();
            IEnumerable<DateTime> resultsFromMethodGrabber = _methodGrabber.GetDateTimeCreatedyCompanyID("Torben");

            foreach (var date in resultsFromMethodGrabber)
            {
                Console.WriteLine(date);
            }

            


            Console.ReadLine();
        }



    }
}
