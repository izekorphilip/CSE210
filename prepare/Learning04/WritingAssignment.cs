public class WritingAssignment : Assignment
{
    public string _title;

    public WritingAssignment(string _studentName, string topic, string title) : base(_studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}