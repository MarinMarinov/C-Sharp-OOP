namespace Problem_1.Shapes
{
    using System;

    class TheMain
    {
        static void Main()
        {
            Rectangle firstRec = new Rectangle(4.3, 5.8);
            Console.WriteLine(firstRec.CalculateSurface());

            Square firstSquare = new Square(3.24);
            Console.WriteLine(firstSquare.CalculateSurface());

            Triangle firstTriangle = new Triangle(3, 4);
            Console.WriteLine(firstTriangle.CalculateSurface());

            Shape[] arrayOfShapes = 
            {
                firstRec,
                new Rectangle(2.834, 4.956),
                firstSquare,
                new Square(5.689),
                firstTriangle,
                new Triangle(3.45, 6.789)
            };

            foreach (Shape shape in arrayOfShapes)
            {
                Console.WriteLine("{0} area: {1} m2", shape.GetType().Name, shape.CalculateSurface());
            }

            //Rectangle wrongRectangle = new Rectangle(-2, 8);// OK- хвърля ексепшън при валидацията!
        }
    }
}
