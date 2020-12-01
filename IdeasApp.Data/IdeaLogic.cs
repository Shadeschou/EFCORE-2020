using System;
using System.Collections.Generic;
using System.Linq;

namespace IdeasApp.Data
{
    public class IdeaLogic
    {
        public IEnumerable<int> GetIdeaIDByCompanyID(string companyID)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                var query = dc.Ideas.Where(b => b.CompanyID == companyID).Select(s => s.IdeaID).ToList();
                return query;
            }
        }

        public  IEnumerable<String> GetTextContentByCompanyID(string companyID)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                var query = dc.Ideas.Where(b => b.CompanyID == companyID).Select(s => s.TextContent).ToList();
                return query;
            }
        }

        public  IEnumerable<DateTime> GetDateTimeCreatedyCompanyID(string companyID)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                var query = dc.Ideas.Where(b => b.CompanyID == companyID).Select(s => s.DateCreated).ToList();
                return query;
            }
        }

        public  IEnumerable<int> GetPriorityIDByCompanyID(string companyID)
        {
            using (DatabaseContext dc = new DatabaseContext())
            {
                var query = dc.Ideas.Where(b => b.CompanyID == companyID).Select(s => s.PriorityID).ToList();
                return query;
            }
        }
    }
}
