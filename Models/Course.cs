public class Course
{
    public string courseName { get; set; } = string.Empty;    

    public int totalStudents { get; set; }

    public int averageMarks { get; set; }

    public GradeDistribution? gradeDistribution { get; set; } 
}
