using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct PhoneBook
    {
        string[] Names;
        string[] Numbers;

        /// number of elemnts in Phonebook
        public int Count { get; private set; }

        /// capcity of phone book
        /// //[max number of elements can be saved in phonebook]
        public int Size { get; private set; }

        //Constructor Chaining : 
        ///calling one constructor from another constructor in the same Struct or Class
        public PhoneBook() : this(4) //=> refer to anthor constructor that take one parameter
        {
            //Names = default; //null
            //Numbers = default; //null
            //Names = new string[4];
            //Numbers = new string[4];
        }

        public PhoneBook(int _size)
        {
            Size = _size < 4 ? 4 : _size;
            Names = new string[Size];
            Numbers = new string[Size];
            Count = 0;
        }

        public void AddContact(string _name, string _number)
        {
            if (Count == Size)
            {
                //Console.WriteLine("PhoneBook is full");
                //return;

                //resizing
                Resizing();
            }
            this.Names[Count] = _name;
            this.Numbers[Count] = _number;
            Count++;

            Console.WriteLine("Contact Added Successfully");

        }

        public void RemoveContact(string _name)
        {
            // step 1 : find the contact index
            int index = Array.IndexOf(Names, _name, 0, Count);

            // step 2 : check if contact exists 
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            // step 3 : shift elements to left
            for (int i = index; i < Count - 1; i++)
            {
                Names[i] = Names[i + 1];
                Numbers[i] = Numbers[i + 1];
            }

            // step 4 : clear last postion
            Names[Count - 1] = null;
            Numbers[Count - 1] = null;

            //Array.Clear(Names, Count - 1, 1);
            //Array.Clear(Numbers, Count - 1, 1);

            // step 5 : update count
            Count--;

            Console.WriteLine("Contact Removed Successfully");
        }

        public void SetContact(string _name, string _number)
        {
            // step 1 : find the contact index
            int index = Array.IndexOf(Names, _name, 0, Count);

            // step 2 : check if contact exists 
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            Numbers[index] = _number;
            Console.WriteLine("Contact Set Successfully");
        }

        public string GetContact(string _name)
        {
            // step 1 : find the contact index
            int index = Array.IndexOf(Names, _name, 0, Count);

            // step 2 : check if contact exists 
            if (index == -1)
            {
                return "Contact not found";
            }

            return Numbers[index];
        }

        public string this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    Console.WriteLine("out of range");
                    return string.Empty;
                }
                return $"{Names[i]} => {Numbers[i]}";
            }
        }

        public string this[string _name] 
        {
            get
            {
                // step 1 : find the contact index
                int index = Array.IndexOf(Names, _name, 0, Count);

                // step 2 : check if contact exists 
                if (index == -1)
                {
                    return "Contact not found";
                }

                return Numbers[index];
            }
            set
            {
                // step 1 : find the contact index
                int index = Array.IndexOf(Names, _name, 0, Count);

                // step 2 : check if contact exists 
                if (index == -1)
                {
                    Console.WriteLine("Contact not found");
                    return;
                }

                Numbers[index] = value;
                Console.WriteLine("Contact Set Successfully");
            } 
        }

        private void Resizing()
        {
            Size *= 2;
            string[] newnames = new string[Size];
            string[] newnumbers = new string[Size];

            Names.CopyTo(newnames, 0);
            Numbers.CopyTo(newnumbers, 0);

            Names = newnames;
            Numbers = newnumbers;
        }
    }
}
