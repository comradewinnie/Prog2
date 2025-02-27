﻿namespace DatoriumMerch.Models
{
    public class Merch
    {
        public long Id { get; set; }
        public double Price { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public string? Color { get; set; }
        public long StorageId { get; set; }
        public Storage? Storage { get; set; }
    }
}
