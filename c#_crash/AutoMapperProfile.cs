namespace c__crash
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TASK, GetTaskDto>();
            CreateMap<TASK, AddTaskDto>();
            CreateMap<AddTaskDto, TASK>();
        }
    }
}
