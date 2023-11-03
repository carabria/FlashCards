USE master;
GO

IF DB_ID ('FlashCards') IS NOT NULL
BEGIN
	ALTER DATABASE FlashCards SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE FlashCards;
END

CREATE DATABASE FlashCards;
GO

USE FlashCards;
GO

DROP TABLE IF EXISTS cards
GO

BEGIN TRANSACTION
CREATE TABLE cards (
	id INT IDENTITY,
	name VARCHAR(50) NOT NULL,
	category VARCHAR(50) NOT NULL,
	description VARCHAR(200) NOT NULL,
	used bit NOT NULL
	CONSTRAINT pk_cards PRIMARY KEY (id)
	);

	INSERT INTO cards(name, category, description, used) VALUES
	('Git', 'Version Control / Development Tools', 'A distributed version control system.', 0),
	('Repository', 'Version Control / Development Tools', 'A storage location for a project''s files and version history.', 0),
	('Directory/Folder', 'Version Control / Development Tools', 'A container for organizing files.', 0),
	('Absolute Path', 'Version Control / Development Tools', 'The complete path to a file or directory starting from the root.', 0),
	('Relative Path', 'Version Control / Development Tools', 'A path to a file or directory relative to the current location.', 0),
	('Terminal/Shell', 'Version Control / Development Tools', 'A command-line interface for interacting with a computer''s operating system.', 0),
	('Command Prompt', 'Version Control / Development Tools', 'A command-line interface on Windows operating systems.', 0),

	('Variable', 'Programming Concepts', 'A named storage location for data.', 0),
	('Data Types', 'Programming Concepts', 'Categories of data with specific characteristics.', 0),
	('Casting', 'Programming Concepts', 'Converting data from one type to another.', 0),
	('Namespace', 'Programming Concepts', 'A container for organizing code.', 0),
	('Switch/Case', 'Programming Concepts', 'A control flow structure for multiple conditional branches.', 0),
	('System', 'Programming Concepts', 'A namespace in .NET.', 0),
	('System.Collections.Generic', 'Programming Concepts', 'A namespace for generic collections.', 0),
	('Using', 'Programming Concepts', 'A keyword for importing namespaces.', 0),
	('Foreach', 'Programming Concepts', 'A loop for iterating over collections.', 0),
	('Type-Safe', 'Programming Concepts', 'Ensures data types are used correctly.', 0),

	('Methods', 'Programming Structures', 'Functions or procedures that perform specific tasks.', 0),
	('Statement', 'Programming Structures', 'A single line of code that performs an action.', 0),
	('Widening', 'Programming Structures', 'Converting data to a larger data type without data loss.', 0),
	('Narrowing', 'Programming Structures', 'Converting data to a smaller data type with potential data loss.', 0),
	('Expression', 'Programming Structures', 'A combination of values and operators that produce a result.', 0),
	('Scope', 'Programming Structures', 'The region of code where a variable is accessible.', 0),
	('Block', 'Programming Structures', 'A group of statements enclosed in curly braces.', 0),
	('Literal', 'Programming Structures', 'A fixed value in code.', 0),
	('Branches', 'Programming Structures', 'Different paths of code execution.', 0),
	('Condition', 'Programming Structures', 'A test that determines which branch of code to execute.', 0),

	('Array', 'Data Structures', 'A collection of elements with a fixed size.', 0),
	('Ternary', 'Data Structures', 'An operator that evaluates a condition and returns one of two values.', 0),
	('Loop', 'Data Structures', 'A control structure for repeating a block of code.', 0),
	('Collection', 'Data Structures', 'A group of elements.', 0),
	('Element', 'Data Structures', 'An individual item in a collection.', 0),
	('Increment/Decrement', 'Data Structures', 'Operators for increasing or decreasing a value.', 0),
	('Reserved Words', 'Data Structures', 'Words with predefined meanings in programming.', 0),
	('FIFO (First-In-First-Out)', 'Data Structures', 'A queuing strategy.', 0),
	('Queue', 'Data Structures', 'A collection that follows FIFO.', 0),
	('Enqueue', 'Data Structures', 'Adding an item to a queue.', 0),
	('Dequeue', 'Data Structures', 'Removing an item from a queue.', 0),
	('LIFO (Last-In-First-Out)', 'Data Structures', 'A stacking strategy.', 0),
	('Push', 'Data Structures', 'Adding an item to a stack.', 0),
	('Pop', 'Data Structures', 'Removing an item from a stack.', 0),
	('Key-Value Pair', 'Data Structures', 'A data structure that associates a key with a value.', 0),
	('HashSet', 'Data Structures', 'A collection that stores unique elements.', 0),
	('Dictionary', 'Data Structures', 'A collection that stores key-value pairs.', 0),
	('DateTime', 'Data Structures', 'A data type for representing dates and times.', 0),

	('String Interpolation', 'String Manipulation', 'Embedding variables in strings.', 0),
	('Parsing', 'String Manipulation', 'Analyzing and converting data from one format to another.', 0),
	('Break/Continue', 'String Manipulation', 'Control flow statements in loops.', 0),
	('Split', 'String Manipulation', 'Dividing a string into substrings.', 0),
	('For', 'String Manipulation', 'A loop that iterates a specific number of times.', 0),
	('While', 'String Manipulation', 'A loop that repeats while a condition is true.', 0),
	('Do-While', 'String Manipulation', 'A loop that executes at least once.', 0),

	('Value Type', 'Object-Oriented Programming', 'A data type that stores its value directly.', 0),
	('Reference Type', 'Object-Oriented Programming', 'A data type that stores a reference to its value.', 0),
	('Stack', 'Object-Oriented Programming', 'A memory area for function call and local variable storage.', 0),
	('Heap', 'Object-Oriented Programming', 'A memory area for dynamic memory allocation.', 0),
	('Immutability', 'Object-Oriented Programming', 'The inability to change the value of an object.', 0),
	('Class', 'Object-Oriented Programming', 'A blueprint for creating objects.', 0),
	('Object', 'Object-Oriented Programming', 'An instance of a class.', 0),
	('New', 'Object-Oriented Programming', 'Keyword for creating objects.', 0),
	('Substring', 'Object-Oriented Programming', 'A part of a string.', 0),
	('Object-Oriented Programming (OOP)', 'Object-Oriented Programming', 'A programming paradigm that uses objects and classes for modeling.', 0),
	('Abstraction', 'Object-Oriented Programming', 'The process of simplifying complex systems by modeling essential features.', 0),
	('Encapsulation', 'Object-Oriented Programming', 'The bundling of data and methods into a single unit (object).', 0),
	('Inheritance', 'Object-Oriented Programming', 'The mechanism that allows one class to inherit properties and methods from another.', 0),
	('Polymorphism', 'Object-Oriented Programming', 'The ability to present the same interface for different data types.', 0),

	('Big O Notation', 'Algorithm Analysis', 'A notation used to describe the upper bound of an algorithm''s time complexity.', 0),
	('Calling Methods', 'Algorithm Analysis', 'Invoking functions or procedures within a program.', 0),

	('Namespace', 'Access Modifiers / Class Members', 'A container for organizing code.', 0),
	('Public', 'Access Modifiers / Class Members', 'An access modifier that allows unrestricted access.', 0),
	('Private', 'Access Modifiers / Class Members', 'An access modifier that restricts access to within the defining class.', 0),
	('Properties', 'Access Modifiers / Class Members', 'Class members that provide controlled access to object attributes.', 0),
	('Computed/Calculated/Derived Properties', 'Access Modifiers / Class Members', 'Properties whose values are calculated based on other data.', 0),
	('Constructor', 'Access Modifiers / Class Members', 'A special method used to initialize objects.', 0),
	('Overloading', 'Access Modifiers / Class Members', 'Defining multiple methods with the same name but different parameters.', 0),
	('Get/Set', 'Access Modifiers / Class Members', 'Methods used to access or modify property values.', 0),

	('Parent/Super/Base', 'Inheritance and Class Hierarchy', 'The parent class in an inheritance hierarchy.', 0),
	('Child/Sub/Derived', 'Inheritance and Class Hierarchy', 'A class that inherits from another class.', 0),
	('Inheritance', 'Inheritance and Class Hierarchy', 'The mechanism by which one class inherits properties and behaviors from another.', 0),
	('Protected', 'Inheritance and Class Hierarchy', 'An access modifier that allows access within the class and derived classes.', 0),
	('Static', 'Inheritance and Class Hierarchy', 'A modifier that indicates a member belongs to the class, not an instance.', 0),
	('Virtual', 'Inheritance and Class Hierarchy', 'A modifier that indicates a method can be overridden in derived classes.', 0),
	('Override', 'Inheritance and Class Hierarchy', 'A keyword used to provide a new implementation for a base class method.', 0),
	('Base', 'Inheritance and Class Hierarchy', 'A keyword for invoking a base class constructor or method.', 0),
	('Is-A', 'Inheritance and Class Hierarchy', 'A relationship between a derived class and its base class.', 0),
	('Parameterized Constructors', 'Inheritance and Class Hierarchy', 'Constructors that accept parameters.', 0),
	('Object', 'Inheritance and Class Hierarchy', 'The root class for all classes in C#.', 0),

	('Polymorphism', 'Interfaces and Polymorphism', 'The ability to use objects of different classes through a common interface.', 0),
	('Interface', 'Interfaces and Polymorphism', 'A contract that defines a set of methods a class must implement.', 0),
	('Implement', 'Interfaces and Polymorphism', 'The act of providing concrete implementations for interface methods.', 0),
	('Inherit', 'Interfaces and Polymorphism', 'The process of deriving a class from an interface.', 0),
	('ToString()', 'Interfaces and Polymorphism', 'A method used to convert an object to a string representation.', 0),

	('Readonly', 'Modifiers and Testing', 'A modifier that indicates a variable''s value cannot be changed after initialization.', 0),
	('Abstract', 'Modifiers and Testing', 'A modifier that indicates a class or method is incomplete and must be implemented by derived classes.', 0),
	('Sealed', 'Modifiers and Testing', 'A modifier that prevents further inheritance or overriding.', 0),
	('Internal', 'Modifiers and Testing', 'An access modifier that allows access within the same assembly.', 0),
	('Integration Testing', 'Modifiers and Testing', 'Testing that checks interactions between different components or modules.', 0),
	('Regression Testing', 'Modifiers and Testing', 'Re-testing a program after changes to ensure existing functionalities still work.', 0),
	('Acceptance Testing', 'Modifiers and Testing', 'Testing to verify if the system meets user-defined requirements.', 0),
	('Exploratory Testing', 'Modifiers and Testing', 'Informal testing to discover defects without predefined test cases.', 0),
    ('Manual Testing', 'Modifiers and Testing', 'Testing performed by human testers without automation.', 0),
    ('Automated Testing', 'Modifiers and Testing', 'Testing conducted using automated testing tools.', 0),
    ('Unit Testing', 'Modifiers and Testing', 'Testing individual units or components of a software.', 0),
	('Technical Debt', 'Modifiers and Testing', 'The cost of postponing necessary work on a software project.', 0),
    ('Assert', 'Modifiers and Testing', 'A statement that checks whether a condition is true.', 0),
    ('CollectionAssert', 'Modifiers and Testing', 'A class for asserting conditions on collections.', 0),
    ('TestClass', 'Modifiers and Testing', 'A class used for organizing unit tests.', 0),
    ('TestMethod', 'Modifiers and Testing', 'A method that contains a unit test.', 0),
    ('Refactor', 'Modifiers and Testing', 'Restructuring code to improve its quality without changing its external behavior.', 0),
    ('Code Smells', 'Modifiers and Testing', 'Indications of potential problems in code.', 0),
    ('Test-Driven Development (TDD)', 'Modifiers and Testing', 'A development approach where tests are written before code.', 0),
    ('Red / Green / Refactor', 'Modifiers and Testing', 'The TDD cycle of writing failing tests, making them pass, and improving code.', 0),
    ('Arrange - Act - Assert', 'Modifiers and Testing', 'The structure of a unit test.', 0),

    ('Agile', 'Software Development Practices', 'An iterative and flexible approach to software development.', 0),
    ('Waterfall', 'Software Development Practices', 'A linear and sequential approach to software development.', 0),
    ('Software Development Lifecycle', 'Software Development Practices', 'The process of planning, creating, testing, and maintaining software.', 0),
    ('XML Documentation (///)', 'Software Development Practices', 'Documentation comments in code for generating documentation.', 0),
    ('Sprint', 'Software Development Practices', 'A time-boxed development iteration in Agile.', 0),
    
    ('Code Coverage', 'Code Analysis and Error Handling', 'A metric measuring the proportion of code executed by tests.', 0),
    ('Try-Catch-Finally', 'Code Analysis and Error Handling', 'Error-handling mechanism in programming.', 0),
    ('Compile-Time (Compiler) Errors', 'Code Analysis and Error Handling', 'Errors detected by the compiler during code compilation.', 0),
    ('Run-Time Errors', 'Code Analysis and Error Handling', 'Errors that occur during program execution.', 0),
    ('Logic Errors', 'Code Analysis and Error Handling', 'Errors in the program''s logic that don''t result in immediate crashes.', 0),
    ('Stack Trace', 'Code Analysis and Error Handling', 'A report of the function calls made during program execution.', 0),
    ('Custom Exceptions', 'Code Analysis and Error Handling', 'User-defined exception types.', 0),
    ('Throw', 'Code Analysis and Error Handling', 'A keyword for raising exceptions.', 0),
    
	('Data Stream', 'File I/O and String Handling', 'A sequence of data elements.', 0),
    ('StreamReader', 'File I/O and String Handling', 'A class for reading character streams.', 0),
    ('StreamWriter', 'File I/O and String Handling', 'A class for writing character streams.', 0),
    ('Verbatim String (@)', 'File I/O and String Handling', 'A string that doesn''t interpret escape sequences.', 0),
    ('Buffer', 'File I/O and String Handling', 'A temporary storage area.', 0),
    
	('SELECT', 'Database Query Language and Concepts', 'SQL command for querying data.', 0),
    ('FROM', 'Database Query Language and Concepts', 'SQL clause specifying the data source.', 0),
    ('WHERE', 'Database Query Language and Concepts', 'SQL clause for filtering data.', 0),
    ('BETWEEN', 'Database Query Language and Concepts', 'SQL operator for specifying a range.', 0),
    ('AS', 'Database Query Language and Concepts', 'SQL clause for aliasing columns.', 0),
    ('IS NULL', 'Database Query Language and Concepts', 'SQL condition for checking if a value is null.', 0),
    ('IS NOT NULL', 'Database Query Language and Concepts', 'SQL condition for checking if a value is not null.', 0),
    ('IN', 'Database Query Language and Concepts', 'SQL operator for matching values in a list.', 0),
    ('LIKE', 'Database Query Language and Concepts', 'SQL operator for pattern matching.', 0),
    ('Server', 'Database Query Language and Concepts', 'A computer or system hosting a database.', 0),
    ('Database', 'Database Query Language and Concepts', 'A structured collection of data.', 0),
    ('Table', 'Database Query Language and Concepts', 'A database object that stores data.', 0),
    ('Column', 'Database Query Language and Concepts', 'A field within a database table.', 0),
    ('Row', 'Database Query Language and Concepts', 'A single record in a database table.', 0),
    ('RDBMS (Relational Database Management System)', 'Database Query Language and Concepts', 'A database system that uses a relational model.', 0),
    ('ORDER BY', 'Database Query Language and Concepts', 'SQL clause for sorting query results.', 0),
    ('ASC', 'Database Query Language and Concepts', 'Keyword used with ORDER BY to sort in ascending order.', 0),
    ('DESC', 'Database Query Language and Concepts', 'Keyword used with ORDER BY to sort in descending order.', 0),
    ('TOP', 'Database Query Language and Concepts', 'SQL keyword for limiting the number of rows returned.', 0),
    ('PERCENT', 'Database Query Language and Concepts', 'SQL keyword for specifying a percentage of rows to return.', 0),
    ('WITH TIES', 'Database Query Language and Concepts', 'SQL clause that includes rows with equal values when using TOP.', 0),
    ('JOIN', 'Database Joins and Keys', 'SQL operation for combining rows from multiple tables.', 0),
    ('INNER JOIN / JOIN', 'Database Joins and Keys', 'SQL operation that returns only matching rows from both tables.', 0),
    ('LEFT OUTER JOIN / LEFT JOIN', 'Database Joins and Keys', 'SQL operation that returns all rows from the left table and matching rows from the right table.', 0),
    ('RIGHT OUTER JOIN / RIGHT JOIN', 'Database Joins and Keys', 'SQL operation that returns all rows from the right table and matching rows from the left table.', 0),
    ('UNION', 'Database Joins and Keys', 'SQL operation for combining result sets from two or more SELECT statements.', 0),
    ('PRIMARY KEY', 'Database Joins and Keys', 'A column or set of columns that uniquely identifies each row in a table.', 0),
    ('FOREIGN KEY', 'Database Joins and Keys', 'A column that establishes a link between data in two tables.', 0),
    ('Natural Keys', 'Database Joins and Keys', 'Keys derived from the data itself.', 0),
    ('Surrogate Keys', 'Database Joins and Keys', 'Keys generated specifically for identification purposes.', 0),
    ('Cardinality', 'Database Joins and Keys', 'The number of unique values in a column.', 0),
    ('One-to-One', 'Database Joins and Keys', 'A relationship where each record in one table is related to only one record in another.', 0),
    ('One-to-Many', 'Database Joins and Keys', 'A relationship where each record in one table can be related to multiple records in another.', 0),
    ('Many-to-Many', 'Database Joins and Keys', 'A relationship where multiple records in one table can be related to multiple records in another.', 0),
    ('Crow''s Foot Notation', 'Database Joins and Keys', 'A visual notation for representing entity-relationship diagrams.', 0),
    
	('Table Constraints', 'Database Constraints and Operations', 'Rules applied to columns in a database table.', 0),
    ('NULL / NOT NULL', 'Database Constraints and Operations', 'Constraints specifying whether a column can contain null values.', 0),
    ('UNIQUE', 'Database Constraints and Operations', 'Constraint ensuring that values in a column are unique.', 0),
    ('PRIMARY KEY', 'Database Constraints and Operations', 'Constraint defining a unique identifier for a table.', 0),
    ('FOREIGN KEY', 'Database Constraints and Operations', 'Constraint establishing a link to another table.', 0),
    ('DEFAULT', 'Database Constraints and Operations', 'Constraint specifying a default value for a column.', 0),
    ('CHECK', 'Database Constraints and Operations', 'Constraint that validates data using a Boolean expression.', 0),
    ('INDEX', 'Database Constraints and Operations', 'A data structure that improves the speed of data retrieval.', 0),
    ('ACID', 'Database Constraints and Operations', 'Properties of database transactions (Atomicity, Consistency, Isolation, Durability).', 0),
    ('Transaction', 'Database Constraints and Operations', 'A sequence of SQL statements treated as a single unit of work.', 0),
    ('COMMIT', 'Database Constraints and Operations', 'SQL command to make changes to a database permanent.', 0),
    ('ROLLBACK', 'Database Constraints and Operations', 'SQL command to undo changes in a transaction.', 0),
    ('DELETE', 'Database Constraints and Operations', 'SQL command for removing rows from a table.', 0),
    ('INSERT', 'Database Constraints and Operations', 'SQL command for adding new rows to a table.', 0),
    ('UPDATE', 'Database Constraints and Operations', 'SQL command for modifying existing rows in a table.', 0),
    
	('IDENTITY', 'Database Management and Definitions', 'A property used to generate unique values for a column.', 0),
    ('DDL (Data Definition Language)', 'Database Management and Definitions', 'SQL statements for defining database structures.', 0),
    ('DML (Data Manipulation Language)', 'Database Management and Definitions', 'SQL statements for manipulating data.', 0),
    ('DCL (Data Control Language)', 'Database Management and Definitions', 'SQL statements for controlling access to data.', 0),
    ('ERD (Entity Relationship Diagrams)', 'Database Management and Definitions', 'Visual representations of database entities and their relationships.', 0),
    ('TFLA (Three and Four Letter Acronyms)', 'Database Management and Definitions', 'A humorous reference to the abundance of acronyms in the IT field.', 0),
    ('Normalization', 'Database Management and Definitions', 'The process of organizing database tables to reduce data redundancy.', 0),
    ('Schema/Data', 'Database Management and Definitions', 'The structure and organization of a database.', 0),
    ('CREATE/DROP/ALTER for TABLE and DATABASE', 'Database Management and Definitions', 'SQL commands for creating, deleting, or modifying tables and databases.', 0),
    ('GO', 'Database Management and Definitions', 'A SQL batch separator.', 0),
   
    ('OUTPUT', 'Database Output and Data Access', 'SQL clause for returning result sets from INSERT, UPDATE, or DELETE statements.', 0),
    ('DAO (Data Access Object)', 'Database Output and Data Access', 'A design pattern for separating data access logic from business logic.', 0),
    ('Connection String', 'Database Output and Data Access', 'A string that specifies database connection parameters.', 0),
   
	('ExecuteNonQuery', 'Database Commands and Parameters', 'A method for executing SQL commands that don''t return data.', 0),
    ('ExecuteScalar', 'Database Commands and Parameters', 'A method for executing SQL commands that return a single value.', 0),
    ('Command.Parameter.AddWithValue', 'Database Commands and Parameters', 'A method for adding parameters to SQL commands.', 0),
    ('Nullable Types (int?, double?, etc.)', 'Database Commands and Parameters', 'Data types that can hold null values.', 0),
    
	('SQL Injection', 'Security and Testing', 'A security vulnerability involving malicious SQL code injection.', 0),
    ('Salt', 'Security and Testing', 'Random data added to password hashes for security.', 0),
    ('Hashing', 'Security and Testing', 'A process that converts data into a fixed-size string of characters.', 0),
    ('Integration Testing', 'Security and Testing', 'Testing that checks interactions between different components.', 0),
    ('Encryption', 'Security and Testing', 'The process of converting data into a secure format.', 0),
    ('Single Key Encryption', 'Security and Testing', 'Using a single key for both encryption and decryption.', 0),
    ('Open Key Encryption', 'Security and Testing', 'A type of encryption where the encryption key is publicly available.', 0),
    ('Dependency Injection', 'Security and Testing', 'A design pattern for injecting dependencies into objects.', 0),
    ('Assembly Initialize / Assembly Cleanup', 'Security and Testing', 'Methods used for setup and teardown in unit testing.', 0),
    ('Test Initialize / Test Cleanup', 'Security and Testing', 'Methods used for setup and teardown in unit testing.', 0),
    
	('HTTP (Hypertext Transport Protocol)', 'Web Technologies', 'A protocol for transferring data on the web.', 0),
    ('REST (Representational State Transfer)', 'Web Technologies', 'A design style for building web services.', 0),
    ('JSON (JavaScript Object Notation)', 'Web Technologies', 'A lightweight data interchange format.', 0),
    ('IP (Internet Protocol)', 'Web Technologies', 'A set of rules for routing data across networks.', 0),
    ('IP Address', 'Web Technologies', 'A numerical label assigned to each device on a network.', 0),
    ('DNS (Domain Name Servers)', 'Web Technologies', 'Servers that translate domain names into IP addresses.', 0),
    ('Serialize / Deserialize', 'Web Technologies', 'Converting data to/from a format suitable for transmission.', 0),
    ('API (Application Programming Interface)', 'Web Technologies', 'A set of rules and protocols for building software.', 0),
    ('TLS (Transport Layer Security)', 'Web Technologies', 'A protocol for securing data transmitted over networks.', 0),
    ('URL (Universal Resource Locator)', 'Web Technologies', 'A web address.', 0),
    ('localhost (127.0.0.1)', 'Web Technologies', 'A special IP address representing the local machine.', 0),
    ('Status Codes', 'Web Technologies', 'Numeric codes indicating the outcome of an HTTP request.', 0),
    ('Web Server', 'Web Technologies', 'A server that serves web content.', 0),
    ('Web Service', 'Web Technologies', 'A service accessible over the web.', 0),
    ('Request/Response', 'Web Technologies', 'The communication pattern in web interactions.', 0),
    
	('POST', 'HTTP Methods', 'HTTP method for sending data to a server to create a new resource.', 0),
    ('PUT', 'HTTP Methods', 'HTTP method for updating an existing resource on a server.', 0),
    ('DELETE', 'HTTP Methods', 'HTTP method for deleting a resource on a server.', 0),
    
	('Internet Engineering Task Force (IETF)', 'Internet and Standards', 'An organization that develops internet standards.', 0),
    ('Request For Comment (RFC)', 'Internet and Standards', 'A publication describing internet protocols.', 0),
    ('RestSharp', 'Internet and Standards', 'A popular library for making RESTful HTTP requests.', 0),
    
	('Controller', 'Software Architecture and Design', 'In the context of MVC, it handles user input and interaction.', 0),
    ('Model', 'Software Architecture and Design', 'In the context of MVC, it represents the application''s data and logic.', 0),
    ('View', 'Software Architecture and Design', 'In the context of MVC, it presents the data to the user.', 0),
    ('MVC (Model-View-Controller)', 'Software Architecture and Design', 'A design pattern for organizing code in software development.', 0),
    ('Query String', 'Software Architecture and Design', 'A part of a URL that passes data to the server.', 0),
    ('Optional Parameters', 'Software Architecture and Design', 'Parameters that don''t have to be provided when calling a function.', 0),
    ('Framework', 'Software Architecture and Design', 'A pre-built structure for developing applications.', 0),
    ('Content Negotiation', 'Software Architecture and Design', 'The process of determining the best content type for a response.', 0),
    ('Attributes / Tags / Decorations', 'Software Architecture and Design', 'Annotations used to add metadata to code.', 0);
COMMIT TRANSACTION