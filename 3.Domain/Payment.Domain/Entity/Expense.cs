﻿using Payment.Domain.Enums;
using System;

namespace Payment.Domain.Entity
{
    public class Expense : BaseEntity
    {

        protected Expense() { }

        public Expense(string name, DateTime purchaseDate, decimal amount, ExpenseType expenseType, Guid paymentInstituitionId, Guid paymentTypeId, PaymentStatus paymentStatus)
        {
            Name = name;
            PurchaseDate = purchaseDate;
            Amount = amount;
            ExpenseType = expenseType;
            PaymentInstituitionId = paymentInstituitionId;
            PaymentTypeId = paymentTypeId;
            PaymentStatus = paymentStatus;
            CreatedAt = DateTime.Now;
        }

        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public Guid PaymentInstituitionId { get; set; }
        public Guid PaymentTypeId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public virtual PaymentInstituition PaymentInstituition { get; protected set; }
        public virtual PaymentType PaymentType { get; protected set; }
    }
}
