using Microsoft.EntityFrameworkCore;

namespace VisitorCommentsApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VisitorCommentsApp.Data.VisitorCommentsAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VisitorCommentsApp.Data.VisitorCommentsAppContext>>()))
            {
                // Look for any visitors.
                if (context.Visitors.Any())
                {
                    return;   // DB has been seeded
                }

                context.Visitors.AddRange(
                    new Visitor
                    {
                        Name = "John Smith",
                        Address = "123 The High Street, Manchester",
                        Email = "john@smith.com",
                        Phone1 = "1234567890",
                        Phone2 = "0987654321",
                        Comments = "Excellent coffee!"
                    },

                    new Visitor
                    {
                        Name = "Paul Jones",
                        Address = "43 Green Lane, Manchester",
                        Email = "paul@jones.com",
                        Phone1 = "12121212",
                        Phone2 = "34343434",
                        Comments = "Very productive meeting"
                    },

                    new Visitor
                    {
                        Name = "Alan Brown",
                        Address = "99 Bond Street, Manchester",
                        Email = "alan@brown.com",
                        Phone1 = "878787878787",
                        Phone2 = "454545454545",
                        Comments = "Great facilities"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
