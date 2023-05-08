namespace _ConsoleTable {
    partial class ConsoleTable {
        public override bool Equals(object? obj) {
            return obj is ConsoleTable table &&
                   EqualityComparer<List<ITableItem>>.Default.Equals(_items, table._items) &&
                   AnyKeyForExit == table.AnyKeyForExit &&
                   KeyForExit == table.KeyForExit &&
                   Border == table.Border &&
                   Space == table.Space;
        }

        public override int GetHashCode() {
            return HashCode.Combine(_items, AnyKeyForExit, KeyForExit, Border, Space);
        }

        public override string ToString() => PrintTable();
        // public override 
    }
}