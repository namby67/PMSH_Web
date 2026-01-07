namespace BaseBusiness.Contants
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Error { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T? Data { get; set; }

        public ApiResponse() { }

        public ApiResponse(bool success, string? message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }


    public class ApiResponseAddError<T> : ApiResponse
    {

        public List<T> Errors { get; set; } = [];
        public int? Type { get; set; }
    }
}
