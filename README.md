## ConsoleTable

Quickly create table in console
(Project have standart TableItem - class TableItem(extended with string)
* Program.cs have some example

### Constructors:
- standart
- constr(List<ITableItem> items, bool anyKeyForExit = true)
- const(List<ITableItem> items, char keyForExit)
- const(ConsoleTable other)
  
### Methods:
  * AppendItem(ITableItem item)
  * RemoveItem(ITableItem item)
  * RemoveItem(int index)
  * RemoveItem(int start, int end)
  * Clear()
  
### Get Table:
  * PrinTable()
  * (override ToString)
  
If you want create own table item extend your class with interface ITableItem
