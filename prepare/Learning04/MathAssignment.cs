
public class MathAssignment : Assignment
{
    // Atributes
    private string _textBookSection;
    private string _problems;

    // Pass base Constructor from "Assignment" constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        :base(studentName, topic)
    {
        // Variables for MathAssignment
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}