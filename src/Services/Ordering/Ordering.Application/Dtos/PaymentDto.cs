namespace Ordering.Application.Dtos
{
    public record PaymentDto(
        string CardName,
        string CarNumber,
        string Expiration,
        string Cvv,
        int PaymentMethod);
}