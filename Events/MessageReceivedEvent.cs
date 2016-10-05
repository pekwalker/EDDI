﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddiEvents
{
    public class MessageReceivedEvent : Event
    {
        public const string NAME = "Message received";
        public const string DESCRIPTION = "Triggered when you receive a message";
        public const string SAMPLE = "{\"timestamp\":\"2016-06-10T14:32:03Z\",\"event\":\"ReceiveText\",\"From\":\"HRC1\",\"Message\":\"Hello\"}";
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static MessageReceivedEvent()
        {
            VARIABLES.Add("from", "The name of the pilot who sent the message");
            VARIABLES.Add("player", "True if the sender is a player");
            VARIABLES.Add("channel", "The channel in which the message came (direct, local, wing)");
            VARIABLES.Add("message", "The message");
        }

        [JsonProperty("from")]
        public string from { get; private set; }

        [JsonProperty("player")]
        public bool player { get; private set; }

        [JsonProperty("channel")]
        public string channel { get; private set; }

        [JsonProperty("message")]
        public string message { get; private set; }

        public MessageReceivedEvent(DateTime timestamp, string from, bool player, string channel, string message) : base(timestamp, NAME)
        {
            this.from = from;
            this.player = player;
            this.channel = channel;
            this.message = message;
        }
    }
}
