using issue_tracker.Models;

namespace issue_tracker.DataAccess.Repository.IRepository
    {
    public interface ICompanyRepository : IGenericRepository<Company>
        {
        Task<Company> ProjectListByCompanyId(int id);
        }
    }