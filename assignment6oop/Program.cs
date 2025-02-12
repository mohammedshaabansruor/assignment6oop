namespace assignment6oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region P01
            Point3D point = new Point3D(10);
            Console.WriteLine(point);




            Point3D[] points =
            {
                new Point3D(2,3,4),
                new Point3D(5,6,7),
                new Point3D(2,9,10),
            };



            Array.Sort(points);
            foreach (Point3D item in points)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
