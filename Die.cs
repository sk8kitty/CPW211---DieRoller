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
        /// Represents the current face-up value
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// Represents whether the die is held - True if the die is held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets <see cref="FaceValue"/> to the new number.
        /// Returns the new number.
        /// </summary>
        public void Roll()
        {
            // Generate random number
            // Set FaceValue
            // Return number
            throw new NotImplementedException();
        }
    }
}
