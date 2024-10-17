using DataAccess.Entities;


namespace Application.Dto;

public class CreateParcelDto
{
    public decimal EstimatedValue { get; set; }
    public string Description { get; set; }
    public decimal Remittancel { get; set; }
}
