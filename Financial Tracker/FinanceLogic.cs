using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker
{
    internal class FinanceLogic
    {
        


        // 1. Enumerations: 
        public enum TransactionType { Income, Expense }
        public enum Category { Food, Transport, Salary, Shopping, Others }

        // 2. Class Definitions & Inheritance:
        public abstract class Transaction // abstract عشان محدش يعمل منه object مباشرة
        {
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public Category Category { get; set; }
            public string Description { get; set; }
            public abstract TransactionType TType { get; } // Property لازم تتنفذ في الوراثة
        }

        // الوراثة لعمليات الصرف
        public class Expense : Transaction
        {
            public override TransactionType TType => TransactionType.Expense;
        }

        // الوراثة لعمليات الدخل
        public class Income : Transaction
        {
            public override TransactionType TType => TransactionType.Income;
        }

        // 3. المحرك الأساسي (File Handling & Arrays)
        public static class FinanceManager
        {
            // استخدام List (وهي Dynamic Array) لتخزين الكائنات
            public static List<Transaction> Transactions = new List<Transaction>();
            private static string filePath = "my_data.txt";

            // ميثود لإضافة عملية جديدة
            public static void AddTransaction(Transaction t)
            {
                Transactions.Add(t);
            }

            // 4. File Handling: حفظ البيانات في ملف
            public static void SaveToFile()
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var t in Transactions)
                        {
                            // بنسجل الداتا كسطر واحد وبنفصل بينهم بـ علامة |
                            writer.WriteLine($"{t.TType}|{t.Amount}|{t.Date:yyyy-MM-dd}|{t.Category}|{t.Description}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving: " + ex.Message);
                }
            }

            // 5. File Handling: قراءة البيانات من الملف
            public static void LoadFromFile()
            {
                if (!File.Exists(filePath)) return;

                Transactions.Clear(); // نمسح الموجود عشان ميتكررش
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] p = line.Split('|');
                    Transaction t;

                    // بنشوف النوع عشان نكريت Object من الكلاس الصح (Polymorphism)
                    if (p[0] == "Expense") t = new Expense();
                    else t = new Income();

                    t.Amount = decimal.Parse(p[1]);
                    t.Date = DateTime.Parse(p[2]);
                    t.Category = (Category)Enum.Parse(typeof(Category), p[3]);
                    t.Description = p[4];

                    Transactions.Add(t);
                }
            }
        }
    }
}

