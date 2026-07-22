namespace ODataServer.Models {
    static class SampleData {
        public static List<Product> Products = [
            new Product {
                Product_ID = 1,
                Product_Name = "HD Video Player",
                Product_Production_Start = new DateTime(2013, 10, 7, 16, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 225,
                Product_Cost = 110.00,
                Product_Sale_Price = 220.00,
                Product_Retail_Price = 330.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Video Players"
            },
            new Product {
                Product_ID = 2,
                Product_Name = "SuperHD Video Player",
                Product_Production_Start = new DateTime(2013, 12, 1, 0, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 150,
                Product_Cost = 175.00,
                Product_Sale_Price = 275.00,
                Product_Retail_Price = 400.00,
                Product_Consumer_Rating = 4,
                Product_Category = "Video Players"
            },
            new Product {
                Product_ID = 3,
                Product_Name = "SuperPlasma 50",
                Product_Production_Start = new DateTime(2005, 1, 10, 12, 45, 0),
                Product_Available = false,
                Product_Current_Inventory = 0,
                Product_Cost = 1100.00,
                Product_Sale_Price = 1800.00,
                Product_Retail_Price = 2400.00,
                Product_Consumer_Rating = 4.5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 4,
                Product_Name = "SuperLED 50",
                Product_Production_Start = new DateTime(2011, 10, 30, 8, 30, 0),
                Product_Available = true,
                Product_Current_Inventory = 77,
                Product_Cost = 775.00,
                Product_Sale_Price = 1100.00,
                Product_Retail_Price = 1600.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Televisions"
            },
            new Product {
                Product_ID = 5,
                Product_Name = "SuperLED 42",
                Product_Production_Start = new DateTime(2012, 9, 15, 8, 0, 0),
                Product_Available = true,
                Product_Current_Inventory = 445,
                Product_Cost = 675.00,
                Product_Sale_Price = 1050.00,
                Product_Retail_Price = 1450.00,
                Product_Consumer_Rating = 5,
                Product_Category = "Televisions"
            }
        ];
    }
}
