using System;

public class Students
{

	private string _name;
	private string _surname;
	private int _avgPoint;

    public string Name { get; set; }
    public string Surname { get; set; }


    public int Avgpoint
    {
        get
        {
            
            return _avgPoint;
        }
        set
        {

            if(value>=0 && value <= 100)
            {

                _avgPoint = value;
            }
            else
            {
                _avgPoint = -1;
            }

        }
    }
}
