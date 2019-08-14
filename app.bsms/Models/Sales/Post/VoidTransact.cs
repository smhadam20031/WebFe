﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.bsms.Models.Sales.Post
{
    public class VoidTransact
    {

        public string siteCode { get; set; }

        public string customerCode { get; set; }

        public string treatmentParentCode { get; set; }

        public DateTime transactionDate { get; set; }

        public DateTime purchaseDate { get; set; }

        public string transactionNumber { get; set; }

        public string invoiceNumber { get; set; }

        public string treatmentCode { get; set; }

        public string linkCode { get; set; }

        public string treatmentDescription { get; set; }

        public string treatmentStatus { get; set; }

        public string recordStatus { get; set; }

        public string treatmentRemark { get; set; }

        public string treatmentType { get; set; }

        public List<Transaction> transactions { get; set; }
    }
}