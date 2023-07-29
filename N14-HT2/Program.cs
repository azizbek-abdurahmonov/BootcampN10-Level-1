using N14_HT2_CL;

var classRoom = new UltimateClassroomAttendance();
classRoom.Mark("Azizbek", true);
classRoom.Mark("Habiba", true);
classRoom.Mark("Bunyod", false, "Shaxsiy ishi bor");
classRoom.Mark("Mahroj", false, "Viloyatga ketgan");
classRoom.Mark("Abdurahmon", true);

classRoom.Display();