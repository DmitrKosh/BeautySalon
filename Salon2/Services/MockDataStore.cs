using Salon2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon2.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Стрижка женская с укладкой",
                    Description="Стоимость услуги: 650 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Стрижка мужская",
                    Description="Стоимость услуги: 500 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Стрижка детская до 5 лет",
                    Description="Стоимость услуги: 450 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Окантовка челки",
                    Description="Стоимость услуги: 350 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка",
                    Description="Стоимость услуги: 350 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Сложная укладка",
                    Description="Стоимость услуги: 600 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка детская(до 10 лет)",
                    Description="Стоимость услуги: 400 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Мужская укладка на короткие волосы",
                    Description="Стоимость услуги: 400 р." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка на длинные волосы",
                    Description="Стоимость услуги: 500р." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}