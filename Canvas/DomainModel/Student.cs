namespace DomainModel
{
    public class Student
    {
        int id;
        string firstName;
        string lastName;
        string email;

        List<Class> enrollments;

        public Student() {
            this.enrollments = new List<Class>();
        }

        public int getId() {
            return this.id;
        }
        public string getFirstName() {
            return this.firstName;
        }
        public string getLastName() {
            return this.lastName;
        }
        public string getEmail() {
            return this.email;
        }

        public List<int> checkGrades(Class currentClass) {
            List<Assignment> assignments = currentClass.getAssignments();
            List<int> scores = assignments.getScore;
            return scores;
        }

    }
}