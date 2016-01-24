namespace Problem_1_3_Student_class
{
    using System;
    using System.Collections.Generic;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        private int ssn;
        private string address;
        private string mobileNumber;
        public string Email { get; private set; }
        public byte Course { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }
        public Speciality Speciality { get; private set; }

        public int SSN
        {
            get { return this.ssn; }
            private set
            {
                if (value < 1000000)
                {
                    throw new ArgumentOutOfRangeException("SSNumber has at least 7 digits!");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address can't be empty string");
                }
                this.address = value;
            }
        }

        public string MobileNumber
        {
            get { return this.mobileNumber; }
            private set
            {
                if (value.Length < 13)
                {
                    throw new ArgumentOutOfRangeException("Mobile phone number has at least 13 symbols in format +359XXXXXXXXX!");
                }
                this.mobileNumber = value;
            }
        }

        public Student(string firstname, string middlename, string lastname, int ssnumber, string address, string mobilenumber, string email,
                       byte course, University university, Faculty faculty, Speciality speciality)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.SSN = ssnumber;
            this.Address = address;
            this.MobileNumber = mobilenumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Middle name: {1}, Last name: {2}, \nSSN {3}, Address: {4},\nMobile phone number: {5}, Email: {6}, Course: {7}, \nUniversity: {8}, Faculty: {9}, Speciality: {10}"
                , this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobileNumber, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        public override bool Equals(object obj)
        {
            var objCastStudent = obj as Student;
            if (objCastStudent == null)
            {
                return false;
            }
            if (this.SSN != objCastStudent.SSN) //достатъчно е да сравним социално-осигурителният номер на двамата студенти
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public object Clone() //Problem 2
        {
            Student cloning = new Student
                (
                    this.FirstName,
                    this.MiddleName,
                    this.LastName,
                    this.SSN,
                    this.Address,
                    this.MobileNumber,
                    this.Email,
                    this.Course,
                    this.University,
                    this.Faculty,
                    this.Speciality
                    );

            return cloning;
            //return this.MemberwiseClone(); //и това би трябвало да върши работа, доколкото нямаме референтни типове(ако считаме string за примитивен)
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }
            if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            if (this.SSN.CompareTo(otherStudent.SSN) != 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
            return 0;
        }
    }
}