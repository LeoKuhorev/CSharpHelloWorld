using System.Collections.Generic;

namespace HelloWorld.Intermediate.Exercises
{
    public class WorkFlow
    {
        public IList<IActivity> Activities { get; }

        public WorkFlow()
        {
            Activities= new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}