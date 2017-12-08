/**
    Scenario: 
        -Here you have a button and when the button is pressed it calls a lamp object to turn it on or off.
        -The fundamental issue here is that the abstraction of a button should not be dependent on a lamp.
        We want our button to be able to work with any object we hook it up to. The lamp should be dependent on the button and not the other way around.
        The button should not care what it's target object is. 

        Fix this class so that it works with the the dependency inversion principle in mind. 
        To prove your solution works add a TV class which may have a different implementation of turnOn/turnOff.
 */

public class Button {
    private Lamp lamp;
    public void Push() {
        if (/*some condition*/) {
            lamp.TurnOff();
        } else if (/*some condition*/) {
            lamp.TurnOn();
        }
    }
}

public class Lamp {
    public void TurnOn() {
        //supply power to object
    }

    public void TurnOff() {
        //cut the power to the object
    }
}