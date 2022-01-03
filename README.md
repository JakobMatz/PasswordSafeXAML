
# PasswordSafeXAML

This app is a minimilist Password-Safe, it comes as a Visual Studio
Project Folder and is written in C#.

## Usage
### Cloning the project
The project can be cloned by using your preferred way of using git and cloning the project with the following url:

https://github.com/JakobMatz/PasswordSafeXAML.git

### Starting the project
After the project is cloned, it can be built and edited by opening the
File "PasswordSafeXAML.sln" in the main Git directory.
To start the project no additional software or databases are needed, the project should run as-is.

### Maintenance
#### CsvHelper
CsvHelper is a library used to write and read csv-files.
More Info can be found here:

https://joshclose.github.io/CsvHelper/

#### Tests
Tests for the application can be done by editing files within the
application itself. Those tests don't have to be further automated
because of the simplicity of the app.

### Repair
When the App is unable to run properly, debugging may be necessary via the Visual Studio Debugging menu. Manual testing can be done by adding and removing entries to the PasswordSafe.
If you want to insert your own csv database for the program, place the file in this directory: PasswordSafeXAML/PasswordSafeXAML/bin/Debug/ and name the file "LoginDaten.csv"
To see Debugging info, start the Visual Studio project and run the app from there. When errors do occur, the Debugging Manager will open to assist you finding the error.

### Extradition
The release of the application is done by building the program with Visual Studio Start Button in the top. After that the .exe-File can be found in the project's /bin/Debug/ folder. This file can then be distributed.


## License
This software is distributed under GNU GPL3.0
