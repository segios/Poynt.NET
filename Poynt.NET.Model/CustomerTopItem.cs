//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;

namespace Poynt.NET.Model
{

    public class CustomerTopItem

    {

        private const string TAG = "CustomerTopItem";

        public decimal Count { get; set; }

        public long? ProductId { get; set; }

        public long? VariationId { get; set; }

        public long? FirstPurchasedAt { get; set; }

        public long? LastPurchasedAt { get; set; }

        public string Name { get; set; }

        public UnitOfMeasure CountUnit { get; set; }
    }
}
