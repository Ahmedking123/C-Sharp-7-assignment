using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_7__assignment
{
    internal class ExpressShipment : Shipment
    {
        #region Fields

        private decimal _extraFee;

        #endregion
        #region Constructors

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            ExtraFee = extraFee;
        }

        #endregion
        #region Properties

        public decimal ExtraFee
        {
            get
            {
                return _extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost => DeliveryFee + ExtraFee + (Weight * 5);

        #endregion

        #region Methods
        public override void PrintShipment()
        {
            Console.WriteLine("ExpressShipment\n");

            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {_extraFee}");
        }

        #endregion
    }
}
