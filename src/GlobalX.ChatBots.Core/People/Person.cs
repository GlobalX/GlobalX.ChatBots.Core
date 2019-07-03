using System;

namespace GlobalX.ChatBots.Core.People {
    public class Person {
        public DateTime Created { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public string[] Emails { get; set; }
        public PersonType Type { get; set; }
    }
}
