using aspproj.Models;

namespace aspproj.Data
{
    public class ApplucationDbInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder) 
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any()) 
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema() 
                        {
                            Name = "Cinema 1",
                            Logo = "C:\\Users\\Lucif\\Pictures\\Saved Pictures\\cinema1.png",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "images\\cinema-logo-2.jpg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "images\\cinema-logo-3.jpg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "images\\cinema-logo-4.jpg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "images\\cinema-logo-5.jpg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor."
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any()) 
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Brad Pitt",
                            Bio = "Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor.",
                            ProfilePictureURL = "images/brad pitt.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Johnny Depp",
                            Bio = "Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor.",
                            ProfilePictureURL = "images/johnney depp.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Robert Downey jr",
                            Bio = "Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor.",
                            ProfilePictureURL = "images/robert-downey-jr.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Edward Norton",
                            Bio = "Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor.",
                            ProfilePictureURL = "images/edward notron.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Ryan Gosling",
                            Bio = "Diam phasellus vestibulum lorem sed risus ultricies tristique nulla aliquet. Aliquam ut porttitor leo a diam sollicitudin tempor.",
                            ProfilePictureURL = "images/ryan gosling.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (context.Movies.Any()) 
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {

                        },
                        new Movie() 
                        {

                        },
                        new Movie()
                        {

                        },
                        new Movie()
                        {

                        },
                        new Movie()
                        {

                        }

                    });
                    context.SaveChanges();
                }
                //Producers
                if (context.Producers.Any()) 
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {

                        },
                        new Producer()
                        {

                        },
                        new Producer()
                        {

                        },
                        new Producer()
                        {

                        },
                        new Producer()
                        {

                        }

                    });
                    context.SaveChanges();
                }
                //Actors&Movies
                if (context.Actors_Movies.Any()) 
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 1,
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
