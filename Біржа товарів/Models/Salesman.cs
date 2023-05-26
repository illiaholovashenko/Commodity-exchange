using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    internal class Salesman: User
    {
        public new string ClassName = "Продавець";

        public Salesman(string[] data):base(data) { }

        public override void SetMeetingText(MainForm mainForm)
        {
            mainForm.RankText.Text = ClassName;
            mainForm.MeetingLabel.Text = $"Привіт, {FullName}!";
        }
    }
}
