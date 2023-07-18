using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six-sided die (1 - 6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The random object to be shared between all Die objects 
        /// </summary>
        private static Random _r;

        /// <summary>
        /// Initializes the static random object to be shared among all Die objects
        /// </summary>
        static Die()
        {
            _r = new Random();
        }

        /// <summary>
        /// Creates a Die object and calls <see cref="Roll"/> so that it begins with a random face-up value
        /// </summary>
        public Die()
        {
            Roll();
        }


        /// <summary>
        /// Represents the current face-up value
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// Represents whether the die is held - True if the die is held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets <see cref="FaceValue"/> to a new number if the die is not held.
        /// Returns <see cref="FaceValue"/>.
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld)
            {
                FaceValue = (byte) _r.Next(1, 7);
            }

            return FaceValue;
        }
    }
}
