namespace IlmhubProblems.Solutions.LittlePrince
{
    public interface IStorage
    {
        List<Point> GetAllPoints();
        void InsertPoint(Point point);
        List<Point> FindPoints(string search);
    }
}