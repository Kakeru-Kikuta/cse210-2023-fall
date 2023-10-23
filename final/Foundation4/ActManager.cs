using System;

public class ActManager
{
    private List<Activity> _acts = new List<Activity>();

    public ActManager()
    {}

    public void AddActivity(Activity activity)
    {
        _acts.Add(activity);
    }

}
