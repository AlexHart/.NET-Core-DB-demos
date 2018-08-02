namespace DbCoreDemos.EFCSharpInMemory.BusinessLogic
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\tUrl: {this.Url}";
        }
    }
}
