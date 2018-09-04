
using System;

namespace Poynt.NET.Model
{

    public class AVSResult

    {

        private const string TAG = "AVSResult";

        public AVSResultType AddressResult { get; set; }

        public AVSResultType PostalCodeResult { get; set; }

        public AVSResultType StateResult { get; set; }

        public AVSResultType CountryResult { get; set; }

        public AVSResultType PhoneResult { get; set; }

        public AVSResultType CardHolderNameResult { get; set; }

        public AVSResultType CityResult { get; set; }

        public string ActualResult { get; set; }

    }
}
