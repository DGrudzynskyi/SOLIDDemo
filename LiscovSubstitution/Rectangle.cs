namespace LiscovSubstitution
{
    public class Rectangle
    {
        private double _length;
        private double _height;

        public Rectangle(double length,double height) {
            _length = length;
            _height = height;
        }

        public virtual double Length { get => _length; set => _length = value; }

        public virtual double Height { get => _height; set => _height = value; }

        public double Area()
        {
            return _length * _height;
        }
    }
}
