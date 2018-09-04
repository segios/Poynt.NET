using System;
using System.Collections.Generic;

namespace Poynt.NET.Model
{

    public class DiscoveredTerminal

    {

        private const string TAG = "DiscoveredTerminal";

        public IList<DiscoveredActivation> Activations;

        public IList<DiscoveredBusiness> PotentialBusinesses;
    }
}
