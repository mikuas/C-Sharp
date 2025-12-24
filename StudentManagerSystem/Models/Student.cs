namespace StudentManagerSystem.Models;

public class Student
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required char Gender { get; set; }
    public required int Age { get; set; }

    public override string ToString() => $"学号: {Id},\t 姓名: {Name},\t 性别: {Gender},\t 年龄: {Age}";
}