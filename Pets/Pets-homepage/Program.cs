using PetArchive;
string input = "";

    while(input != "4"){
    //creating a pet shop using classes in c#
    Console.WriteLine("Welcome to the Pet Store!\n");

    //create list/prompt user
    Console.WriteLine("1. ADD A NEW PET\n2. LIST ALL PETS\n3. HAVE PETS MEET\n4. EXIT\n");
        input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("What is the name of your new pet?");
            string petName = Console.ReadLine();
            Console.WriteLine("1. Add a new cat\n2. Add a new Turtle\n3. Add a new Chimp");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    Cat newCat = new Cat(petName);
                    break;
                case "2":
                    Chimp newChimp = new Chimp(petName);

                    break;
                case "3":
                    Turtle newTurtle = new Turtle(petName);

                    break;

            }
            break;
        case "2":
            break;
        case"3":
            break;
        case"4":
            break;
        default:
            break;
    }
        


}