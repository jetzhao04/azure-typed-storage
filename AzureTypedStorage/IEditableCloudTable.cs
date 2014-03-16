namespace AzureTypedStorage
{
    using Microsoft.WindowsAzure.Storage.Table;

    public interface IEditableCloudTable<TElement> where TElement : ITableEntity, new()
    {
        TableResult Insert(TElement element);

        TableResult InsertOrReplace(TElement element);

        TableResult Remove(TElement element);
    }
}