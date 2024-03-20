namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string StartDayTime { get; private set; }
        public string EndDayTime { get; private set; }

        public Activity(int id, string name, string startDayTime, string endDayTime)
        {
            Id = id;
            Name = name;
            StartDayTime = startDayTime;
            EndDayTime = endDayTime;
        }
    }
}
