using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();

        private readonly List<Product> prodList;
        public MockProductRepository()
        {
            prodList = new List<Product>()
            {
                new Product{
                    Name="OPEN AQUARIUM",
                    Description="Open Aquarium with hanging lighting",
                    InStock=true,
                    IsPrefferedProduct = true,
                    Price=105.22M,
                    ImagePath="~/Images/akvarijum.jpg",
                    Category = categoryRepository.GetCategories().First()
                },

                new Product
                {
                    Name="AQUARIUM WITH COVER",
                    Description="Indoor Aquarium with lid containing lighting",
                    InStock=true,
                    IsPrefferedProduct = false,
                    Price=120.5M,
                    ImagePath="https://images-na.ssl-images-amazon.com/images/I/81zvlOIT5nL._AC_SX569_.jpg",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "ROUNDED AQUARIUM",
                    Description="Aquarium with rounded front, open or closed variant",
                    InStock=true,
                    IsPrefferedProduct = false,
                    Price=180.7M,
                    ImagePath="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCyZ8dNFdVYkYDDWReC_85pGT4YSrXUDMovNgRNkwpYrdWzyspXw&s",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "3D AQUARIUM",
                    Description = "Aquarium with 3D background",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 220.3M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDPsKsgPJQJOiGfMDpriK57uk0uOoq5bt2xNoGTV8KIiZFxv4Lag&s",
                    Category = categoryRepository.GetCategories().First()
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
                    Category = categoryRepository.GetCategories().First()
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
                    ImagePath = "",
                   Category = categoryRepository.GetCategories().First()
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
                    ImagePath = "https://ae01.alicdn.com/kf/HTB1jFTbKVXXXXalXXXXq6xXFXXXW/Green-Orange-Aquarium-Artificial-Fish-Float-In-Water-Simuliated-Fake-Fish-For-Aquarium-Fish-Tank-Decoration.jpg",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "PARACHEIRODON AXELRODI",
                    Description = "Royal Neonfish is probably the most represented fish in the aquariums of both domestic and worldwide aquarists. " +
                                  "The popularity of this small flock has not waned for almost a century, " +
                                  "while interest in most other species has changed over time.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 1.8M,
                    ImagePath = "",
                    Category = categoryRepository.GetCategories().First()
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
                   Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "HEMIGRAMMUS RHODOSTOMUS ",
                    Description = "Rhodostomus is one of the most favorite species of small haracin, " +
                                  "a peaceful flock species that adorns many aquariums",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 1.9M,
                    ImagePath = "",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "VESICULARIA DUBYANA ‘CHRISTMAS’",
                    Description = "Originally from Brazil, this moss was given its 'Christmas' nickname thanks to the specific structure of its flanks that resemble tree twigs. " +
                                  "Ideally, it reaches a height of 1-3cm, grows slowly but is easily attached to rocks or other decoration inside the aquarium. " +
                                  "As it grows in width, it needs to be occasionally cropped to maintain its attractiveness.",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 4.8M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSGT4o2UedXj9dWDvX_1PKBsnokJkJLSNYdL9UhtOjgsodIHiwJ",
                    Category = categoryRepository.GetCategories().First()
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
                    Category = categoryRepository.GetCategories().First()
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
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "LUDWIGIA REPENS ‘RUBIN’",
                    Description = "Ludwigia repens 'Rubin' originates from North America and is most recognizable for its burgundy leaves " +
                                  "and stems that can grow 20-50 cm tall and 4-6 cm wide. Because of its specific color, it is ideal for creating" +
                                  " a colorful image inside an aquarium and is usually recommended to be planted in groups as groups.",
                    InStock = true,
                    IsPrefferedProduct =false,
                    Price = 3.8M,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRPPi8Ali_HxopZmchnUyDrDTn7SqUmSCXrQA7X3bzF-oSRzpG7",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "ATMAN PUMP",
                    Description = "Atman aquarium water circulation pump - AT-101, AT-102, AT-103",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 22.2M,
                    ImagePath = "https://ae01.alicdn.com/kf/HTB1QDnaLXXXXXXeXFXXq6xXFXXXg/222016714/HTB1QDnaLXXXXXXeXFXXq6xXFXXXg.jpg",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "ATMAN AIR PUMP",
                    Description = "Atman air pump for aquarium - AT-301, AT-302 and AT-303",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 20.7M,
                    ImagePath = "https://cf.shopee.com.my/file/7051b5159288e624785d93a1f2221065",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "HEATERS",
                    Description = "Heaters for aquarium of 50w, 100w and 200w",
                    InStock = true,
                    IsPrefferedProduct = false,
                    Price = 20.7M,
                    ImagePath = "https://img.alicdn.com/imgextra/i4/2358519606/TB2dofyfFXXXXcXXpXXXXXXXXXX_!!2358519606.jpg",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "REEF",
                    InStock = false,
                    IsPrefferedProduct = false,
                    Price = 800.0M,
                    ImagePath = "https://i.ytimg.com/vi/ftDfetGSsPM/maxresdefault.jpg",
                    Category = categoryRepository.GetCategories().First()
                },
                new Product
                {
                    Name = "REEF",
                    InStock = false,
                    IsPrefferedProduct = true,
                    Price = 900.0M,
                    ImagePath = "https://cdn.shopify.com/s/files/1/1044/6774/articles/Nano_Reef_Tank_FTS_for_Site_600x.png?v=1466534409",
                    Category = categoryRepository.GetCategories().First()
                }
            };
        }

        public IEnumerable<Product> PrefferedProducts { get; }

        public IEnumerable<Product> GetAllProducts()
        {
            return prodList;
        }

        public Product GetProductById(int id)
        {
            return prodList.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
