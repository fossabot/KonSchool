namespace KonSchool_Models
{
    public partial class School
    {
        private int mobilenum;
        public string MobileNum
        {
            get => "+880" + mobilenum.ToString();
            set => mobilenum = System.Convert.ToInt32(value);
        }

        private int eiin;
        public int EIIN
        {
            get => eiin;
            set => eiin = (value >= 100_000) ? value - 100_000 : value;
        }

        private string name;
        public string Name { get => name; set => name = value; }
        
        private int age;
        public int Age { get => age; set => age = value; }

        private Address location;
        public Address Location { get => location; set => location = value; }

        private double distance;
        public double Distance { get => distance; set => distance = value; }

        private string streetaddr;
        public string StreetAddr { get => streetaddr; set => streetaddr = value; }
        
        private string type; // boys'/girls'/co-ed
        public string Type { get => type; set => type = value; }

        private string level; // ju-sec/sec/hi-sec
        public string Level { get => level; set => level = value; }

        private double averAge;
        public double AverAge { get => averAge; set => averAge = value; }

        private double smfRatio;
        public double Students_MFRatio { get => smfRatio; set => smfRatio = value; }

        private double tsRatio;
        public double TeacherStudentRatio { get => tsRatio; set => tsRatio = value; }
        
        private double seScore;
        public double SEScore { get => seScore; set => seScore = value; }

        private System.ValueTuple<double, double, double>[,] CompMat;

        
        public School(int EIIN) => eiin = EIIN;
    }
}