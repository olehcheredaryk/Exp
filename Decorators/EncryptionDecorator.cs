using System;
using System.Text;

namespace MvcPatternDemo.Decorators
{
    public class EncryptionDecorator : TransactionDecorator
    {
        public EncryptionDecorator(ITransactionProcessor processor) : base(processor) { }

        // Шифрує повідомлення у Base64
        public override string Process(double amount)
        {
            string originalResult = base.Process(amount);
            byte[] textBytes = Encoding.UTF8.GetBytes(originalResult);
            string base64String = Convert.ToBase64String(textBytes);
            return $"[ENCRYPTED: {base64String}]";
        }
    }
}
