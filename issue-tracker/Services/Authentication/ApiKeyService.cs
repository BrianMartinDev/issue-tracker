using issue_tracker.DataAccess;
using issue_tracker.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;

namespace issue_tracker.Services.Authentication
    {
    public class ApiKeyService
        {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ApiKeyService(ApplicationDbContext context, IUnitOfWork unitOfWork)
            {
            _context = context;
            _unitOfWork = unitOfWork;
            }

        public UserApiKey CreateApiKey(IdentityUser user)
            {
            var newGeneratedApiKey = new UserApiKey
                {
                User = user,
                Value = GenerateApiKeyValue(),
                };
            _context.UserApiKeys?.Add(newGeneratedApiKey);
            _context.SaveChanges();

            return newGeneratedApiKey;
            }

        private string GenerateApiKeyValue()
            {
            return $"{Guid.NewGuid().ToString()}-{Guid.NewGuid().ToString()}";
            }
        }
    }
