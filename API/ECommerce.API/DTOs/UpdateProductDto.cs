namespace ECommerce.API.DTOs;

public record UpdateProductDto(
    int Id,
    string Name,
    string? Description,
    decimal Price,
    string? ImageUrl,
    int Stock,
    bool IsActive);