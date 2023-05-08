using _ConsoleTable;

namespace _ConsoleTable {
    class Program {
        static void Main(string[] args) {

            // FIRST EXAMPLE
            var table = new ConsoleTable();

            table.AppendItem((TableItem)"first");
            table.AppendItem((TableItem)"second");
            table.AppendItem((TableItem)"three");

            Console.WriteLine(table);

            //SECOND EXAMPLE
            var table1 = new ConsoleTable();
            var item = new TableItem();
            
            table1.AppendItem(item["Fisrt"]);
            table1.AppendItem(item["Second"]);
            table1.AppendItem(item["Three"]);

            Console.WriteLine(table1);
        }
    }
}