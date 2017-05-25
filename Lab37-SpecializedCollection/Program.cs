using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
namespace Lab37_SpecializedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========start of CollectionUtile ===============================");
            Hashtable tw = CollectionsUtil.CreateCaseInsensitiveHashtable();
            tw.Add("sa","sagar");
            tw.Add("ma", "madam");
            Console.WriteLine(tw["SA"]);

            Console.WriteLine("=========start of ListtDictionry ===============================");
            ListDictionary ls = new ListDictionary();
            ls.Add("sa", "sujit");
            ls.Add("ma", "madam");
            Console.WriteLine(ls["sa"]);

            Console.WriteLine("================start of hybrid Dictionary========================");
            HybridDictionary hs = new HybridDictionary();
            hs.Add("sa", "prem");
            hs.Add("ma", "madam");
            Console.WriteLine(hs["sa"]);


            Console.WriteLine("===============String Collection=========================");
            StringCollection st = new StringCollection();
            st.Add("sagar");
            st.Add("sujit");
            Console.WriteLine(st[0]);

            Console.WriteLine("========================================");

            Console.Read();
        }
    }
}
