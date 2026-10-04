using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_7__assignment
{
    internal class StandardShipment : Shipment
    {
        #region Constructors

        public StandardShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination) : base(trackingCode, description, weight, delivaryFee, destination)
        {

        }

        #endregion
        #region Methods

        public override void PrintShipment()
        {
            Console.WriteLine("Standerd shipment\n");
            base.PrintShipment();
        }
        #endregion
    }
}
