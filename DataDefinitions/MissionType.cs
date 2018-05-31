﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace EddiDataDefinitions
{
    /// <summary>
    /// Mission types
    /// </summary>
    public class MissionType : ResourceBasedLocalizedEDName<MissionType>
    {
        static MissionType()
        {
            resourceManager = Properties.MissionType.ResourceManager;
            resourceManager.IgnoreCase = false;
            missingEDNameHandler = (edname) => new MissionType(edname);

            var Altruism = new MissionType("Altruism");
            var AltruismCredits = new MissionType("AltruismCredits");
            var Assassinate = new MissionType("Assassinate");
            var Collect = new MissionType("Collect");
            var Courier = new MissionType("Courier");
            var Delivery = new MissionType("Delivery");
            var Disable = new MissionType("Disable");
            var LongDistanceExpedition = new MissionType("LongDistanceExpedition");
            var Massacre = new MissionType("Massacre");
            var Mining = new MissionType("Mining");
            var PassengerBulk = new MissionType("PassengerBulk");
            var PassengerVIP = new MissionType("PassengerVIP");
            var Piracy = new MissionType("Piracy");
            var Rescue = new MissionType("Rescue");
            var Salvage = new MissionType("Salvage");
            var Scan = new MissionType("Scan");
            var Sightseeing = new MissionType("Sightseeing");
            var Smuggle = new MissionType("Smuggle");
        }

        // dummy used to ensure that the static constructor has run
        public MissionType() : this("")
        { }

        private MissionType(string edname) : base(edname, edname)
        { }
    }
}