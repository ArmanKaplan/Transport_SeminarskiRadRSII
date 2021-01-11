using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Transport.MobileAplication.Services.Vozaci
{
    public interface IDataStore1<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
