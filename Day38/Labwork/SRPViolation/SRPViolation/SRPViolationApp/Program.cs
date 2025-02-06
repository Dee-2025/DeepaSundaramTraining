using SRPViolationApp.Model;
using System.Security.Cryptography;

namespace SRPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);
            PrintInvoice(invoice);
        }
        static void PrintInvoice(Invoice invoice)
        {
           InvoiceManager invoiceManager = new InvoiceManager();
                string template = $"Id :{invoice.id} " +
                    $",description:{invoice.description}" +
                    $" cost is :{invoice.cost}" +
                    $" tax amt is :{invoiceManager.CalculateTax(invoice.cost,invoice.tax)}" +
                    $" discount amt is {invoiceManager.CalculateDiscount(invoice.cost,invoice.discountPercent)}" +
                    $" Final cost is :{invoiceManager.FinalCost(invoice.cost,invoice.tax,invoice.discountPercent)}";
                Console.WriteLine(template);


            
        }
    }
}