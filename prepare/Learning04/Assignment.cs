
public class Assignment
{
    private string _studentName;
    private string __topic;

   public Assignment (string studentName, string topic)
   {
        _studentName = studentName;
        __topic = topic;
   }

   public string GetStudentName()
   {
        return  _studentName;
   }
   public string GetTopic()
   {
        return __topic;
   }

   public string GetSumary()
   {
        return _studentName + " - " + __topic;
   }
}