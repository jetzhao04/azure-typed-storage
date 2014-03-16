namespace AzureTypedStorage
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    public interface IQuerableCloudTable<TElement> where TElement : ITableEntity, new()
    {
        TableQuery<TElement> CreateQuery();

        IEnumerable<TElement> ExecuteQuery(
            TableQuery<TElement> query,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) ;

        TableQuerySegment<TElement> ExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) ;

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            AsyncCallback callback,
            object state) ;

        ICancellableAsyncResult BeginExecuteQuerySegmented(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state) ;

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(TableQuery<TElement> query, TableContinuationToken token) ;

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            CancellationToken cancellationToken) ;

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext) ;

        Task<TableQuerySegment<TElement>> ExecuteQuerySegmentedAsync(
            TableQuery<TElement> query,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken) ;

        IEnumerable<TResult> ExecuteQuery<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) ;

        TableQuerySegment<TResult> ExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions = null,
            OperationContext operationContext = null) ;

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            AsyncCallback callback,
            object state) ;

        ICancellableAsyncResult BeginExecuteQuerySegmented<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            AsyncCallback callback,
            object state) ;

        TableQuerySegment<TResult> EndExecuteQuerySegmented<TResult>(IAsyncResult asyncResult) ;

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token) ;

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            CancellationToken cancellationToken) ;

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext) ;

        Task<TableQuerySegment<TResult>> ExecuteQuerySegmentedAsync<TResult>(
            TableQuery<TElement> query,
            EntityResolver<TResult> resolver,
            TableContinuationToken token,
            TableRequestOptions requestOptions,
            OperationContext operationContext,
            CancellationToken cancellationToken) ;
    }
}