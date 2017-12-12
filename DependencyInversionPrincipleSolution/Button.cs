public class Button {
    private ButtonServer _buttonServer;

    public Button(ButtonServer buttonServer) {
        this._buttonServer = buttonServer;
    }

    public void Push() {
        if (/*some condition*/) {
            _buttonServer.TurnOff();
        } else if (/*some condition*/) {
            _buttonServer.TurnOn();
        }
    }
}

public interface ButtonServer {
    void TurnOn();
    void TurnOff();
}

public class Lamp : ButtonServer {
    public void TurnOn() {
        //supply power to object
    }

    public void TurnOff() {
        //cut the power to the object
    }
}
public class TV : ButtonServer {
    public void TurnOn() {
        //supply power to object
    }

    public void TurnOff() {
        //cut the power to the object
    }
}


Tv tv = new TV();
Lamp lamp = new Lamp();

Button button = new Button(Tv);
Button button = new Button(Lamp);