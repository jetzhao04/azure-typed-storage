namespace AzureTypedStorage
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    public interface ICloudTable<TElement> : IQuerableCloudTable<TElement>, IExecutableCloudTable, IExecutableCloudTable<TElement>, IEditableCloudTable<TElement>
        where TElement : ITableEntity, new()
    {
        TableResult Execute(
            TableOperation operation,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecute(TableOperation operation, AsyncCallback callback, object state);

        ICancellableAsyncResult BeginExecute(
            TableOperation operation,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        TableResult EndExecute(IAsyncResult asyncResult);

        Task<TableResult> ExecuteAsync(TableOperation operation);

        Task<TableResult> ExecuteAsync(TableOperation operation, CancellationToken cancellationToken);

        Task<TableResult> ExecuteAsync(TableOperation operation, TableRequestOptions requestOptions, OperationContext operationContext);

        Task<TableResult> ExecuteAsync(
            TableOperation operation,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        IList<TableResult> ExecuteBatch(
            TableBatchOperation batch,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecuteBatch(TableBatchOperation batch, AsyncCallback callback, object state);

        ICancellableAsyncResult BeginExecuteBatch(
            TableBatchOperation batch,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        IList<TableResult> EndExecuteBatch(IAsyncResult asyncResult);

        Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch);

        Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch, CancellationToken cancellationToken);

        Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch, TableRequestOptions requestOptions, OperationContext operationContext);

        Task<IList<TableResult>> ExecuteBatchAsync(
            TableBatchOperation batch,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        IEnumerable<DynamicTableEntity> ExecuteQuery(
            TableQuery query,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        TableQuerySegment<DynamicTableEntity> ExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            AsyncCallback callback,
            object state);

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        TableQuerySegment<DynamicTableEntity> EndExecuteQuerySegmented(IAsyncResult asyncResult);

        Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(TableQuery query, TableContinuationToken token);

        Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(TableQuery query, TableContinuationToken token, CancellationToken cancellationToken);

        Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext);

        Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        IEnumerable<TResult> ExecuteQuery<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        TableQuerySegment<TResult> ExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            AsyncCallback callback,
            object state);

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(TableQuery query, EntityResolver<TResult> resolver, TableContinuationToken token);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            CancellationToken cancellationToken);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        TableQuery<TElement> CreateQuery();

        IEnumerable<TElement> ExecuteQuery(
            TableQuery<TElement> query,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        TableQuerySegment<TElement> ExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            AsyncCallback callback,
            object state);

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        TableQuerySegment<TResult> EndExecuteQuerySegmented<TElement, TResult>(IAsyncResult asyncResult);

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(TableQuery<TElement> query, TableContinuationToken token);

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            CancellationToken cancellationToken);

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext);

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        IEnumerable<TResult> ExecuteQuery<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        TableQuerySegment<TResult> ExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            AsyncCallback callback,
            object state);

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        TableQuerySegment<TResult> EndExecuteQuerySegmented<TResult>(IAsyncResult asyncResult);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            CancellationToken cancellationToken);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext);

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        void Create(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginCreate(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginCreate(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        void EndCreate(IAsyncResult asyncResult);

        Task CreateAsync();

        Task CreateAsync(CancellationToken cancellationToken);

        Task CreateAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task CreateAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        bool CreateIfNotExists(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginCreateIfNotExists(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginCreateIfNotExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        bool EndCreateIfNotExists(IAsyncResult asyncResult);

        Task<bool> CreateIfNotExistsAsync();

        Task<bool> CreateIfNotExistsAsync(CancellationToken cancellationToken);

        Task<bool> CreateIfNotExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task<bool> CreateIfNotExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        void Delete(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginDelete(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginDelete(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        void EndDelete(IAsyncResult asyncResult);

        Task DeleteAsync();

        Task DeleteAsync(CancellationToken cancellationToken);

        Task DeleteAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task DeleteAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        bool DeleteIfExists(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginDeleteIfExists(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginDeleteIfExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        bool EndDeleteIfExists(IAsyncResult asyncResult);

        Task<bool> DeleteIfExistsAsync();

        Task<bool> DeleteIfExistsAsync(CancellationToken cancellationToken);

        Task<bool> DeleteIfExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task<bool> DeleteIfExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        bool Exists(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginExists(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        bool EndExists(IAsyncResult asyncResult);

        Task<bool> ExistsAsync();

        Task<bool> ExistsAsync(CancellationToken cancellationToken);

        Task<bool> ExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task<bool> ExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        TablePermissions GetPermissions(TableRequestOptions requestOptions = null, OperationContext operationContext = null);

        ICancellableAsyncResult BeginGetPermissions(AsyncCallback callback, object state);

        ICancellableAsyncResult BeginGetPermissions(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        TablePermissions EndGetPermissions(IAsyncResult asyncResult);

        Task<TablePermissions> GetPermissionsAsync();

        Task<TablePermissions> GetPermissionsAsync(CancellationToken cancellationToken);

        Task<TablePermissions> GetPermissionsAsync(TableRequestOptions requestOptions, OperationContext operationContext);

        Task<TablePermissions> GetPermissionsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        void SetPermissions(
            TablePermissions permissions,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null);

        ICancellableAsyncResult BeginSetPermissions(TablePermissions permissions, AsyncCallback callback, object state);

        ICancellableAsyncResult BeginSetPermissions(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state);

        void EndSetPermissions(IAsyncResult asyncResult);

        Task SetPermissionsAsync(TablePermissions permissions);

        Task SetPermissionsAsync(TablePermissions permissions, CancellationToken cancellationToken);

        Task SetPermissionsAsync(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext);

        Task SetPermissionsAsync(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken);

        string GetSharedAccessSignature(
            SharedAccessTablePolicy policy,
            string accessPolicyIdentifier,
            string startPartitionKey,
            string startRowKey,
            string endPartitionKey,
            string endRowKey);

        CloudTableClient ServiceClient { get; }

        string Name { get; }

        Uri Uri { get; }
    }
}