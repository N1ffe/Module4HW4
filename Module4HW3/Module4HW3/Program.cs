using Module4HW4.Entities;

namespace Module4HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<Title> titles = db.Titles.ToList();
                foreach (Title title in titles)
                {
                    Console.WriteLine($"{title.TitleId} {title.Name}");
                }
            }
        }
    }
}