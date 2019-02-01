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
            return list.Where(n => n >= list[limit - 1]);

        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
			/*var FileGrp = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower()).GroupBy(z => z, (fExt, extCtr) => new
			{
				Extension = fExt,
				Count = extCtr.Count()
			});
			foreach(var num in FileGrp)
			{

				Console.WriteLine(num);
			}*/
			var dict = new Dictionary<string, int>();
			var egrp = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
					 .GroupBy(x => x, (ext, extCnt) => new
					 {
						 Extension = ext,
						 Count = extCnt.Count()
					 });

			foreach (var v in egrp)
			{
				dict.Add(v.Extension, v.Count);
			}
			return dict;

           
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
			//
			List<Tuple<string, string, int, double>> resultat = new List<Tuple<string, string, int, double>>();
			foreach(Purchase achats in purchases)
			{
				List<Client> cli = clients.Where(m => m.Id == achats.ClientId).ToList();
				List<Item> product = items.Where(m => m.Id == achats.ItemId).ToList();

				string cliNom = cli[0].Name;
				string productName = product[0].Label;
				int quantite = achats.Quantity;
				double price = product[0].Price;


				Tuple<string, string, int, double> commande = Tuple.Create(cliNom, productName, quantite, price);
				resultat.Add(commande); 
			}
			IEnumerable<Tuple<string, string, int, double>> myresult = resultat;
			return myresult;

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
