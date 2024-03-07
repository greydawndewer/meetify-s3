using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Meetify

{
    public class MyDbContext : DbContext
    {
        // DbSet represents a table in the database
        public DbSet<Main> Main { get; set; }

        // Constructor to specify options
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }

    public class Main
    {
        public int Id { get; set; }
        public String? Pass { get; set; }
    }

    public class Database
    {
        public void set(int id, string pass) 
        { 
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer("Data Source=THE-MECHA-BEAST;Initial Catalog=Meetify;Integrated Security=True;");

            using (var context = new MyDbContext(optionsBuilder.Options))
            {
                // Query the table to check if an item exists
                var existingItem = context.Main.FirstOrDefault(item => item.Id == 1); // Modify this condition as needed

                if (existingItem == null)
                {
                    // Create a new item if it doesn't exist
                    var newItem = new Main
                    {
                        Id = id, // Assuming 'Id' is the primary key and auto-incremented, you may need to remove this line
                        Pass = pass
                        // Set other properties as needed
                    };

                    // Add the new item to the table
                    context.Main.Add(newItem);

                    // Save changes to the database
                    context.SaveChanges();

                    Console.WriteLine("New item added successfully.");
                }
                else
                {
                    Console.WriteLine("Item already exists.");
                }
            }
        }
    }
}
