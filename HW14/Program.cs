namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.AddContact(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.AddContact(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.AddContact(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.AddContact(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.AddContact(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.AddContact(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            phoneBook.AddContact(new Contact("Игорь", "Васильев", 799998000001, "igorVas@example.com"));
            phoneBook.AddContact(new Contact("Игорь", "Граченко", 799998000001, "igorGrach@example.com"));
            phoneBook.AddContact(new Contact("Филипп", "Киркоров", 799998000001, "fillKirkorov@example.com"));


            while (true)
            {
                Console.WriteLine("Введите номер страницы");
                try
                {
                    int str = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        phoneBook.ContactsShowByPages(str);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Вы ввели не числовое значение. Попробуйте ещё раз");
                }

                Console.WriteLine();

            }
        }
    }
}
