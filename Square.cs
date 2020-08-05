namespace csharp_oop{
    public class Square : Shape
    {
        private int side;
        public Square(char color, int side): base(color){
            this.side = side;
        }

        public override double CalculateArea()
        {
            return side*side;
        }
    }
}