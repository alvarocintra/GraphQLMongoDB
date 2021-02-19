namespace PrettyDirty.Domain.Settings
{
    public class StorageSettings : IStorageSettings
    {
        public string AccountName { get; set; }
        public string AccountKey { get; set; }
    }

    public interface IStorageSettings
    {
        string AccountName { get; set; }
        string AccountKey { get; set; }
    }
}
