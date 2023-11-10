# Flash Cards
An application made on the side during my free time at Tech Elevator to help myself and other students study.
## Sql database:
The application will require a SQL database in order to hold, access, and edit the list of vocabulary terms **[IMPLEMENTED]**

In order to properly test the application's functions, the application will require a test database **[IMPLEMENTED]**

## Use cases:
1. Basic interaction. As a user of the app, I should be able to:
    1. Add individual vocabulary terms **[IMPLEMENTED]**
    2. View all vocabulary terms, made up of an id, a name, a catgegory, and its definition **[IMPLEMENTED]**
    3. View all vocabulary categories **[IMPLEMENTED]**
    4. Filter vocabulary by their categories **[IMPLEMENTED]**
    5. Load in all terms mentioned in the c# class
    6. View a specific vocabulary term by its id
    7. Delete a vocabulary term by its id
    8. Delete vocabulary by its category

2. Application parameters. As a user of the app, I should be able to:
    1. Set parameters of the app to be able to custgomize studying
    2. Study only one category
    3. Study only specific catgegories
    4. Study vocabulary terms by inputted ids
    5. Study all vocabularies

3. Application. As a user of the app, I should be able to: 
    1. Play the studying game based on the parameters set
    2. Have the vocabulary name displayed, along with 4 options of terms, one of which is correct
    3. Be able to exit out of program early if need be
    4. Be given feedback on exactly which terms the definition for was wrong

4. Server. The application initially will connect to a local server using REST Api

5. UI. The local server will eventually be displayed in a website the user can interact with through checkboxes (selecting vocabulary, correct answer, etc) and text boxes (to create vocabulary terms)