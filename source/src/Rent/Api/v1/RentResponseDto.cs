using CarRent.Rent.Domain;

namespace CarRent.Rent.Api.v1
{
    public class RentResponseDto
    {
        public Guid Id { get; set; }
        public Guid Customer { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }

        public RentResponseDto() { }
    }
}
