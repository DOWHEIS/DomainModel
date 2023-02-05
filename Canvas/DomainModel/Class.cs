namespace DomainModel;
public class Class
{
    int id;
    int courseNumber;
    string courseName;

    List<Student> students;
    List<Assignment> assignments;

    public Class() {
        this.students = new List<Student>();
        this.assignments = new List<Assignment>();
    }
    public List<Assignment> getAssignments(){
        return this.assignments;
    }

    public List<Student> getStudents() {
        return this.students;
    }
    public int getId() {
        return this.id;
    }
    public int getCourseNumber() {
        return this.courseNumber;
    }
    public string getCourseName() {
        return this.courseName;
    }

}
