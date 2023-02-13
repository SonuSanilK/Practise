using ProjectNew.Types;

namespace ProjectNew.Entities
{
    internal class Exam
    {
        public ExamType Type { get; set; }

        public Subject Subject { get; set; }

        public int MarkScored { get; set; }
    }
}
