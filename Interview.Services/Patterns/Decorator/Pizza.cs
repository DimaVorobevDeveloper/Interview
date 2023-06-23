namespace Interview.Services.Patterns.Decorator
{
   public abstract class Pizza
    {
        protected Pizza(string n)
        {
            this.Name = n;
        }

        public string Name { get; protected set; }

        public abstract int GetCost();
    }
}
