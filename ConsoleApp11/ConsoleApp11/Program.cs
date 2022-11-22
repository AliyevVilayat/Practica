using System.Text;

Students student = new Students();
student.Name = "Vilayat";
student.Surname = "Aliyev";
student.Avgpoint = 99;

Console.WriteLine($"Name:  {student.Name},Surname: {student.Surname},Point: {student.Avgpoint}");


BuilderString bs = new BuilderString();
bs.Append("test");
Console.WriteLine(bs);
