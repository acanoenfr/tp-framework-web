﻿using System;
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
			
			
			//item cest mon objet
			 return strings.Where(item => item.StartsWith(startCharacter) && item.EndsWith(endCharacter));

			

        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
			foreach(var lstnum in numbers)
			{
				Console.WriteLine(lstnum + " ");
			}
			
			return numbers.Where(y => y > 80 ? true : false);
		}

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
			throw new NotImplementedException();

		}

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
			var FileGrp = files.Select(file => Path.GetExtension(file).TrimStart('.').Tolower()).Groupby(z => z, (fExt, extCtr) => new
			{
				Extension = fExt,
				Count = extCtr.count()
			});
			return FileGrp;


        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            throw new NotImplementedException();
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
