using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Test
    {
        public string FIoExaminee { get; set; }
        public string FIoExaminer { get; set; }
        public DateTime Date { get; set; }
        public int Evaluation { get; set; }

        public Test(string fIoExaminee, string fIoExaminer,
                    DateTime date, int evaluation)
        {
            FIoExaminee = fIoExaminee;
            FIoExaminer = fIoExaminer;
            Date = date;
            Evaluation = evaluation;
        }
        public override string ToString()
        {
            return $"Test: {FIoExaminee}, {FIoExaminer}, { Date}, { Evaluation}";
        }
    }
}
