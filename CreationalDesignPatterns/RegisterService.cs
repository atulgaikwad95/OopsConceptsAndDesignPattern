using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace CreationalDesignPatterns
{
    public class RegisterService
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into ....");

        }
    }

    public class SmtpClient
    {
        string str;

        public SmtpClient(string s)
        {
            this.str = str;
        }

        public class MailMessage
        {
        }

        internal void Send(System.Net.Mail.MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }
    }

   
       
}
     

