
public class WritingAssignment : Assignment
{
    private string _title;

    // Pass base Constructor from "Assignment" constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Specific variable for WritingAssignment
        _title = title;
    }

    public string GetWritingInformation()
    {
        // _studentName is private because of it getter needed to be called
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";   
    }    
}