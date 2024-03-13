namespace c__crash.Models.ServicResponse
{
    public class ServiceResponseClass<T>
    {
        public T? Data { get; set; }
        public bool? Success { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
