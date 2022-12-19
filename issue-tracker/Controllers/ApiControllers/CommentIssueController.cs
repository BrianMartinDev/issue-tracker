using AutoMapper;
using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models.DTO.CommentIssue;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class CommentIssueController : ControllerBase
        {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CommentIssue> _logger;
        private readonly IMapper _mapper;

        public CommentIssueController(IUnitOfWork unitOfWork, ILogger<CommentIssue> logger, IMapper mapper)
            {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            }
        // GET: api/CommentIssue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCommentIssueDTO>>> GetCommentIssueList()
            {
            try
                {
                var issueComment = await _unitOfWork.CommentIssueRepository.GetAllAsync();
                var issueCommentDto = _mapper.Map<IEnumerable<GetCommentIssueDTO>>(issueComment);
                return Ok(issueCommentDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentIssueController));
                return BadRequest(ex);
                }

            }

        // GET api/CommentIssue/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCommentIssueDTO>> Get(int id)
            {
            try
                {
                var issueComment = await _unitOfWork.CommentIssueRepository.GetAsync(id);
                var issueCommentDto = _mapper.Map<GetCommentIssueDTO>(issueComment);
                return Ok(issueCommentDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentIssueController));
                return BadRequest(ex);
                }
            }

        // POST api/CommentIssue
        [HttpPost]
        public async Task<ActionResult<CreateCommentIssueDTO>> Create([FromBody] CreateCommentIssueDTO createCommentIssueDTO)
            {
            try
                {
                if (createCommentIssueDTO == null)
                    {
                    BadRequest();
                    }
                var issueComment = _mapper.Map<CommentIssue>(createCommentIssueDTO);
                await _unitOfWork.CommentIssueRepository.CreateAsync(issueComment);
                await _unitOfWork.CompletedAsync();
                return Ok(createCommentIssueDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentIssueController));
                return BadRequest(ex);
                }
            }

        // PUT api/CommentIssue/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateCommentIssueDTO>> Update(int id, [FromBody] UpdateCommentIssueDTO updateCommentIssueDTO)
            {
            try
                {
                var commentIssue = _mapper.Map<CommentIssue>(updateCommentIssueDTO);
                await _unitOfWork.CommentIssueRepository.UpdateAsync(commentIssue);
                await _unitOfWork.CompletedAsync();
                return Ok(updateCommentIssueDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentIssueController));
                return BadRequest(ex);
                }
            }

        // DELETE api/CommentIssue/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<GetCommentIssueDTO>> Delete(int id, [FromBody] GetCommentIssueDTO getCommentIssueDTO)
            {
            try
                {
                if (id != getCommentIssueDTO.Id)
                    {
                    _logger.LogError("{Controller} All function error", typeof(CommentIssueController));
                    BadRequest();
                    }
                await _unitOfWork.CommentIssueRepository.Remove(id);
                await _unitOfWork.CompletedAsync();
                return Ok(getCommentIssueDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentIssueController));
                return BadRequest(ex);
                }
            }
        }
    }
