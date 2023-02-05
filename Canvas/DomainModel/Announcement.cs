namespace DomainModel
{
    public class Announcement
    {
        int id;
        string date;
        string message;

        public int getId() {
            return this.id;
        }
        public string getDate() {
            return this.date;
        }
        public string getMessage() {
            return this.message;
        }
        public void announce(string message) {
            this.message = message;
        }
    }
}