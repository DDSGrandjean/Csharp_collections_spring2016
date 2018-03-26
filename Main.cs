using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Collections
{
    class Main
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("Chris");
            nameList.Add("Lori");
            nameList.Add("Mike");

            MessageBox.Show("Count is " + nameList.Count);
            string str = string.Empty;
            DisplayList(nameList);

            nameList.Insert(0, "Amy");

            DisplayList(nameList);

            int position = nameList.IndexOf("Lori");
            if (position == -1)
                MessageBox.Show("Not found");
            else
                MessageBox.Show("Index is " + position);

            nameList.RemoveAt(position);
            DisplayList(nameList);
            LINQ(nameList);
        }
        private static void DisplayList(List<string> nList)
        {
            string str = string.Empty;
            foreach (string item in nList)
                str += item + "\n";
            MessageBox.Show(str);
        }
        private static void LINQ(List<string> nList)
        {
            string name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            var record = from item in nList
                         where name.ToUpper() == item.ToUpper()
                         select item;
            Console.WriteLine(record);

            foreach (var item in record)
                Console.WriteLine(item);
        }
    }
}
