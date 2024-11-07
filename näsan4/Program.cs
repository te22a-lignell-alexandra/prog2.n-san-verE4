Book book1 = new() {Name = ":)", Pages = 2};
Book book2 = new() {Name = ":I", Pages = 4};
Book book3 = new() {Name = ":(", Pages = 6};

Console.WriteLine(book1.CurrentPage);
book1.TurnPage();
Console.WriteLine(book1.CurrentPage);

Console.ReadLine();