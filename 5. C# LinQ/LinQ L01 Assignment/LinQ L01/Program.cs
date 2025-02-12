using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.XPath;
using static LinQ_L01.ListGenerator;
namespace LinQ_L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            // Method 1 :Suing the Fluent Syntax
            //var Products = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var Product in Products)
            //{
            //    Console.WriteLine(Product);
            //}

            //Method 2: Using the Query Syntx
            //var Products = from product in ProductsList
            //               where (product.UnitsInStock == 0)
            //               select product;
            //foreach (var product in Products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //Method 1: Using the Fluent Syntax
            //var Products = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var Product in Products)
            //{
            //    Console.WriteLine(Product);
            //}
            //Method 2: Using the Query Syntax
            //var Products = from product in ProductsList
            //               where product.UnitsInStock > 0 && product.UnitPrice > 3.00M
            //               select product;
            //foreach (var product in Products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 3. Returns digits whose name is shorter than their value.


            #endregion

            //LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //Method 1: Using the Fluent Mehtod
            //var Product = ProductsList.Where(p => p.UnitsInStock == 0).First();
            //Console.WriteLine(Product);
            //Method 2: Using the Query Syntax
            //var Product = (from product in ProductsList
            //              where product.UnitsInStock == 0
            //              select product).First();
            //Console.WriteLine(Product);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //Method 1: Using the Fluent Syntax
            //var product = ProductsList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(product);
            //Method 2: Using the Query Syntax
            //var Product = (from product in ProductsList
            //              where product.UnitPrice > 1000
            //              select product).FirstOrDefault();
            //Console.WriteLine(Product);
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Method 1: Fluent Syntax
            //var order = Arr.OrderBy(x => x);
            //var second = order.Where(p => p > 6).First();
            //Console.WriteLine(second);

            //Method 2: Quesy Syntax
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Results = (from product in Arr.OrderBy(x => x)
            //               where product > 6
            //               select product
            //               ).First();
            //Console.WriteLine(Results);              
            #endregion
            //LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Method 1: Using the Fluent Syntax
            //var Results = Arr.Where(p => p % 2 == 1).Count();
            //Console.WriteLine($"Number of Odd Element is {Results}");
            //Method 2: Using the Query Syntax
            //var Resultss = (from array in Arr
            //                where array % 2 == 1
            //                select array).Count();
            //Console.WriteLine($"Number of Odd Element is {Resultss}");
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //Method 1: Using the Fluent Syntax
            //var Results = CustomersList.Select(p => new
            //{
            //    CustomerName = p.CustomerName,
            //    NumberOfOrders = p.Orders.Count(),
            //});
            //foreach (var Result in Results)
            //{
            //    Console.WriteLine(Result);
            //}
            //Console.WriteLine(Results);

            //Method 2: Using the Query Syntax
            //var Results = from cutomer in CustomersList
            //              select new 
            //              {
            //                  CustomerName   = cutomer.CustomerName,
            //                  CustomerOrders = cutomer.Orders.Count()
            //              };
            //foreach ( var result in Results )
            //{
            //    Console.WriteLine( result );
            //}
            #endregion
            #region 3. Return a list of categories and how many products each has
            //Method 1 :Using the Fluent Syntax
            //var Results = ProductsList.Select(p => new
            //                                  {
            //                                    Category      = p.Category,
            //                                    TotalProducts = p.Category.Count()
            //                                  }
            //                                  );
            //foreach ( var item in Results )
            //{
            //    Console.WriteLine( item );
            //}
            //Method 2 :Using the Query Syntax
            //var Results = from product in ProductsList
            //              select new
            //              {
            //                  Category = product.Category,
            //                  TotlaProduct = product.Category.Count(),
            //              };
            //foreach ( var item in Results )
            //{
            //    Console.WriteLine( item );
            //}
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int [] Arrr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Method 1:Using the Fluent Syntax
            //var Results = Arrr.Sum();
            //Console.WriteLine(Results);
            //Method 2: Using the Query Syntax
            //var Results = (from pro in Arr
            //              select pro).Sum();
            //Console.WriteLine($"The Sum is {Results}");
            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            #endregion
            //LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //Method 1: Fluent Syntax
            //var Results = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var Result in Results)
            //{
            //    Console.WriteLine(Result);
            //}
            //Method 2: Query Syntax
            //var Results = from product in ProductsList.OrderBy(p => p.ProductName)
            //              select product;
            //foreach (var Result in Results)
            //{
            //    Console.WriteLine(Result);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arrrr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Results  = Arrrr.OrderBy(x => x).ToList();
            //foreach ( var Result in Results )
            //{
            //    Console.WriteLine( Result );
            //}

            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Results  =  ProductsList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var Result in Results)
            //{
            //    Console.WriteLine(Result);
            //}

            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arrr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //First Approch
            //var bylengthNae = Arrr.OrderBy(p => p.Length);
            //foreach(var i in bylengthNae)
            //{
            //    Console.WriteLine(i);
            //}
            //Second Approch
            //var alphabeticallyByName = (from name in Arrr
            //                           select name);
            //foreach(var a in alphabeticallyByName)
            //{
            //    Console.WriteLine(a);
            //}
            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arrrr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arrrr.OrderBy(p => p.Length);
            //foreach (var i in Arrrr)
            //{
            //    Console.WriteLine(i);
            //}
            //var Result = Arrrr.OrderBy(p => p);
            //foreach (var i in Arrrr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Reults01 = ProductsList.OrderByDescending(p => p.Category);
            //foreach (var Result in Results)
            //{
            //    Console.WriteLine(Result);
            //}
            //var Result02 =  from product in ProductsList
            //                orderby product.UnitPrice descending
            //                select product;
            //foreach (var result in Results)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arrd = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Results01 = Arrd.OrderBy(p => p.Length);
            //foreach (var Result in Results01)
            //{
            //    Console.WriteLine(Result);
            //}

            //String[] Arrd = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Rsult02 = from prod in Arrd
            //              orderby prod descending
            //              select prod;
            //foreach ( var r in Rsult02 )
            //{
            //    Console.WriteLine( r.ToString() );
            //}

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arrr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var filteredList = Arrr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();
            //foreach ( var item in filteredList )
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            //LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.


            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.


            #endregion
            #region 4. Determine if the value of int in an array matches their position in the array.
            int[] Arre = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.


            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.


            #endregion


        }
    }
}
