namespace CodeAlong2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Regler: Et hus er ikke ferdig før hver etasje består av nøyaktig\n5 rom, og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje.\n");
            Console.WriteLine("Når huset er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.\n");
            Console.WriteLine("Du kan velge av \"Bad: 1\" \"Kjøkken: 2\" \"Rom1: 3\" \"Rom2: 4\" og \"Rom3: 5\"\n");



            string Continue = "y";

            List<Room> rooms = new List<Room>();
            List<Floor> floors = new List<Floor>();
            List<House> house = new List<House>();

            int FloorNumber = 0;

            while(Continue == "y")
            {
                int NumberOfBad = 0;
                int NumberOfKjøkken = 0;
                string UserRoomToAdd;
                

                for (int i = 1; i <= 5; i++)
                {
                    UserRoomToAdd = Console.ReadLine()!;

                    if (UserRoomToAdd != null)
                    {
                        switch (UserRoomToAdd)
                        {
                            case "1":
                                if (NumberOfBad > 0)
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    rooms.Add(new Room("Bad"));
                                    NumberOfBad++;
                                    break;
                                }

                            case "2":
                                if (NumberOfKjøkken > 0)
                                {
                                    i--;
                                    break;
                                }
                                else
                                {
                                    rooms.Add(new Room("Kjøkken"));
                                    NumberOfKjøkken++;
                                    break;
                                }

                            case "3": rooms.Add(new Room("Room1")); break;

                            case "4": rooms.Add(new Room("Room2")); break;

                            case "5": rooms.Add(new Room("Room3")); break;

                            default:
                                Console.WriteLine("Oppgi et nummer mellom 1-5");
                                i--;
                                break;
                        }
                    }
                }

                floors.Add(new(FloorNumber, rooms));
                FloorNumber++;
                Console.WriteLine("\"y\" to continue");
                Continue = Console.ReadLine()!;

                house.Add(new(floors));
            }

            foreach (var room in house)
            {
                Console.WriteLine(room);
            }
        }
    }
}

/* Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom. Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad, kjøkken,
 * soverom eller stue. Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom, og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje. Når huset 
 * er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.*/

//TESTING
/*var roomsOnFloor1 = new List<Room> { room1, room2, room3, room4, room5 };
var floor1 = new Floor(1, roomsOnFloor1);

var roomsOnFloor2 = new List<Room> { room1, room2, room3, room4, room5 };
var floor2 = new Floor(2, roomsOnFloor2);

var floorsInTheHouse = new List<Floor> { floor1, floor2 };
var house = new House(floorsInTheHouse);*/

//A kuløn objectek kuløn køløn is kiirathatåk igy:
/*Console.WriteLine(room1);
Console.WriteLine(floor1);*/

//Itt kilistazzuk az egesz hazat
//Console.WriteLine(house);