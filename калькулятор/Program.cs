using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    public class Calculator
    {
        // Публичный метод для сложения двух чисел
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Приватный метод для умножения двух чисел
        private double Multiply(double x, double y)
        {
            return x * y;
        }
    }

    public class User
    {
        // Свойство для имени пользователя
        public string Username { get; set; }

        // Свойство для электронной почты
        public string Email { get; set; }

        // Свойство для пароля (например, хэшированный)
        private string PasswordHash { get; set; }

        // Свойство для даты регистрации
        public DateTime RegistrationDate { get; set; }

        // Свойство для статуса пользователя (активный/неактивный)
        public bool IsActive { get; set; }

        // Конструктор класса
        public User(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            RegistrationDate = DateTime.Now;
            IsActive = true; // По умолчанию новый пользователь активен
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования класса Calculator
            Calculator calc = new Calculator();
            int sum = calc.Add(5, 7);
            Console.WriteLine($"Сумма: {sum}");

            // Пример использования класса User
            User user = new User("JohnDoe", "john.doe@example.com", "hashed_password");
            Console.WriteLine($"Пользователь: {user.Username}, Email: {user.Email}, Дата регистрации: {user.RegistrationDate}");
        }
    }
}
