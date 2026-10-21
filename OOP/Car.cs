using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //public int Id;

        public int Id { get; set; }

        private string _model;

        public string Model
        {
            get { return _model ?? "N/A"; }
            set { _model = value.Length <= 20 ? value : value.Substring(0, 20); }
        }

        public int Speed { get; set; }

        ///clr will generate empty pramaterless constructor , if no user-defined constructor created
        //public Car(){ } //=> do nothing

        ///user-defined constructor
        public Car(int _id, string _model, int _speed)
        {
            Id = _id;
            Model = _model;
            Speed = _speed;

            Console.WriteLine("ctor 4");
        }

        public Car(int _id, string _model) : this(_id, _model, 320)
        {
            //Id = _id;
            //Model = _model;
            //Speed = 320;
            Console.WriteLine("ctor 3");
        }

        public Car(int _id) : this(_id, "BMW")
        {
            //Id = _id;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("ctor 2");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("ctor 1");
        }


    }
}
