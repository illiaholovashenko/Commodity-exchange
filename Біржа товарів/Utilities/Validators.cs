using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів.Utilities
{
    // Статичний клас, що реалізує методи для перевірки введених користувачем даних
    public static class Validators
    {
        // Основний метод для перевірки даних 
        // при успішній перевірці закінчує процес валідації
        // при невдалій показує помилку користувача при введені
        // запрошує повторити ввід
        public static void ValidateField(TextBox textField, Label errorLabel, 
            CancelEventArgs e, FieldValidationDelegate fieldValidationDelegate)
        {
            string errorMessage;

            if (!fieldValidationDelegate(textField.Text, out errorMessage))
            {
                e.Cancel = true;
                textField.Select(0, textField.Text.Length);
                errorLabel.Text = errorMessage;
            }
        }

        // Основний метод для перевірки наявності введеного тексту в базі данних 
        public static void AvailabilityCheck(TextBox textField, Label errorLabel,
            string FieldName, CancelEventArgs e, IsAvailableDelegate isAvailableDelegate)
        {
            string errorMessage;

            if (!isAvailableDelegate(FieldName, textField.Text, out errorMessage))
            {
                e.Cancel = true;
                textField.Select(0, textField.Text.Length);
                errorLabel.Text = errorMessage;
            }
        }

        // Метод для перевірки імені та прізвища користувача
        public static bool IsFieldValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsRightRegex(Name, out ErrorMessage, 
                new Regex(@"^[А-ЩЬЮЯЇІЄҐа-щьюяїієґ]+$"), 
                "Поле має містити виключно українські літери")
                && IsFirstLetterCapital(Name, out ErrorMessage);
        }

        // Метод для перевірки правильного формату номера
        public static bool IsNumberValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsRightRegex(Name, out ErrorMessage, 
                new Regex(@"^\+380-\d{2}-\d{3}-\d{4}$"), "Неправильний формат номера");
        }

        // Метод для перевірки логіну
        public static bool IsLoginValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsRightRegex(Name, out ErrorMessage, 
                new Regex("^[a-zA-Z0-9]+$"),
                "Поле має має містити латинські літери або цифри");
        }

        // Метод для перевірки пароля
        public static bool IsPasswordValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsRightRegex(Name, out ErrorMessage,
                new Regex("^[a-zA-Z0-9]+$"),
                "Поле має має містити латинські літери або цифри")
                && IsEnoughLetter(Name, out ErrorMessage);
        }

        // Метод для перевірки імені товара
        public static bool IsProductNameValid(string Name, out string ErrorMessage)
        {
            return ProductFieldsValidating(Name, out ErrorMessage, 
                new Regex(@"^[\p{L}\d\s,]+$"), "Поле має містити літери або цифри", IsRightRegex);
        }

        // Метод для перевірки вартості та кількості товарів
        public static bool IsProductPriceValid(string Name, out string ErrorMessage)
        {
            return ProductFieldsValidating(Name, out ErrorMessage, 
                new Regex(@"^(?!0+$)\d+$"), "Поле має містити числа більші за нуль", IsRightRegex);
        }

        // Метод для перевірки коректного вводу адреси
        public static bool IsAdressValid(string Name, out string ErrorMessage)
        {
            return ProductFieldsValidating(Name, out ErrorMessage, 
                new Regex(@"^[А-ЩЬЮЯЇІЄҐа-щьюяїієґ]+,\s[А-ЩЬЮЯЇІЄҐа-щьюяїієґ\s]+,\s[А-ЩЬЮЯЇІЄҐа-щьюяїієґ\s]+\s\d+$"),
                "Введіть аресу у форматі: Країна, Місто, Вулиця Номер", IsRightRegex);
        }

        // Метод для перевірки наявності тексту в базі даних
        public static bool IsAvailable(string FieldName, string Name, out string ErrorMessage)
        {
            if ((GetItemFromDatabase(CustomersData, $"{FieldName}: {Name};") == null) 
                && (GetItemFromDatabase(SalesmenData, $"{FieldName}: {Name};")) == null)
            {
                ErrorMessage = "";
                return true;
            }

            ErrorMessage = $"Такий {FieldName} вже зареєстровано";
            return false;
        }

        private static bool HasLetter(string Name, out string ErrorMessage)
        {
            if (Name.Length == 0)
            {
                ErrorMessage = "Поле має бути заповнено";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsFirstLetterCapital(string Name, out string ErrorMessage)
        {
            char firstLetter = Name[0];

            if (!(char.IsUpper(firstLetter) && Name.Substring(1).All(char.IsLower)))
            {
                ErrorMessage = "Поле має починатись з великої літери";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsRightRegex(string Name,
            out string ErrorMessage, Regex regex, string ErrorString)
        {
            if (!regex.IsMatch(Name))
            {
                ErrorMessage = ErrorString;
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsEnoughLetter(string Name, out string ErrorMessage)
        {
            if (Name.Length < 8)
            {
                ErrorMessage = "Поле має бути довше 8-ми символів";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool ProductFieldsValidating(string Name, out string ErrorMessage, 
            Regex regex, string errorString, IsRightRegexDelegate isRightRegexDelegate)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ErrorMessage = "";
                return true;
            }

            return isRightRegexDelegate(Name, out ErrorMessage, regex, errorString);
        }

        public delegate bool FieldValidationDelegate(string name, 
            out string errorMessage);

        public delegate bool IsRightRegexDelegate(string name,
            out string errorMessage, Regex regex, string errorString);

        public delegate bool IsAvailableDelegate(string FieldName, 
            string name, out string errorMessage);
    }
}
