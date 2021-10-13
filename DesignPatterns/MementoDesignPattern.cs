using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MementoDesignPattern
    {
    }

    class Book
    {
        private string title;
        private string author;
        private string ısbn;
        DateTime lastEdited;

        public string Title { 
            get => title; 
            set
            {
                title = value;
                SetLastEdited();
            }
        }
        public string Author { 
            get => author; 
            set
            {
                author = value;
                SetLastEdited();
            }
        }
        public string Isbn { 
            get => ısbn; 
            set
            {
                ısbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited()
        {
            lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(Isbn, title, author, lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            title = memento.Title;
            author = memento.Author;
            Isbn = memento.Isbn;
            lastEdited = memento.LastEdited;
        }

    }

    class Memento
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string isbn, string title, string author, DateTime lastEdit)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdit;
        }
    }

    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
