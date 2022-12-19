using AutoMapper;
using issue_tracker.Models;
using issue_tracker.Models.DTO.AppUser;
using issue_tracker.Models.DTO.CommentIssue;
using issue_tracker.Models.DTO.CommentProject;
using issue_tracker.Models.DTO.Company;
using issue_tracker.Models.DTO.Project;

namespace issue_tracker.DataAccess.DataMapping
    {
    public class MappingProfile : Profile
        {
        public MappingProfile()
            {
            // Company Model Mapping
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Company, GetCompanyDTO>().ReverseMap();
            CreateMap<Company, BaseCompanyDTO>().ReverseMap();
            CreateMap<Company, CreateCompanyDTO>().ReverseMap();
            CreateMap<Company, UpdateCompanyDTO>().ReverseMap();

            // Project Model Mapping
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<Project, GetProjectDTO>().ReverseMap();
            CreateMap<Project, BaseProjectDTO>().ReverseMap();
            CreateMap<Project, CreateProjectDTO>().ReverseMap();
            CreateMap<Project, UpdateProjectDTO>().ReverseMap();
            // Issue Model Mapping
            CreateMap<Issue, ProjectDTO>().ReverseMap();
            CreateMap<Issue, GetProjectDTO>().ReverseMap();
            CreateMap<Issue, BaseProjectDTO>().ReverseMap();
            CreateMap<Issue, CreateProjectDTO>().ReverseMap();
            CreateMap<Issue, UpdateProjectDTO>().ReverseMap();

            // CommentProject Model Mapping
            CreateMap<CommentProject, CommentProjectDTO>().ReverseMap();
            CreateMap<CommentProject, GetCommentProjectDTO>().ReverseMap();
            CreateMap<CommentIssue, BaseCommentProjectDTO>().ReverseMap();
            CreateMap<CommentProject, CreateCommentProjectDTO>().ReverseMap();
            CreateMap<CommentProject, UpdateCommentProjectDTO>().ReverseMap();

            // CommentIssue Model Mapping
            CreateMap<CommentIssue, CommentIssueDTO>().ReverseMap();
            CreateMap<CommentIssue, GetCommentIssueDTO>().ReverseMap();
            CreateMap<CommentIssue, BaseCommentIssueDTO>().ReverseMap();
            CreateMap<CommentIssue, CreateCommentIssueDTO>().ReverseMap();
            CreateMap<CommentIssue, UpdateCommentIssueDTO>().ReverseMap();

            // AppUser Model Mapping
            CreateMap<AppUserDTO, AppUser>().ReverseMap();
            }

        }
    }
