﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandaloneForm
{
    public class Applicant
    {
        // Регистрационный номер
        public String RegNumber { private set; get; }
        // ФИО
        public String FirstName { private set; get; }
        public String SecondName { private set; get; }
        public String LastName { private set; get; }
        public String BirthDate { private set; get; }
        // Место рождения и проживания
        public String BirthPlace { private set; get; }
        public Address Address_ { private set; get; }
        // Гражданство
        public String Citizenship { private set; get; }
        // Документ удостоверяющий личность
        public String Passport { private set; get; }
        public String Serial { private set; get; }
        public String Number { private set; get; }
        public String PassportIssuedDate { set; get; }

        public String HomePhone { private set; get; }
        public String LearningForm { private set; get; }
        public String Funding { private set; get; }

        public Specialization[] Specs { private set; get; }

        public String Education { private set; get; }
        public String EducationDocument { private set; get; }
        public String NumberOfEducationDocument { private set; get; }
        public String EducationIssuedDate { private set; get; }

        public EnteranceExamination[] EnteranceExaminations { private set; get; }

        public bool AllowUniversityExams { private set; get; }
        public String Grounds { private set; get; }
        public String Facilities { private set; get; }
        public List<String> Olimpiads { private set; get; }

        public bool NeedDorm { private set; get; }
        public String IssuedUniversityEducation { private set; get; }

        public Applicant(String RegNumber,
            String FirstName, String SecondName, String LastName,
            String BirthDate, String BirthPlace, Address Address_,
            String Citizenship, String Passport, String Serial, String Number, String PassportIssuedDate,
            String HomePhone, String LearningForm, String Funding, 
            Specialization[] Specs, String Education, String EducationDocument, String NumberOfEducationDocument, String EducationIssuedDate,
            EnteranceExamination[] EnteranceExaminations,
            bool AllowUniversityExams, String Grounds,
            String Facilities, List<String> Olimpiads,
            bool NeedDorm, String IssuedUniversityEducation)
        {
            this.RegNumber = RegNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.BirthPlace = BirthPlace;
            this.Address_ = Address_;
            this.Citizenship = Citizenship;
            this.Passport = Passport;
            this.Serial = Serial;
            this.Number = Number;
            this.PassportIssuedDate = PassportIssuedDate;
            this.HomePhone = HomePhone;
            this.LearningForm = LearningForm;
            this.Funding = Funding;
            this.Specs = Specs;
            this.Education = Education;
            this.EducationDocument = EducationDocument;
            this.NumberOfEducationDocument = NumberOfEducationDocument;
            this.EducationIssuedDate = EducationIssuedDate;
            this.EnteranceExaminations = EnteranceExaminations;
            this.AllowUniversityExams = AllowUniversityExams;
            this.Grounds = Grounds;
            this.Facilities = Facilities;
            this.Olimpiads = Olimpiads;
            this.NeedDorm = NeedDorm;
            this.IssuedUniversityEducation = IssuedUniversityEducation;

        }

        public Applicant()
        {

        }

    }
    
    // Inner classes for applicant
    public class Address
    {
        public String Index { private set; get; }
        public String Region { private set; get; } // область
        public String Town { private set; get; } // город/поселок
        public String AppAddress { private set; get; } // адрес

        public Address(String Index, String Region, String Town, String AppAddress)
        {
            this.Index = Index;
            this.Region = Region;
            this.Town = Town;
            this.AppAddress = AppAddress;
        }

        public Address()
        {

        }
    }

    public class Specialization
    {
        public String Spec { set; get; }
        public List<String> Faculty { set; get; }

        public Specialization(String Spec, List<String> Faculty)
        {
            this.Spec = Spec;
            this.Faculty = Faculty;
        }

        public Specialization()
        {

        }
    }

    public class EnteranceExamination
    {
        public String Subject { set; get; }
        public int Points { set; get; }
        public bool Ege { set; get; }
        public bool Olimp { set; get; }
        public String TitleAndNum { set; get; }
        public String DocumentIssuedDate { set; get; }

        public EnteranceExamination(String Subject, int Point, bool Ege, bool Olimp, String TitleAndNum, String DocumentIssuedDate)
        {
            this.Subject = Subject;
            this.Points = Points;
            this.Ege = Ege;
            this.Olimp = Olimp;
            this.TitleAndNum = TitleAndNum;
            this.DocumentIssuedDate = DocumentIssuedDate;
        }

        public EnteranceExamination()
        {

        }
    }
}
