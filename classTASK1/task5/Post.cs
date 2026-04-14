class Post
{
    public string Text {get; set;}
    public int Like {get; set;}
    public List<string> Comment {get; set;} =[];

    public void SetPost(string text)
    {
        Text =text;
        System.Console.WriteLine("Post Created: ");
    }
    public void AddLike()
    {
        Like++;
    }
    public void addComment(string commment)
    {
        Comment.Add(commment);
    }
    public void GetInfo()
    {
        System.Console.Write("Post title: "+Text);
        System.Console.WriteLine();
        System.Console.Write("Total likes: "+Like);
        System.Console.WriteLine();
        System.Console.WriteLine("Comments in this post: ");
        foreach (var item in Comment)
        {
            System.Console.WriteLine(item);
        }
    }
}