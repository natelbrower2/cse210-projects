namespace learning05
{
    public class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public void setColor(string color)
        {
            _color = color;
        }

        public string getColor()
        {
            return _color;
        }

        public virtual double GetArea()
        {
            return 5;
        }
    }
}