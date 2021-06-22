using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public Bird(string babyName = "chick", bool canMove = true, bool canBreath = true )
        {
            BabyName = babyName;
            CanMove = canMove;
            CanBreath = canBreath;

        }
        public string LocomotionType { get; set; }
        public bool HasFeathers { get; set; }
        public string BeakOrBill { get; set; }
        public string NestType { get; set; }

    }
}
