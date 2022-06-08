namespace b2
{
    public class Member
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public bool IsGraduated { get; set; }

        public string Info
        {
            get
            {
                return string.Format("-------------------\r\n"
                + "First Name: {0}\r\n"
                + "Last Name: {1}\r\n"
                + "Age: {2}\r\n"
                + "Gender: {3}\r\n"
                + "Date of Birth: {4}\r\n"
                + "Phone Number: {5}\r\n"
                + "Birth Place: {6}\r\n"
                + "Is Graduated: {7}"
                , FirstName
                , LastName
                , Age
                , Gender
                , DateOfBirth
                , PhoneNumber
                , BirthPlace
                , IsGraduated);
            }
        }

        public string fullName
        {
            get
            {
                return string.Format(FirstName + " " + LastName);
            }
        }
    }
}