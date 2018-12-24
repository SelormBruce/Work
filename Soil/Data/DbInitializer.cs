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
                            IsPreferredDrink = false,
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
                             IsPreferredDrink = false,
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
                              IsPreferredDrink = false,
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
                                IsPreferredDrink = false,
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
                                   IsPreferredDrink = false,
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
                                    IsPreferredDrink = false,
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
                                     IsPreferredDrink = false,
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
                                      IsPreferredDrink = false,
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
                                       IsPreferredDrink = false,
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
                                        IsPreferredDrink = false,
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
                                         IsPreferredDrink = false,
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
                                          IsPreferredDrink = false,
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
                                           IsPreferredDrink = false,
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
                                            IsPreferredDrink = false,
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
                                             IsPreferredDrink = false,
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
                                              IsPreferredDrink = false,
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
                                                IsPreferredDrink = false,
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
                                                  IsPreferredDrink = false,
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
                                                       IsPreferredDrink = false,
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
                                                         IsPreferredDrink = false,
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
                                                             IsPreferredDrink = false,
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
                                                                 IsPreferredDrink = false,
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
                                                         IsPreferredDrink = false,
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
                                                             IsPreferredDrink = false,
                                                             ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQklDH0zqhaGWzBua94NpIHuDBEOOHCiSnZILroC_4mSiAu1hQJjQ"
                                                         },
                                                           new Products
                                                           {
                                                               Name = "Cassava Fish",
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
                                                                Name = "Tuna",
                                                                Price = 10.0M,
                                                                ShortDescription = "Smoked Tuna ",
                                                                Category = Categories["Smoked Fish"],
                                                                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQR7Urbo72BAHxfqCYQYYmqqXyZ-lsswtBhg7Uwz4s_yquVPWaP",
                                                                InStock = true,
                                                                IsPreferredDrink = false,
                                                                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQR7Urbo72BAHxfqCYQYYmqqXyZ-lsswtBhg7Uwz4s_yquVPWaP"
                                                            },
                                                            // fruits

                     new Products
                     {
                         Name = "Mango",
                         Price = 10.0M,
                         ShortDescription = "Alphonso mango",
                         Category = Categories["Fruits"],
                         ImageUrl = "http://www.mangohapus.com/wp-content/uploads/2017/03/hapus_golden-min.jpg",
                         InStock = true,
                         IsPreferredDrink = false,
                         ImageThumbnailUrl = "http://www.mangohapus.com/wp-content/uploads/2017/03/hapus_golden-min.jpg"
                     },
                        new Products
                        {
                            Name = "Mango",
                            Price = 10.0M,
                            ShortDescription = "Ataulfo mango",
                            Category = Categories["Fruits"],
                            ImageUrl = "https://d2lnr5mha7bycj.cloudfront.net/product-image/file/large_c9225157-bf64-48a0-9db5-9ede39c2e429.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://d2lnr5mha7bycj.cloudfront.net/product-image/file/large_c9225157-bf64-48a0-9db5-9ede39c2e429.jpg"
                        },
                           new Products
                           {
                               Name = "Mango",
                               Price = 10.0M,
                               ShortDescription = "Francis mango",
                               Category = Categories["Fruits"],
                               ImageUrl = "https://www.humphreysfarm.com/ProductCart/pc/catalog/9421E-lg.jpg",
                               InStock = true,
                               IsPreferredDrink = false,
                               ImageThumbnailUrl = "https://www.humphreysfarm.com/ProductCart/pc/catalog/9421E-lg.jpg"
                           },
                              new Products
                              {
                                  Name = "Mango",
                                  Price = 10.0M,
                                  ShortDescription = "Haden mangoo",
                                  Category = Categories["Fruits"],
                                  ImageUrl = "https://www.fruttaweb.com/8989-large_default/fresh-kent-mango.jpg",
                                  InStock = true,
                                  IsPreferredDrink = false,
                                  ImageThumbnailUrl = "https://www.fruttaweb.com/8989-large_default/fresh-kent-mango.jpg"
                              },
                                 new Products
                                 {
                                     Name = "Mango",
                                     Price = 10.0M,
                                     ShortDescription = "Keitt mango",
                                     Category = Categories["Fruits"],
                                     ImageUrl = "https://cdn3.volusion.com/kceqm.mleru/v/vspfiles/photos/713-2.jpg?1521734349g",
                                     InStock = true,
                                     IsPreferredDrink = false,
                                     ImageThumbnailUrl = "https://cdn3.volusion.com/kceqm.mleru/v/vspfiles/photos/713-2.jpg?1521734349g"
                                 },
                                    new Products
                                    {
                                        Name = "Mango",
                                        Price = 10.0M,
                                        ShortDescription = "Kent mango",
                                        Category = Categories["Fruits"],
                                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/21jivLJsAeL.jpg",
                                        InStock = true,
                                        IsPreferredDrink = false,
                                        ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/21jivLJsAeL.jpg"
                                    },
                                       new Products
                                       {
                                           Name = "Mango",
                                           Price = 10.0M,
                                           ShortDescription = "Tommy Atkins mango",
                                           Category = Categories["Fruits"],
                                           ImageUrl = "https://i.ytimg.com/vi/dwr_X0aaTLI/hqdefault.jpg",
                                           InStock = true,
                                           IsPreferredDrink = false,
                                           ImageThumbnailUrl = "https://i.ytimg.com/vi/dwr_X0aaTLI/hqdefault.jpg"
                                       },
                                          new Products
                                          {
                                              Name = "Mango",
                                              Price = 10.0M,
                                              ShortDescription = "Valencia Pride",
                                              Category = Categories["Fruits"],
                                              ImageUrl = "https://www.specialtyproduce.com/sppics/9833.pngg",
                                              InStock = true,
                                              IsPreferredDrink = false,
                                              ImageThumbnailUrl = "https://www.specialtyproduce.com/sppics/9833.png"
                                          },
                                             new Products
                                             {
                                                 Name = "Mango",
                                                 Price = 10.0M,
                                                 ShortDescription = "Glenn mango",
                                                 Category = Categories["Fruits"],
                                                 ImageUrl = "http://2.bp.blogspot.com/-U3bFFAjaZ1k/UmyPDFleAqI/AAAAAAAAJTY/Xu0Up3nVG68/s1600/ROB_9062.jpg",
                                                 InStock = true,
                                                 IsPreferredDrink = false,
                                                 ImageThumbnailUrl = "http://2.bp.blogspot.com/-U3bFFAjaZ1k/UmyPDFleAqI/AAAAAAAAJTY/Xu0Up3nVG68/s1600/ROB_9062.jpg"
                                             },
                                                new Products
                                                {
                                                    Name = "Banana",
                                                    Price = 10.0M,
                                                    ShortDescription = "Fresh Banana",
                                                    Category = Categories["Fruits"],
                                                    ImageUrl = "https://img.purch.com/rc/300x200/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA2NS8xNDkvb3JpZ2luYWwvYmFuYW5hcy5qcGc=",
                                                    InStock = true,
                                                    IsPreferredDrink = false,
                                                    ImageThumbnailUrl = "https://img.purch.com/rc/300x200/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA2NS8xNDkvb3JpZ2luYWwvYmFuYW5hcy5qcGc="
                                                },
                                                   new Products
                                                   {
                                                       Name = "Avocado Pear",
                                                       Price = 10.0M,
                                                       ShortDescription = "Fresh Avocado Pear",
                                                       Category = Categories["Fruits"],
                                                       ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOjQqnYclpJVehTc4SrzYj7eJ1p8q1-5YeUGVCFh1ZbNozL2m",
                                                       InStock = true,
                                                       IsPreferredDrink = false,
                                                       ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOjQqnYclpJVehTc4SrzYj7eJ1p8q1-5YeUGVCFh1ZbNozL2m"
                                                   },
                                                      new Products
                                                      {
                                                          Name = "Grapes",
                                                          Price = 10.0M,
                                                          ShortDescription = "Fresh Grapes",
                                                          Category = Categories["Fruits"],
                                                          ImageUrl = "https://i5.walmartimages.ca/images/Enlarge/098/5_r/6000195440985_R.jpg",
                                                          InStock = true,
                                                          IsPreferredDrink = false,
                                                          ImageThumbnailUrl = "https://i5.walmartimages.ca/images/Enlarge/098/5_r/6000195440985_R.jpg"
                                                      },
                                                       new Products
                                                       {
                                                           Name = "Apple",
                                                           Price = 10.0M,
                                                           ShortDescription = " Fresh Apple",
                                                           Category = Categories["Fruits"],
                                                           ImageUrl = "https://www.sagefruit.com/wp-content/uploads/2016/08/our-fruit-apples-1.jpg",
                                                           InStock = true,
                                                           IsPreferredDrink = true,
                                                           ImageThumbnailUrl = "https://www.sagefruit.com/wp-content/uploads/2016/08/our-fruit-apples-1.jpg"
                                                       },
                                                        new Products
                                                        {
                                                            Name = "Pineapple",
                                                            Price = 10.0M,
                                                            ShortDescription = " Fresh Pineapple",
                                                            Category = Categories["Fruits"],
                                                            ImageUrl = "https://keelings.ie/wp-content/uploads/2016/04/pineapple-1.jpg",
                                                            InStock = true,
                                                            IsPreferredDrink = false,
                                                            ImageThumbnailUrl = "https://keelings.ie/wp-content/uploads/2016/04/pineapple-1.jpg"
                                                        },
                                                         new Products
                                                         {
                                                             Name = "orange",
                                                             Price = 10.0M,
                                                             ShortDescription = "Fresh orange",
                                                             Category = Categories["Fruits"],
                                                             ImageUrl = "https://www.photober.com/wp-content/uploads/2013/09/3sm.jpg",
                                                             InStock = true,
                                                             IsPreferredDrink = false,
                                                             ImageThumbnailUrl = "https://www.photober.com/wp-content/uploads/2013/09/3sm.jpg"
                                                         },
                                                          new Products
                                                          {
                                                              Name = "lemon",
                                                              Price = 10.0M,
                                                              ShortDescription = "Fresh lemon",
                                                              Category = Categories["Fruits"],
                                                              ImageUrl = "https://i.ytimg.com/vi/bjyOboaxvrk/hqdefault.jpg",
                                                              InStock = true,
                                                              IsPreferredDrink = false,
                                                              ImageThumbnailUrl = "https://i.ytimg.com/vi/bjyOboaxvrk/hqdefault.jpg"
                                                          },
                                                           new Products
                                                           {
                                                               Name = "Lime",
                                                               Price = 10.0M,
                                                               ShortDescription = "Frsh lime",
                                                               Category = Categories["Fruits"],
                                                               ImageUrl = "http://www.georgeperry.co.uk/images/P/GP_79432652_GP_XXL.jpg",
                                                               InStock = true,
                                                               IsPreferredDrink = false,
                                                               ImageThumbnailUrl = "http://www.georgeperry.co.uk/images/P/GP_79432652_GP_XXL.jpg"
                                                           },
                                                            new Products
                                                            {
                                                                Name = "Pawpaw",
                                                                Price = 10.0M,
                                                                ShortDescription = "Fresh Pawpaw",
                                                                Category = Categories["Fruits"],
                                                                ImageUrl = "https://5.imimg.com/data5/ST/LT/MY-37487333/fresh-papaya-fruit-500x500.jpg",
                                                                InStock = true,
                                                                IsPreferredDrink = false,
                                                                ImageThumbnailUrl = "https://5.imimg.com/data5/ST/LT/MY-37487333/fresh-papaya-fruit-500x500.jpg"
                                                            },
                                                             new Products
                                                             {
                                                                 Name = "Strawberries",
                                                                 Price = 10.0M,
                                                                 ShortDescription = "strawberries",
                                                                 Category = Categories["Fruits"],
                                                                 ImageUrl = "https://cdn1.medicalnewstoday.com/content/images/articles/271/271285/three-strawberries.jpg",
                                                                 InStock = true,
                                                                 IsPreferredDrink = false,
                                                                 ImageThumbnailUrl = "https://cdn1.medicalnewstoday.com/content/images/articles/271/271285/three-strawberries.jpg"
                                                             },
                                                              new Products
                                                              {
                                                                  Name = "Black Berries",
                                                                  Price = 10.0M,
                                                                  ShortDescription = "black berries",
                                                                  Category = Categories["Fruits"],
                                                                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIUp_iPi8MvkgTc9Fw-DsN7PA-WqvSkKXEdOfjnOnyH_b_uBB9",
                                                                  InStock = true,
                                                                  IsPreferredDrink = false,
                                                                  ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIUp_iPi8MvkgTc9Fw-DsN7PA-WqvSkKXEdOfjnOnyH_b_uBB9"
                                                              },
                                                               new Products
                                                               {
                                                                   Name = "Guava",
                                                                   Price = 10.0M,
                                                                   ShortDescription = "Guava",
                                                                   Category = Categories["Fruits"],
                                                                   ImageUrl = "https://i0.wp.com/minchinburyfruitmarket.com.au/wp-content/uploads/2017/05/Guava.jpg?fit=265%2C262&ssl=1",
                                                                   InStock = true,
                                                                   IsPreferredDrink = false,
                                                                   ImageThumbnailUrl = "https://i0.wp.com/minchinburyfruitmarket.com.au/wp-content/uploads/2017/05/Guava.jpg?fit=265%2C262&ssl=1"
                                                               },

                                                                 // Cereals


                                                                 new Products
                                                                 {
                                                                     Name = "Rice",
                                                                     Price = 10.0M,
                                                                     ShortDescription = "Perfume Rice",
                                                                     Category = Categories["Cereal"],
                                                                     ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmkkeuuHeZ_6fQ1B4Ie3rpY9I70-eraFRvuiVLmooiKuQGBRuZBw",
                                                                     InStock = true,
                                                                     IsPreferredDrink = false,
                                                                     ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmkkeuuHeZ_6fQ1B4Ie3rpY9I70-eraFRvuiVLmooiKuQGBRuZBw"
                                                                 },
                                                                   new Products
                                                                   {
                                                                       Name = "Rice",
                                                                       Price = 10.0M,
                                                                       ShortDescription = "Local Rice",
                                                                       Category = Categories["Cereal"],
                                                                       ImageUrl = "https://farmersdgt.com/wp-content/uploads/2018/02/Bag-of-rice-1200x630.jpg",
                                                                       InStock = true,
                                                                       IsPreferredDrink = false,
                                                                       ImageThumbnailUrl = "https://farmersdgt.com/wp-content/uploads/2018/02/Bag-of-rice-1200x630.jpg"
                                                                   },
                                                                     new Products
                                                                     {
                                                                         Name = "Corn",
                                                                         Price = 10.0M,
                                                                         ShortDescription = "Fresh Corn",
                                                                         Category = Categories["Cereal"],
                                                                         ImageUrl = "https://leadership.ng/wp-content/uploads/2018/11/maize-prefered.jpg",
                                                                         InStock = true,
                                                                         IsPreferredDrink = false,
                                                                         ImageThumbnailUrl = "https://leadership.ng/wp-content/uploads/2018/11/maize-prefered.jpg"
                                                                     },
                                                                       new Products
                                                                       {
                                                                           Name = "Maize",
                                                                           Price = 10.0M,
                                                                           ShortDescription = "Maize",
                                                                           Category = Categories["Cereal"],
                                                                           ImageUrl = "http://www.shipfrombrazil.com/wp-content/uploads/2018/04/animal-feed-yellow-corn.jpg",
                                                                           InStock = true,
                                                                           IsPreferredDrink = false,
                                                                           ImageThumbnailUrl = "http://www.shipfrombrazil.com/wp-content/uploads/2018/04/animal-feed-yellow-corn.jpg"
                                                                       },
                                                                         new Products
                                                                         {
                                                                             Name = "Millet",
                                                                             Price = 10.0M,
                                                                             ShortDescription = "Millet",
                                                                             Category = Categories["Cereal"],
                                                                             ImageUrl = "https://5.imimg.com/data5/NY/WT/MY-38873162/pearl-millet-500x500.jpg",
                                                                             InStock = true,
                                                                             IsPreferredDrink = false,
                                                                             ImageThumbnailUrl = "https://5.imimg.com/data5/NY/WT/MY-38873162/pearl-millet-500x500.jpg"
                                                                         },
                                                                           new Products
                                                                           {
                                                                               Name = "Beans",
                                                                               Price = 10.0M,
                                                                               ShortDescription = "Beans",
                                                                               Category = Categories["Cereal"],
                                                                               ImageUrl = "https://nuts.com/images/auto/510x340/assets/9e84f4aa12cacfde.jpg",
                                                                               InStock = true,
                                                                               IsPreferredDrink = false,
                                                                               ImageThumbnailUrl = "https://nuts.com/images/auto/510x340/assets/9e84f4aa12cacfde.jpg"
                                                                           },
                                                                             new Products
                                                                             {
                                                                                 Name = "Gari",
                                                                                 Price = 10.0M,
                                                                                 ShortDescription = "Gari",
                                                                                 Category = Categories["Cereal"],
                                                                                 ImageUrl = "https://i2.wp.com/www.habanaija.com/wp-content/uploads/2013/03/bowlofgari.jpg",
                                                                                 InStock = true,
                                                                                 IsPreferredDrink = false,
                                                                                 ImageThumbnailUrl = "https://i2.wp.com/www.habanaija.com/wp-content/uploads/2013/03/bowlofgari.jpg"
                                                                             },
                                                                               new Products
                                                                               {
                                                                                   Name = "Tapioka",
                                                                                   Price = 10.0M,
                                                                                   ShortDescription = "Tapioka",
                                                                                   Category = Categories["Cereal"],
                                                                                   ImageUrl = "http://www.wiecejnizzdrowie.pl/wp-content/uploads/bigstock-White-Tapioca-Pearls-sierpniowka.jpg",
                                                                                   InStock = true,
                                                                                   IsPreferredDrink = false,
                                                                                   ImageThumbnailUrl = "http://www.wiecejnizzdrowie.pl/wp-content/uploads/bigstock-White-Tapioca-Pearls-sierpniowka.jpg"
                                                                               },
                                                                                 new Products
                                                                                 {
                                                                                     Name = "Soybeans",
                                                                                     Price = 10.0M,
                                                                                     ShortDescription = "Soybeans",
                                                                                     Category = Categories["Cereal"],
                                                                                     ImageUrl = "https://www.dsmenu.com/user-folder/images/2/2375/1485864397-2375.png",
                                                                                     InStock = true,
                                                                                     IsPreferredDrink = false,
                                                                                     ImageThumbnailUrl = "https://www.dsmenu.com/user-folder/images/2/2375/1485864397-2375.png"
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
