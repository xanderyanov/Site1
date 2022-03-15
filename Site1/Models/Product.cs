using MongoDB.Bson;

namespace Site1.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        
        public long ProductID { get; set; }

        public bool ShowOnMainPage { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        //public string Category { get; set; }

    }
}
