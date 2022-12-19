using AutoMapper;
using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;
using issue_tracker.Models.DTO.Issue;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
        {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<Issue> _logger;

        public IssueController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<Issue> logger)
            {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            }
        // GET: api/Issue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetIssueDTO>>> GetIssueList()
            {
            try
                {
                var issue = await _unitOfWork.IssueRepository.GetAllAsync();
                var issueDto = _mapper.Map<IEnumerable<GetIssueDTO>>(issue);
                return Ok(issueDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(IssueController));
                return BadRequest(ex);
                }
            }

        // GET api/Issue/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetIssueDTO>> Get(int id)
            {
            try
                {
                var issue = await _unitOfWork.IssueRepository.GetAsync(id);
                var issueDto = _mapper.Map<GetIssueDTO>(issue);
                return Ok(issueDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(IssueController));
                return BadRequest(ex);
                }
            }

        // POST api/Issue
        [HttpPost]
        public async Task<ActionResult<CreateIssueDTO>> Create([FromBody] CreateIssueDTO createIssueDTO)
            {
            try
                {
                if (createIssueDTO == null)
                    {
                    BadRequest();
                    }
                var issue = _mapper.Map<Issue>(createIssueDTO);
                await _unitOfWork.IssueRepository.CreateAsync(issue);
                await _unitOfWork.CompletedAsync();
                return Ok(createIssueDTO);

                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(IssueController));
                return BadRequest(ex);
                }
            }

        // PUT api/Issue/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateIssueDTO>> Update(int id, [FromBody] UpdateIssueDTO updateIssueDTO)
            {
            try
                {
                if (id != updateIssueDTO.Id)
                    {
                    return BadRequest(updateIssueDTO);
                    }
                var issue = _mapper.Map<Issue>(updateIssueDTO);
                await _unitOfWork.IssueRepository.UpdateAsync(issue);
                await _unitOfWork.CompletedAsync();
                return Ok(updateIssueDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(IssueController));
                return BadRequest(ex);
                }
            }

        // DELETE api/Issue/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<GetIssueDTO>> Delete(int id, [FromBody] GetIssueDTO getIssueDTO)
            {
            try
                {

                if (id != getIssueDTO.Id)
                    {
                    return BadRequest(getIssueDTO);
                    }
                await _unitOfWork.IssueRepository.Remove(id);
                await _unitOfWork.CompletedAsync();
                return Ok(getIssueDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(IssueController));
                return BadRequest(ex);
                }
            }
        }
    }
