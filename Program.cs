// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"    ____                      _ __  _            __         ____                  ____          __
   / __ \____ __      _______(_) /_(_)   _____  / /_  __   / __ \__  ____________/ __/__  _____/ /_
  / /_/ / __ `/ | /| / / ___/ / __/ / | / / _ \/ / / / /  / /_/ / / / / ___/ ___/ /_/ _ \/ ___/ __/
 / ____/ /_/ /| |/ |/ (__  ) / /_/ /| |/ /  __/ / /_/ /  / ____/ /_/ / /  / /  / __/  __/ /__/ /_
/_/    \__,_/ |__/|__/____/_/\__/_/ |___/\___/_/\__, /  /_/    \__,_/_/  /_/  /_/  \___/\___/\__/
                                               /____/                                              ");

List<Category> categories = new List<Category>()
{
   new Category()
   {
      Name = "Cute",
      Id = 1
   },
   new Category()
   {
      Name = "Evil",
      Id = 2
   },
   new Category()
   {
      Name = "Angry",
      Id = 3
   }
};

Random random = new Random();

List<Meme> memes = new List<Meme>()
{
   new Meme()
   {
      Content = "Are you fur real?",
      CategoryId = 3,
      PostDate = new DateTime(2023, random.Next(2,9), random.Next(1,29) ),
      Cringe = 0.7M
   },
   new Meme()
   {
      Content = "What do you call a cat teacher? ...A purrfessor.",
      CategoryId = 1,
      PostDate = new DateTime(2023, random.Next(2,9), random.Next(1,29) ),
      Cringe = 0.6M
   },
   new Meme()
   {
      Content = "You've got to be kitten me right now!",
      CategoryId = 2,
      PostDate = new DateTime(2023, random.Next(2,9), random.Next(1,29) ),
      Cringe = 0.9M
   },
   new Meme()
   {
      Content = "Let's paws for a moment and appreciate these cat puns.",
      CategoryId = 2,
      PostDate = new DateTime(2023, random.Next(2,9), random.Next(1,29) ),
      Cringe = 0.5M
   },
   new Meme()
   {
      Content = "What's the best medicine for cat allergies? ...Anti-hisstamines.",
      CategoryId = 1,
      PostDate = new DateTime(2023, random.Next(2,9), random.Next(1,29) ),
      Cringe = 0.3M
   }
};

void MainMenu()
{

    string? menuSelection = null;

    while (menuSelection != "0")
    {
        Console.WriteLine(@"Choose an option:
   0. Exit
   1. View All Memes
   2. Sort by CATegory
   3. Sort by Latest Posted
   4. Post new meme
   5. Edit meme
   6. Delete meme");

        switch (menuSelection)
        {
            case "0":
                Console.WriteLine("Live long and pawsper");
                break;
            case "1":
                throw new NotImplementedException();
            case "2":
                throw new NotImplementedException();
            case "3":
                throw new NotImplementedException();
            case "4":
                throw new NotImplementedException();
            case "5":
                throw new NotImplementedException();
            case "6":
                throw new NotImplementedException();
        }
    }

}

Console.Clear();
MainMenu();

void ViewAllMemes()
{

}

void SortByCategory()
{

}

void SortByLatest()
{

}

void PostMeme()
{

}

void EditMeme()
{

}

void DeleteMeme()
{

}