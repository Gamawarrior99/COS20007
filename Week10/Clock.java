import java.awt.*;
import java.io.IOException;
import java.text.MessageFormat;


public class Main
{

  public static void clearScreen()
  {  
    System.out.print("\033[H\033[2J");  
    System.out.flush();  
  }

  public static void main(String[] arg)
  {
    Clock TestClock = new Clock();
    while (true)
    {
      TestClock.Tick();
      try
      {
        Thread.sleep(1000);
        clearScreen();
      }catch (InterruptedException e) {}

      System.out.println(TestClock.Print());
      
    }
  }
}

import java.awt.*;
import java.io.IOException;
import java.text.MessageFormat;

public class Clock
{
    final int secNumber = 60;
    final int minNumber = 60;
    final int hourNumber = 24;
    private Counter Hours;
    private Counter Minute;
    private Counter Second;

    public Clock()
    {
      Hours = new Counter("Hours");
      Minute = new Counter("Minutes");
      Second = new Counter("Seconds");
    }

    public final void Tick()
    {
      Second.Increment();

        if((Second.Value()) == secNumber)
        {
          Minute.Increment();
          Second.Reset();
        }

        if((Minute.Value()) == minNumber)
        {
            HRS.Increment();
            Minute.Reset();
        }

        if((Hours.Value()) == hourNumber)
        {
          Hours.Reset();
          Minute.Reset();
          Second.Reset();
        }
    }

    public String Print()
    {
        return MessageFormat.format("{0, Number,00}:{1, Number,00}:{2, Number,00}",Hours.Value(), Minute.Value(),Second.Value());
    }

    public void Reset()
    {
      Hours.Reset();
      Minute.Reset();
      Second.Reset();
    }
}

import java.awt.*;
import java.io.IOException;
import java.text.MessageFormat;

public class Counter
{
    private int _count;
    private String _name;

    public Counter (String name)
    {
      _name = name;
      _count = 0;
    }

    public String Name()
    {
        return _name;
    }
    public void setName(String newName) 
    {
      this._name = newName;
    }

    public int Value()
    {
        return _count;
    }
   public int getCount() 
    {
      return _count;
    }
    public void setName(int newCount) 
    {
      this._count = newCount;
    }

    public void Increment()
    {
        _count += + 1;
    }

    public void Reset()
    {
        _count = 0;
    }
}