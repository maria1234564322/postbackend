
using DataAccess.Entities;

namespace DataAccess.Repostories.DbIndexs;

public interface IIndexRepository : IRepository<DataAccess.Entities.DbIndex>
{
    List<Entities.DbIndex> Search(string district, string region, string city, string street, string numberStreet);
    DbIndex FindByUniqueFields(string district, string region, string city, string street, string numberStreet);
    DbIndex GetById(long id);
}

