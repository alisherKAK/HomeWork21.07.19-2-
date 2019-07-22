using System;

namespace HomeWork21_07_19_2_
{
    public interface IProduct
    {
        string Description();
    }

    public interface IProcessor : IProduct
    { }

    public interface IMainboard : IProduct
    {
        string ShowProcessor(IProcessor processor);
    }

    public interface IAbstractFactory
    {
        IMainboard GetMainboard();
        IProcessor GetProcessor();
    }

    public class Dell : IAbstractFactory
    {
        public IMainboard GetMainboard()
        {
            return new DellMainboard();
        }

        public IProcessor GetProcessor()
        {
            return new DellProcessor();
        }
    }

    public class Sony : IAbstractFactory
    {
        public IMainboard GetMainboard()
        {
            return new SonyMainboard();
        }

        public IProcessor GetProcessor()
        {
            return new SonyProcessor();
        }
    }

    public class DellMainboard : IMainboard
    {
        public string Description()
        {
            return "This is Dell's mainboard";
        }

        public string ShowProcessor(IProcessor processor)
        {
            return $"In Dell mainboard({processor.Description()})";
        }
    }

    public class DellProcessor : IProcessor

    {
        public string Description()
        {
            return "This is Dell's processor";
        }
    }

    public class SonyMainboard : IMainboard
    {

        public string Description()
        {
            return "This is Sony's mainboard";
        }

        public string ShowProcessor(IProcessor processor)
        {
            return $"In Sony mainboard({processor.Description()})";
        }
    }

    public class SonyProcessor : IProcessor
    {
        public string Description()
        {
            return "This is Sony's processor";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClientCode(new Dell());
            ClientCode(new Sony());
        }

        static void ClientCode(IAbstractFactory factory)
        {
            IMainboard mainboard = factory.GetMainboard();
            IProcessor processor = factory.GetProcessor();

            Console.WriteLine(mainboard.Description());
            Console.WriteLine(mainboard.ShowProcessor(processor));
        }
    }
}
