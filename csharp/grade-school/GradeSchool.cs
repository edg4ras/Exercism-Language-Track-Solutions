using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly SortedDictionary<int, SortedSet<string>> grades = new SortedDictionary<int, SortedSet<string>>();

    public void Add(string student, int grade)
    {
        if (grades.TryGetValue(grade, out var students))
            students.Add(student);
        else
            grades.Add(grade, new SortedSet<string> { student });
    }

    public IEnumerable<string> Roster() => grades.Keys.SelectMany(x => Grade(x));

    public IEnumerable<string> Grade(int grade) => grades.TryGetValue(grade, out var students) ? students : Enumerable.Empty<string>();
}