using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller;

/// <summary>
/// Represents a die used in games or simulations, with a configurable number of sides.
/// </summary>
/// <remarks>The <see cref="Die"/> class models a standard die, commonly used in board games or random number
/// generation. The number of sides is fixed upon creation and cannot be modified.</remarks>

public class Die
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Die"/> class with the specified number of sides.
    /// </summary>
    /// <param name="numSides">The number of sides on the die. Must be greater than zero.</param>
    public Die(byte numSides) 
    {
        if (numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), $"{nameof(numSides)} must be greater than 0 and less than 21.");
        }
        NumberOfSides = numSides;
    }

    /// <summary>
    /// Gets the number of sides of the die.
    /// </summary>
    public byte NumberOfSides { get; private set; }
}