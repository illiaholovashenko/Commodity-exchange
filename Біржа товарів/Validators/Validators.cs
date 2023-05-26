using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Біржа_товарів.Validators
{
    public static class Validators
    {
        public static void ValidateField(TextBox textField, 
            Label errorLabel, CancelEventArgs e, 
            FieldValidationDelegate fieldValidationDelegate)
        {
            string errorMessage;

            if (!fieldValidationDelegate(textField.Text, out errorMessage))
            {
                e.Cancel = true;
                textField.Select(0, textField.Text.Length);
                errorLabel.Text = errorMessage;
            }
        }

        public static bool IsFieldValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsUkrainianLetters(Name, out ErrorMessage)
                && IsFirstLetterCapital(Name, out ErrorMessage);
        }

        public static bool IsNumberValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsNumberCorrect(Name, out ErrorMessage);
        }

        public static bool IsLoginValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsLogin(Name, out ErrorMessage);
        }

        public static bool IsPasswordValid(string Name, out string ErrorMessage)
        {
            return HasLetter(Name, out ErrorMessage)
                && IsLogin(Name, out ErrorMessage)
                && IsEnoughLetter(Name, out ErrorMessage);
        }

        public static bool AreFieldsFilled(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsLoginAvailable(string path, string login)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains($"Логін: {login},"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string? IsPasswordCorrect(string path, string login, string password)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains($"Логін: {login},"))
                    {
                        if (line.Contains($"Пароль: {password},"))
                        {
                            return line;
                        }
                    }
                }
            }
            return null;
        }

        public static bool IsTelephoneAvailable(string path, string phoneNumber)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains($"Телефон: {phoneNumber}"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool HasLetter(string Name, out string ErrorMessage)
        {
            if (Name.Length == 0)
            {
                ErrorMessage = "Це поле має бути заповнено";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsUkrainianLetters(string Name, out string ErrorMessage)
        {
            Regex UkrLetters = new(@"^[А-ЩЬЮЯЇІЄҐа-щьюяїієґ]+$");

            if (!UkrLetters.IsMatch(Name))
            {
                ErrorMessage = "Поле має містити виключно українські літери";
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

        private static bool IsNumberCorrect(string Name, out string ErrorMessage)
        {
            Regex Number = new Regex(@"^\+380-\d{2}-\d{3}-\d{4}$");

            if (!Number.IsMatch(Name))
            {
                ErrorMessage = "Неправильний формат номера";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsLogin(string Name, out string ErrorMessage)
        {
            Regex EngOrNum = new Regex("^[a-zA-Z0-9]+$");

            if (!EngOrNum.IsMatch(Name))
            {
                ErrorMessage = "Поле має складатись з латинських літер або цифр";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsEnoughLetter(string Name, out string ErrorMessage)
        {
            if (Name.Length < 8)
            {
                ErrorMessage = "Пароль має бути довше 8-ми символів";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        public delegate bool FieldValidationDelegate(string name, out string errorMessage);
    }
}
