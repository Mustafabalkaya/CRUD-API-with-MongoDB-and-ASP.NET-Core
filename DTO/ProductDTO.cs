namespace API_CRUD_MongoDB.DTO
{
    public class ProductDTO
    {
        public string Name {get;set;} = null!;
        public decimal Price {get;set;}
        public int Stock {get;set;}
    }
}