// See https://aka.ms/new-console-template for more information
using ConsoleAppEF.Core.Entities;
using ConsoleAppEF.DatabaseAccess;
using ConsoleAppEF.DTOs;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("EF Project");

AppDbContext context = new AppDbContext();


#region Add
//Product product1 = new()
//{
//    Name = "Honor",
//    Price = 2000
//};
//Product product2 = new()
//{
//    Name = "Sony Ericson",
//    Price = 1050
//};
//Product product3 = new()
//{
//    Name = "Samsung",
//    Price = 1410
//};
//Product product4 = new()
//{
//    Name = "Panasonic",
//    Price = 1500
//};
//await context.Products.AddRangeAsync(product1, product2, product3, product4, product4);
//await context.Products.AddAsync(product1); // first adding method
//context.Entry(product1).State = EntityState.Added; // second adding method
//await context.AddAsync(product1);// third adding method
//Console.WriteLine(context.Entry(product1).State);
//await context.Products.AddAsync(product4);
//Console.WriteLine(product.Id);
//Product product = new()
//{
//    Name = "Sony Xperia Z",
//    Price = 2500
//};
//context.Entry(product).State = EntityState.Added;

//await context.SaveChangesAsync();
#endregion
#region Attach

#endregion
#region Select
//Product? product = context.Products.FirstOrDefault(p=> p.Id == 5);
//Product? product = context.Products.Where(p=> p.Id == 5).FirstOrDefault();
//Product product = await context.Products.FirstAsync(p=> p.Id == 7);
//Product product = await context.Products.Where(p => p.Id > 5 && p.Id < 9).FirstAsync();
//Product? product = await context.Products.FindAsync(5);
//#pragma warning disable CS8602 // Dereference of a possibly null reference.
//Console.WriteLine(value: $"Name: {product.Name}");
//#pragma warning restore CS8602 // Dereference of a possibly null reference.
#endregion
#region Update
//Product? product = await context.Products.FindAsync(5);
//Console.WriteLine(value: product.Name) ;
//product.Price = 1400;
//Console.WriteLine(context.Entry(product).State);
//Product product = new()
//{
//    Id = 10,
//    Name = "Sony Xperia Z",
//    Price = 2500
//};

//context.Entry(product).State = EntityState.Modified;
////context.Update(product);//not recommended with async
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(product).State);
#endregion
#region Delete
//Product product = await context.Products.FindAsync(2);

//context.Products.Remove(entity: product);
//Console.WriteLine(context.Entry(product).State);

//Product product = new()
//{
//    Id = 5
//};
//context.Entry(product).State = EntityState.Deleted;
//context.Remove(product);
//await context.SaveChangesAsync();
//Console.WriteLine(value: product.Name);

#endregion
#region IQuerable and IEnumarable
//var result = context.Products;
//foreach (var item in result)
//{
//    Console.WriteLine($"Id: {item.Id}, Model: {item.Name}, Price: {item.Price}");
//}//IEnumarable
//decimal tempPrice = 1300;
//var result = context.Products.Where(p=>p.Price>tempPrice).ToList();//IEnumarable
//var result = context.Products.Where(p => p.Price > tempPrice);//IQuerable
//tempPrice = 1600;
//Console.WriteLine();
//foreach (var item in result)
//{
//    Console.WriteLine($"Id: {item.Id}, Model: {item.Name}, Price: {item.Price}");
//}
#endregion
#region Select
//var product = await context.Products.SingleAsync(p => p.Id == 6);
//var product = await context.Products.SingleAsync(p => p.Name.Contains("Sony"));
//var product = await context.Products.SingleOrDefaultAsync(p => p.Id == 10);
//var product = await context.Products.Where(p => p.Name.Contains("Lum") && p.Price>=1000).SingleOrDefaultAsync();
//var product = await context.Products.Where(p => p.Price > 1000).OrderBy(p=>p.Price).FirstAsync();
//var product = await context.Products.Where(p => p.Price > 2500).FirstAsync();
//var product = await context.Products.Where(p => p.Price > 2000).FirstOrDefaultAsync();
//var product = await context.Products.
//                            Where(p => p.Price > 1000).
//                            OrderBy(p => p.Price).
//                            LastOrDefaultAsync();
//var product = await context.Products.FindAsync(10);//working with primary key
//var product = await context.Products.AsNoTracking().ToListAsync();//select command usually use AsNoTracking for performance issues
//var product = await context.Products.ToListAsync();
//var product = await context.Products.
//                    Where(p => p.Price > 100).
//                    AsNoTracking().
//                    ToListAsync();
//var result = context.ChangeTracker.Entries();
//Console.WriteLine(result);
//Console.WriteLine($"Id: {product.Id}, Model: {product.Name}, Price: {product.Price}");
//var product = await context.Products.
//                    Where(p => p.Price > 1000).
//                    ToArrayAsync();
//Console.WriteLine(product[0].Name);

//var product = await context.Products.//Select method
//                    Where(p => p.Price > 1000).
//                    AsNoTracking().
//                    Select(p=> new ProductSelectDTO
//                    {
//                        Product = p.Name,
//                        Price = p.Price
//                    }).
//                    ToListAsync();
//foreach(var item in product)
//{
//Console.WriteLine($"Product: {item.Product}, Price: {item.Price}");
//}
#endregion
#region Dictionary

//Setting setting1 = new()
//{
//    Key = "Phone Number",
//    Value = "0552029291"
//};

//Setting setting2 = new()
//{
//    Key = "Email",
//    Value = "elkhantma@code.edu.az"
//};

//Setting setting3 = new()
//{
//    Key = "Address",
//    Value = "Yasamal Rayonu"
//};

//await context.Settings.AddRangeAsync(setting1, setting2, setting3);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(setting1).State);

//var setting = await context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);//Dictionary

//Console.WriteLine(setting["Phone Number"]);

//var products = context.Products.OrderBy(p => p.Name).ThenBy(p => p.Price);//OrderBy ThenBy
//var product =await context.Products.OrderBy(p => p.Name).ThenByDescending(p => p.Price).FirstAsync();
//Console.WriteLine(value: $"Name: {product.Name}");


#endregion
#region Count, All, Any, Contain
//var productCount = await context.Products.Where(p => p.Price > 1000).CountAsync();
//Console.WriteLine(productCount);

//bool isExist = await context.Products.Where(p=> p.Price == 1000).AnyAsync();
//Console.WriteLine(isExist);

//bool allExist = await context.Products.AllAsync(p => p.Price > 1000);
//Console.WriteLine(allExist);

//decimal maxPrice = (decimal) await context.Products.MaxAsync(x => x.Price);
//Console.WriteLine(maxPrice);

//decimal minPrice = (decimal) await context.Products.MinAsync(x => x.Price);
//Console.WriteLine(minPrice);

//decimal averagePrice = (decimal) await context.Products.AverageAsync(x => x.Price);
//Console.WriteLine(averagePrice);

//decimal sumPrice = (decimal)await context.Products.SumAsync(x => x.Price);
//Console.WriteLine(sumPrice);

//var product = await context.Products.Select(p => p.Name).Distinct().ToListAsync();
//foreach (var item in product)
//{
//    Console.WriteLine(item);
//}

//var product = await context.Products.Where(p => p.Name.Contains("Sony")).ToListAsync();
//foreach(var item in product)
//{
//    Console.WriteLine(item.Name);
//}
#endregion
#region One To One

#endregion
#region One To Many

#endregion
#region Many To Many

#endregion