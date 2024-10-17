namespace Application.Dto;

public class CreateClientDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string MiddleName { get; set; }
    public string Phone { get; set; }
    public bool IsRegistered { get; set; }

}
