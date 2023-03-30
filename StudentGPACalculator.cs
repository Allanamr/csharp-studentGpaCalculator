/* You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

You're given the student's name and class information.
Each class has a name, the student's grade, and the number of credit hours for that class.
Your application needs to perform basic math operations to calculate the GPA for the given student.
Your application needs to output/display the student’s name, class information, and GPA.
To calculate the GPA:

Multiply the grade value for a course by the number of credit hours for that course.
Do this for each course, then add these results together.
Divide the resulting sum by the total number of credit hours.*/

// Variable Declaration

//Name of student and Courses
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// Course's credit
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Storing the grade equivalents
int gradeA = 4;
int gradeB = 3;

// Assign the grades per course
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// Create a variable for the total credit hours
int totalCreditHours = 0;
//Sum of all the credits
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

//Create a variable for the total grade points
int totalGradePoints = 0;
//Sum of all the credits
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//Variable for grade point average
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

//Variable to get the number before the point
int leadingDigit = (int) gradePointAverage;
//Variable to get the 2 numbers after the point 
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

// Display Results

Console.WriteLine($"Student Name: {studentName}\n");

Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA: {leadingDigit}.{trailingDigits}");