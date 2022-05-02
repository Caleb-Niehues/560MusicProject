Welcome to our Music Database!

To get an instance of our database and Visual Studio user interface running for yourself, follow these instructions.
	1. Clone or download this instance into your machine, and open it up in Visual Studio.
	2. Navigate to MusicProject -> MusicProjectFullSchema.sql.
	3. Open MusicProjectFullSchema.sql. up in your local instance of Microsoft SQL Server Management Studio.
	4. In line 1 of MusicProjectFullSchema.sql., change the line to "USE [your_database_name]". Make sure everytime you run
	   any .sql files pertaining to this project, you are using [your_database_name].
	5. Click the Execute button. This will create the MusicProject schema with all of the required tables.
	   Additionally, this will run all inserts to insert all present data that is in our current version. This will
	   also run all stored procedures that you can execute through Visual Studio's user interface.
	6. After the commands completed successfully, open Visual Studio up to the MusicProject solution.
	7. Open up App.config. 
	8. Navigate to the section name="configConnectionGrader". Replace Database=[your_database_name] to the 
	   same database you executed THEFILENAME on. Change any other things with Server or Integrated Security if needed.
	   Here is a reference to a useful website if you are not using a server modeled like ours: 
	   https://www.connectionstrings.com/sql-server/.
	9. In MusicProject Solution, navigate to Controller.cs -> Line 15. 
	   Change/verify this line reads: private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionGrader"].ConnectionString;
	10. Your instance of our database is ready to go! To run, just click Visual Studio's Start button.
	11. First Login to the system. By doing this create an username and password. But 100 as the weight and click the "Create User" Button.
	12. Once logged in go to the search bar and type in "Kendrick Lamar" and press enter, you should get some results from the artist
	13. Click on the radio buttons corresponding to the search results to see them appear on the big text box
	14. If you want to see a variety of results type in "Closer" to the search bar to find an album and a variety of songs called closer.
	15. To add an artist, click on the "Add Artist" button and type in a name to add as an artist
	16. To add a producer, click on the "Add Producer" button and type in a name to add as a producer
	17. To add a Record Label, click on the "Add Label" button and add in the name and dates of the Record Label.
	18. To add an album, click on the "Add/Edit Album" button and add in your artist and record label
	19. After adding your artist press enter so that the artist can be registered into the album you make, same goes for the record label
	20. Add in other various variables like the the certification, the producers and the date/time
	21. To add in songs, press the "Add Song"" Button, you will have the option to add in a song name, the elapsed time of the song, and the genre of the song
	22. Complete this process by pressing the "Add Album" button
	23. You can search up the album by typing in the name of the album in the top left corner
	24. To access the aggregate queries, you will have to use the bottom section
	25. First set the start date and end date to your preference
	26. Click on the number counter for the top perfoming genre to your preference
	27. Click on the "Top Performing Genres in Timeline" button to get results of the top genres in your prefered timeframe
	28. To use the "Artist's Top Albums", use the bottom search bar and look up an artist, press the "Artist's Top Albums" button to see the results of the album
	29. To use the "Artist's Super Fans" button, type in the artist in the bottom search bar and click on the button
	30. To use the "Record Label's Album Timeline", type in the record label in the bottom search bar and click on the button
	31. To look at reviews make sure you are logged into an account and you have search up an album. Click on the "Review" button on the bottom left.
	32. After the reviews window pops up, you can look at the variety of reviews based off the album you looked up
	33. You can also add in your own reviews, to do that click on the "Get Your Review" button and add in your very own review, click on "Save Changes" after you complete the review
	34. That's basically it for the application, good luck and have fun!