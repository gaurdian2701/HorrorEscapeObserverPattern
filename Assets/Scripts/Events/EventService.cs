using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventService : GenericMonoSingleton<EventService>
{
    public EventController OnLightSwitchToggled{  get; private set; }
    protected override void Awake()
    {
        base.Awake();
    }

    public EventService()
    {
        OnLightSwitchToggled = new EventController();
    }

}
