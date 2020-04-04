using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Models
{
    public static class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context = applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Products.Any())
            {
                context.AddRange
             (
                //new List<Product
                new Product
                {
                    Name = "OPEN AQUARIUM",
                    Description = "Open Aquarium with hanging lighting",
                    InStock = true,
                    IsPrefferedProduct = true,
                    Price = 105.22M,
                    ImagePath = "https://i.pinimg.com/originals/86/53/6e/86536eae38caf70e29ef7a46f5d3d1a9.jpg",
                    Category = Categories["Aquarium"]
                },

                new Product
                {
                    Name = "AQUARIUM WITH COVER",
                    Description = "Indoor Aquarium with lid containing lighting",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 120.5M,
                    ImagePath = "https://images-na.ssl-images-amazon.com/images/I/81zvlOIT5nL._AC_SX569_.jpg",
                    Category = Categories["Aquarium"]
                },
                new Product
                {
                    Name = "ROUNDED AQUARIUM",
                    Description = "Aquarium with rounded front, open or closed variant",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 180.7M,
                    ImagePath = "https://img.alicdn.com/imgextra/i4/656008166/O1CN01AEThoT2AC4kag5X7J_!!656008166.jpg",
                    Category = Categories["Aquarium"]
                },
                new Product
                {
                    Name = "3D AQUARIUM",
                    Description = "Aquarium with 3D background",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 220.3M,
                    ImagePath = "https://i.ytimg.com/vi/fCBqpfNL6iU/maxresdefault.jpg",
                    Category = Categories["Aquarium"]
                },
                new Product
                {
                    Name = "PARACHEIRODON INNESI",
                    Description = "Blue neon is one of the favorite types of aquarium fish. " +
                                  "This small flock fish can also be settled in small aquariums, " +
                                  "it is not demanding and is suitable for beginners in aquarium.",
                    InStock = true,
                    IsPrefferedProduct = true,
                    Price = 1.5M,
                    ImagePath = "https://4.imimg.com/data4/AP/HY/ANDROID-4075233/product-500x500.jpeg",
                    Category = Categories["Fish"]
                },
                new Product
                {
                    Name = "GUPI",
                    Description = "Gupi is an aquarium fish that can be easily acclimated. " +
                                  "It lives in a habitat in waters where the temperature is 24 to 26 degrees Fahrenheit " +
                                  "but in our country it lives at much lower temperatures, " +
                                  "the lowest temperature at which the goiter lived +4 degrees Fahrenheit.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 1.2M,
                    ImagePath = "https://ae01.alicdn.com/kf/HTB1jFTbKVXXXXalXXXXq6xXFXXXW/Green-Orange-Aquarium-Artificial-Fish-Float-In-Water-Simuliated-Fake-Fish-For-Aquarium-Fish-Tank-Decoration.jpg",
                    Category = Categories["Fish"]
                },
                new Product
                {
                    Name = "ELECTRIC BLUE RAMIREZ",
                    Description = "Mikrogeophagus ramirezi-Ramirez,sa razlogom je jedna od najomiljenijih vrsta ribica " +
                                  "u akvarijumima domaćih akvarista koji su prihvatili drugi deo latinskog naziva " +
                                  "kao domaći naziv za ovu ribu.",
                    InStock = false,
                    IsPrefferedProduct = false,
                    Price = 2.0M,
                    ImagePath = "https://epond.eu/wp-content/uploads/2019/12/Mikrogeophagus-ramirezi-SUPER-NEON-BLUE.jpg",
                    Category = Categories["Fish"]
                },
                new Product
                {
                    Name = "DISKUS",
                    Description = "Royal Neonfish is probably the most represented fish in the aquariums of both domestic and worldwide aquarists. " +
                                  "The popularity of this small flock has not waned for almost a century, " +
                                  "while interest in most other species has changed over time.",
                    InStock = true,
                    IsPrefferedProduct = true,
                    Price = 1.8M,
                    ImagePath = "https://previews.123rf.com/images/boedefeld/boedefeld1912/boedefeld191200318/135328851-discus-fish-in-the-group-in-the-aquarium.jpg",
                    Category = Categories["Fish"]
                },

                new Product
                {
                    Name = "INPAICHTHYS KERRI",
                    Description = "The keri tetra is the only species of its kind, sometimes referred to as the blue royal tetra. " +
                                  "These are peaceful and small fish that do not need a large aquarium.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 1.8M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQLdWL43_tI1sigd4zFo5H951_9VEfhEUlN9dV1agHmtL_ikbpP",
                    Category = Categories["Fish"]
                },
                new Product
                {
                    Name = "RHODOSTOMUS",
                    Description = "Rhodostomus is one of the most favorite species of small haracin, " +
                                  "a peaceful flock species that adorns many aquariums",
                    InStock = true,
                    IsPrefferedProduct = true,
                    Price = 1.9M,
                    ImagePath = "https://htgetrid.com/assets/uploads/2018/06/rodostomus.jpg",
                    Category = Categories["Fish"]
                },
                new Product
                {
                    Name = "VESICULARIA DUBYANA",
                    Description = "Originally from Brazil, this moss was given its 'Christmas' nickname thanks to the specific structure of its flanks that resemble tree twigs. " +
                                  "Ideally, it reaches a height of 1-3cm, grows slowly but is easily attached to rocks or other decoration inside the aquarium. " +
                                  "As it grows in width, it needs to be occasionally cropped to maintain its attractiveness.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 4.8M,
                    ImagePath = "https://cdn11.bigcommerce.com/s-960dd/images/stencil/2048x2048/products/1325/4841/vesiculariadubyanachristmastc2__96016.1544726751.jpg?c=2",
                    Category = Categories["Plant"]
                },
                new Product
                {
                    Name = "ROTALA WALLICHII",
                    Description = "Rotala wallichii originates in Southeast Asia and is one of the most demanding aquarium plants that need to provide adequate light intensity. " +
                                  "Its thick, needle-like leaves of reddish color are best suited to soft slightly acidic water with a temperature range of 18-28c, " +
                                  "and the addition of CO2 is a must if you want this fast growing plant to decorate your aquarium.",
                    InStock = true,
                    IsPrefferedProduct = true,
                    Price = 4.5M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTexNR_kmDfEI8O5WThz4RdxK_0OgHnHY6q0YAslJQuFyV_bqO5",
                    Category = Categories["Plant"]
                },
                new Product
                {
                    Name = "POGOSTEMON HELFERI",
                    Description = "Pogostemon helferi svoje poreklo vodi sa Tajlanda. S obzirom na to da u idealnim uslovima doseže svega 5-10cm visine " +
                                  "(i širine) jasno je zbog čega su joj akvaristi nadenuli nadimak – „mala zvezda“. " +
                                  "Ova neobična akvarijumska biljka, kompaktnog oblika sa okruglastim listovima jarko zelene boje, idealna je za formiranje impresivnog tepiha unutar akvarijuma.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 4.9M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTesIaroEnNcHZxFjBFlqqK095qPkMMQ4KiOmhnipTufecEZnq5",
                    Category = Categories["Plant"]
                },
                new Product
                {
                    Name = "LUDWIGIA REPENS ‘RUBIN’",
                    Description = "Ludwigia repens 'Rubin' originates from North America and is most recognizable for its burgundy leaves " +
                                  "and stems that can grow 20-50 cm tall and 4-6 cm wide. Because of its specific color, it is ideal for creating" +
                                  " a colorful image inside an aquarium and is usually recommended to be planted in groups as groups.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 3.8M,
                    ImagePath = "https://www.akvasvet.org/wp-content/uploads/2017/05/ludwigia-rubin-2.jpg",
                    Category = Categories["Plant"]
                },
                new Product
                {
                    Name = "ATMAN PUMP",
                    Description = "Atman aquarium water circulation pump - AT-101, AT-102, AT-103",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 22.2M,
                    ImagePath = "https://ae01.alicdn.com/kf/HTB1QDnaLXXXXXXeXFXXq6xXFXXXg/222016714/HTB1QDnaLXXXXXXeXFXXq6xXFXXXg.jpg",
                    Category = Categories["Equipment"]
                },
                new Product
                {
                    Name = "ATMAN AIR PUMP",
                    Description = "Atman air pump for aquarium - AT-301, AT-302 and AT-303",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 20.7M,
                    ImagePath = "https://cf.shopee.com.my/file/7051b5159288e624785d93a1f2221065",
                    Category = Categories["Equipment"]
                },
                new Product
                {
                    Name = "HEATERS",
                    Description = "Heaters for aquarium of 50w, 100w and 200w",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 20.7M,
                    ImagePath = "https://img.alicdn.com/imgextra/i4/2358519606/TB2dofyfFXXXXcXXpXXXXXXXXXX_!!2358519606.jpg",
                    Category = Categories["Equipment"]
                },
                new Product
                {
                    Name = "REEF",
                    InStock = false,
                    IsPrefferedProduct = true,
                    Price = 800.0M,
                    ImagePath = "https://i.ytimg.com/vi/ftDfetGSsPM/maxresdefault.jpg",
                    Category = Categories["Reef"]
                },
                new Product
                {
                    Name = "REEF",
                    InStock = false,
                    IsPrefferedProduct = false,
                    Price = 900.0M,
                    ImagePath = "https://cdn.shopify.com/s/files/1/1044/6774/articles/Nano_Reef_Tank_FTS_for_Site_600x.png?v=1466534409",
                    Category = Categories["Reef"]
                }
            );
            }

            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "Aquarium", Description="All types of Aquariums"},
                        new Category{CategoryName = "Fish", Description="All types of Fish"},
                        new Category{CategoryName = "Plant", Description="All types of Plant"},
                        new Category{CategoryName = "Equipment", Description="All types of Equipment"},
                        new Category{CategoryName = "Reef", Description="All types of Reef"}
                    };
                    categories = new Dictionary<string, Category>();

                    foreach (var v in list)
                    {
                        categories.Add(v.CategoryName, v);
                    }
                }
                return categories;
            }

        }
    }
}

