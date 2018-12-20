using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data
{
    public class DbInitializer
    {
        internal static void Seed(IApplicationBuilder app)
        {

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }
                context.SaveChanges();
                if (!context.Products.Any())
                {
                    context.AddRange
                    (
                        // Vegetables
                        new Products
                        {
                            Name = "Tomato",
                            Price = 5.0M,
                            ShortDescription = "Fresh Tomato",
                            Category = Categories["Vegetables"],
                            ImageUrl = "http://www.georgeperry.co.uk/images/P/vinetoms.jpg",
                            InStock = true,
                            IsPreferredDrink = true,
                            ImageThumbnailUrl = "http://www.georgeperry.co.uk/images/P/vinetoms.jpg"
                        },
                         new Products
                         {
                             Name = "Onions",
                             Price = 5.0M,
                             ShortDescription = "Fresh Onions",
                             Category = Categories["Vegetables"],
                             ImageUrl = "http://www.yummymummyclub.ca/sites/default/files/styles/large/public/onion_fennel_bisque.jpg?itok=JpkbnMqM",
                             InStock = true,
                             IsPreferredDrink = true,
                             ImageThumbnailUrl = "http://www.yummymummyclub.ca/sites/default/files/styles/large/public/onion_fennel_bisque.jpg?itok=JpkbnMqM"
                         },
                          new Products
                          {
                              Name = "Cucumber",
                              Price = 5.0M,
                              ShortDescription = "Fresh Cucumber",
                              Category = Categories["Vegetables"],
                              ImageUrl = "https://www.naturalfoodseries.com/wp-content/uploads/2017/12/Cucumber-768x512.jpg",
                              InStock = true,
                              IsPreferredDrink = true,
                              ImageThumbnailUrl = "https://www.naturalfoodseries.com/wp-content/uploads/2017/12/Cucumber-768x512.jpg"
                          },
                            new Products
                            {
                                Name = "carrot",
                                Price = 5.0M,
                                ShortDescription = "Fresh carrotr",
                                Category = Categories["Vegetables"],
                                ImageUrl = "https://gourmetdelight.in/image/cache/catalog/pdp/organic_carrots-600x600.jpg",
                                InStock = true,
                                IsPreferredDrink = true,
                                ImageThumbnailUrl = "https://gourmetdelight.in/image/cache/catalog/pdp/organic_carrots-600x600.jpg"
                            },
                               new Products
                               {
                                   Name = "Green pepper",
                                   Price = 5.0M,
                                   ShortDescription = "Fresh Green pepper",
                                   Category = Categories["Vegetables"],
                                   ImageUrl = "https://www.puppyfaqs.com/wp-content/uploads/2018/09/Can-Dogs-Eat-Green-Peppers-1.jpg",
                                   InStock = true,
                                   IsPreferredDrink = true,
                                   ImageThumbnailUrl = "https://www.puppyfaqs.com/wp-content/uploads/2018/09/Can-Dogs-Eat-Green-Peppers-1.jpgg"
                               },
                                new Products
                                {
                                    Name = "spring onion",
                                    Price = 5.0M,
                                    ShortDescription = "Fresh spring onion",
                                    Category = Categories["Vegetables"],
                                    ImageUrl = "https://online.yunusmarket.com.tr/2091-thickbox_default/sogan-taze.jpg",
                                    InStock = true,
                                    IsPreferredDrink = true,
                                    ImageThumbnailUrl = "https://online.yunusmarket.com.tr/2091-thickbox_default/sogan-taze.jpg"
                                },
                                 new Products
                                 {
                                     Name = "shallots",
                                     Price = 5.0M,
                                     ShortDescription = "Fresh shallotsr",
                                     Category = Categories["Vegetables"],
                                     ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9d7Do5G9FXuE9POGllpJ5L464tlUylDa-Ix2vKFy22RAY8IeuuA",
                                     InStock = true,
                                     IsPreferredDrink = true,
                                     ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9d7Do5G9FXuE9POGllpJ5L464tlUylDa-Ix2vKFy22RAY8IeuuA"
                                 },
                                  new Products
                                  {
                                      Name = "French beans",
                                      Price = 5.0M,
                                      ShortDescription = "Fresh French beans",
                                      Category = Categories["Vegetables"],
                                      ImageUrl = "https://mealprepgrind.com/wp-content/uploads/2017/12/56660713-B29C-4097-9594-5ACA16CDAD4E.jpeg",
                                      InStock = true,
                                      IsPreferredDrink = true,
                                      ImageThumbnailUrl = "https://mealprepgrind.com/wp-content/uploads/2017/12/56660713-B29C-4097-9594-5ACA16CDAD4E.jpeg"
                                  },
                                   new Products
                                   {
                                       Name = "Green pepper",
                                       Price = 5.0M,
                                       ShortDescription = "Fresh Green pepper",
                                       Category = Categories["Vegetables"],
                                       ImageUrl = "https://www.puppyfaqs.com/wp-content/uploads/2018/09/Can-Dogs-Eat-Green-Peppers-1.jpg",
                                       InStock = true,
                                       IsPreferredDrink = true,
                                       ImageThumbnailUrl = "https://www.puppyfaqs.com/wp-content/uploads/2018/09/Can-Dogs-Eat-Green-Peppers-1.jpg"
                                   },
                                    new Products
                                    {
                                        Name = "Red pepper",
                                        Price = 5.0M,
                                        ShortDescription = "Fresh Red pepper",
                                        Category = Categories["Vegetables"],
                                        ImageUrl = "https://www.naturalfoodseries.com/wp-content/uploads/2017/10/Chili-Pepper-800x416.jpg",
                                        InStock = true,
                                        IsPreferredDrink = true,
                                        ImageThumbnailUrl = "https://www.naturalfoodseries.com/wp-content/uploads/2017/10/Chili-Pepper-800x416.jpg"
                                    },
                                     new Products
                                     {
                                         Name = "Cabbage",
                                         Price = 5.0M,
                                         ShortDescription = "Fresh Cabbage",
                                         Category = Categories["Vegetables"],
                                         ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Cabbage_and_cross_section_on_white.jpg/1200px-Cabbage_and_cross_section_on_white.jpg",
                                         InStock = true,
                                         IsPreferredDrink = true,
                                         ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Cabbage_and_cross_section_on_white.jpg/1200px-Cabbage_and_cross_section_on_white.jpg"
                                     },
                                      new Products
                                      {
                                          Name = "Kontomire",
                                          Price = 5.0M,
                                          ShortDescription = "Fresh Kontomire",
                                          Category = Categories["Vegetables"],
                                          ImageUrl = "https://www.tobremeonline.com/wp-content/uploads/2018/01/Kontomire.jpeg",
                                          InStock = true,
                                          IsPreferredDrink = true,
                                          ImageThumbnailUrl = "https://www.tobremeonline.com/wp-content/uploads/2018/01/Kontomire.jpeg"
                                      },
                                       new Products
                                       {
                                           Name = "Garden Eggs",
                                           Price = 5.0M,
                                           ShortDescription = "Fresh Garden Eggs",
                                           Category = Categories["Vegetables"],
                                           ImageUrl = "http://www.nuovafrutta.com/wp-content/uploads/Garden-Eggs-Uganda.jpg",
                                           InStock = true,
                                           IsPreferredDrink = true,
                                           ImageThumbnailUrl = "http://www.nuovafrutta.com/wp-content/uploads/Garden-Eggs-Uganda.jpg"
                                       },
                                        new Products
                                        {
                                            Name = "Turkish berries",
                                            Price = 5.0M,
                                            ShortDescription = "Fresh Turkish berries",
                                            Category = Categories["Vegetables"],
                                            ImageUrl = "http://4.bp.blogspot.com/-peR0lxFWm8Q/VHrZuPLGhCI/AAAAAAAAC2I/yeeBB1A1QnE/s1600/DSC08041.JPG",
                                            InStock = true,
                                            IsPreferredDrink = true,
                                            ImageThumbnailUrl = "http://4.bp.blogspot.com/-peR0lxFWm8Q/VHrZuPLGhCI/AAAAAAAAC2I/yeeBB1A1QnE/s1600/DSC08041.JPG"

                                        },
                                         new Products
                                         {
                                             Name = "Lettuce",
                                             Price = 5.0M,
                                             ShortDescription = "Fresh Lettuce",
                                             Category = Categories["Vegetables"],
                                             ImageUrl = "https://gallery.yopriceville.com/var/resizes/Free-Clipart-Pictures/Vegetables-PNG/Lettuce_PNG_Picture.png?m=1507172105",
                                             InStock = true,
                                             IsPreferredDrink = true,
                                             ImageThumbnailUrl = "https://gallery.yopriceville.com/var/resizes/Free-Clipart-Pictures/Vegetables-PNG/Lettuce_PNG_Picture.png?m=1507172105"
                                         },
                                          new Products
                                          {
                                              Name = "Spinachr",
                                              Price = 5.0M,
                                              ShortDescription = "Fresh Spinach",
                                              Category = Categories["Vegetables"],
                                              ImageUrl = "https://www.localcrop.com.au/368-large_default/baby-spinach-leaves-235g-bag-17kg.jpg",
                                              InStock = true,
                                              IsPreferredDrink = true,
                                              ImageThumbnailUrl = "https://www.localcrop.com.au/368-large_default/baby-spinach-leaves-235g-bag-17kg.jpg"
                                          },
                                           new Products
                                           {
                                               Name = "Okro",
                                               Price = 5.0M,
                                               ShortDescription = "Fresh Okro",
                                               Category = Categories["Vegetables"],
                                               ImageUrl = "http://dailypost.ng/wp-content/uploads/2017/07/Okra.jpg",
                                               InStock = true,
                                               IsPreferredDrink = true,
                                               ImageThumbnailUrl = "http://dailypost.ng/wp-content/uploads/2017/07/Okra.jpg"
                                           },
                                            new Products
                                            {
                                                Name = "Ademe",
                                                Price = 5.0M,
                                                ShortDescription = "Fresh Ademe",
                                                Category = Categories["Vegetables"],
                                                ImageUrl = "http://www.babaewegbemi.com/medias/album/corchorus-olitorius-ayo-ewedu-eweedu-eyo-yoyo-eyo-ganbe-senu-gbooro.jpg",
                                                InStock = true,
                                                IsPreferredDrink = true,
                                                ImageThumbnailUrl = "http://www.babaewegbemi.com/medias/album/corchorus-olitorius-ayo-ewedu-eweedu-eyo-yoyo-eyo-ganbe-senu-gbooro.jpg"
                                            },
                                              new Products
                                              {
                                                  Name = "Mushrooms",
                                                  Price = 10.0M,
                                                  ShortDescription = "Fresh Mushrooms",
                                                  Category = Categories["Vegetables"],
                                                  ImageUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/articles/health_tools/all_about_mushrooms_slideshow/493ss_thinkstock_rf_variety_of_mushrooms.jpg",
                                                  InStock = true,
                                                  IsPreferredDrink = true,
                                                  ImageThumbnailUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/articles/health_tools/all_about_mushrooms_slideshow/493ss_thinkstock_rf_variety_of_mushrooms.jpg"
                                              },
                                                new Products
                                                {
                                                    Name = "Garlic",
                                                    Price = 5.0M,
                                                    ShortDescription = "Fresh Garlic",
                                                    Category = Categories["Vegetables"],
                                                    ImageUrl = "https://static1.squarespace.com/static/54694fa6e4b0eaec4530f99d/t/57b6fc3a6a49637a91086fd7/1471609927056/?format=750w",
                                                    InStock = true,
                                                    IsPreferredDrink = false,
                                                    ImageThumbnailUrl = "https://static1.squarespace.com/static/54694fa6e4b0eaec4530f99d/t/57b6fc3a6a49637a91086fd7/1471609927056/?format=750w"
                                                },
                                                //Fresh Fish
                                                 new Products
                                                 {
                                                     Name = "Tilapia",
                                                     Price = 20.0M,
                                                     ShortDescription = "Fresh Tilapia",
                                                     Category = Categories["Fresh Fish"],
                                                     ImageUrl = "https://ak9.picdn.net/shutterstock/videos/4182569/thumb/1.jpg",
                                                     InStock = true,
                                                     IsPreferredDrink = true,
                                                     ImageThumbnailUrl = "https://ak9.picdn.net/shutterstock/videos/4182569/thumb/1.jpg"
                                                 },
                                                   new Products
                                                   {
                                                       Name = "Salmon",
                                                       Price = 15.0M,
                                                       ShortDescription = "Fresh Salmon",
                                                       Category = Categories["Fresh Fish"],
                                                       ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR97FOqXTNGpT3UJeYbRmAs8nnX3tYo5WwR0Pql9QyduaK0odhfOQ",
                                                       InStock = true,
                                                       IsPreferredDrink = true,
                                                       ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR97FOqXTNGpT3UJeYbRmAs8nnX3tYo5WwR0Pql9QyduaK0odhfOQ"
                                                   },
                                                     new Products
                                                     {
                                                         Name = "Kpala",
                                                         Price = 10.0M,
                                                         ShortDescription = "Fresh Kpala",
                                                         Category = Categories["Fresh Fish"],
                                                         ImageUrl = "https://www.nairaland.com/attachments/3217770_mackerelbig_jpeg0de3d657ba3bc05478f7590c7ab76e55",
                                                         InStock = true,
                                                         IsPreferredDrink = true,
                                                         ImageThumbnailUrl = "https://www.nairaland.com/attachments/3217770_mackerelbig_jpeg0de3d657ba3bc05478f7590c7ab76e55"
                                                     },
                                                       new Products
                                                       {
                                                           Name = "Catfish",
                                                           Price = 15.0M,
                                                           ShortDescription = "Fresh Catfish",
                                                           Category = Categories["Fresh Fish"],
                                                           ImageUrl = "https://5.imimg.com/data5/NY/FS/MY-48938108/fresh-catfish-500x500.jpg",
                                                           InStock = true,
                                                           IsPreferredDrink = false,
                                                           ImageThumbnailUrl = "https://5.imimg.com/data5/NY/FS/MY-48938108/fresh-catfish-500x500.jpg"
                                                       },
                                                         new Products
                                                         {
                                                             Name = "Mudfish",
                                                             Price = 10.0M,
                                                             ShortDescription = "Fresh Mudfish",
                                                             Category = Categories["Fresh Fish"],
                                                             ImageUrl = "https://tpwd.texas.gov/fishboat/fish/images/inland_species/bowfinbig.jpg",
                                                             InStock = true,
                                                             IsPreferredDrink = true,
                                                             ImageThumbnailUrl = "https://tpwd.texas.gov/fishboat/fish/images/inland_species/bowfinbig.jpg"
                                                         },
                                                           new Products
                                                           {
                                                               Name = "Cassava Fish, ",
                                                               Price = 10.0M,
                                                               ShortDescription = "Fresh Cassava Fish, ",
                                                               Category = Categories["Fresh Fish"],
                                                               ImageUrl = "http://4.bp.blogspot.com/-eDJkBnf1hyQ/TiIJXsSEIcI/AAAAAAAAA1E/vYbGqsSPrjw/s1600/kenam1.jpg",
                                                               InStock = true,
                                                               IsPreferredDrink = false,
                                                               ImageThumbnailUrl = "http://4.bp.blogspot.com/-eDJkBnf1hyQ/TiIJXsSEIcI/AAAAAAAAA1E/vYbGqsSPrjw/s1600/kenam1.jpg"
                                                           },


                                                             // Smoked Tilapia
                                                             new Products
                                                             {
                                                                 Name = "Tilapia",
                                                                 Price = 20.0M,
                                                                 ShortDescription = "Smoked  Tilapia",
                                                                 Category = Categories["Smoked Fish"],
                                                                 ImageUrl = "https://mangumangu.com/Shop/i/Dry%20tilapia.jpg",
                                                                 InStock = true,
                                                                 IsPreferredDrink = true,
                                                                 ImageThumbnailUrl = "https://mangumangu.com/Shop/i/Dry%20tilapia.jpg"
                                                             },
                                                   new Products
                                                   {
                                                       Name = "Salmon",
                                                       Price = 15.0M,
                                                       ShortDescription = "Smoked Salmon ",
                                                       Category = Categories["Smoked Fish"],
                                                       ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXOsU1pg73GlJutb50yWP2wUj_f97AvhfrSFku1EfZC4j60UPbQ",
                                                       InStock = true,
                                                       IsPreferredDrink = true,
                                                       ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXOsU1pg73GlJutb50yWP2wUj_f97AvhfrSFku1EfZC4j60UPbQ"
                                                   },
                                                     new Products
                                                     {
                                                         Name = "Kpala",
                                                         Price = 10.0M,
                                                         ShortDescription = "Smoked Kpala",
                                                         Category = Categories["Smoked Fish"],
                                                         ImageUrl = "https://www.ghanadwaso.com/wp-content/uploads/2018/01/Odei-1pc-247x300.jpg",
                                                         InStock = true,
                                                         IsPreferredDrink = true,
                                                         ImageThumbnailUrl = "https://www.ghanadwaso.com/wp-content/uploads/2018/01/Odei-1pc-247x300.jpg"
                                                     },
                                                       new Products
                                                       {
                                                           Name = "Catfish",
                                                           Price = 15.0M,
                                                           ShortDescription = "Smoked Catfish",
                                                           Category = Categories["Smoked Fish"],
                                                           ImageUrl = "http://www.smallstarter.com/wp-content/uploads/2013/02/Dried_and_smoked_fish_export_5.jpg",
                                                           InStock = true,
                                                           IsPreferredDrink = false,
                                                           ImageThumbnailUrl = "http://www.smallstarter.com/wp-content/uploads/2013/02/Dried_and_smoked_fish_export_5.jpg"
                                                       },
                                                         new Products
                                                         {
                                                             Name = "Mudfish",
                                                             Price = 10.0M,
                                                             ShortDescription = "Smoked Mudfish",
                                                             Category = Categories["Smoked Fish"],
                                                             ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQklDH0zqhaGWzBua94NpIHuDBEOOHCiSnZILroC_4mSiAu1hQJjQ",
                                                             InStock = true,
                                                             IsPreferredDrink = true,
                                                             ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQklDH0zqhaGWzBua94NpIHuDBEOOHCiSnZILroC_4mSiAu1hQJjQ"
                                                         },
                                                           new Products
                                                           {
                                                               Name = "Cassava Fish, ",
                                                               Price = 10.0M,
                                                               ShortDescription = "Smoked Cassava Fish ",
                                                               Category = Categories["Smoked Fish"],
                                                               ImageUrl = "https://www.opusdandies.com/wp-content/uploads/2017/03/titus_smoked_1.jpg",
                                                               InStock = true,
                                                               IsPreferredDrink = false,
                                                               ImageThumbnailUrl = "https://www.opusdandies.com/wp-content/uploads/2017/03/titus_smoked_1.jpg"
                                                           },
                                                            new Products
                                                            {
                                                                Name = "Tuna, ",
                                                                Price = 10.0M,
                                                                ShortDescription = "Smoked Tuna ",
                                                                Category = Categories["Smoked Fish"],
                                                                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQR7Urbo72BAHxfqCYQYYmqqXyZ-lsswtBhg7Uwz4s_yquVPWaP",
                                                                InStock = true,
                                                                IsPreferredDrink = false,
                                                                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQR7Urbo72BAHxfqCYQYYmqqXyZ-lsswtBhg7Uwz4s_yquVPWaP"
                                                            }


                    );
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fresh Fish", Description="Tilapia, Salmon, Emule, Kpala, Catfish, Mudfish, Amani, Cassava Fish, others" },
                        new Category { CategoryName = "Smoked Fish", Description="Tilapia, Salmon, Emule, Kpala, Catfish, Mudfish, Cassava fish, Amani, Tuna, others" },
                        new Category { CategoryName = "Dried / Fried Fish", Description="Salted fish (Koobi), Kako, Momoni, Salted Beef, Tilapia, One man thousand, Keta School boys, others" },
                        new Category { CategoryName = "Meat", Description="Cow meat, Goat meat, sheep meat, pork, pork feet, Chicken wings, chicken thighs (hard or soft), Cow feet, Hide(Wele), Cow face, cow sausage, chicken sausage, gizzard, snails, crabs, lobster, shrimps, Akrantie, Okusie,  others" },
                         new Category { CategoryName = "Tubers", Description="Water Yam, Pona, cocoyam, sweet potato, Cassava, Apentu, Riped Plantain, Oni Aba others" },
                        new Category { CategoryName = "Vegetables", Description="Tomato, Onions, Cucumber, carrot, Green pepper, spring onion, shallots, French beans, red pepper,  Cabbage, Kontomire, Garden Eggs, Turkish berries, Lettuce, Spinach, Okro, Ademe, Da-wa-da, mushrooms, garlic, Others " },
                        new Category { CategoryName = "Cereal", Description="Rice, Maize, Millet, Beans (specify), Gari, Tapioka, soybeans, " },
                        new Category { CategoryName = "Groceries", Description="	Tomato Paste, Milk, Sugar (Brown or white,cube or..specify), sardine, Milo, Powdered milk, Mostquito repellents, Oats, Indomie, Spaghetti, Canned fish, Coffee,Lipton, Shito, Baked beans, Blueband margarine, Soaps(specify – bathing or washing), cooking oils (specify), toothbrush, toothpaste, others" },
                        new Category { CategoryName = "Fruits", Description="Mango(specify), Banana, Avocado Pear, Grapes, Apple, Pineapple, orange, lemon, lime, Pawpaw, strawberries, black berries, guava, Others" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }

        }
    }
}
