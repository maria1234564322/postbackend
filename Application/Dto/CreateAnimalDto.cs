using Common;

namespace Application.Dto;

public class CreateAnimalDto
{
    public bool Feed { get; set; }
    public string Notes { get; set; }
    public AnimalType AnimalTyp { get; set; }
}

