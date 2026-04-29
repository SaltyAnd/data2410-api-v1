public class Course
{
    required public string courseName { get; set; }

    public int totalStudents { get; set; }

    public int averageMarks { get; set; }

    required public GradeDistribution gradeDistribution { get; set; } 
}
