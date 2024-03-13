using c__crash.Models.ServicResponse;
using Microsoft.AspNetCore.Mvc;

namespace c__crash.Controllers.TaskController
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly TaskInterface _taskService;

        public TaskController(TaskInterface taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponseClass<List<GetTaskDto>>>> Get()
        {
            return await _taskService.GetTask();
        }
        [HttpGet("GetById")]
        public async Task<ActionResult<ServiceResponseClass<GetTaskDto>>> Get(int id)
        {
            return await _taskService.GetTaskById(id);
        }
        [HttpPost("AddTask")]
        public async Task<ActionResult<ServiceResponseClass<List<AddTaskDto>>>> Post(AddTaskDto NewTask) {
        
            var updatedTask = await _taskService.AddTask(NewTask);
            return updatedTask;
        }

        
            
            }

    
    
}
