using Generic_Practise;

//IntList datas = new IntList();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);

//var response = datas.GetAll();
//foreach (var item in response)
//{
//    Console.WriteLine(item);
//}
//StringList stringList = new StringList();
//stringList.Add("salam");
//stringList.Add("sagol");
//stringList.Add("necesen");
//var result= stringList.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
DataList<string> datas = new DataList<string>();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//datas.Delete(2);
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<Book> books = new DataList<Book>();
//books.Add(new Book { Id = 1, Name = "test1" });
//books.Add(new Book { Id = 2, Name = "test2" });
//books.Add(new Book { Id = 3, Name = "test3" });
//var booksResult = books.GetAll();
//foreach (var item in booksResult)
//{
//    Console.WriteLine(item.Name);
//}

datas.Add("Fatima");
datas.Add("Sadigkhan");
datas.Add("Inji");
datas.Add("Gunel");
datas.Add("Elvin");

//datas.Delete("Elvin");
//var result=datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
datas.Delete("Fatima");
var result = datas.GetAll();
foreach (var item in result)
{
    Console.WriteLine(item);
}


