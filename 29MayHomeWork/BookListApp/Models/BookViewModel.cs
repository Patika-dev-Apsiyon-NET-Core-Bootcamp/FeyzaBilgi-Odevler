using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Models
{
    public static class BookViewModel
    {
        public static List<BookModel> bookModels = new List<BookModel>
            {
                new BookModel{Id=1,Name="Guguk Kuşu",Author="Bilinmiyor"},
                new BookModel{Id=2,Name="1984",Author="Bilinmiyor"},
                new BookModel{Id=3,Name="Kozmos",Author="Bilinmiyor"},
                new BookModel{Id=4,Name="Biliçaltının Gücü",Author="Bilinmiyor"},
                new BookModel{Id=5,Name="Beyin",Author="Bilinmiyor"},
            };
        public static List<BookModel> BookModels
        {
            get
            {
                return bookModels;
            }
        }
        public static void AddBookModel(BookModel bookModel)
        {
            bookModels.Add(bookModel);
        }
    }
}
