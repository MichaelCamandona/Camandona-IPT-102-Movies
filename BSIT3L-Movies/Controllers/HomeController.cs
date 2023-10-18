using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel {
                Id = 1,
                Name = "Titanic",
                Rating = "10",
                ReleaseYear = 1997,
                Genre = "Romance/Drama",
                Description = "Titanic is a famous romantic film. This film is about the love " +
                "story of Rose Dewitt Bukater and Jack Dawson. Jack was a free-spirited poor " +
                "young man but he got a ticket for a luxurious ship, Titanic. Rose was from the " +
                "American upper class and was engaged to a man. She was reluctant to marry him. " +
                "She met Jack in Titanic and they fell deeply in love even there was a huge gap between them.",
                Image = "/Content/Images/1.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=b0KYvGa_nN8"},



            new MovieViewModel {
                Id = 2,
                Name = "Inception",
                Rating = "10",
                ReleaseYear = 2010,
                Genre = "Science Fiction/Thriller",
                Description = "The movie tells about Dom Cobb. He is not an ordinary thief. " +
                "He is masterly on stolen, can penetrate into the unconscious of any person to " +
                "steal the recesses secret of these people. If he wants to do this, he walks into their dreams.",
                Image = "/Content/Images/2.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0&t=66s" },

            new MovieViewModel {
                Id = 3,
                Name = "The Shawshank Redemption",
                Rating = "9",
                ReleaseYear = 1994,
                Genre = "Drama",
                Description = "After the murder of his wife, hotshot banker Andrew Dufresne is sent to Shawshank " +
                "Prison, where the usual unpleasantness occurs. Over the years, he retains hope and eventually gains " +
                "the respect of his fellow inmates, especially longtime convict “Red” Redding, a black marketeer," +
                " and becomes influential within the prison. Eventually, Andrew achieves his ends on his own terms.",
                Image = "/Content/Images/3.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=PLl99DlL6b4"},

            new MovieViewModel {
                Id = 4,
                Name = "Fight Club",
                Rating = "9",
                ReleaseYear = 1999,
                Genre = "Drama" ,
                Description = "A ticking-time-bomb insomniac and a slippery soap salesman channel primal male " +
                "aggression into a shocking new form of therapy. Their concept catches on, with underground " +
                "“fight clubs” forming in every town, until an eccentric gets in the way and ignites an " +
                "out-of-control spiral toward oblivion. Fight Club attracts many viewers by its interesting content.",
               Image = "/Content/Images/4.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=qtRKdVHc-cE"},

            new MovieViewModel {
                Id = 5,
                Name = "Forrest Gump",
                Rating = "9",
                ReleaseYear = 1999,
                Genre = "Action/Sci-Fi",
                 Description = "Forrest Gump is set in the war in Vietnam, boy Forrest Gump was born and grew up " +
                 "not normally like any other children. His fate through many events and ties to the historical " +
                 "change.",
               Image = "/Content/Images/5.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=bLvqoHBptjg"},

            new MovieViewModel {
                Id = 6,
                Name = "Spider-Man: Homecoming",
                Rating = "10",
                ReleaseYear = 2017,
                Genre = "Action/Adventure/Fantasy",
                 Description = "The movie follows Peter Parker as he balances his dual identity of a budding " +
                 "superhero while navigating the everyday life of a teenager in high school. Peter must soon " +
                 "put his powers to the test when the evil Vulture emerges to threaten everything that he holds dear.",
               Image = "/Content/Images/6.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=rk-dF1lIbIg" },

            new MovieViewModel {
                Id = 7,
                Name = "Lord of The Rings",
                Rating = "9",
                ReleaseYear = 2001,
                Genre = "Action/Adventure/Drama" ,
                 Description = "Soon after, the Dark Lord Sauron makes the One Ring, and uses it to attempt to " +
                 "conquer Middle-earth. Following the Last Alliance of Elves and Men’s fall, the Ring is seized " +
                 "by Prince Isildur, lies at the bottom of the river Anduin for over 2500 years.",
               Image = "/Content/Images/7.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4"},

            new MovieViewModel {
                Id = 8,
                Name = "The Silence of the Lambs",
                Rating = "9",
                ReleaseYear = 1991,
                Genre = "Crime/Drama/Thriller" ,
                 Description = "FBI trainee Clarice Starling is pulled from her training at the FBI Academy " +
                 "at Quantico, Virginia by Jack Crawford of the Bureau’s Behavioral Science Unit. He assigns " +
                 "her to interview Hannibal Lecter, a former psychiatrist and incarcerated cannibalistic serial " +
                 "killer.",
                Image = "/Content/Images/8.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=6iB21hsprAQ" },

            new MovieViewModel {
                Id = 9,
                Name = "Gladiator",
                Rating = "8",
                ReleaseYear = 2000,
                Genre = "Action/Adventure/Drama" ,
                 Description = "Maximus is a powerful Roman general, loved by the people and the aging Emperor," +
                 " Marcus Aurelius. Before his death, the Emperor chooses Maximus to be his heir over his own son," +
                 " Commodus, and a power struggle leaves Maximus and his family condemned to death.",
                Image = "/Content/Images/25.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=P5ieIbInFpg"},

            new MovieViewModel {
                Id = 10,
                Name = "The Departed",
                Rating = "9",
                ReleaseYear = 2006,
                Genre = "Crime/Drama/Thriller" ,
                 Description = "Two men from opposite sides of the law are undercover within the Massachusetts" +
                 " State Police and the Irish mafia, but violence and bloodshed boil when discoveries are made, " +
                 "and the moles are dispatched to find out their enemy’s identities. The Departed is released in" +
                 " 2006 with the participation of many stars as Leonardo DiCaprio, Matt Damon, Jack Nicholson, " +
                 "Mark Wahlberg, Vera Farmiga.",
                Image = "/Content/Images/10.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=iojhqm0JTW4"},

            new MovieViewModel {
                Id = 11,
                Name = "The Godfather",
                Rating = "9",
                ReleaseYear = 1974,
                Genre = "Crime/Drama" ,
                 Description = "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American " +
                 "Corleone crime family. When organized crime family patriarch, Vito Corleone barely survives " +
                 "an attempt on his life, his youngest son, Michael steps in to take care of the would-be killers, " +
                 "launching a campaign of bloody revenge.",
               Image = "/Content/Images/11.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=UaVTIH8mujA"},

            new MovieViewModel {
                Id = 12,
                Name = "Schindler's List",
                Rating = "9",
                ReleaseYear = 1993,
                Genre = "Biography/Drama/History",
                 Description = "Oskar Schindler is a vainglorious and greedy German businessman who becomes an" +
                 " unlikely humanitarian amid the barbaric German Nazi reign when he feels compelled to turn " +
                 "his factory into a refuge for Jews. Based on the true story of Oskar Schindler who managed " +
                 "to save about 1100 Jews from being gassed at the Auschwitz concentration camp, it is a testament " +
                 "to the good in all of us.",
              Image = "/Content/Images/12.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=gG22XNhtnoY"},

            new MovieViewModel {
                Id = 13,
                Name = "The Dark Knight Rises",
                Rating = "8",
                ReleaseYear = 2012,
                Genre = "Action/Thriller",
                 Description = "The Dark Knight Rises” has made many viewers feel extremely satisfied with " +
                 "the scenes as the plane explodes, the broken bridge collapse or thousands of people fight " +
                 "in chaos which are done meticulously, monumentally, and support for the images are excellent " +
                 "soundtracks. Movies reached the top 10 best films in 2012 voted by the film institute of the " +
                 "United States.",
               Image = "/Content/Images/13.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=g8evyE9TuYk"},

            new MovieViewModel {
                Id = 14,
                Name = "The Green Mile",
                Rating = "9",
                ReleaseYear = 1999,
                Genre = "Crime/Drama/Fantasy" ,
                 Description = "The Green Mile is an American film which is directed by Frank Darabont " +
                 "with the participation of famous stars as Tom Hanks, Michael Clarke Duncan, David Morse, " +
                 "etc. The lives of guards on Death Row are affected by one of their charges: a black man " +
               "accused of child murder and rape, yet who has a mysterious gift.",
               Image = "/Content/Images/14.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=Ki4haFrqSrw"},

            new MovieViewModel {
                Id = 15,
                Name = "Interstellar",
                Rating = "9",
                ReleaseYear = 2014,
                Genre = "Adventure/Drama/Sci-Fi" ,
                 Description = "Interstellar directed Christopher Nolan who is famous for making science " +
                 "fiction genre. His most successful films are The Dark Night and Inception. This time his" +
                 " new film with the participation of many famous names in Hollywood as Matthew McConaughey, " +
                 "Anne Hathaway, Jessica Chastain, Bill Irwin, Ellen Burstyn, Michael Caine star.",
                Image = "/Content/Images/15.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E"},

            new MovieViewModel {
                Id = 16,
                Name = "Parasite",
                Rating = "9",
                ReleaseYear = 2020,
                Genre = "Thriller/Comedy/Drama/" ,
                 Description = "All unemployed, Ki-taek’s family takes peculiar interest in the wealthy" +
                 " and glamorous Parks for their livelihood until they get entangled in an unexpected incident.",
                Image = "/Content/Images/16.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=5xH0HfJHsaY"},

             new MovieViewModel {
                Id = 17,
                Name = "Joker",
                Rating = "8",
                ReleaseYear = 2019,
                Genre = "Action/Crime/Drama" ,
                Description = "During the 1980s, a failed stand-up comedian is driven insane and " +
                "turns to a life of crime and chaos in Gotham City while becoming an infamous psychopathic " +
                "crime figure.",
                Image = "/Content/Images/17.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=zAGVQLHvwOY"},


              new MovieViewModel {
                Id = 18,
                Name = "No Time to Die",
                Rating = "8",
                ReleaseYear = 2021,
                Genre = "Action/Adventure/Thriller" ,
                 Description = "Bond has left active service and is enjoying a tranquil life in " +
                 "Jamaica. His peace is short-lived when his old friend Felix Leiter from the CIA " +
                 "turns up asking for help. The mission to rescue a kidnapped scientist turns out " +
                 "to be far more treacherous than expected, leading Bond onto the trail of a mysterious " +
                 "villain armed with dangerous new technology.",
                Image = "/Content/Images/18.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=BIhNsAtPbPI"},

               new MovieViewModel {
                Id = 19,
                Name = "Black Widow",
                Rating = "10",
                ReleaseYear = 2021 ,
                Genre = "Action/Adventure/Sci-Fi" ,
                Description = "A film about Natasha Romanoff in her quests between the films Civil War " +
                "and Infinity War",
                Image = "/Content/Images/19.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=ybji16u608U"},

                new MovieViewModel {
                Id = 20,
                Name = "The Suicide Squad",
                Rating = "10",
                ReleaseYear = 2021,
                Genre = "Action/Adventure/Comedy" ,
                Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of " +
                "nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as " +
                "they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                Image = "/Content/Images/20.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=eg5ciqQzmK0"},

                new MovieViewModel {
                Id = 21,
                Name = "A Quiet Place",
                Rating = "8",
                ReleaseYear = 2018,
                Genre = "Action/Adventure/Comedy" ,
                Description = "This thriller follows a family of four as they navigate their lives in silence " +
                "after mysterious creatures that hunt by sound threaten their survival. If they hear you, " +
                "they hunt you.",
                Image = "/Content/Images/21.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=WR7cc5t7tv8&t=9s"},



        };
    }
     public IActionResult Loading()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

