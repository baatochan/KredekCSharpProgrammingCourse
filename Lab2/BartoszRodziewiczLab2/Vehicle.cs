namespace BartoszRodziewiczLab2
{
    public class Vehicle : Base, IMovable
    {
        public int NumberOfWheels { get; set; }

        public string Move()
        {
            return "Ja jadeeeee! :)";
        }
    }
}
