using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Біржа_товарів.Utilities
{
    internal static class Utilities
    {
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
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedItem != null) 
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static Dictionary<string, string> GetFilledFields(Form form)
        {
            Dictionary<string, string> filledFields = new Dictionary<string, string>();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        filledFields.Add(textBox.Name.Replace("Field", ""), textBox.Text);
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedItem != null)
                    {
                        filledFields.Add(comboBox.Name.Replace("Box", ""), comboBox.Text);
                    }
                }
            }

            return filledFields;
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
    }
}
