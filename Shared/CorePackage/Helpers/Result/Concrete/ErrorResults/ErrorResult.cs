namespace CorePackage.Helpers.Result.Concrete.ErrorResults
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }
        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}