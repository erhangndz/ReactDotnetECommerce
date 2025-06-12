namespace ECommerce.API.DTOs
{
    public record CreateProductDto
    {
        public required string Name { get; init; }
        public string? Description { get; init; }
        public decimal Price { get; init; }
        public string? ImageUrl { get; init; }
        public int Stock { get; init; }
        public bool IsActive { get; init; }
    }
}
