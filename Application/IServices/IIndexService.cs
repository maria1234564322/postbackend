using Application.Dto;
using DataAccess.Entities;
using System.IO;

namespace Application.IServices
{
    public interface IIndexService
    {
        void Create(CreateIndexDto index);
        void Update(IndexDto indexDto);
        void Delete(int id);
        int FindIndex(FindIndexDto index);
        IndexDto Get(long id);
        List<IndexDto> GetAll();
        List<IndexDto> Search(string district, string region, string city, string street, string numberStreet);
       
    }
}
