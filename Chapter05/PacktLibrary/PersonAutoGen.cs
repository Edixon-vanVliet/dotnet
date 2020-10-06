namespace Packt.Shared
{
    public partial class Person
    {
        // a property defined using C# 1 - 5 syntax 
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }


    }
}