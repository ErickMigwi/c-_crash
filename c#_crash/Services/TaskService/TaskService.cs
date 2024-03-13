
using c__crash.Models.ServicResponse;

namespace c__crash.Services.TaskService
{
    public class TaskService : TaskInterface
    {
        public static List<TASK> Tasks = new List<TASK>
        {
          new TASK
            {
                Task = "Becoming a senior developer",
                Id = 1,
                IsCompleted = false,
            },
            new TASK
            {
                Task = "Starting a business",
                Id = 2,
                IsCompleted = false,
            },
            new TASK
            {
                Task = "Buying a Razor Blade 17",
                Id = 3,
                IsCompleted = false,
            }
        };
        private readonly IMapper _mapper;

        public TaskService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponseClass<List<AddTaskDto>>> AddTask(AddTaskDto NewTask)
        {
            var serviceResponse = new ServiceResponseClass<List<AddTaskDto>>();
            Tasks.Add(_mapper.Map<TASK>(NewTask));
            serviceResponse.Data = Tasks.Select(t => _mapper.Map<AddTaskDto>(t)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponseClass<List<GetTaskDto>>> GetTask()
        {
            var serviceResponse = new ServiceResponseClass<List<GetTaskDto>>();
            var data = Tasks;
             serviceResponse.Data =data.Select(t=>_mapper.Map<GetTaskDto>(t)).ToList() ;
            return serviceResponse;
        }


        public async Task<ServiceResponseClass<GetTaskDto>> GetTaskById(int id)
        {
            var serviceResponse = new ServiceResponseClass <GetTaskDto>();

            var specTask = Tasks.FirstOrDefault(t => t.Id != id);
            
            if(specTask != null)
            {
                serviceResponse.Data = _mapper.Map<GetTaskDto>(specTask);
                return serviceResponse;
            }
            else
            {
                 Console.WriteLine("Task Not Found");
                throw new ArgumentException("Task not found with the provided ID", nameof(id));
            }
        }
    }
}
