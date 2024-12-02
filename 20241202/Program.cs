using _20241202;
using System;
Random rnd = new Random();
var books = new List<Book>();
var authors = new List<Authors>();
List<string> Authors = new List<string>
{
    "Miklós Kovács",
    "Anna Tóth",
    "Peter Johnson",
    "Laura Brown",
    "László Nagy",
    "Éva Szabó",
    "Michael Williams",
    "Zoltán Tóth",
    "Sarah White",
    "Gábor Kiss", 
    "Emily Clark",
    "Ferenc Horváth",
    "Catherine King",
    "John Doe",
    "Jane Smith"
};
string[] Titles = new string[] 
{
    "A Rejtett Kincs",
    "Az Elveszett Falu",
    "Az Elvarázsolt Erdő",
    "Az Idő Őrzője",
    "A Csendes Megfigyelő",
    "A Titkos Kert",
    "A Végső Kaland",
    "Az Ősi Hagyaték",
    "A Visszatérés Útja",
    "A Végtelen Horizont",
    "Az Álmok Földje",
    "A Múlt Visszhangjai",
    "The Whispering Shadows",
    "Lost in Budapest",
    "The Forgotten Village"
};


for (int i = 0; i < 15; i++)
{
        int szam = (rnd.Next(10, 100))*100;
        
    authors.Add(new Authors(Authors[i]));
    books.Add(new Book(rnd.NextInt64(1000000000, 9999999999),
        authors,
        Titles[i],rnd.Next(2007,2025)
        ,rnd.NextDouble()<0.8?"magyar":"angol",
        rnd.NextDouble()>0.3?rnd.Next(5,10):0,
        szam
     ));
}
foreach (var e in books) {
    Console.WriteLine(e.ToString());
}