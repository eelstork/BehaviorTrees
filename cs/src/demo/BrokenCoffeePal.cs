using Activ.Rx; using static Activ.Rx.status;

public class BrokenCoffeePal{

    public Container tap, pot, pouch, cup;
    public Kettle kettle;

    public status Brew()
    => Pour(tap, kettle)
    && kettle.Switch(true)
    && Pour(pouch, pot)
    && kettle.boiled ? done : cont
    && Pour(kettle, pot)
    && Wait(minutes: 1)
    && Pour(pot, cup);

    public status Pour(object src, object dst) => done;

    public status Wait(int minutes) => done;

}

public class Container{}

public class Kettle : Container{

    public bool boiled;

    public bool Switch(bool on) => on ? boiled = true : boiled;

}
