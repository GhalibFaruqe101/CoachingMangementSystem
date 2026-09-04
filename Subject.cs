namespace CoachingMangementSystem
{
    internal class Subject
    {
        private string id;
        private string name;

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

        internal Subject(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
