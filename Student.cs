namespace CoachingMangementSystem
{
    internal class Student : Person
    {
        private string gender;
        private string address;
        private string className;
        private string section;

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

        internal string ClassName
        {
            get { return this.className; }
            set { this.className = value; }
        }

        internal string Section
        {
            get { return this.section; }
            set { this.section = value; }
        }

        internal Student(
            string id,
            string name,
            string username,
            string password,
            string gender,
            string address,
            string className,
            string section)
            : base(id, name, username, password)
        {
            this.Gender = gender;
            this.Address = address;
            this.ClassName = className;
            this.Section = section;
        }

        internal override void PrintInfo()
        {
            base.PrintInfo();

            // Console.WriteLine("Gender: {0}", this.Gender);
            // Console.WriteLine("Address: {0}", this.Address);
            // Console.WriteLine("Class: {0}", this.ClassName);
            // Console.WriteLine("Section: {0}", this.Section);
        }
    }
}
