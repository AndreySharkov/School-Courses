using System;
using System.Collections;
using System.Collections.Generic;

public class Competitor<T> : IEnumerable<T>, IComparable<Competitor<T>>
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 10)
            {
                throw new ArgumentOutOfRangeException("Age cannot be less than 10.");
            }
            age = value;
        }
    }

    public List<T> Scores { get; private set; }

    public Competitor(string name, int age)
    {
        Name = name;
        Age = age;
        Scores = new List<T>();
    }

    public void Add(T score)
    {
        Scores.Add(score);
    }

    public int CountCompetitions()
    {
        return Scores.Count;
    }

    public T ChangeLastScore(T newScore)
    {
        if (Scores.Count == 0)
        {
            throw new InvalidOperationException("No scores to change.");
        }

        T oldScore = Scores[Scores.Count - 1];
        Scores[Scores.Count - 1] = newScore;
        return oldScore;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return Scores.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CompareTo(Competitor<T> other)
    {
        if (other == null)
        {
            return 1;
        }
        int nameComparison = string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        if (nameComparison == 0)
        {
            return nameComparison;
        }

        return this.Age.CompareTo(other.Age);
    }
}