namespace RecordStatic_TASK
{
    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Point {  get; set; }

        public Student(int id,string fullname,int point)
        {
            Id= id;
            FullName= fullname;
            Point = point;
        }
    }
}
