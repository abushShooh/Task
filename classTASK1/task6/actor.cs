public class Movie
{
    private string title;
    private int releaseYear;

    public Movie(string title, int releaseYear)
    {
        this.title = title;
        this.releaseYear = releaseYear;
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetReleaseYear()
    {
        return releaseYear;
    }
}

public class Actor
{
    private string fullName;
    private int age;
    private string gender;
    private List<Movie> moviesPlayed;

    public Actor(string fullName, int age, string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
        this.moviesPlayed = new List<Movie>();
    }

    public void AddMovie(Movie movie)
    {
        if (movie != null)
        {
            moviesPlayed.Add(movie);
        }
    }

    public List<Movie> GetMoviesPlayed()
    {
        return new List<Movie>(moviesPlayed); // возвращаем копию списка
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGender(string gender)
    {
        this.gender = gender;
    }

    public string GetGender()
    {
        return gender;
    }
}