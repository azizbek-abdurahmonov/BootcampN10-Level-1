using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_T1
{
    internal class EmailTemplates
    {
        public string subject;
        public string content;

        public EmailTemplates(string subject, string content)
        {
            this.subject = subject;
            this.content = content;
        }
    }
}
