using System;

namespace SecureDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            string apiKey = "sk_live_51H8mYMLmXyq12345678901234567890";
            string awsAccessKeyId = "AKIAIOSFODNN7EXAMPLE";
            string awsSecretAccessKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";
            string email = "john.doe@example.com";
            string cardNumber = "4111 1111 1111 1111";

           
            Console.WriteLine($"[DEBUG] API prefix: {apiKey[..4]}..., AWS Key: {awsAccessKeyId[..4]}...");
            Console.WriteLine($"[DEBUG] Secret length: {awsSecretAccessKey.Length}");
            Console.WriteLine($"[DEBUG] Email domain: {email.Split('@')[1]}");
            Console.WriteLine($"[DEBUG] Card ends with: {cardNumber.Substring(cardNumber.Length - 4)}");

            Console.WriteLine("Fake processing complete.");
        }
    }
}
