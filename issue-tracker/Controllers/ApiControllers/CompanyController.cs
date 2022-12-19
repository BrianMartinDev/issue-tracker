using AutoMapper;
using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;
using issue_tracker.Models.DTO.Company;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
        {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<Company> _logger;
        private readonly IMapper _mapper;

        public CompanyController(IUnitOfWork unitOfWork, ILogger<Company> logger, IMapper mapper)
            {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            }

        // GET: api/Company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDTO>>> GetCompanyList()
            {
            try
                {
                var company = await _unitOfWork.CompanyRepository.GetAllAsync();
                var companyDto = _mapper.Map<IEnumerable<CompanyDTO>>(company);
                return Ok(companyDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CompanyController));
                return BadRequest(ex);
                }
            }

        // GET api/Company/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDTO>> Get(int id)
            {
            try
                {
                var company = await _unitOfWork.CompanyRepository.GetAsync(id);
                var companyDto = _mapper.Map<CompanyDTO>(company);
                return Ok(company);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CompanyController));
                return BadRequest(ex);
                }
            }

        // POST api/Company
        [HttpPost]
        public async Task<ActionResult<CreateCompanyDTO>> Create([FromBody] CreateCompanyDTO createCompanyDTO)
            {
            try
                {
                var company = _mapper.Map<Company>(createCompanyDTO);
                await _unitOfWork.CompanyRepository.CreateAsync(company);
                await _unitOfWork.CompletedAsync();
                return Ok(createCompanyDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CompanyController));
                return BadRequest(ex);
                }
            }

        // PUT api/Company/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateCompanyDTO>> Update(int id, [FromBody] UpdateCompanyDTO updateCompanyDTO)
            {
            try
                {
                if (id != updateCompanyDTO.Id)
                    {
                    return BadRequest(updateCompanyDTO);
                    }
                var updateCompanyDTOToCompany = _mapper.Map<Company>(updateCompanyDTO);
                var company = await _unitOfWork.CompanyRepository.UpdateAsync(updateCompanyDTOToCompany);
                await _unitOfWork.CompletedAsync();
                return Ok(company);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CompanyController));
                return BadRequest(ex);
                }
            }

        // DELETE api/Company/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<GetCompanyDTO>> Delete(int id, [FromBody] GetCompanyDTO deleteCompanyDTO)
            {
            try
                {
                if (id != deleteCompanyDTO.Id)
                    {
                    return BadRequest(deleteCompanyDTO);
                    }
                await _unitOfWork.CompanyRepository.Remove(id);
                await _unitOfWork.CompletedAsync();
                return Ok(deleteCompanyDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CompanyController));
                return BadRequest(ex);
                }
            }
        }
    }
