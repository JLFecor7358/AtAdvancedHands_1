using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtAdvancedHands1
{
    public class Person
    {
        //class field
        private String name;
        private int age;
        private Boolean canWalk;

        //constructor
        public Person(String name) {
            this.name = name;
        }

        //class property
        public String GetName()
        {
            return name;
        }
        //class property
        public int GetAge()
        {
            return age;
        }
        //class property
        public void SetAge(int value)
        {
            this.age = value;
            if (age < 2 || age > 89)
                canWalk = false;
            else
                canWalk = true;
        }
        //class property
        public Boolean GetWalk()
        {
            return canWalk;
        }
    }
    }