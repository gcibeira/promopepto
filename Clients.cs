class Client
{
    public string Name { get; set; }
    public int Credits { get; set; }

    public Client(string name)
    {
        this.Name = name;
        this.Credits = 0;
    }

    public int IncrementCredits()
    {
        if(this.Credits < 10)
            this.Credits++;
        return this.Credits;
    }
    public int DecrementCredits()
    {
        if (this.Credits > 0)
            this.Credits--;
        return this.Credits;
    }

    public int ResetCredits()
    {
        this.Credits = 0;
        return this.Credits;
    }
}