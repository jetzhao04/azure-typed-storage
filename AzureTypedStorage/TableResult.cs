namespace AzureTypedStorage
{
    using Microsoft.WindowsAzure.Storage.Table;

    public class TableResult<TElement>
    {
        private readonly TableResult _instance;

        public TableResult(TableResult instance)
        {
            _instance = instance;
        }

        public TElement Result
        {
            get
            {
                return (TElement)_instance.Result;
            }
            set
            {
                _instance.Result = value;
            }
        }

        public int HttpStatusCode
        {
            get
            {
                return _instance.HttpStatusCode;
            }
            set
            {
                _instance.HttpStatusCode = value;
            }
        }

        public string Etag
        {
            get
            {
                return _instance.Etag;
            }
            set
            {
                _instance.Etag = value;
            }
        }
    }
}