﻿namespace HVC.Store.Domain.Entities {
    public class User : Entity {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
