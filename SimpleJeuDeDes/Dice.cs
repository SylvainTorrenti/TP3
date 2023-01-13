using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJeuDeDes
{
    public class Dice
    {
        #region Attribute
        private static int _diceNb = 1;
        private int _value;
        private int _number = DiceNb;
        #endregion
        public Dice()
        {
            DiceNb++;
        }
        #region Get value
        /// <summary>
        /// Value of Dice
        /// </summary>
        public int Value { get => _value; }
        #endregion
        #region Get & Set number
        /// <summary>
        /// Number of the Dice
        /// </summary>
        public int Number { get => _number; set => _number = value; }
        #endregion
        #region Get & Set DiceNb
        public static int DiceNb { get => _diceNb; set => _diceNb = value; }
        #endregion
        #region Method
        /// <summary>
        /// Method to display Dice
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Le dé {Number} a pour valeur : {Value}");
        }
        /// <summary>
        /// Method to launch Dice
        /// </summary>
        public int Launch()
        {
            Random valueRandom = new Random();
            this._value = valueRandom.Next(1, 7);
            return this._value;
        }
        #endregion
    }

}
