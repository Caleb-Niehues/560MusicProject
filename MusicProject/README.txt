Welcome to our Music Database!

To get an instance of our database and Visual Studio user interface running for yourself, follow these instructions.
	1. Clone or download this instance into your machine, and open it up in Visual Studio.
	2. Navigate to MusicProject -> MusicProjectFullSchema.sql.
	3. Open MusicProjectFullSchema.sql up in your local instance of Microsoft SQL Server Management Studio.
	4. In line 1 of MusicProjectFullSchema.sql., change the line to "USE [your_database_name]". Make sure everytime you run
	   any .sql files pertaining to this project, you are using [your_database_name].
	5. Click the Execute button. This will create the MusicProject schema with all of the required tables.
	   Additionally, this will run all inserts to insert all present data that is in our current version. This will
	   also run all stored procedures that you can execute through Visual Studio's user interface.
	6. After the commands completed successfully, open Visual Studio up to the MusicProject solution.
	7. Open up App.config. 
	8. Navigate to the section name="configConnectionGrader". Replace Database=[your_database_name] to the 
	   same database you just executed on. Change any other things with Server or Integrated Security if needed.
	   Here is a reference to a useful website if you are not using a server modeled like ours: 
	   https://www.connectionstrings.com/sql-server/.
	9. In MusicProject Solution, navigate to Controller.cs -> Line 15. 
	   Change/verify this line reads: private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionGrader"].ConnectionString;
	10. Your instance of our database is ready to go! To run, just click Visual Studio's Start button.
	
User interaction instructions - a guide to common use cases:
	1. First Login to the system. To do this, create an username and password. Enter a value from 1-100 as your user weight and click the "Create User" Button.
	2. Once logged in go to the search bar and type in any name of a song, artist, album, etc. and press enter. Some interesting searches include: Closer, Marvin 		 Gaye, record label Eu Limited, producer Abdul Keith. 
	3. If those results aren't specific enough, click on the radio buttons corresponding to the search results to see them appear on the Focus box.
	5. To add an artist, click on the "Add Artist" button, and type in a name to add as an artist.
	6. To add a producer, click on the "Add Producer" button, and type in a name to add as a producer.
	7. To add a Record Label, click on the "Add Label" button, and add in the name and dates of the Record Label.
	8. To add or edit an album, click on the "Add/Edit Album" button. 
		a. In adding an album, enter a title, hit enter. Enter an artist, hit enter. Continue this until all fields are entered and you receive a successful 			message for each.
		b. In editing an album, first have your album entered on the main view with the "Albums" radio button selected along with the album itself that's 		     contained in the Focus box. Continue your desired changes as represented in a. 
	9. Finish off the album with the "Finish Album" button. 
	10. You can search up the recently added album by typing in the name of the album in the top left corner.
	11. To access the aggregate queries, you will have to use the bottom section of buttons and search bars.
	12. For the "Top Performing Genres in Timeline" button, first set the start date and end date to your preference. Then, click on the number counter for the top 	    perfoming genre to your preference. Then, click the original button to get results of the top genres in your prefered timeframe.
	13. To use the "Artist's Top Albums", use the bottom search bar to look up an artist, and press the "Artist's Top Albums" button to see the results of the 	       album.
	14. To use the "Artist's Super Fans" button, type in the artist in the bottom search bar and click on the button.
	15. To use the "Record Label's Album Timeline", type in the record label in the bottom search bar and toggle the start date and end date and click on the 	      original button.
	16. To look at reviews make sure you are logged into an account and you have search up an album that is then selected. Click on the "Review" button on the 	       bottom left. After the reviews window pops up, you can look at the variety of reviews based off the album you looked up. You can also add in your own 		    reviews. To do that click on the "Get Your Review" button, and add in your very own review. Click on "Save Changes" after you complete the review
This covers some basic and common functionality of the application. Thanks for visiting our project!
