using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmet_2
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        // DeliveryFee + (Weight × 5) + ExtraFee
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight,
                               decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        protected override string ShipmentType
        {
            get { return "Express Shipment"; }
        }

        protected override void PrintExtraDetails()
        {
            PrintLine("Extra Fee", $"{ExtraFee} EGP");
        }
    }

}

