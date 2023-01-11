using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJeuDeDes
{
    internal class Dice
    {
        #region Attribute
        private int value;
        private int number; 
        #endregion
        #region Get value
        public int GetValue()
        {
            return value;
        }

        #endregion
        #region Get & Set number
        public int GetNumber()
        {
            return value;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        #endregion
        #region Method
        /// <summary>
        /// Method to display Dice
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Valeur : {value}");
        }
        /// <summary>
        /// Method to launch Dice
        /// </summary>
        public void Launch()
        {
            Random valueRandom = new Random();
            this.value = valueRandom.Next(1, 6);
        } 
        #endregion
    }

}
