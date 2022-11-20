using AutoMapper;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WorkItem, WorkItemDto>().ReverseMap();
            CreateMap<WorkItem, SaveWorkItemDto>().ReverseMap();
        }
    }
}
