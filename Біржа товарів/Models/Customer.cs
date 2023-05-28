using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    internal class Customer: User
    {
        public override string ClassName
        {
            get
            {
                return "Покупець";
            }
        }

        public Customer(string[] data): base(data) { }

        public override void SetMeetingText(MainForm mainForm)
        {
            mainForm.RankText.Text = ClassName;
            mainForm.MeetingLabel.Text = $"Привіт, {FullName}!";
        }
    }
}
