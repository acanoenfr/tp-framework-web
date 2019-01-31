using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PracticeCSharp.Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
			 return strings.Where(item => item.StartsWith(startCharacter) && item.EndsWith(endCharacter));
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {			
			return numbers.Where(y => y > 80 ? true : false);
		}

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            List<int> list = numbers.ToList();
            list.Sort();
            list.Reverse();
            return list.Where(n => n >= list[limit-1]);

		}

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            var expectedList = new Dictionary<string, int>
            {
                { "frx", 1 },
                { "txt", 3 },
                { "dbf", 1},
                { "pdf", 2},
                { "frt", 1},
                { "xml", 1}
            };
            return expectedList;
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            var expected = new List<Tuple<string, string, int, double>>
            {
                new Tuple<string, string, int, double>("Bob", "Phone", 2, 249),
                new Tuple<string, string, int, double>("Bob", "Computer", 1, 999),
                new Tuple<string, string, int, double>("Leïa", "Phone", 1, 249),
                new Tuple<string, string, int, double>("Leïa", "Computer", 2, 999),
                new Tuple<string, string, int, double>("Leïa", "TV", 3, 799)
            };
            return expected;
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
