using AutoMapper;
using issue_tracker.Models;
using issue_tracker.Models.DTO.AppUser;
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

            // AppUser Model Mapping
            CreateMap<AppUserDTO, AppUser>().ReverseMap();
            }

        }
    }
