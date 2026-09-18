using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmet_2
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;         
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        
        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = !string.IsNullOrEmpty(trackingCode) ? trackingCode : "UNKNOWN";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = !string.IsNullOrEmpty(trackingCode) ? trackingCode : "UNKNOWN";
            this.description = !string.IsNullOrEmpty(description) ? description : "Unknown";
            this.weight = weight > 0 ? weight : 1;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee;
        }

       
        public virtual void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            PrintLine("Tracking Code", TrackingCode);
            PrintLine("Description", Description);
            PrintLine("Weight", $"{Weight} KG");
            PrintLine("Delivery Fee", $"{DeliveryFee} EGP");
            PrintLine("Destination", Destination.GetFullAddress());
            PrintExtraDetails();
            PrintLine("Estimated Cost", $"{EstimatedCost} EGP");
        }

        protected virtual string ShipmentType
        {
            get { return "Shipment"; }
        }

        protected virtual void PrintExtraDetails() { }

        protected static void PrintLine(string label, object value)
        {
            Console.WriteLine($"{label,-20}: {value}");
        }
    }

}

