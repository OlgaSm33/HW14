using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    public class PhoneBook
    {
        public List<Contact> _contacts { get; set; }


        public PhoneBook(List<Contact> contacts)
        {
            _contacts = contacts;
        }

        public PhoneBook()
        {
            _contacts = new List<Contact>();
        }

        /// <summary>
        /// добавление контакта в телефонную книгу
        /// </summary>
        /// <param name="contact"></param>
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            _contacts = _contacts.OrderBy(contact => contact.Name).ThenBy(contact => contact.LastName).ToList();
        }

        /// <summary>
        /// метод, реализующий постраничный вывод контаков
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="contactsOnPageCount"></param>
        /// <exception cref="ArgumentException"></exception>
        public void ContactsShowByPages(int pageNumber, int contactsOnPageCount = 2)
        {
            int contactsCount = _contacts.Count();
            int pagesCount = Convert.ToInt32(Math.Round(contactsCount / (double)contactsOnPageCount, MidpointRounding.AwayFromZero));
            IEnumerable<Contact> page;
            switch (pageNumber)
            {
                case int n when (n >= 1 && n <= pagesCount):

                    int skipCount = (n - 1) * contactsOnPageCount;
                    page = _contacts.Skip(skipCount).Take(contactsOnPageCount);
                    break;
                default:
                    page = null;
                    break;
            }
            if (page == null)
            {
                throw new ArgumentException("Страница не существует");
            }
            else
            {
                foreach (var item in page)
                {
                    Console.WriteLine(item.Name + " " + item.LastName + " " + item.PhoneNumber);
                }
            }
        }
    }
}
