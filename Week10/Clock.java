import java.awt.*;
import java.io.IOException;


public class Main
{

  public static void clearScreen()
  {  
    System.out.print("\033[H\033[2J");  
    System.out.flush();  
  }

  public static void main(String[] arg)
  {
    Clock testClock = new Clock();
    while (true)
    {
      testClock.Tick();
      try
      {
        Thread.sleep(1000);
        clearScreen();
      }catch (InterruptedException e) {}

      System.out.println(testClock.Print());
      
    }
  }
}

public class Clock
{
    final int SECS_NUMBER = 60;
    final int MINS_NUMBER = 60;
    final int HRS_NUMBER = 24;
    private Counter HRS = new Counter("Hours");
    private Counter MINS = new Counter("Minutes");
    private Counter SECS = new Counter("Seconds");

    public final void Tick()
    {
        SECS.Increment();

        if((SECS.Value()) == SECS_NUMBER)
        {
            MINS.Increment();
            SECS.Reset();
        }

        if((MINS.Value()) == MINS_NUMBER)
        {
            HRS.Increment();
            MINS.Reset();
        }

        if((HRS.Value()) == HRS_NUMBER)
        {
            HRS.Reset();
            MINS.Reset();
            SECS.Reset();
        }
    }


    public String Print()
    {

        String _seconds;
        String _minutes;
        String _hours;


        _seconds = Integer.toString(SECS.Value());
        _minutes = Integer.toString(MINS.Value()) + ":";
        _hours = Integer.toString(HRS.Value()) + ":";
        return (_hours + _minutes + _seconds);
    }

    public void Reset()
    {
        HRS.Reset();
        MINS.Reset();
        SECS.Reset();
    }
}

public class Counter
{
    private int _count;
    private String _name;

    public Counter (String name)
    {
        this. _name = name;
        this. _count = 0;
    }

    public void Increment()
    {
        _count = _count + 1;
    }

    public void Reset()
    {
        _count = 0;
    }

    public String Name()
    {
        return _name;
    }

    public int Value()
    {
        return _count;
    }

}