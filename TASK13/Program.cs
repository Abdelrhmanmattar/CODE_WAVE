namespace DAY13
{
    class Club
    {
        public void AddInClub()
        {
            Console.WriteLine("Employee added to the club");
        }
    }
    class SocialInsurance
    {
        public void BeginSocialInsurance()
        {
            Console.WriteLine("Employee's social insurance begin");
        }
    }
    public class employee
    {
        private Club club;
        private SocialInsurance socialInsurance;
        public employee()
        {
            this.club = new Club();
            this.socialInsurance = new SocialInsurance();
        }
        public void Add()
        {
            Console.WriteLine("Employee added to company");
            club.AddInClub();
            socialInsurance.BeginSocialInsurance();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            employee emp = new employee();
            emp.Add();
        }
    }

}