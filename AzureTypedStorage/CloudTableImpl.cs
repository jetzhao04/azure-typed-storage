namespace AzureTypedStorage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    public class CloudTableImpl<TElement> : IQuerableCloudTable<TElement>, IExecutableCloudTable, IExecutableCloudTable<TElement>, IEditableCloudTable<TElement>, ICloudTable<TElement>
        where TElement : ITableEntity, new()
    {
        private readonly CloudTable _instance;

        public CloudTableImpl(CloudTable instance)
        {
            _instance = instance;
        }

        public TableResult Execute(
            TableOperation operation,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.Execute(operation, requestOptions, operationContext);
        }

        TableResult<TElement> IExecutableCloudTable<TElement>.Execute(
           TableOperation operation,
           TableRequestOptions requestOptions = null,
           OperationContext operationContext = null)
        {
            return new TableResult<TElement>(_instance.Execute(operation, requestOptions, operationContext));
        }

        public ICancellableAsyncResult BeginExecute(TableOperation operation, AsyncCallback callback, object state)
        {
            return _instance.BeginExecute(operation, callback, state);
        }

        public ICancellableAsyncResult BeginExecute(
            TableOperation operation,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecute(operation, requestOptions, operationContext, callback, state);
        }

        public TableResult EndExecute(IAsyncResult asyncResult)
        {
            return _instance.EndExecute(asyncResult);
        }

        public Task<TableResult> ExecuteAsync(TableOperation operation)
        {
            return _instance.ExecuteAsync(operation);
        }

        public Task<TableResult> ExecuteAsync(TableOperation operation, CancellationToken cancellationToken)
        {
            return _instance.ExecuteAsync(operation, cancellationToken);
        }

        public Task<TableResult> ExecuteAsync(TableOperation operation, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.ExecuteAsync(operation, requestOptions, operationContext);
        }

        public Task<TableResult> ExecuteAsync(
            TableOperation operation,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.ExecuteAsync(operation, requestOptions, operationContext, cancellationToken);
        }

        public IList<TableResult> ExecuteBatch(
            TableBatchOperation batch,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.ExecuteBatch(batch, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExecuteBatch(TableBatchOperation batch, AsyncCallback callback, object state)
        {
            return _instance.BeginExecuteBatch(batch, callback, state);
        }

        public ICancellableAsyncResult BeginExecuteBatch(
            TableBatchOperation batch,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecuteBatch(batch, requestOptions, operationContext, callback, state);
        }

        public IList<TableResult> EndExecuteBatch(IAsyncResult asyncResult)
        {
            return _instance.EndExecuteBatch(asyncResult);
        }

        public Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch)
        {
            return _instance.ExecuteBatchAsync(batch);
        }

        public Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch, CancellationToken cancellationToken)
        {
            return _instance.ExecuteBatchAsync(batch, cancellationToken);
        }

        public Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation batch, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.ExecuteBatchAsync(batch, requestOptions, operationContext);
        }

        public Task<IList<TableResult>> ExecuteBatchAsync(
            TableBatchOperation batch,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.ExecuteBatchAsync(batch, requestOptions, operationContext, cancellationToken);
        }

        public IEnumerable<DynamicTableEntity> ExecuteQuery(
            TableQuery query,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.ExecuteQuery(query, requestOptions, operationContext);
        }

        public TableQuerySegment<DynamicTableEntity> ExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.ExecuteQuerySegmented(query, token, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecuteQuerySegmented(query, token, callback, state);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecuteQuerySegmented(query, token, requestOptions, operationContext, callback, state);
        }

        public TableQuerySegment<DynamicTableEntity> EndExecuteQuerySegmented(IAsyncResult asyncResult)
        {
            return _instance.EndExecuteQuerySegmented(asyncResult);
        }

        public Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(TableQuery query, TableContinuationToken token)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token);
        }

        public Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(TableQuery query, TableContinuationToken token, CancellationToken cancellationToken)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, cancellationToken);
        }

        public Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, requestOptions, operationContext);
        }

        public Task<TableQuerySegment<DynamicTableEntity>> ExecuteQuerySegmentedAsync(
            TableQuery query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, requestOptions, operationContext, cancellationToken);
        }

        public IEnumerable<TResult> ExecuteQuery<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.ExecuteQuery(query, resolver, requestOptions, operationContext);
        }

        public TableQuerySegment<TResult> ExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            return _instance.ExecuteQuerySegmented(query, resolver, token, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecuteQuerySegmented(query, resolver, token, callback, state);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExecuteQuerySegmented(query, resolver, token, requestOptions, operationContext, callback, state);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(TableQuery query, EntityResolver<TResult> resolver, TableContinuationToken token)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            CancellationToken cancellationToken)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, cancellationToken);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, requestOptions, operationContext);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, requestOptions, operationContext, cancellationToken);
        }

        public TableQuery<TElement> CreateQuery() 
        {
            return _instance.CreateQuery<TElement>();
        }

        public IEnumerable<TElement> ExecuteQuery(
            TableQuery<TElement> query,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) 
        {
            return _instance.ExecuteQuery(query, requestOptions, operationContext);
        }

        public TableQuerySegment<TElement> ExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) 
        {
            return _instance.ExecuteQuerySegmented(query, token, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            AsyncCallback callback,
            object state) 
        {
            return _instance.BeginExecuteQuerySegmented(query, token, callback, state);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state) 
        {
            return _instance.BeginExecuteQuerySegmented(query, token, requestOptions, operationContext, callback, state);
        }

        public TableQuerySegment<TResult> EndExecuteQuerySegmented<TElement, TResult>(IAsyncResult asyncResult)
        {
            return _instance.EndExecuteQuerySegmented<TResult>(asyncResult);
        }

        public Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(TableQuery<TElement> query, TableContinuationToken token) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token);
        }

        public Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            CancellationToken cancellationToken) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, cancellationToken);
        }

        public Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, requestOptions, operationContext);
        }

        public Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, token, requestOptions, operationContext, cancellationToken);
        }

        public IEnumerable<TResult> ExecuteQuery<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) 
        {
            return _instance.ExecuteQuery(query, resolver, requestOptions, operationContext);
        }

        public TableQuerySegment<TResult> ExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) 
        {
            return _instance.ExecuteQuerySegmented(query, resolver, token, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            AsyncCallback callback,
            object state) 
        {
            return _instance.BeginExecuteQuerySegmented(query, resolver, token, callback, state);
        }

        public ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state) 
        {
            return _instance.BeginExecuteQuerySegmented(query, resolver, token, requestOptions, operationContext, callback, state);
        }

        public TableQuerySegment<TResult> EndExecuteQuerySegmented<TResult>(IAsyncResult asyncResult) 
        {
            return _instance.EndExecuteQuerySegmented<TResult>(asyncResult);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            CancellationToken cancellationToken) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, cancellationToken);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, requestOptions, operationContext);
        }

        public Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken) 
        {
            return _instance.ExecuteQuerySegmentedAsync(query, resolver, token, requestOptions, operationContext, cancellationToken);
        }

        public void Create(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            _instance.Create(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginCreate(AsyncCallback callback, object state)
        {
            return _instance.BeginCreate(callback, state);
        }

        public ICancellableAsyncResult BeginCreate(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginCreate(requestOptions, operationContext, callback, state);
        }

        public void EndCreate(IAsyncResult asyncResult)
        {
            _instance.EndCreate(asyncResult);
        }

        public Task CreateAsync()
        {
            return _instance.CreateAsync();
        }

        public Task CreateAsync(CancellationToken cancellationToken)
        {
            return _instance.CreateAsync(cancellationToken);
        }

        public Task CreateAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.CreateAsync(requestOptions, operationContext);
        }

        public Task CreateAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.CreateAsync(requestOptions, operationContext, cancellationToken);
        }

        public bool CreateIfNotExists(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            return _instance.CreateIfNotExists(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginCreateIfNotExists(AsyncCallback callback, object state)
        {
            return _instance.BeginCreateIfNotExists(callback, state);
        }

        public ICancellableAsyncResult BeginCreateIfNotExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginCreateIfNotExists(requestOptions, operationContext, callback, state);
        }

        public bool EndCreateIfNotExists(IAsyncResult asyncResult)
        {
            return _instance.EndCreateIfNotExists(asyncResult);
        }

        public Task<bool> CreateIfNotExistsAsync()
        {
            return _instance.CreateIfNotExistsAsync();
        }

        public Task<bool> CreateIfNotExistsAsync(CancellationToken cancellationToken)
        {
            return _instance.CreateIfNotExistsAsync(cancellationToken);
        }

        public Task<bool> CreateIfNotExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.CreateIfNotExistsAsync(requestOptions, operationContext);
        }

        public Task<bool> CreateIfNotExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.CreateIfNotExistsAsync(requestOptions, operationContext, cancellationToken);
        }

        public void Delete(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            _instance.Delete(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginDelete(AsyncCallback callback, object state)
        {
            return _instance.BeginDelete(callback, state);
        }

        public ICancellableAsyncResult BeginDelete(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginDelete(requestOptions, operationContext, callback, state);
        }

        public void EndDelete(IAsyncResult asyncResult)
        {
            _instance.EndDelete(asyncResult);
        }

        public Task DeleteAsync()
        {
            return _instance.DeleteAsync();
        }

        public Task DeleteAsync(CancellationToken cancellationToken)
        {
            return _instance.DeleteAsync(cancellationToken);
        }

        public Task DeleteAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.DeleteAsync(requestOptions, operationContext);
        }

        public Task DeleteAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.DeleteAsync(requestOptions, operationContext, cancellationToken);
        }

        public bool DeleteIfExists(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            return _instance.DeleteIfExists(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginDeleteIfExists(AsyncCallback callback, object state)
        {
            return _instance.BeginDeleteIfExists(callback, state);
        }

        public ICancellableAsyncResult BeginDeleteIfExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginDeleteIfExists(requestOptions, operationContext, callback, state);
        }

        public bool EndDeleteIfExists(IAsyncResult asyncResult)
        {
            return _instance.EndDeleteIfExists(asyncResult);
        }

        public Task<bool> DeleteIfExistsAsync()
        {
            return _instance.DeleteIfExistsAsync();
        }

        public Task<bool> DeleteIfExistsAsync(CancellationToken cancellationToken)
        {
            return _instance.DeleteIfExistsAsync(cancellationToken);
        }

        public Task<bool> DeleteIfExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.DeleteIfExistsAsync(requestOptions, operationContext);
        }

        public Task<bool> DeleteIfExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.DeleteIfExistsAsync(requestOptions, operationContext, cancellationToken);
        }

        public bool Exists(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            return _instance.Exists(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginExists(AsyncCallback callback, object state)
        {
            return _instance.BeginExists(callback, state);
        }

        public ICancellableAsyncResult BeginExists(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginExists(requestOptions, operationContext, callback, state);
        }

        public bool EndExists(IAsyncResult asyncResult)
        {
            return _instance.EndExists(asyncResult);
        }

        public Task<bool> ExistsAsync()
        {
            return _instance.ExistsAsync();
        }

        public Task<bool> ExistsAsync(CancellationToken cancellationToken)
        {
            return _instance.ExistsAsync(cancellationToken);
        }

        public Task<bool> ExistsAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.ExistsAsync(requestOptions, operationContext);
        }

        public Task<bool> ExistsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.ExistsAsync(requestOptions, operationContext, cancellationToken);
        }

        public TablePermissions GetPermissions(TableRequestOptions requestOptions = null, OperationContext operationContext = null)
        {
            return _instance.GetPermissions(requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginGetPermissions(AsyncCallback callback, object state)
        {
            return _instance.BeginGetPermissions(callback, state);
        }

        public ICancellableAsyncResult BeginGetPermissions(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginGetPermissions(requestOptions, operationContext, callback, state);
        }

        public TablePermissions EndGetPermissions(IAsyncResult asyncResult)
        {
            return _instance.EndGetPermissions(asyncResult);
        }

        public Task<TablePermissions> GetPermissionsAsync()
        {
            return _instance.GetPermissionsAsync();
        }

        public Task<TablePermissions> GetPermissionsAsync(CancellationToken cancellationToken)
        {
            return _instance.GetPermissionsAsync(cancellationToken);
        }

        public Task<TablePermissions> GetPermissionsAsync(TableRequestOptions requestOptions, OperationContext operationContext)
        {
            return _instance.GetPermissionsAsync(requestOptions, operationContext);
        }

        public Task<TablePermissions> GetPermissionsAsync(
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.GetPermissionsAsync(requestOptions, operationContext, cancellationToken);
        }

        public void SetPermissions(
            TablePermissions permissions,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null)
        {
            _instance.SetPermissions(permissions, requestOptions, operationContext);
        }

        public ICancellableAsyncResult BeginSetPermissions(TablePermissions permissions, AsyncCallback callback, object state)
        {
            return _instance.BeginSetPermissions(permissions, callback, state);
        }

        public ICancellableAsyncResult BeginSetPermissions(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state)
        {
            return _instance.BeginSetPermissions(permissions, requestOptions, operationContext, callback, state);
        }

        public void EndSetPermissions(IAsyncResult asyncResult)
        {
            _instance.EndSetPermissions(asyncResult);
        }

        public Task SetPermissionsAsync(TablePermissions permissions)
        {
            return _instance.SetPermissionsAsync(permissions);
        }

        public Task SetPermissionsAsync(TablePermissions permissions, CancellationToken cancellationToken)
        {
            return _instance.SetPermissionsAsync(permissions, cancellationToken);
        }

        public Task SetPermissionsAsync(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext)
        {
            return _instance.SetPermissionsAsync(permissions, requestOptions, operationContext);
        }

        public Task SetPermissionsAsync(
            TablePermissions permissions,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken)
        {
            return _instance.SetPermissionsAsync(permissions, requestOptions, operationContext, cancellationToken);
        }

        public string GetSharedAccessSignature(
            SharedAccessTablePolicy policy,
            string accessPolicyIdentifier,
            string startPartitionKey,
            string startRowKey,
            string endPartitionKey,
            string endRowKey)
        {
            return _instance.GetSharedAccessSignature(policy, accessPolicyIdentifier, startPartitionKey, startRowKey, endPartitionKey, endRowKey);
        }

        public CloudTableClient ServiceClient
        {
            get
            {
                return _instance.ServiceClient;
            }
        }

        public string Name
        {
            get
            {
                return _instance.Name;
            }
        }

        public Uri Uri
        {
            get
            {
                return _instance.Uri;
            }
        }

        public TableResult Insert(TElement element)
        {
            return _instance.Execute(TableOperation.Insert(element));
        }

        public TableResult InsertOrReplace(TElement element)
        {
            return _instance.Execute(TableOperation.InsertOrReplace(element));
        }

        public TableResult Remove(TElement element)
        {
            return _instance.Execute(TableOperation.Delete(element));
        }
    }
}