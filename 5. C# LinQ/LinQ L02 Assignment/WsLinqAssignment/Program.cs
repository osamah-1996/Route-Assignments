using static WsLinqAssignment.ListGenerators;
namespace WsLinqAssignment
{
    class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x)== Sort(y);
        }

        public int GetHashCode(string obj)
        {
            return Sort(obj).GetHashCode();
        }


        string Sort(string obj)
        {
            var word = obj.ToCharArray();
            Array.Sort(word);
            return new string(word);
        }
    }
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y,StringComparison.OrdinalIgnoreCase);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
 
            #region LINQ - Aggregate Operators
            #region 1.Get the total units in stock for each product category.

            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    UnitsInStock = p.Sum(x => x.UnitsInStock)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
            #region 2.Get the cheapest price among each category's products

            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    UnitPrice = p.Min(x => x.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3.Get the products with the cheapest price in each category(Use Let)

            //var result = from p in ProductList
            //    group p by p.Category
            //    into pc
            //    let cheapest = pc.Where(p => p.UnitPrice == pc.Min(p => p.UnitPrice))
            //    select cheapest;

            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine($"Category {i.Category} , UnitPrice {i.UnitPrice} , ProductName {i.ProductName}");
            //    }
            //}




            #endregion
            #region 4.Get the most expensive price among each category's products.

            //var result = from p in ProductList
            //             group p by p.Category
            //    into pc
            //             let cheapest = pc.Where(p => p.UnitPrice == pc.Max(p => p.UnitPrice))
            //             select cheapest;

            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine($"Category {i.Category} , UnitPrice {i.UnitPrice} , ProductName {i.ProductName}");
            //    }
            //}



            #endregion
            #region 5.Get the products with the most expensive price in each category.


            //var result = from p in ProductList
            //             group p by p.Category
            //    into pc
            //             let cheapest = pc.Where(p => p.UnitPrice == pc.Max(p => p.UnitPrice))
            //             select cheapest;

            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine($"Category {i.Category} , UnitPrice {i.UnitPrice} , ProductName {i.ProductName}");
            //    }
            //}

            #endregion
            #region 6.Get the average price of each category's products.

            //var result = ProductList.GroupBy(c => c.Category).Select(p => new
            //{
            //    p.Key,
            //    AvgPrice = p.Average(i=> i.UnitPrice)
            //});

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #endregion

            #region LINQ – Set Operators

            #region 1. Find the unique Category names from Product List

            //var result1 = ProductList.Select(p => p.Category).Distinct();

            //foreach (var i in result1)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result2 = ProductList.Select(p => p.ProductName[0])
            //    .Union(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var c in result2)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result3 = ProductList.Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var c in result3)
            //{
            //    Console.WriteLine(c);
            }

        #endregion

        #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

        //var result4 = ProductList.Select(p => p.ProductName[0])
        //    .Except(CustomerList.Select(c => c.CustomerName[0]));

        //foreach (var c in result4)
        //{
        //    Console.WriteLine(c);
        //}

        #endregion

        #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

        //var result5 = ProductList.Select(p => p.ProductName[^3..])
        //    .Concat(CustomerList.Select(c => c.CustomerName[^3..]));

        //foreach (var c in result5)
        //{
        //    Console.WriteLine(c);
        //}

        #endregion

        #endregion

            #region LINQ – Partitioning Operators

        #region 1.Get the first 3 orders from customers in Washington

        //var result = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

        //foreach (var order in result)
        //{
        //    Console.WriteLine(order);
        //}

        #endregion

        #region 2.Get all but the first 2 orders from customers in Washington.
        //var result = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

        //foreach (var order in result)
        //{
        //    Console.WriteLine(order);
        //}

        #endregion

        #region 3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var result = numbers.TakeWhile((n, i) => n > i);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}


        #endregion

        #region 4.Get the elements of the array starting from the first element divisible by 3.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var result = numbers.SkipWhile(n=> n % 3 != 0);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}


        #endregion

        #region 5.Get the elements of the array starting from the first element less than its position.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


        //var result = numbers.SkipWhile((n, i) => n > i);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #endregion

            #region LINQ – Quantifiers Operators

        #region 1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

        //var result = words.Any(w => w.Contains("ei"));

        //Console.WriteLine(result);


        #endregion

        #region 2.Return a grouped list of products only for categories that have at least one product that is out of stock.

        //var result = ProductList.GroupBy(c => c.Category).Where(c => c.Any(p => p.UnitsInStock == 0))
        //    .Select(p => p);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i.Key);
        //    foreach (var p in i)
        //    {
        //        Console.WriteLine(p);
        //    }
        //}

        #endregion

        #region 3.Return a grouped list of products only for categories that have all of their products in stock.

        //var result = ProductList.GroupBy(c => c.Category).Where(c => c.All(p => p.UnitsInStock > 0))
        //    .Select(p => p);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i.Key);
        //    foreach (var p in i)
        //    {
        //        Console.WriteLine(p);
        //    }
        //}
        #endregion

        #endregion

            #region LINQ – Grouping Operators

        #region 1.Use group by to partition a list of numbers by their remainder when divided by 5

        //Result:
        //Numbers With a remainder of 0 when divided by 5:
        //0
        //5
        //10
        //15
        //Numbers With a remainder of 1 when divided by 5:
        //1
        //6
        //11
        //Numbers With a remainder of 2 when divided by 5:
        //2
        //7
        //12
        //Numbers With a remainder of 3 when divided by 5:
        //3
        //8
        //13
        //Numbers With a remainder of 4 when divided by 5:
        //4
        //9
        //14

        //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var result = numbers.GroupBy(n => n % 5);

        //foreach (var i in result)
        //{
        //    Console.WriteLine($"Numbers With a remainder of {i.Key} when divided by 5");
        //    foreach (var n in i)
        //        Console.WriteLine(n);
        //}

        #endregion

        #region 2.Uses group by to partition a list of words by their first letter(Use dictionary_english.txt for Input).

        //string[] Lines = File.ReadAllLines("dictionary_english.txt");

        //var result = Lines.GroupBy(w => w[0]);

        //foreach (var i in result)
        //{
        //    Console.WriteLine(i.Key);
        //    foreach (var n in i)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}


        #endregion

        #region 3.Consider this Array as an Input

        // Use Group By with a custom comparer that matches words that are consists of the same Characters Together

        //Result:
        //from
        //form
        //....
        //salt
        //last
        //....
        //earn
        //near
        //....

        //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

        //var result = Arr.GroupBy(w => w.Trim(), new EqualityComparer());

        //foreach (var word in result)
        //{
        //    foreach (var item in word)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #endregion

    }
}