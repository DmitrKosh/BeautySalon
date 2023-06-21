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
                    Description="Стоимость услуги: 650 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Стрижка мужская",
                    Description="Стоимость услуги: 500 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Стрижка детская до 5 лет",
                    Description="Стоимость услуги: 450 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Окантовка челки",
                    Description="Стоимость услуги: 350 р.",
                    ImageItem="1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка",
                    Description="Стоимость услуги: 350 р.",
                    ImageItem="1" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Сложная укладка",
                    Description="Стоимость услуги: 600 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка детская(до 10 лет)",
                    Description="Стоимость услуги: 400 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Мужская укладка на короткие волосы",
                    Description="Стоимость услуги: 400 р.",
                    ImageItem="1"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Укладка на длинные волосы",
                    Description="Стоимость услуги: 500р.",
                    ImageItem="1"}
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

    public class MockDataStoreEmployee : IDataStore<Employee>
    {
        readonly List<Employee> employees;

        public MockDataStoreEmployee()
        {
            employees = new List<Employee>()
            {
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Петрова Анна",
                    Description="Aнна - работник нашего салона красоты, обладает высокой квалификацией в области ухода за волосами и визажа. Она профессионально проводит различные процедуры: стрижки, окрашивание, мелирование, укладку и т.д. Анна также специализируется на создании свадебных причесок и макияжа, обладает хорошим вкусом и чутким отношением к клиентам.",
                    ImageItem="1"},
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Иванова Валерия",
                    Description="Валерия -  профессиональный мастер по маникюру и педикюру. Она имеет большой опыт работы в данной сфере и знает все современные техники и тенденции. Валерия очень вежливая и приятная в общении, всегда учитывает пожелания и требования клиентов. Она фокусируется на деталях, чтобы обеспечить высокое качество услуги и отличный результат. Валерия точно знает, какое оборудование и инструменты нужны для работы, а также как правильно обращаться с клиентами.",
                    ImageItem="1"},
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Шибзухова Евгения",
                    Description="Стоимость услуги: 450 р.",
                    ImageItem="1"}
            };
        }



        public Task<bool> AddItemAsync(Employee item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}