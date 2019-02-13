using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AfterMidXML
{
    class Program
    {
        static void Main(string[] args)
        {


            XElement books = XElement.Load("Books.xml");
            XElement authors = XElement.Load("Authors.xml");
            XElement publishers = XElement.Load("Publishers.xml");


            var res = books.Elements("Book").Join(

                authors.Elements("Author"),

                b => b.Attribute("AuthorId").Value,

                a => a.Attribute("id").Value,

                (b, a) => new { Book = b, Author = a  }

                );

            foreach (var item in res)
            {
                Console.WriteLine($"Author Name: {item.Author.Element("Name").Value} ;;; Book Name: {item.Book.Element("Title").Value}");
            }



            Console.ReadKey();



        }
    }
}
