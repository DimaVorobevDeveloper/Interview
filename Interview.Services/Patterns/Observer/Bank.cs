namespace Interview.Services.Patterns.Observer
{
    /// <summary>
    /// Банк - наблюдатель
    /// <para>будет следить за передаваемым ему объектом.</para>
    /// </summary>
    public class Bank : IObserver
    {
        public string Name { get; set; }

        /// <summary>
        /// содержит ссылку на наблюдаемый объект
        /// </summary>
        IObservable stock;

        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}
