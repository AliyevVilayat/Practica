using Practica9.Exceptions;

namespace Practica9.Entitiy;

public class User
{
    public static int _id = 0;
    public int Id
    {
        get => _id;
    }
    public List<Status> Statuses { get; set; }

    public string Username { get; set; }

    public User(string username)
    {
        _id++;
        Username = username;
        Statuses = new List<Status>();
    }

    public void ShareStatus(Status status)
    {
        Statuses.Add(status);
    }

    public Status GetStatusById(int? id)
    {

        Status status = Statuses.Find(status => status.Id == id);

        return status;
    }

    public List<Status> GetAllStatuses()
    {
        if (Statuses.Count != 0)
        {
            return Statuses;
        }
        return null;
    }

    public List<Status> FilterStatusByDate(DateTime date)
    {
        List<Status> CheckStatuses = new();
        CheckStatuses = Statuses.FindAll(status => (status.SharedDate.Ticks - date.Ticks) / 10000000 >= 0);

        if (CheckStatuses.Count == 0)
        {
            throw new NotFoundException("User hec bir status");
        }

        return CheckStatuses;

    }

}
