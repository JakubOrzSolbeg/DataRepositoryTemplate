using DataRepository.DbContext;
using DataRepository.Entities;
using DataRepository.Repositories.Interfaces;

namespace DataRepository.Repositories.Implementations;

public class DummyRepository : Repository<Dummy>
{
    public DummyRepository(MainDbContext1 mainDbContext) : base(mainDbContext)
    {
    }

    public override async Task<List<Dummy>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<Dummy?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override async Task<Dummy> Add(Dummy obj)
    {
        throw new NotImplementedException();
    }

    public override async Task<Dummy> Update(Dummy obj)
    {
        throw new NotImplementedException();
    }

    public override async Task<bool> Delete(Dummy obj)
    {
        throw new NotImplementedException();
    }
}