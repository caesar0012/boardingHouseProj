using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace boardingHouseProj
{
    internal class staff_Class
    {
        private static string firstName;
        private static string lastName;
        private static string userName;
        private static string Role;
        private static string Password;
        private static string Questions;
        private static string Contact;
        private static string questionAnswers;

        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public static string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public static string Role01
        {
            get { return Role; }
            set { Role = value; }
        }
        public static string Password1
        {
            get { return Password; }
            set { Password = value; }
        }
        public static string Questions1
        {
            get { return Questions; }
            set { Questions = value; }
        }
        public static string Contact1
        {
            get { return Contact; }
            set { Contact = value; }
        }
        public static string questionAnswers1
        {
            get { return questionAnswers; }
            set { questionAnswers = value; }
        }

        public static void createAcc() {

            using (SqlConnection connect = new SqlConnection(ConnectSql.connectionString)) {
                connect.Close();
                connect.Open();
            
            
            
            
            }
        
        
        
        
        }



    }
}
