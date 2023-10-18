namespace CodeWarts.Infrastructure.Implementations.PaginationHelper;

public class PagnationHelper<T>
{
    private readonly IList<T> _collection;
    private readonly int _itemsPerPage;

    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        if (itemsPerPage < 1)
            throw new ArgumentException("Items per page has wrong value");
        _collection = collection;
        _itemsPerPage = itemsPerPage;
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount => _collection.Count;

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount => (_collection.Count / _itemsPerPage) + 1;

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0 || pageIndex + 1 > PageCount)
            return -1;
        if (pageIndex + 1 == PageCount)
            return ItemCount - (pageIndex * _itemsPerPage);
        return _itemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex + 1 > ItemCount)
            return -1;
        return 0;
    }
}