using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_7__assignment
{
    internal class Driver
    {
        #region Fields

        private string _name = default!;


        #endregion
        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }
        #endregion
        #region Constructors

        public Driver(string name)
        {
            Name = name;
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Driver Name: {Name}";
        }
        #endregion
    }
}
