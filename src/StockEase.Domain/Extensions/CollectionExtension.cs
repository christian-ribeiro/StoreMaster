namespace StockEase.Domain.Extensions
{
    public static class CollectionExtension
    {
        public static List<TResult> ConvertAll<TResult>(this IEnumerable<object> listSource)
        {
            if (listSource == null)
                return new List<TResult>();

            return (from i in listSource select (TResult)(dynamic)i).ToList();
        }
    }
}