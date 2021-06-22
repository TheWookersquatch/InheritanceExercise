using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public Reptile( bool canMove = true, bool canBreath = true, bool isColdBlooded = true)
        {
            
            CanMove = canMove;
            CanBreath = canBreath;
            IsColdBlooded = isColdBlooded;
        }
        public bool IsColdBlooded { get; set; }
        public string AwakeHabit { get; set; }
        public bool NeedsUVB { get; set; }
        public string ReptileType { get; set; }

    }
}
