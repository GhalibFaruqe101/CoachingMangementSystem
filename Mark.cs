namespace CoachingMangementSystem
{
    internal class Mark
    {
        private string studentId;
        private string subjectId;
        private double marks;
        private string grade;

        internal string StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }

        internal string SubjectId
        {
            get { return this.subjectId; }
            set { this.subjectId = value; }
        }

        internal double Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        internal string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        internal Mark(string studentId, string subjectId, double marks, string grade)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;
            this.Marks = marks;
            this.Grade = grade;
        }
    }
}
