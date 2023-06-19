namespace ProClimberAPI.Models
{
    public class ProClimberResponse<T>
    
         where T : class
    {
        public ProClimberResponse()
        {
            ErrorMessages = new List<string>();
        }
        public bool Success { get; set; }

        public List<string> ErrorMessages { get; set; }

        public T Data { get; set; }
    }

}
