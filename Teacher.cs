namespace CoachingMangementSystem
{
    internal class Teacher : Person
    {
        private string gender;
        private string address;
        private string subject;

        internal string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        internal string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        internal Teacher(
            string id,
            string name,
            string username,
            string password,
            string gender,
            string address,
            string subject)
            : base(id, name, username, password)
        {
            this.Gender = gender;
            this.Address = address;
            this.Subject = subject;
        }

        internal override void PrintInfo()
        {
            base.PrintInfo();

            // Console.WriteLine("Gender: {0}", this.Gender);
            // Console.WriteLine("Address: {0}", this.Address);
            // Console.WriteLine("Subject: {0}", this.Subject);
        }
    }
}
