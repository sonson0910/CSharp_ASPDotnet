﻿namespace HelloWorld.Models
{
    public class Message
    {
        public string msg { get; set; }
        public int pgnum { get; set; }

        public Message()
        {

        }

        public Message(string msg, int pgnum)
        {
            this.msg = msg;
            this.pgnum = pgnum;
        }
    }
}
