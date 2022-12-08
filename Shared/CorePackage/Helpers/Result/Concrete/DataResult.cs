using CorePackage.Helpers.Result.Abstract;

namespace CorePackage.Helpers.Result.Concrete
{
    public class DataResult<TResult> : Result, IDataResult<TResult>
    {
        public DataResult(TResult data, bool success) : base(success)
        {
            Data = data;
        }
        public DataResult(TResult data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public TResult Data { get; }
    }
}