using AutoMapper;
using issue_tracker.DataAccess.Repository.IRepository;
using issue_tracker.Models;
using issue_tracker.Models.DTO.Project;
using Microsoft.AspNetCore.Mvc;

namespace issue_tracker.Controllers.ApiControllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
        {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<Project> _logger;

        public ProjectController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<Project> logger)
            {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            }
        // GET api/Project
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProjectDTO>>> GetProjectList()
            {
            try
                {
                var projects = await _unitOfWork.ProjectRepository.GetAllAsync();
                var projectsDto = _mapper.Map<IEnumerable<ProjectDTO>>(projects);
                return Ok(projectsDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(ProjectController));
                return BadRequest(ex);
                }
            }

        // GET api/Project/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProjectDTO>> Get(int id)
            {
            try
                {
                var project = await _unitOfWork.ProjectRepository.GetAsync(id);
                var projectsDto = _mapper.Map<GetProjectDTO>(project);
                return Ok(projectsDto);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(ProjectController));
                return BadRequest(ex);
                }
            }

        // POST api/Project
        [HttpPost]
        public async Task<ActionResult<CreateProjectDTO>> Create([FromBody] CreateProjectDTO createProjectDTO)
            {
            try
                {
                var project = _mapper.Map<Project>(createProjectDTO);
                await _unitOfWork.ProjectRepository.CreateAsync(project);
                await _unitOfWork.CompletedAsync();
                return Ok(createProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(ProjectController));
                return BadRequest(ex);
                }

            }

        // PUT api/Project/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateProjectDTO>> Update(int id, [FromBody] UpdateProjectDTO updateProjectDTO)
            {
            try
                {
                if (id != updateProjectDTO.Id)
                    {
                    return BadRequest(updateProjectDTO);
                    }
                var project = _mapper.Map<Project>(updateProjectDTO);
                await _unitOfWork.ProjectRepository.UpdateAsync(project);
                await _unitOfWork.CompletedAsync();
                return Ok(updateProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(ProjectController));
                return BadRequest(ex);
                }
            }

        // DELETE api/Project/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<GetProjectDTO>> Delete(int id, [FromBody] GetProjectDTO getProjectDTO)
            {
            try
                {
                if (id != getProjectDTO.Id)
                    {
                    return BadRequest(getProjectDTO);
                    }
                await _unitOfWork.ProjectRepository.Remove(id);
                await _unitOfWork.CompletedAsync();
                return Ok(getProjectDTO);
                }
            catch (Exception ex)
                {
                _logger.LogError(ex, "{Controller} All function error", typeof(ProjectController));
                return BadRequest(ex);
                }
            }
        }
    }
