﻿namespace PolicyManagement.Core
{
    public class Policy
    {
        public int Id { get; set; }
        public string? PolicyNumber { get; set; }
        public string? PolicyHolderName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Premium { get; set; }
    }
}
