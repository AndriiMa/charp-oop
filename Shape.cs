namespace csharp_oop{

    public class Shape{

       private  char color;

        public Shape(char color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"Shape of color: {color}";
        }
    }

}