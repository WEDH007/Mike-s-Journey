using School.Classes;

Student studentaccount = null;
Teacher teacheraccount = null;

List<Student> studentlist = new List<Student>
{
    new Student("Mike", 23, "1246 Canyon Creek Circle", "1001", 3.5),
new Student("Alice", 21, "763 Pinewood Avenue", "1002", 3.8),
new Student("John", 25, "455 Elm Street", "1003", 3.2),
new Student("Sophia", 22, "982 Oak Lane", "1004", 3.9),
new Student("James", 24, "327 Maple Road", "1005", 2.8),
new Student("Emma", 20, "1067 Willow Drive", "1006", 3.7),
new Student("Lucas", 23, "453 Birch Avenue", "1007", 3.6),
new Student("Olivia", 22, "889 Cedar Circle", "1008", 3.4),
new Student("Benjamin", 26, "674 Aspen Street", "1009", 3.5),
new Student("Charlotte", 19, "333 Oakwood Drive", "1010", 3.8),
new Student("Liam", 27, "254 Pine Avenue", "1011", 3.1),
new Student("Amelia", 22, "1457 Maplewood Lane", "1012", 4.0),
new Student("Henry", 24, "632 River Road", "1013", 3.2),
new Student("Isabella", 21, "789 Birchwood Lane", "1014", 3.6),
new Student("Daniel", 23, "1020 Willow Road", "1015", 3.9)

};

List<Student> mathlist = new List<Student>
{
    studentlist[0],
    studentlist[1],
    studentlist[2]
};
List<Student> sciencelist = new List<Student>
{
    studentlist[3],
    studentlist[4],
    studentlist[5],
    studentlist[0]
};
List<Student> historylist = new List<Student>
{
    studentlist[6],
    studentlist[7],
    studentlist[8]
};
List<Student> englishlist = new List<Student>
{
    studentlist[9],
    studentlist[10],
    studentlist[11]
};
List<Student> geographylist = new List<Student>
{
    studentlist[12],
    studentlist[13],
    studentlist[14]
};


List<Teacher> teacherlist = new List<Teacher>
{
   new Teacher("Juan", 22, "838 Mineral Wells Lane", "2001", 5),
new Teacher("Sophia", 30, "245 Riverfront Street", "2002", 7),
new Teacher("Michael", 35, "762 Birchwood Drive", "2003", 10),
new Teacher("Emily", 28, "983 Oakview Road", "2004",  4),
new Teacher("David", 40, "1020 Cedar Lane", "2005", 12)

};
List<Subject> subjectlist = new List<Subject>
{
    new Subject("Math", teacherlist[0], mathlist),
new Subject("Science", teacherlist[1], sciencelist),
new Subject("History", teacherlist[2], historylist),
new Subject("English", teacherlist[3], englishlist),
new Subject("Geography", teacherlist[4], geographylist)
};

List<Grade> gradeslist = new List<Grade>
{
    new Grade(subjectlist[0], subjectlist[0].StudentList[0], 96),
    new Grade(subjectlist[0], subjectlist[0].StudentList[1], 96),
    new Grade(subjectlist[0], subjectlist[0].StudentList[0], 96),
    new Grade(subjectlist[0], subjectlist[0].StudentList[0], 96)
};

Console.WriteLine("Please enter your school ID");
string id = Console.ReadLine();

bool found = false;

foreach (Student student in studentlist)
{
    if (id == student.StudentID.ToString())
    {
        Console.WriteLine($"Welcome, {student.Name}!");
        found = true;
        studentaccount = student;
        break;
    }
}

if (!found)
{
    foreach (Teacher teacher in teacherlist)
    {
        if (id == teacher.TeacherID.ToString())
        {
            Console.WriteLine($"Welcome, {teacher.Name}!");
            teacheraccount = teacher;
            break;
        }
    }
}

while (studentaccount != null)
{
    Console.WriteLine(@"
    Main Menu
1. View personal info.
2. View Subjects
3. View Grades"
);

    var answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            studentaccount.DisplayInfo();
            
            Console.ReadLine();
            
            break;

        case "2":
            foreach (Subject i in subjectlist)
            {
                foreach (Student m in i.StudentList)
                {
                    if (studentaccount == m)
                    {
                        Console.WriteLine(i.SubjectName);
                    }
                }
            }
            break;

        case "3":
            foreach (Grade grade in gradeslist)
            {
                if (grade.Student == studentaccount)
                {
                    Console.WriteLine($"{grade.Subject.SubjectName}: {grade.GradeNumber}");
                }
            }
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

while (teacheraccount != null)
{
    Console.WriteLine("Main Menu");
    var answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
           
            break;
        case "2":
            
            break;
        case "3":
            
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}