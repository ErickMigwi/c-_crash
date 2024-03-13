using c__crash.Models.ServicResponse;

namespace c__crash.Services.TaskService
{
    public interface TaskInterface
    {
        Task<ServiceResponseClass<List<GetTaskDto>>>GetTask();
       Task<ServiceResponseClass<GetTaskDto>> GetTaskById(int id);

        Task<ServiceResponseClass<List<AddTaskDto>>> AddTask(AddTaskDto NewTask);
    }
}
