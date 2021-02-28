namespace HelloWorld.Intermediate.Exercises
{
    class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }

        }
    }
}