using System;

class Student
{
    public string Name { get; set; }
    private int rating;

    public void SetRating(int value)
    {
        if (value >= 0 && value <= 100)
            rating = value;
        else
            throw new ArgumentException("Reyting 0-100 oralig'ida bo'lishi kerak");
    }

    public string GetStatus()
    {
        return rating > 60 ? "Passed" : "Failed";
    }

    public int GetRating()
    {
        return rating;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Ali";
        s.SetRating(75);

        Console.WriteLine(s.Name);
        Console.WriteLine(s.GetRating());
        Console.WriteLine(s.GetStatus());
    }
}
