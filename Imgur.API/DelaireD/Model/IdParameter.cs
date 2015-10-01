namespace DelaireD.Model
{
    public abstract class IdParameter 
    {
        protected IdParameter()
        {
        }
        protected IdParameter(string id)
        {
            Id = id;
        }
        public string Id { get; set; }
    }
}