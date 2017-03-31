namespace TechJobs.Models
{
    public class JobField
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Value { get; set; }

        public JobField()
        {
            ID = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        // Provide a basic case-insensitive search
        public bool Contains(string testValue)
        {
            return Value.ToLower().Contains(testValue.ToLower());
        }

        public override string ToString()
        {
            return Value;
        }

        // override object.Equals                       // I Dont really understand what this is doing
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())  // especially the 2nd half of this disjunction
            {
                return false;
            }
            
            return (obj as JobField).ID == ID;              // or this 'else' return
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return ID;
        }

    }
}
