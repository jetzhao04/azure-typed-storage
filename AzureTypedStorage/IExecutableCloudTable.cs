namespace AzureTypedStorage
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    public interface IExecutableCloudTable
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
    }

    public interface IExecutableCloudTable<TElement>
    {
        TableResult<TElement> Execute(
                TableOperation operation,
                TableRequestOptions requestOptions = null,
                OperationContext operationContext = null);

    }
}