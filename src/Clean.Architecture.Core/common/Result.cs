namespace Clean.Architecture.Core.common
{
    public class Result<TResponse>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }

        private Result(bool isSuccess, Error error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result<TResponse> Success<T>() => new(true, Error.None);
        public static Result<TResponse> Failure<T>(Error error) => new(false, error);
    }

    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }

        private Result(bool isSuccess, Error error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
        public static Result Problem(string statusCode, string title, Error error) => new(false, error);
    }
}

