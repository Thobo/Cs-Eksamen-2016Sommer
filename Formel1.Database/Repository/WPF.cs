using Formel1.Database.Entity;

namespace Formel1.Database.Repository
{
    public class WPF
    {
        public void InsertDrivers(Driver driver)
        {
            using (var context = new Formel1Context())
            {
                context.Drivers.Add(driver);
                context.SaveChanges();
            }
        }

        public void InsertRace(Race race)
        {

        }
    }
}
