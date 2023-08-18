using N26_HT2.Enums;
using N26_HT2.Models;

var skillsA = new List<Skill>
{
    new Skill("Nimadir", SkillLevel.Beginner),
    new Skill("Nimadir2", SkillLevel.Master),
    new Skill("Nimadir3", SkillLevel.Expert),
};
var skillsB = new List<Skill>
{
     new Skill("Nimadir", SkillLevel.Beginner),
    new Skill("Nimadir2", SkillLevel.Expert),
    new Skill("Nimadir3", SkillLevel.Expert),
    new Skill("Nimadir4", SkillLevel.Master),
};

skillsA.Update(skillsB);

foreach(var item in skillsA)
{
    Console.WriteLine($"{item.Name} {item.Level}");
}