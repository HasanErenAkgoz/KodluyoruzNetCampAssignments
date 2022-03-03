public class Directory{

    public string number { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }

    public Directory(string number,string Name,string SurName)
    {
        this.Name=Name;
        this.SurName=SurName;
        this.number=number;
    }

}