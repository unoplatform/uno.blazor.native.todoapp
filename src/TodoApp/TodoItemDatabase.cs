// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoItemDatabase
    {
        int _counter = 0;
        List<TodoItem> _items = new List<TodoItem>();
        private readonly Func<Task> _dbChanged;

        public TodoItemDatabase(string dbPath, Func<Task> dbChanged)
        {
            _dbChanged = dbChanged;
        }

        public async Task<List<TodoItem>> GetItemsAsync()
        {
            return _items;
        }

        public async Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return 1;
            }
            else
            {
                _items.Add(item);
                item.ID = ++_counter;
                _dbChanged();
                return 1;
            }
        }

        public async Task<int> DeleteItemAsync(TodoItem item)
        {
            _items.Remove(item);
            _dbChanged();
            return 1;
        }
    }
}
