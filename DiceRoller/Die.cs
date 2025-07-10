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
    private static readonly Random rand = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Die"/> class with the specified number of sides.
    /// </summary>
    /// <param name="numSides">The number of sides on the die. Must be greater than zero.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when invalid number of sides is entered</exception>
    public Die(byte numSides) 
    {
        if (numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), $"{nameof(numSides)} must be greater than 0 and less than 21.");
        }
        NumberOfSides = numSides;

        // Automatically roll the die upon creation, starts with a random number.
        Roll();
    }

    /// <summary>
    /// Gets the number of sides of the die.
    /// </summary>
    public byte NumberOfSides { get; private set; }

    /// <summary>
    /// Gets the current value being displayed after a roll.
    /// </summary>
    public byte ShowingValue { get; private set; }

    /// <summary>
    /// Simulates rolling the die and returns the resulting value.
    /// </summary>
    /// <remarks>The result is a random number between 1 and the number of sides on the die,
    /// inclusive.</remarks>
    /// <returns>A byte representing the value rolled, ranging from 1 to the number of sides on the die.</returns>
    public byte Roll()
    {
        ShowingValue = Convert.ToByte(rand.Next(1, NumberOfSides + 1));

        return ShowingValue;
    }
}