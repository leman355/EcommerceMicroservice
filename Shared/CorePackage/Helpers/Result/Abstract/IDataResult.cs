namespace CorePackage.Helpers.Result.Abstract
{
    public interface IDataResult<TResult> : IResult
    {
        TResult Data { get; }
    }
}