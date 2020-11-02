using System;
using System.Collections.Generic;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isLooping = true;
            string selectedString = "";

            while (selectedString == "")
            {

                string[] nameArray = new string[] { "Liam", "Oliva", "Cam", "Noah", "Blake", "Frank", "Ava", "William", "Sophia", "Elijah", "Isabella", "James", "Benjamin", "Charlotte", "Amelia", "Lucas", "Mia", "Mason", "Harper", "Ethan", "Evelyn" };


                Console.WriteLine(String.Format("Select an item from the array using numbers {0}-{1}", 1, nameArray.Length -1));
                string selectedIndexString = Console.ReadLine();


                try
                {
                    int selectedIndex = Convert.ToInt32(selectedIndexString);
                    if (selectedIndex < 1 || selectedIndex >= nameArray.Length +1)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    selectedString = nameArray[selectedIndex];
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The index must belong to the range: [{0}:{1}]", 1, nameArray.Length -1);
                    continue;
                }
            }

            while (isLooping)
            {
                Console.WriteLine(String.Format("You have choosen: {0} . What would you like to know about {0}? (enter “hometown” or “favorite food”)", selectedString));
                string TheTwoOptions = Console.ReadLine();

                // while (isLooping)

                // bool Liam =  TheTwoOptions == ("hometown");

                if (TheTwoOptions != "hometown" && TheTwoOptions != "favorite food")
                {
                    Console.WriteLine( " Data not correct");

                    continue;
                }

                if (selectedString == "Liam" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Liam is from Detroit, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Liam" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Liam's favorite food is popcorn! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Oliva" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Oliva is from Royal, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Oliva" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Oliva's favorite food is sushi! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Cam" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Cam is from Flint, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Cam" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Cam's favorite food is Soup! Would you like to know more? Enter 'yes' or 'no");

                }

                else if (selectedString == "Noah" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Noah is from Birmingham, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Noah" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Noah's favorite food is chicken fingers! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Blake" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Blake is from West Bloomfield, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Blake" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Blake's favorite food is Shrimp! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Frank" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Frank is from Bloomfield, MI. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Frank" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Frank's favorite food is Turkey! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Ava" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Ava is from Bloomington, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Ava" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Ava's favorite food is Salmon! Would you like to know more? Enter 'yes' or 'no");
                }



                else if (selectedString == "William" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("William is from Bloomingford, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "William" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("William's favorite food is chicken ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Sophia" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Sophia is from Greenwood, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Sophia" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Sophia's favorite food is watermelon ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Elijah" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Elijah is from Unionville, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Elijah" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Elijah's favorite food is apple pie ! Would you like to know more? Enter 'yes' or 'no");
                }
                else if (selectedString == "Isabella" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Isabella is from Linden, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Isabella" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Isabella's favorite food is strawberry pie ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "James" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("James is from Brazil, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "James" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("James's favorite food is berry pie ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Benjamin" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Benjamin is from Rushville, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Benjamin" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Benjamin's favorite food is banana pie ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Charlotte" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Charlotte is from York, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Charlotte" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Charlotte's favorite food is cucumber pie ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Amelia" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Amelia is from NewYork, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Amelia" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Amelia's favorite food is pudding pie ! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Lucas" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Lucas is from Paris, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Lucas" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Lucas's favorite food is pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Mia" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Mia is from Paris, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Mia" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Mia's favorite food is vanilla pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Mason" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Mason is from Clay, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Mason" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Mason's favorite food is strawberry pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Harper" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Harper is from Clayville, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Harper" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Harper's favorite food is oarnge pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Ethan" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Ethan is from Claysong, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Ethan" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Ethan's favorite food is apple pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                else if (selectedString == "Evelyn" && TheTwoOptions == "hometown")
                {
                    Console.WriteLine("Evelyn is from Austin, IN. Would you like to know more? Enter 'yes' or 'no'");
                }

                else if
                    (selectedString == "Evelyn" && TheTwoOptions == "favorite food")
                {
                    Console.WriteLine("Evelyn's favorite food is non-flavored pudding! Would you like to know more? Enter 'yes' or 'no");
                }

                Console.WriteLine(" Continue? (yes/no)");
                string userLoopInput = Console.ReadLine();

                if (userLoopInput.Equals("yes"))
                {
                    continue;

                }

                else

                {
                    isLooping = false;


                }

                Console.ReadLine();

            }
        }

    }
}