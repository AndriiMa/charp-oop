namespace csharp_oop{

    abstract  public class Shape{

       private  char color;

        public Shape(char color)
        {
            this.color = color;
        }


        abstract public  double CalculateArea();

        public override string ToString()
        {
            return $"Shape of color: {color}";
        }
    }

}