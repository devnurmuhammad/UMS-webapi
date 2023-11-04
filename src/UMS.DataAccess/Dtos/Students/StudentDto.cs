﻿namespace UMS.DataAccess.Dtos.Students
{
    public class StudentDto
    {
        public long PersonalDataId { get; set; }
        public int Course { get; set; }
        public long SpecialtyEduFormId { get; set; }
        public bool IsActive { get; set; }
        public string EduType { get; set; }
        public string GroupNumber { get; set; }
        public long SubjectId { get; set; }
    }
}
