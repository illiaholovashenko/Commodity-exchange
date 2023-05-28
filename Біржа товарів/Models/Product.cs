using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    public class Product
    {

        internal string? Name { get; set; }
        internal int? Amount { get; set; }
        internal int? UnitPrice { get; set; }
        internal string? PaymentForm { get; set; }
        internal string? DeliveryCondition { get; set; }
        internal string? Adress { get; set; }
        internal string? Notes { get; set; }

        public Product(string name, int amount, int price, string paymentForm, 
            string deliveryCondition, string adress, string notes)
        {
            Name = name;
            Amount = amount;
            UnitPrice = price;
            PaymentForm = paymentForm;
            DeliveryCondition = deliveryCondition;
            Adress = adress;
            Notes = notes;
        }

        public Product(Form form)
        {
            Name = ((TextBox?)form.Controls["ProductNameField"])?.Text;
            Amount = int.Parse(((TextBox?)form.Controls["ProductAmountField"])?.Text ?? "0");
            UnitPrice = int.Parse(((TextBox?)form.Controls["ProductPriceField"])?.Text ?? "0");
            PaymentForm = ((ComboBox?)form.Controls["PaymentFormBox"])?.SelectedItem?.ToString() ?? " ";
            DeliveryCondition = ((ComboBox?)form.Controls["DeliveryConditionBox"])?.SelectedItem?.ToString() ?? " ";
            Adress = ((TextBox?)form.Controls["AdressField"])?.Text ?? " ";
            Notes = ((TextBox?)form.Controls["NotesField"])?.Text ?? " ";
        }

        public string GetInfo()
        {
            return $"Назва: {Name}, Ціна: {UnitPrice}, Кількість: {Amount}, " +
                $"Адреса: {Adress}, Оплата: {PaymentForm}, " +
                $"Доставка: {DeliveryCondition}, Замітки: {Notes}";
        }
    }
}
