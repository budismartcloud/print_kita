using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace print_kita.Models
{
    public class QuotationModel
    {
        public string quotationId { set; get; }
        public string file { set; get; }
        public string isGrayScale { get; set; }
        public string isA4 { get; set; }
        public string numberOfCopy { get; set; }
        public string description { get; set; }
        public string pickupTimePlan { get; set; }
        public string amount { get; set; }
        public string totalAmount { get; set; }
        public string isCanceled { get; set; }
        public string canceledAt { get; set; }
        public string isPickedUp { get; set; }
        public string pickedUpAt { get; set; }
        public string createdAt { get; set; }
        public string createdByUserId { get; set; }
        public string referenceNumber { get; set; }
        public string paperTypeId { get; set; }
        public string isProcessed { get; set; }
    }
}