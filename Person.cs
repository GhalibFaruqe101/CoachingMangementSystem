using System;

namespace CoachingMangementSystem
{
    internal abstract class Person
    {
        private string id;
        private string name;
        private string username;
        private string password;

        internal string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        internal string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        internal Person(string id, string name, string username, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

        internal virtual void PrintInfo()
        {
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Username: {0}", this.Username);
        }
    }
}
