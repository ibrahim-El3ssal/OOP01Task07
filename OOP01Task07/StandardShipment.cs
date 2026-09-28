using OOP01Task07;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task07
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        public void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
        }
    }
}