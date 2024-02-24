using System;

public class Course
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public string Description { get; set; }

    public Course(string id, string title, int credits, string description)
    {
        Id = id;
        Title = title;
        Credits = credits;
        Description = description;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        return Id == ((Course)obj).Id;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Credits: {Credits}, Description: {Description}";
    }
}
