## Sasip Attendance Marker 
This is developed for a client company which is an educatonal institute in Sri Lanka known as Sasip Institute. This is a standalone desktop application with an embedded SQLite database. System deployed successfully after several iterative version releases. Institute used the system as an internal software for students' attendance management. 

### Language: 
	* c#
	
### Database: 
	* SQLite (embedded database)
	
### Additional packages: 
	* Dapper, SQLite for database management
	* Zxing for barcode read and other operations

### Configuration:
	* You can clone the project and need to install all the additional packages mentioned above. 
	* Build the project with required changes you need to make. 
	* Database relations can take from the 'sasip/release.db' sample database. 
	* After build this version required to replace build directory's 'release.db' file with the 'sasip/release.db' file for proper functioning of the system. (Alternatively can update the 'release.db' database in the build directory with relevant schemas as in 'sasip/release.db'.)
	* After build this version required to copy the 'sasip/sasip_icon.jpg' reesource file into the build directory for proper functioning of the system.