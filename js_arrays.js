var array = [
    {
      "FirstName": "John",
      "LastName": "Doe",
      "Age": 20,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Jane",
      "LastName": "Smith",
      "Age": 22,
      "Department": "Physics"
    },
    {
      "FirstName": "Michael",
      "LastName": "Johnson",
      "Age": 21, 
      "Department": "Mathematics"
    },
    {
      "FirstName": "Sarah",
      "LastName": "Williams",
      "Age": 19,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Robert",
      "LastName": "Brown",
      "Age": 23,
      "Department": "Mathematics"
    },
    {
      "FirstName": "Emily",
      "LastName": "Davis",
      "Age": 20,
      "Department": "Computer Science"
    }
  ];

  // 1. List the students whose department is computer science.
  console.log("Department is computer science.");
  const compSci = array.filter(x => x.Department.match("Computer Science"));
  compSci.forEach(x => {
    console.log(x);
  });
  console.log("");
  
  // 2. List the first name of students whose age is greater than  21
  console.log("Age is greater than  21");
  const olderThan21 = array.filter(x => x.Age > 21);
  olderThan21.forEach(x =>{
    console.log(x.FirstName);
  });
  console.log("");

  //3. Check whether a student having a first name as Robert is present in the Computer Science Department. The result should be in boolean type
  console.log("Robert is present in the Computer Science Department?");
  var robertExists = array.some(x => x.FirstName == "Robert" && x.Department == "Computer Science");
  console.log(robertExists);
  console.log("");

  //4. Check whether there is any student whose age is greater than 23 is studying in the Maths department.The result should be in boolean type
  console.log("Age is greater than 23 is studying in the Maths department?");
  var mathsGT23 = array.some(x => x.Age >23 && x.Department == "Mathematics");
  console.log(mathsGT23);
  console.log("");

  //5. Check whether all the students are above an age group of 18.The result should be in boolean type.
  console.log("Everyone older than 18?");
  var allOlderthan18 = array.every(x => x.Age > 18);
  console.log(allOlderthan18);
  console.log("");

  //6. Assuming that there is only one student having a first name as John, Print his department name.
  console.log("Department of John");
  var johnsDept = array.find(x => x.FirstName == "John");
  console.log(johnsDept.Department);
  console.log("");



//MOVIES



  var movieArray =
  [
    {
      "MovieName": "The Great Adventure",
      "ActorName": "John Smith",
      "ReleaseDate": "2023-01-15"
    },
    {
      "MovieName": "Mystery in the Woods",
      "ActorName": "Emily Johnson",
      "ReleaseDate": "2022-09-28"
    },
    {
      "MovieName": "Love and Destiny",
      "ActorName": "Michael Brown",
      "ReleaseDate": "2023-05-02"
    },
    {
      "MovieName": "City of Shadows",
      "ActorName": "Sophia Williams",
      "ReleaseDate": "2023-03-12"
    },
    {
      "MovieName": "The Last Stand",
      "ActorName": "William Davis",
      "ReleaseDate": "2022-11-07"
    },
    {
      "MovieName": "Echoes of Time",
      "ActorName": "Olivia Wilson",
      "ReleaseDate": "2022-12-19"
    }
  ];

  //1. List the movie name along with the actor name of those movies released in the year 2022
  console.log("Movies and actors in 2022");
  var moviesOf22 = movieArray.filter(x => new Date(x.ReleaseDate).getFullYear() == 2022);
  moviesOf22.forEach(x => {
    console.log(x.ActorName + " : " + x.MovieName);
    });
    console.log("");

   //2. List the movie names released in the year 2023 where the actor is William Davis.
   console.log("William Davis in 2023");
   var williamIn23 = movieArray.filter( x => x.ActorName == "William Davis"  && new Date(x.ReleaseDate).getFullYear() == 2023);
   williamIn23.forEach(x => {
    console.log(x.MovieName);
    });
    console.log("");

    //3. Retrieve the Actor name and release date of the movie “The Last Stand”
    console.log("Actor of the last stand");
    var actorOfTLS = movieArray.find(x => x.MovieName == "The Last Stand");
    console.log("Actor Name: " +actorOfTLS.ActorName + "\nMovie Name: "+ actorOfTLS.MovieName );
    console.log("");

    //4.Check whether there is any movie in the list with actor name “John Doe”
    console.log("Any movies of John Doe?");
    var johnDoeMovies = movieArray.some(x => x.ActorName == "John Doe");
    console.log(johnDoeMovies);
    console.log("");

    //5.Display the count of movies where the actor name is "Sophia Williams"
    var sWMovies = movieArray.filter(x => x.ActorName == "Sophia Williams");
    console.log("No. of Sophia Williams movies: " +sWMovies.length);
    console.log("");

    //6.Insert an element
    movieArray.push({
        "MovieName": "The Final Stage",
        "ActorName": "John Doe",
        "ReleaseDate": "2022-08-11"
    });

   //movieArray.forEach(x => console.log(x));    console.log("");


   //7. Check whether there exists any duplicate movie names present in the array
   movieArray.sort();
   var duplicateMovies = false;
   for (var i=1;i<movieArray.length;i++)
   {
    if(movieArray[i].MovieName == movieArray[i-1].MovieName)
    {
        duplicateMovies = true;
    }
   }
   console.log("Any duplicate movie name exists? : " +duplicateMovies);

   
   //8.Create a new array starting from the movie "City of Shadows"
   const indexOfCoS = movieArray.findIndex(x => x.MovieName === "City of Shadows")
   var slicedArray = movieArray.slice(indexOfCoS);
   slicedArray.forEach(x => console.log(x));
   console.log("");

   //9.List the distinct actor names in array
   console.log("Distinct actors: ");
   let distinctActors = new Set([]);
   movieArray.forEach(x =>{
    distinctActors.add(x.ActorName);
   });
   var distinctActorsArray = Array.from(new Set(distinctActors));
   distinctActorsArray.forEach(x => {
    console.log(x);
   });
   console.log("");

   
   //10.Insert an element
		/*{
      "MovieName": "Rich & Poor",
      "ActorName": "Johnie Walker",
      "ReleaseDate": "2023-08-11"
    }
    as next element to movie “Love and Destiny”*/

   const indexOfLaD = movieArray.findIndex(x => x.MovieName === "Love and Destiny")
   var splicedArray = movieArray.splice(indexOfLaD,0,{"MovieName": "Rich & Poor",
      "ActorName": "Johnie Walker",
      "ReleaseDate": "2023-08-11"});
      splicedArray.forEach(x => {
        console.log(x) 
      });
       console.log("");

    //11.Display the count of distinct actor names in array
    console.log( "No. of distinct actors: " + distinctActorsArray.length);
    console.log("");

    //12.Remove the movie named  "The Last Stand"
    const indexOfTLS = movieArray.findIndex(x => x.MovieName === "The Last Stand");
    console.log(indexOfTLS);
    movieArray.splice(indexOfTLS,1);
    console.log("Removed The Last Stand /n");
    
    //13.Check whether all the movies are released after 2021 Dec 31
    var allReleasedAfter23 = movieArray.every(x => new Date(x.ReleaseDate).getFullYear() > 2021);
    console.log("all the movies are released after 2021 Dec 31? : " + allReleasedAfter23);

    //14.Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"
    movieArray[indexOfCoS].ReleaseDate = "2023-03-13";

    //15.Create a new array of movie names whose movie name length is greater than 10.
    var longMovieNames = movieArray.filter(x => x.MovieName.length > 10);
    longMovieNames.forEach(x => {
      console.log(x) 
    });



