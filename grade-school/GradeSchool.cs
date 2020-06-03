using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly IList<Student> Students = new List<Student>();

    public void Add(string student, int grade)
    {
        if (string.IsNullOrWhiteSpace(student))
        {
            throw new ArgumentException("student must be a valid string", nameof(student));
        }

        if (grade < 1 || grade > 9)
        {
            throw new ArgumentException("grade must be higher or equal to 1 and lower or equal to 8", nameof(grade));
        }

        var entry = new Student { Name = student, Grade = grade };
        Students.Add(entry);
    }

    public IEnumerable<string> Roster()
    {
        var output = Students
            .OrderBy(g => g.Grade)
            .ThenBy(s => s.Name)
            .Select(s => s.Name);

        return output.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        var output = Students
            .Where(g => g.Grade == grade)
            .OrderBy(s => s.Name)
            .Select(s => s.Name);

        return output.ToArray();
    }
}