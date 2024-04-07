using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class MessageService
    {
        
        public static void doMessage(string status , string message) {

            if (status == "Succeed")
            {
                MessageBox.Show(message,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DialogResult doMessageQuestion(string message)
        {

            return MessageBox.Show(message,"CUD Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

    }
}
