// 1
using System.Xml;

var list= new List<string>();
// 2
var list2= new List<string>()
{
    "apple",
    "banana",
    "orange"
};
// 3
int count = 0;
foreach (var item in list2)
{
    count++;
}
System.Console.WriteLine("-----------------");
System.Console.WriteLine(count);
// 4
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------");
// 5
list2.Remove("banana");
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------");
// 6
// Проверьте, содержится ли элемент "apple" в списке.
foreach (var item in list2)
{
    if (item == "apple")
    {
        System.Console.WriteLine("Элемент 'apple' найден в списке.");
        break;
    }
}
System.Console.WriteLine("-----------------");
// 7
var list3 = new List<string>(list2);
// 8
foreach (var item in list3)
{
   System.Console.WriteLine(item); 
}
System.Console.WriteLine("-----------------");
// 9
list3.Add("grape");
foreach (var item in list3)
{
   System.Console.WriteLine(item); 
}
System.Console.WriteLine("-----------------");
// 10 Удалите элемент на позиции 2 и выведите его значение.
foreach (var item in list3)
{
    if (list3.Count > 2)
    {
        string removed =list3[2];
        list3.RemoveAt(2);
        System.Console.WriteLine($"Удаленный элемент: {removed}");
        break;
    }
}
System.Console.WriteLine("-----------------");
// 11
if (list3.Count == 0)
{
    System.Console.WriteLine("list3 empty");
}
else
{
    System.Console.WriteLine("list3 not empty");
}
System.Console.WriteLine("-----------------");
// 12
list3.Add("kiwi");
list3.Add("melon");
list3.Add("pomegranate");
list3.Add("peach");
list3.Sort();
foreach (var item in list3)
{
   System.Console.WriteLine(item); 
}
System.Console.WriteLine("-----------------");
// 13
list3.Reverse();
foreach (var item in list3)
{
   System.Console.WriteLine(item); 
}
System.Console.WriteLine("-----------------");
// 14
var newList = new List<string>()
{
    "strawberry",
    "blueberry",
    "raspberry"
};
newList.AddRange(list3);
foreach (var item in newList)
{
   System.Console.WriteLine(item); 
}
System.Console.WriteLine("-----------------");
// 15
foreach (var item in newList)
{
    if (item == "apple")
    {
        System.Console.WriteLine($"Индекс элемента 'apple': {newList.IndexOf(item)}");
        break;
    }
    
}
System.Console.WriteLine("-----------------");
// 16
newList.RemoveAll(s=>s.Length>5);
foreach (var item in newList)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------");
// 17
int count2 = newList.Count(x => x.StartsWith("a"));
System.Console.WriteLine($"Количество элементов, начинающихся на 'a': {count2}");
System.Console.WriteLine("-----------------");
// 18
var newList2 = newList.ToList();
newList2.Sort();
newList2.Reverse();
foreach (var item in newList2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-----------------");
newList2.Reverse();
foreach (var item in newList2)
{
    System.Console.WriteLine(item);
}
// 19
System.Console.WriteLine("-----------------");
var newList3 =newList2.ToList();
System.Console.WriteLine(string.Join(", ", newList3));