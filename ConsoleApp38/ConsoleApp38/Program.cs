    class PersonalInformation
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Lastname { get; set; }
    }

    class AddressInformation
    {
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int HouseNumber { get; set; }
        public char Korpus { get; set; }
        public short PostalCode { get; set; }
    }

    class BirthInformation
    {
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string? ZnakZodiaka { get; set; }
    }

    class EducationInformation
    {
        public int StartDay { get; set; }
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public int Kurs { get; set; }
        public string? GroupName { get; set; }
        public string? Specialization { get; set; }
        public int StudentsCount { get; set; }
    }

    class TeachersInformation
    {
        public int LessonsVisited { get; set; }
        public int LessonsLate { get; set; }
        public string? TeacherName { get; set; }
        public string? SubjectName { get; set; }
    }

    class GradesInformation
    {
        public int[]? DzRates { get; set; }
        public float DzAverageRate { get; set; }

        public int[]? PracticeRates { get; set; }
        public float PracticeAverageRate { get; set; }

        public int[]? ExamRates { get; set; }
        public float ExamAverageRate { get; set; }

        public int[]? ZachetRates { get; set; }
        public int ZachetCount { get; set; }
        public float ZachetAverageRate { get; set; }

        public double TotalAverageRate { get; set; }
    }
class Student
{
    public PersonalInformation PersonalInfo { get; set; }
    public AddressInformation AddressInfo { get; set; }
    public BirthInformation BirthInfo { get; set; }
    public EducationInformation EducationInfo { get; set; }
    public TeachersInformation TeachersInfo { get; set; }
    public GradesInformation GradesInfo { get; set; }

    public Student()
    {
        PersonalInfo = new PersonalInformation();
        AddressInfo = new AddressInformation();
        BirthInfo = new BirthInformation();
        EducationInfo = new EducationInformation();
        TeachersInfo = new TeachersInformation();
        GradesInfo = new GradesInformation();
    }
}

class Program
{
    static void Main()
    {
    }
}
