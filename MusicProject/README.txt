Welcome to our Music Database!

To get an instance of our database and Visual Studio user interface running for yourself, follow these instructions.
	1. Clone or download this instance into your machine, and open it up in Visual Studio.
	2. Navigate to MusicProject -> Sql -> NAME FOR ALL COMBINED SQL FILES.
	3. Open THISNAME up in your local instance of Microsoft SQL Server Management Studio.
	4. In line 1 of THISNAME, change the line to "USE [your_database_name]". Make sure everytime you run
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
	9. In MusicProject Solution, navigate to Controllers -> MainController.cs -> Line 15. 
	   Change/verify this line reads: private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionGrader"].ConnectionString;
	10. Your instance of our database is ready to go! To run, just click Visual Studio's Start button.