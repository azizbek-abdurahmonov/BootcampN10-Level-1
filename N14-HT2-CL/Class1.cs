namespace N14_HT2_CL
{
    public class ClassroomAttendance
    {
        protected Dictionary<string, string> pupils = new Dictionary<string, string>();
        public virtual void Display()
        {
            foreach(var pupil in pupils)
            {
                Console.WriteLine($"{pupil.Key} - {pupil.Value}");
            }
        }

        public void Mark(string fullName, bool isPresent)
        {
            pupils[fullName] = isPresent ? "present" : "absent";
        }

        internal protected double GetStats()
        {
            var attend = default(int);
            foreach (var att in pupils)
            {
                if (att.Value == "present")
                    attend++;
            }
            return ((double)attend / pupils.Count) * 100;
        }

    }

    public class UltimateClassroomAttendance : ClassroomAttendance
    {
        public new void Mark(string fullName, bool isPresent, string cause = "")
        {
            pupils.Add(fullName, isPresent ? "present" : "absent " + cause);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Qatnashganlik foizi : {GetStats()}%");
        }
    }
}