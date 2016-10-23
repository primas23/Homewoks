## Database Systems - Overview
### _Homework_

####1. What database models do you know?

* *__Hierarchical (tree)__* where the data is organized into a tree-like structure, implying a single parent for each record.
* *__Network model__*  which expands upon the __hierarchical structure__, allowing many-to-many relationships in a tree-like structure that allows multiple parents.
* *__Relational model:__* The basic data structure of the relational model is the table, where information about a particular entity (say, an employee) is represented in rows (also called tuples) and columns. Thus, the "relation" in "relational database" refers to the various tables in the database; a relation is a set of tuples.
* *__Object-oriented:__* In the 1990s, the object-oriented programming paradigm was applied to database technology, creating a new database model known as object databases. This aims to avoid the object-relational impedance mismatch - the overhead of converting information between its representation in the database (for example as rows in tables) and its representation in the application program (typically as objects). Even further, the type system used in a particular application can be defined directly in the database, allowing the database to enforce the same data integrity invariants. Object databases also introduce the key ideas of object programming, such as encapsulation and polymorphism, into the world of databases.

####2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

* It stores data in tables.
* Sharing a common column in two or more tables (primary and foreign key)
* Tables have rows and column. 
* These tables are created using SQL. 
* And data from these tables are also retrieved using SQL.
* Provides facility primary key to uniquely identify the rows.

####3. Define what is "table" in database terms.

*  Database table A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

####4. Explain the difference between a primary and a foreign key.
####5. Explain the different kinds of relationships between tables in relational databases.
####6. When is a certain database schema normalized?
  * What are the advantages of normalized databases?
####7. What are database integrity constraints and when are they used?
####8. Point out the pros and cons of using indexes in a database.
####9. What's the main purpose of the SQL language?
####10. What are transactions used for?
  * Give an example.
####11. What is a NoSQL database?
####12. Explain the classical non-relational data models.
####13. Give few examples of NoSQL databases and their pros and cons.