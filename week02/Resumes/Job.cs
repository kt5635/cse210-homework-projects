public class Job {
    public string _company = "";
    public string _jobTitle = "";
    public double _startYear = 0;
    public double _endYear = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}