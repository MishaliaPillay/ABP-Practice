using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace PracticeProject.Entities
{
    public class Book : AggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        //needed for efcore because efcore needs a way to instantiate objects without getting data from db
        private Book()
        {

        }
        public Book(Guid id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;

        }


    }
}
