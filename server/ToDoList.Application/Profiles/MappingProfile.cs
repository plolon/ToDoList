using AutoMapper;
using ToDoList.Application.Dtos.Comments;
using ToDoList.Application.Dtos.WorkItems;
using ToDoList.Domain.Models;

namespace ToDoList.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WorkItem, WorkItemDto>().ReverseMap();

            CreateMap<WorkItem, SaveWorkItemDto>();
            CreateMap<SaveWorkItemDto, WorkItem>()
                .ForMember(w => w.Id, opt => opt.Ignore());

            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}
