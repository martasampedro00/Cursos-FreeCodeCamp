string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
int totalGradePoints = course1Credit*course1Grade + course2Credit*course2Grade + course3Credit*course3Grade + course4Credit*course4Grade + course5Credit*course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Credit}\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Credit}\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Credit}\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Credit}\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Credit}\t{course5Credit}\n");
Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
