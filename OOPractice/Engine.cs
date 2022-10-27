namespace OOPractice
{
    public interface IEngine
    {
        int Speed { get; }
    }

    public class Engine : IEngine
    {

        public Engine(string type)
        {
            if (type == "gasoline")
            {
                this.Speed = 30;
            }
            else if (type == "electric")
            {
                this.Speed = 25;
            }
            else
            {
                this.Speed = 0;
            }
        }

        public int Speed { get; }
    }
}