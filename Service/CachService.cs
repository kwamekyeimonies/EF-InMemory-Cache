namespace InMemory_Cache.Services
{
    public class CacheService : ICacheService
    {
        private ObjectCache _memoryCache
        T ICacheService.GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        object ICacheService.RemoveData(string key)
        {
            throw new NotImplementedException();
        }

        bool ICacheService.SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            throw new NotImplementedException();
        }
    }
}