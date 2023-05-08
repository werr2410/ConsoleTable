namespace _ConsoleTable {
    partial class ConsoleTable {
        private List<ITableItem> _items { get; set; } = new List<ITableItem>();
        public bool AnyKeyForExit = true;
        public char KeyForExit = ' ';

        // свойства
        public ITableItem this[int index] {
            set => _items[index] = value;
            get => _items[index];
        }

        public ConsoleTable() { }
        public ConsoleTable(List<ITableItem> _items, bool anyKeyForExit = true) {
            this._items = _items;
            this.AnyKeyForExit = anyKeyForExit;
        }
        public ConsoleTable(List<ITableItem> items, char KeyForExit) {
            this._items = items;
            this.KeyForExit = KeyForExit;
        }
        public ConsoleTable(ConsoleTable other) {
            this._items = other._items;
            this.AnyKeyForExit = other.AnyKeyForExit;
            this.KeyForExit = other.KeyForExit;
        }

        public void AppendItem(ITableItem item) => _items.Add(item);
        public void RemoveItem(ITableItem item) => _items.Remove(item);
        public void RemoveItem(int index) => _items.Remove(_items[index]);
        public void RemoveItem(int start, int end) => _items.RemoveRange(start, end);
        public void Clear() => _items.Clear();
    }
}