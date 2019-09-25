using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            { 
        {
            if (!context.Gloves.Any())
            {
                context.AddRange
                    (
                       new Gloves
                       {
                           Name = "Speed 100",
                           Price = 89.90M,
                           ShortDescription = "Den mest populära boxningshandsken 8 oz",
                           LongDescription = " bla bla bla bla ",
                           ImageUrl = "Images/boxhandske.jpg",
                           ImageThumbnailUrl = "Images/boxhandske.jpg",
                           IsGlovesOfTheWeek = true
                       },


                new Gloves
                {

                    Name = "Speed 200",
                    Price = 99.90M,
                    ShortDescription = "Den mest populära boxningshandsken 10 oz",
                    LongDescription = " bla bla bla bla ",
                    ImageUrl = "Images/bgv14.jpg",
                    ImageThumbnailUrl = "Images/bgv14.jpg",
                    IsGlovesOfTheWeek = false
                },

                new Gloves
                {

                    Name = "Speed 300",
                    Price = 109.90M,
                    ShortDescription = "Den mest populära boxningshandsken 12 oz",
                    LongDescription = " bla bla bla bla ",
                    ImageUrl = "images/fairtex.jpg",
                    ImageThumbnailUrl = "images/fairtex.jpg",
                    IsGlovesOfTheWeek = false
                },

                new Gloves
                {

                    Name = "Speed 400",
                    Price = 119.90M,
                    ShortDescription = "Den mest populära boxningshandsken 16 oz",
                    LongDescription = " bla bla bla bla ",
                    ImageUrl = "Images/boxhandske3.jpg",
                    ImageThumbnailUrl = "Images/boxhandske3.jpg",
                    IsGlovesOfTheWeek = false
                }

                    );
                context.SaveChanges();
            }
        } }
        }
    }
}
