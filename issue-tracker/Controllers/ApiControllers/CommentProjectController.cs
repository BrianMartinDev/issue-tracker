using AutoMapper;
using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models.DTO.CommentIssue;
using issue_tracker.Models.DTO.CommentProject;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class CommentProjectController : ControllerBase
        {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CommentIssue> _logger;
        private readonly IMapper _mapper;

        public CommentProjectController(IUnitOfWork unitOfWork, ILogger<CommentIssue> logger, IMapper mapper)
            {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            }
        // GET: api/CommentProject
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentProjectDTO>>> GetCommentProjectList()
            {
            try
                {
                var commentProject = await _unitOfWork.CommentProjectRepository.GetAllAsync();
                var commentProjectDto = _mapper.Map<CommentProjectDTO>(commentProject);

                return Ok(commentProjectDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentProjectController));
                return BadRequest(ex);
                }
            }

        // GET api/CommentProject/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCommentProjectDTO>> Get(int id)
            {
            try
                {
                var commentProject = await _unitOfWork.CommentProjectRepository.GetAsync(id);
                var commentProjectDto = _mapper.Map<GetCommentProjectDTO>(commentProject);
                return Ok(commentProject);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentProjectController));
                return BadRequest(ex);
                }
            }

        // POST api/CommentProject
        [HttpPost]
        public async Task<ActionResult<CreateCommentProjectDTO>> Create([FromBody] CreateCommentProjectDTO createCommentProjectDTO)
            {
            try
                {
                if (createCommentProjectDTO == null)
                    {
                    BadRequest();
                    }
                var commentproject = _mapper.Map<CommentProject>(createCommentProjectDTO);
                await _unitOfWork.CommentProjectRepository.CreateAsync(commentproject);
                await _unitOfWork.CompletedAsync();
                return Ok(createCommentProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentProjectController));
                return BadRequest(ex);
                }
            }

        // PUT api/CommentProject/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateCommentProjectDTO>> Update(int id, [FromBody] UpdateCommentProjectDTO updateCommentProjectDTO)
            {
            try
                {
                var commentProject = _mapper.Map<CommentProject>(updateCommentProjectDTO);
                await _unitOfWork.CommentProjectRepository.UpdateAsync(commentProject);
                await _unitOfWork.CompletedAsync();
                return Ok(updateCommentProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentProjectController));
                return BadRequest(ex);
                }
            }

        // DELETE api/CommentProject/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<GetCommentProjectDTO>> Delete(int id, [FromBody] GetCommentIssueDTO getCommentProjectDTO)
            {
            try
                {
                if (id != getCommentProjectDTO.Id)
                    {
                    _logger.LogError("{Controller} All function error", typeof(CommentProjectController));
                    BadRequest();
                    }
                await _unitOfWork.CommentProjectRepository.Remove(id);
                await _unitOfWork.CompletedAsync();
                return Ok(getCommentProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(CommentProjectController));
                return BadRequest(ex);
                }
            }
        }
    }
