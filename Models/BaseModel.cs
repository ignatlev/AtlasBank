namespace Bank.Models
{
    public abstract class BaseModel
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public void SetId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative.");
            }
            _id = id;
        }

        public void SetCreatedAt(DateTime createdAt)
        {
            _createdAt = createdAt;
        }
    }
}