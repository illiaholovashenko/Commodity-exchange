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

namespace Біржа_товарів.Validators
{
    public static class Validators
    {
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

        public static bool IsProductNameValid(string Name, out string ErrorMessage)
        {
            return IsLettersOrNumbers(Name, out ErrorMessage)
                && HasLetter(Name, out ErrorMessage);
        }

        public static bool IsProductPriceValid(string Name, out string ErrorMessage)
        {
            return IsNumbers(Name, out ErrorMessage)
                && HasLetter(Name, out ErrorMessage);
        }

        public static bool IsAdressValid(string Name, out string ErrorMessage)
        {
            return ProductFieldsValidating(Name, out ErrorMessage, IsAdress);
        }

        public static int FieldsFilled(Form form)
        {
            int counter = 0;

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static bool IsAvailable(string FieldName, string Name, out string ErrorMessage)
        {
            if ((GetItemFromDatabase(CustomersData, $"{FieldName}: {Name},") == null) 
                && (GetItemFromDatabase(SalesmenData, $"{FieldName}: {Name},")) == null)
            {
                ErrorMessage = "";
                return true;
            }

            ErrorMessage = $"Цей {FieldName} не доступний";
            return false;
        }

        public static void ChangeForm<T>(Form thisForm) where T : Form, new()
        {
            thisForm.Hide();
            T newForm = new T();
            newForm.Show();
        }

        public static string[] GetData(string Data, int fieldsCount)
        {
            string[] result = new string[fieldsCount];

            string[] DataPairs = Data.Split(", ");

            for (int i = 0; i < DataPairs.Length; i++)
            {
                result[i] = DataPairs[i].Split(": ")[1];
            }

            return result;
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
                ErrorMessage = "Поле має бути довше 8-ми символів";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsLettersOrNumbers(string Name, out string ErrorMessage)
        {
            Regex LettersAndGap = new Regex(@"^[\p{L}\d\s]+$");

            if (!LettersAndGap.IsMatch(Name))
            {
                ErrorMessage = "Поле має містити літери або цифри";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsNumbers(string Name, out string ErrorMessage)
        {
            Regex LettersAndGap = new Regex(@"^(?!0+$)\d+$");

            if (!LettersAndGap.IsMatch(Name))
            {
                ErrorMessage = "Поле має містити числа більші за нуль";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool IsAdress(string Name, out string ErrorMessage)
        {
            Regex Adress = new Regex(@"^[А-ЩЬЮЯЇІЄҐа-щьюяїієґ]+,\s*\d+,\s*[А-ЩЬЮЯЇІЄҐа-щьюяїієґ\s]+,\s*[А-ЩЬЮЯЇІЄҐа-щьюяїієґ\s]+\s*\d+$");

            if (!Adress.IsMatch(Name))
            {
                ErrorMessage = "Введіть аресу у форматі: Країна, Індекс, Місто, Вулиця Номер";
                return false;
            }

            ErrorMessage = "";
            return true;
        }

        private static bool ProductFieldsValidating(string Name, out string ErrorMessage, FieldValidationDelegate fieldValidationDelegate)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ErrorMessage = "";
                return true;
            }

            return fieldValidationDelegate(Name, out ErrorMessage);
        }


        public delegate bool FieldValidationDelegate(string name, out string errorMessage);

        public delegate bool IsAvailableDelegate(string FieldName, string name, out string errorMessage);
    }
}
