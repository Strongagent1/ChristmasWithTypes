using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
<<<<<<< HEAD
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
=======
        public int? TreeHeight { get; set; } //Done  Make the Height property nullable

        //Done Make the property, "Day", type enum
        public enum Day {   Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
>>>>>>> 268ab3a16fcacb29947175c37c7d924400fb53be

    }
}
