public class Date
{
    private int day;
    private int month;
    private int year;

    // Public properties
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructors
    public Date() : this(1, 1, 1) { }

    public Date(int day) : this(day, 1, 1) { }

    public Date(int day, int month) : this(day, month, 1) { }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Methods
    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int GetDay()
    {
        return day;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetYear()
    {
        return year;
    }

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year:D4}";
    }
}