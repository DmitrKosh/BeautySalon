using Salon2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Salon2.Services
{
    class ServicesDataStore : IDataStore<ItemService>
    { 
        readonly List<ItemService> itemsServices;

        public ServicesDataStore()
        {
            itemsServices = new List<ItemService>()
            {
                new ItemService { IdService = 1, NameSevice="Стрижка женская с укладкой", PriceService=5100},
                new ItemService { IdService = 2, NameSevice="Стрижка мужская", PriceService=3200},
                new ItemService { IdService = 3, NameSevice="Стрижка детская до 5 лет", PriceService=1000},
                new ItemService { IdService = 4, NameSevice="Окантовка челки", PriceService=700},
                new ItemService { IdService = 5, NameSevice="Укладка", PriceService=3500},
                new ItemService { IdService = 6, NameSevice="Сложная укладка", PriceService=4300},
                new ItemService { IdService = 7, NameSevice="Укладка детская(до 10 лет)", PriceService=2300},
                new ItemService { IdService = 8, NameSevice="Мужская укладка на короткие волосы", PriceService=2200},
                new ItemService { IdService = 9, NameSevice="Укладка на длинные волосы", PriceService=4000}
            };
        }

        public Task<bool> AddItemAsync(ItemService item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemService> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemService>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(ItemService item)
        {
            throw new NotImplementedException();
        }
    }
}
