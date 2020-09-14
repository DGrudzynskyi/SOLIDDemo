namespace LiscovSubstitution
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public override double Length
        {
            get => base.Length;
            set => SetSize(value);
        }

        public override double Height
        {
            get => base.Height;
            set => SetSize(value);
        }

        public void SetSize(double size) {
            base.Length = size;
            base.Height = size;
        }
    }
}
